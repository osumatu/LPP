using LPP.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LPP.Helpers
{
    /// <summary>
    /// The TruthTableHelper class helps the main class BinaryTree to construct truth table and simplify it.
    /// </summary>
    public static class TruthTableHelper
    {
        /// <summary>
        /// This method generates the description of the truth table.
        /// </summary>
        public static string GenerateTruthTable(BinaryTree tree, string formula)
        {
            var variables = tree.GetLeaves();
            string truthTable = "";
            // This part adds the header to the truthTable
            for (int i = 0; i < variables.Count; i++)
            {
                truthTable = truthTable + $" {variables[i]} |";
            }
            truthTable = truthTable + $" {tree.PrintParsedFormula()} \r\n";

            // If the formula contains only of 0's and 1's the answer of the expression is  
            // immediately calculated and the corresponding row is added to the table
            if (!variables.Any(x => x != '1' && x != '0'))
            {
                for (int i = 0; i < variables.Count; i++)
                {
                    truthTable = truthTable + $" {variables[i]} |";
                }
                truthTable = truthTable + $" {(tree.Root.CalculateTTValue() ? 1 : 0)} \r\n";
                return truthTable;
            }

            // Amount of rows in the table equals to the number of possible combinations 
            // of 0's and 1's for all variables 
            int nrOfRows = (int)Math.Pow(2, variables.Count);
            // Amount of columns equals the number of variables + 1 more for result
            int nrOfColumns = variables.Count + 1;
            int[ , ] table = new int[nrOfRows, nrOfColumns];
            MakeColumns(ref table, variables);
            // Fill in the result for every variation/row in a table in the last column
            for (int i = 0; i < table.GetLength(0); i++) 
            {
                BinaryTree temp = ChangeValueOfLeaves(formula, variables, GetRow(i, table));
                table[i, nrOfColumns - 1] = temp.Root.CalculateTTValue() ? 1 : 0;
            }
            return ReadTruthTable(truthTable, variables, tree.PrintParsedFormula(), table);
        }

        /// <summary>
        /// This method generates 0's and 1's in specific order for every column except the result one.
        /// </summary>
        private static void MakeColumns(ref int[ , ] table, List<char> variables)
        {
            // Loops through all the columns except the result one
            for (int c = 0; c < table.GetLength(1) - 1; c++) 
            {
                // Calculates which every n elements should the 1's change to 0's and vice versa
                int repeatEvery = (int)Math.Pow(2, table.GetLength(1) - (c + 2)); // c + 2 because index starts from 0 and the last column is meant for the result value
                bool insertOnes = false;
                // Loops thought the amount of rows each column has
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    // If the variable is either a 0 or 1, insert its actual value
                    if(variables[c] == '0' || variables[c] == '1')
                    {
                        table[i, c] = variables[c] == '0' ? 0 : 1;
                        continue;
                    }
                    // If not, check what number comes next and insert accordingly
                    table[i, c] = insertOnes ? 1 : 0;
                    // Check if the insertion number should be changed by seeing if it is divisible by n.
                    // If so, change the insertion number
                    if ((i + 1) % repeatEvery == 0)
                    {
                        insertOnes = !insertOnes;
                    }
                }
            }
        }

        /// <summary>
        /// This method gets the row from the specified position from the table.
        /// </summary>
        private static int[] GetRow(int rowNumber, int[ , ] table)
        {
            int[] values = new int[table.GetLength(1)];
            for (int i = 0; i < table.GetLength(1); i++)
            {
                values[i] = table[rowNumber, i];
            }
            return values;
        }


        /// <summary>
        /// This method rebuilds the tree based on the new leaves' values.
        /// </summary>
        private static BinaryTree ChangeValueOfLeaves(string formula, List<char> leaves, int[] newValues)
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


        /// <summary>
        /// This method converts the information in truth table to readable format.
        /// </summary>
        private static string ReadTruthTable(string truthTable, List<char> variables, string formula, int[ , ] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                int[] values = GetRow(i, table);
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
