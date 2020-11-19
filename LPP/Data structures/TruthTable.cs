using LPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LPP.Data_structures
{
    /// <summary>
    /// The TruthTable class contains the information about thruth table constructed from BinaryTree.
    /// </summary>
    public class TruthTable
    {
        public char[][] OriginalTable { private set; get; }
        public char[][] SimplifiedTable { private set; get; }
        private int nrOfColumns;
        private int nrOfRows;
        private BinaryTree tree;

        public TruthTable(BinaryTree tree)
        {
            this.tree = tree;
            // Amount of rows in the table equals to the number of possible combinations 
            // of 0's and 1's for all variables
            nrOfRows = (int)Math.Pow(2, tree.GetLeaves().Count);
            // Amount of columns equals the number of variables + 1 more for result
            nrOfColumns = tree.GetLeaves().Count + 1;
            OriginalTable = GenerateTruthTable();
            SimplifiedTable = SimplifyTruthTable();
        }

        /// <summary>
        /// This method returns the array of column headers
        /// </summary>
        public string[] GetHeaders()
        {
            string[] headers = new string[nrOfColumns];
            var variables = tree.GetLeaves();
            for (int i = 0; i < nrOfColumns - 1; i++)
            {
                headers[i] = variables[i].ToString();
            }
            headers[nrOfColumns - 1] = "Formula";
            return headers;
        }

        /// <summary>
        /// This method generated disjunctive normal form of the truth table provided in infix and prefix formats
        /// </summary>
        public DNFModel GetDNF(char[][] table)
        {
            var rowsToConvert = table.Where(c => c[nrOfColumns - 1] == '1').ToArray();
            var variables = tree.GetLeaves();
            string dnfInfix = "";
            string dnfPrefix = "";
            int closingBrackets = 0;
            for (int i = 0; i < rowsToConvert.GetLength(0); i++)
            {
                if (i != 0)
                {
                    dnfInfix += '˅';
                    dnfPrefix += ',';
                }
                if (rowsToConvert.GetLength(0) - i >= 2) // so we know there are at least two elements so a new 'OR' expression can be created
                {
                    dnfPrefix += "|(";
                    closingBrackets++;
                }
                var currentRow = rowsToConvert[i];
                dnfInfix += "(";
                int amount = currentRow.Where(c => c != '*').Count(); // to know how many variables are in the row excluding '*' 
                int insideOpenBrackets = 0;
                for (int j = 0; j < nrOfColumns - 1; j++)
                {
                    if (currentRow[j] != '*')
                    {
                        if (variables.Contains(dnfInfix[dnfInfix.Length - 1]))
                        {
                            dnfInfix += '˄';
                        }
                        if (amount > 2)
                        {
                            dnfPrefix += "&(";
                            insideOpenBrackets++;
                        }
                        dnfInfix += currentRow[j] == '1' ? variables[j].ToString() : $"¬{variables[j]}";
                        dnfPrefix += currentRow[j] == '1' ? variables[j].ToString() : $"~({variables[j]})";
                        if (amount > 2)
                        {
                            dnfPrefix += ',';
                        }
                        amount--;
                    }
                }
                dnfInfix += ")";
                while (insideOpenBrackets > 0)
                {
                    dnfPrefix += ')';
                    insideOpenBrackets--;
                }
            }
            while (closingBrackets > 0)
            {
                dnfPrefix += ')';
                closingBrackets--;
            }
            return new DNFModel { InfixFormat = dnfInfix, PrefixFormat = dnfPrefix };
        }

        /// <summary>
        /// This method generates the hash code of the truth table.
        /// </summary>
        public int GetHashCode(char[][] table)
        {
            string binary = "";
            // reading values from bottom to top from the last column
            for (int i = table.GetLength(0) - 1; i >= 0; i--)
            {
                binary += table[i][nrOfColumns - 1];
            }
            return Convert.ToInt32(binary, 2);
        }

        /// <summary>
        /// This method generates the truth table.
        /// </summary>
        private char[][] GenerateTruthTable()
        {
            var variables = tree.GetLeaves();
            var table = new char[nrOfRows][];

            InitializeJaggedArray(ref table, nrOfRows, nrOfColumns);

            // If the formula contains only of 0's and 1's the answer of the expression is  
            // immediately calculated and the corresponding row is added to the table
            if (!variables.Any(x => x != '1' && x != '0'))
            {
                table = new char[1][];
                InitializeJaggedArray(ref table, 1, nrOfColumns);

                for (int i = 0; i < nrOfColumns - 1; i++)
                {
                    table[0][i] = variables[i];
                }
                table[0][nrOfColumns - 1] = tree.Root.CalculateTTValue() ? '1' : '0';
                return table;
            }

            MakeColumns(ref table, nrOfColumns - 1);

            // Fill in the result for every variation/row in a table in the last column
            for (int i = 0; i < nrOfRows; i++)
            {
                var temp = ChangeValueOfLeaves(table[i], tree.Formula);
                table[i][nrOfColumns - 1] = temp.Root.CalculateTTValue() ? '1' : '0';
            }
            return table;
        }

        /// <summary>
        /// This method intializes a jagged array.
        /// </summary>
        private void InitializeJaggedArray(ref char[][] table, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                table[i] = new char[columns];
            }
        }

        /// <summary>
        /// This method simplifies the truth table.
        /// </summary>
        private char[][] SimplifyTruthTable()
        {
            var originalRows = OriginalTable.Select(s => s.ToArray()).Where(c => c[nrOfColumns - 1] == '0').ToList();
            var simplified = OriginalTable.Select(s => s.ToArray()).Where(c => c[nrOfColumns - 1] == '1').ToList();

            bool rowWasSimplified = true;
            // Simplify rows till the algorithm continues making new changes
            while (rowWasSimplified)
            {
                rowWasSimplified = false;
                var toSimplify = simplified.Select(s => s.ToArray()).ToArray(); ;
                // For every row that needs to be simplified check if it can be simplified with the rest
                for (int i = 0; i < simplified.Count(); i++) // indexOfZero is used because its value determines the start of the rows that needs to be simplified 
                {
                    for (int j = 0; j < simplified.Count(); j++)
                    {
                        int numberOfMatches = 0;
                        int indexDiffers = -1;
                        for (int c = 0; c < nrOfColumns - 1; c++)
                        {
                            // To see how many matching symbols are in the row i with row j
                            if (toSimplify[i][c] == toSimplify[j][c])
                            {
                                numberOfMatches++;
                            }
                            else
                            {
                                indexDiffers = c;
                            }
                        }
                        if (numberOfMatches == nrOfColumns - 2 && indexDiffers != -1) // -2 because one should be different and the result column is not taken into account
                        {
                            // check if the potentially simplified row doesn't exist in the rows resulting in 0, thus can be actually simplified
                            if (checkIfCanBeSimplified(originalRows, simplified[i], indexDiffers))
                            {
                                simplified[i][indexDiffers] = '*';
                                rowWasSimplified = true;
                            }
                            // check if the potentially simplified row doesn't exist in the rows resulting in 0,  thus can be actually simplified
                            if (checkIfCanBeSimplified(originalRows, simplified[j], indexDiffers))
                            {
                                simplified[j][indexDiffers] = '*';
                                rowWasSimplified = true;
                            }
                        }
                    }
                }
            }
            originalRows.AddRange(RemoveDuplicates(simplified));
            return originalRows.ToArray();
        }

        /// <summary>
        /// This method checks if the row can be simplified.
        /// </summary>
        private bool checkIfCanBeSimplified(List<char[]> originalRows, char[] simplifiedRow, int indexDiffers)
        {
            foreach (char[] row in originalRows)
            {
                int matching = 0;
                for (int i = 0; i < nrOfColumns - 1; i++)
                {
                    if (i == indexDiffers)
                    {
                        matching++;
                        continue;
                    }
                    if (row[i] == simplifiedRow[i] || simplifiedRow[i] == '*')
                    {
                        matching++;
                    }
                }
                if (matching == nrOfColumns - 1) // if there exists the row resulting in 0 with the same values as the simplified row, reject the change
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// This method removes duplicated rows in the simplified ones
        /// </summary>
        private List<char[]> RemoveDuplicates(List<char[]> input)
        {
            var withoutDuplicates = input.GroupBy(c => String.Join(",", c))
                       .Select(c => c.First().ToArray()).ToList();
            return withoutDuplicates;
        }

        /// <summary>
        /// This method generates 0's and 1's in specific order for every column except the result one.
        /// </summary>
        private void MakeColumns(ref char[][] input, int columns)
        {
            var variables = tree.GetLeaves();
            // Loops through all the columns 
            for (int c = 0; c < columns; c++)
            {
                // Calculates which every n elements should the 1's change to 0's and vice versa
                int repeatEvery = (int)Math.Pow(2, columns - (c + 1)); // c + 1 because index starts from 0
                bool insertOnes = false;
                // Loops thought the amount of rows each column has
                for (int i = 0; i < nrOfRows; i++)
                {
                    // If the variable is either a 0 or 1, insert its actual value
                    if (variables[c] == '0' || variables[c] == '1')
                    {
                        input[i][c] = variables[c];
                        continue;
                    }
                    // If not, check what number comes next and insert accordingly
                    input[i][c] = insertOnes ? '1' : '0';
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
        /// This method rebuilds the tree based on the new leaves' values.
        /// </summary>
        private BinaryTree ChangeValueOfLeaves(char[] newValues, string formula)
        {
            var leaves = tree.GetLeaves();
            foreach (char c in formula)
            {
                if (leaves.Contains(c))
                {
                    if (c != '0' && c != '1')
                    {
                        int index = Array.IndexOf(leaves.ToArray(), c);
                        formula = formula.Replace(c, newValues[index]);
                    }
                }
            }
            return new BinaryTree(formula);
        }
    }
}
