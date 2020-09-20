using LPP.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LPP.Helpers
{
    public class TruthTableHelper
    {
        public string GenerateTruthTable(BinaryTree tree, string formula)
        {
            var variables = tree.GetLeaves();
            string truthTable = "";
            for (int i = 0; i < variables.Count; i++)
            {
                truthTable = truthTable + $" {variables[i]} |";
            }
            truthTable = truthTable + $" {tree.PrintParsedFormula()} \r\n";
            if (!variables.Any(x => x != '1' && x != '0'))
            {
                for (int i = 0; i < variables.Count; i++)
                {
                    truthTable = truthTable + $" {variables[i]} |";
                }
                truthTable = truthTable + $" {(tree.Root.CalculateTTValue() ? 1 : 0)} \r\n";
                return truthTable;
            }
            int nrOfRows = (int)Math.Pow(2, variables.Count);
            int nrOfColumns = variables.Count + 1;
            int[ , ] table = new int[nrOfRows, nrOfColumns];
            this.MakeColumns(ref table, variables);
            for (int i = 0; i < table.GetLength(0); i++) 
            {
                BinaryTree temp = this.ChangeValueOfLeaves(formula, variables, this.GetRow(i, table));
                table[i, nrOfColumns - 1] = temp.Root.CalculateTTValue() ? 1 : 0;
            }
            return this.ReadTruthTable(truthTable, variables, tree.PrintParsedFormula(), table);
        }

        private void MakeColumns(ref int[ , ] table, List<char> variables)
        {
            for (int c = 0; c < table.GetLength(1) - 1; c++) //-1 because the last column is meant for the result value
            {
                int repeatEvery = (int)Math.Pow(2, table.GetLength(1) - (c + 2)); // c + 2 because index starts from 0 and the last column is meant for the result value
                bool insertOnes = false;
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    if(variables[c] == '0' || variables[c] == '1')
                    {
                        table[i, c] = variables[c] == '0' ? 0 : 1;
                        continue;
                    }
                    table[i, c] = insertOnes ? 1 : 0;
                    if ((i + 1) % repeatEvery == 0)
                    {
                        insertOnes = !insertOnes;
                    }
                }
            }
        }

        private int[] GetRow(int rowNumber, int[ , ] table)
        {
            int[] values = new int[table.GetLength(1)];
            for (int i = 0; i < table.GetLength(1); i++)
            {
                values[i] = table[rowNumber, i];
            }
            return values;
        }

        private BinaryTree ChangeValueOfLeaves(string formula, List<char> leaves, int[] newValues)
        {
            foreach (char c in formula)
            {
                if (leaves.Contains(c))
                {
                    if(c != '0' && c != '1')
                    {
                        int index = Array.IndexOf(leaves.ToArray(), c);
                        formula = formula.Replace(c, newValues[index] == 1 ? '1' : '0');
                    }
                }
            }
            return new BinaryTree(formula);
        }

        private string ReadTruthTable(string truthTable, List<char> variables, string formula, int[ , ] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                int[] values = this.GetRow(i, table);
                for(int j = 0; j < values.Length; j++)
                {
                    if(j + 1 != values.Length)
                    {
                        truthTable = truthTable + $" {values[j]} |";
                    }
                    else
                    {
                        truthTable = truthTable + $" {values[j]} \r\n";
                    }
                }
            }
            return truthTable;
        }
    }
}
