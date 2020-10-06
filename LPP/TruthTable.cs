using System;
using System.Collections.Generic;
using System.Linq;

namespace LPP
{
    /// <summary>
    /// The TruthTable class contains the information about thruth table constructed from BinaryTree.
    /// </summary>
    public class TruthTable
    {
        private BinaryTree tree;
        private char[ , ] table;
        public TruthTable(BinaryTree tree)
        {
            this.tree = tree;
            this.table = this.GenerateTruthTable();
        }

        /// <summary>
        /// This method gets the info about truth table.
        /// </summary>
        public string GetTruthTable()
        {
            return this.ReadTable(this.table);
        }

        /// <summary>
        /// This method gets the info about simplified truth table
        /// </summary>
        public string GetSimplifiedTruthTable()
        {
            char[,] simplifiedTable = this.SimplifyTruthTable();
            return this.ReadTable(simplifiedTable);
        }

        /// <summary>
        /// This method generates the truth table.
        /// </summary>
        private char[ , ] GenerateTruthTable()
        {
            var variables = this.tree.GetLeaves();
            // Amount of rows in the table equals to the number of possible combinations 
            // of 0's and 1's for all variables 
            int nrOfRows = (int)Math.Pow(2, variables.Count);
            // Amount of columns equals the number of variables + 1 more for result
            int nrOfColumns = variables.Count + 1;
            char[ , ] table = new char[nrOfRows, nrOfColumns];

            // If the formula contains only of 0's and 1's the answer of the expression is  
            // immediately calculated and the corresponding row is added to the table
            if (!variables.Any(x => x != '1' && x != '0'))
            {
                table = new char[1, nrOfColumns];
                for (int i = 0; i < variables.Count; i++)
                {
                    table[0, i] = variables[i];
                }
                table[0, variables.Count] = tree.Root.CalculateTTValue() ? '1' : '0';
                return table;
            }
            MakeColumns(ref table);
            // Fill in the result for every variation/row in a table in the last column
            for (int i = 0; i < table.GetLength(0); i++) 
            {
                BinaryTree temp = ChangeValueOfLeaves(GetRow(i, table), this.tree.Formula);
                table[i, nrOfColumns - 1] = temp.Root.CalculateTTValue() ? '1' : '0';
            }
            return table;
        }

        /// <summary>
        /// This method simplifies the truth table.
        /// </summary>
        private char[ , ] SimplifyTruthTable()
        {
            char[ , ] simplifiedTable = new char[this.table.GetLength(0), this.table.GetLength(1)];
            int indexOfZero = 0;
            int indexOfOne = this.table.GetLength(0) - 1;
            // Filling in the rows with 0's from top and 1's from bottom, so it is easier to simplify
            for (int i = 0; i < this.table.GetLength(0); i++)
            {
                if(table[i, this.table.GetLength(1) - 1] == '0')
                {
                    for(int j = 0; j < this.table.GetLength(1); j++)
                    {
                        simplifiedTable[indexOfZero, j] = table[i, j];
                    }
                    indexOfZero++;
                }
                else
                {
                    for (int j = 0; j < this.table.GetLength(1); j++)
                    {
                        simplifiedTable[indexOfOne, j] = table[i, j];
                    }
                    indexOfOne--;
                }
            }
            bool rowWasSimplified = true;
            // Simplify rows till the algorithm continues making new changes
            while (rowWasSimplified)
            {
                rowWasSimplified = false;
                // For every row that needs to be simplified check if it can be simplified with the rest
                for (int i = indexOfZero; i < simplifiedTable.GetLength(0); i++) // indexOfZero is used because its value determines the start of the rows that needs to be simplified 
                {
                    for (int j = indexOfZero; j < simplifiedTable.GetLength(0); j++)
                    {
                        int numberOfMatches = 0;
                        int indexDiffers = 0;
                        for (int c = 0; c < simplifiedTable.GetLength(1) - 1; c++)
                        {
                            if (simplifiedTable[i, c] == simplifiedTable[j, c] || simplifiedTable[i, c] == '*' || simplifiedTable[j, c] == '*')
                            {
                                numberOfMatches++;
                            }
                            else
                            {
                                indexDiffers = c;
                            }
                        }
                        if (numberOfMatches == simplifiedTable.GetLength(1) - 2) // -2 because one should be different and the result column is not taken into account
                        {
                            simplifiedTable[i, indexDiffers] = '*';
                            simplifiedTable[j, indexDiffers] = '*';
                            rowWasSimplified = true;
                        }
                    }
                }
            }
            return simplifiedTable;
        }

        /// <summary>
        /// This method generates 0's and 1's in specific order for every column except the result one.
        /// </summary>
        private void MakeColumns(ref char[ , ] table)
        {
            List<char> variables = this.tree.GetLeaves();
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
                        table[i, c] = variables[c];
                        continue;
                    }
                    // If not, check what number comes next and insert accordingly
                    table[i, c] = insertOnes ? '1' : '0';
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
        private char[] GetRow(int rowNumber, char[ , ] table)
        {
            char[] values = new char[table.GetLength(1)];
            for (int i = 0; i < table.GetLength(1); i++)
            {
                values[i] = table[rowNumber, i];
            }
            return values;
        }


        /// <summary>
        /// This method rebuilds the tree based on the new leaves' values.
        /// </summary>
        private BinaryTree ChangeValueOfLeaves(char[] newValues, string formula)
        {
            List<char> leaves = this.tree.GetLeaves();
            foreach (char c in formula)
            {
                if (leaves.Contains(c))
                {
                    if(c != '0' && c != '1')
                    {
                        int index = Array.IndexOf(leaves.ToArray(), c);
                        formula = formula.Replace(c, newValues[index]);
                    }
                }
            }
            return new BinaryTree(formula);
        }

        /// <summary>
        /// This method converts the information in truth table to readable format.
        /// </summary>
        private string ReadTable(char[ , ] input)
        {
            string truthTable = "";
            List<char> variables = this.tree.GetLeaves();
            // This part adds the header to the truthTable
            for (int i = 0; i < variables.Count; i++)
            {
                truthTable = truthTable + $" {variables[i]} |";
            }
            truthTable = truthTable + $" Formula \r\n";

            for (int i = 0; i < input.GetLength(0); i++)
            {
                char[] values = GetRow(i, input);
                for (int j = 0; j < values.Length; j++)
                {
                    if (j + 1 != values.Length)
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
