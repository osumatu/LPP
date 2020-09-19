using LPP.Nodes;
using System;
using System.Collections.Generic;

namespace LPP.Helpers
{
    public class TruthTableHelper
    {
        public string GenerateTruthTable(BinaryTree tree)
        {
            int nrOfRows = (int)Math.Pow(2, tree.GetLeaves().Count);
            int nrOfColumns = tree.GetLeaves().Count + 1;
            int[ , ] table = new int[nrOfRows, nrOfColumns];
            this.MakeColumns(ref table);
            for (int i = 0; i < table.GetLength(0); i++)
            {
                Node root = this.ChangeValueOfLeaves(tree.Root, tree.GetLeaves(), this.GetRow(i, table));
                table[i, nrOfColumns - 1] = root.CalculateTTValue() ? 1 : 0;
            }
            return this.ReadTruthTable(tree.GetLeaves(), tree.PrintParsedFormula(), table);
        }

        private void MakeColumns(ref int[ , ] table)
        {
            for (int c = 0; c < table.GetLength(1) - 1; c++) //-1 because the last column is meant for the result value
            {
                int repeatEvery = (int)Math.Pow(2, (table.GetLength(1) - c)); // so we get amount of var - 1 the result column and + 1 because column starts from 0
                bool insertOnes = false;
                for (int i = 0; i < table.GetLength(0); i++)
                {
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
            for (int i = 0; i < table.GetLength(1) - 1; i++) //-1 because the last column is meant for the result value
            {
                values[i] = table[rowNumber, i];
            }
            return values;
        }

        private Node ChangeValueOfLeaves(Node node, List<char> leaves, int[] newValues)
        {
            if (node != null)
            {
                if (node is Leaf)
                {
                    int index = Array.IndexOf(leaves.ToArray(), node.Value);
                    node.Value = Convert.ToChar(newValues[index]);
                }
                node.leftChild = ChangeValueOfLeaves(node.leftChild, leaves, newValues);
                node.rightChild = ChangeValueOfLeaves(node.rightChild, leaves, newValues);
                return node;
            }
            else
            {
                return node;
            }
        }

        private string ReadTruthTable(List<char> variables, string formula, int[ , ] table)
        {
            string truthTable = "";
            for (int i = 0; i < variables.Count; i++)
            {
                truthTable = truthTable + $" {variables[i]} |";
            }
            truthTable = truthTable + $" {formula} \r\n";
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
