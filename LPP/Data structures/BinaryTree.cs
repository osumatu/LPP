﻿using LPP.Exceptions;
using LPP.Helpers;
using LPP.Models;
using LPP.Nodes;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LPP.Data_structures
{
    /// <summary>
    /// The main Binary tree class.
    /// Contains methods to create a binary tree and manipulate it.
    /// </summary>
    public class BinaryTree
    {
        public Node Root { get; private set; }
        private List<char> leaves;
        public string Formula { get; private set; }
        private TruthTable truthTableHelper;

        // Before creating a binary tree, the provided formula is validated
        public BinaryTree(string formula)
        {
            leaves = new List<char>();
            formula = formula.Replace(" ", "");
            IsFormulaValid(formula);
            Formula = formula;
            Root = CreateABinaryTree(ref formula, null);
            truthTableHelper = new TruthTable(this);
        }

        public string PrintParsedFormula()
        {
            return Root.ToString();
        }
        public string NandifyFormula()
        {
            return Root.Nandify();
        }

        public char[][] GetOriginalTable()
        {
            return truthTableHelper.OriginalTable;
        }

        public char[][] GetSimplifiedTable()
        {
            return truthTableHelper.SimplifiedTable;
        }

        public DNFModel GetOriginalTableDNF()
        {
            return truthTableHelper.GetDNF(truthTableHelper.OriginalTable);
        }

        public DNFModel GetSimplifiedTableDNF()
        {
            return truthTableHelper.GetDNF(truthTableHelper.SimplifiedTable);
        }

        public string GetTruthTableHashCode()
        {
            return truthTableHelper.GetHashCode(truthTableHelper.OriginalTable).ToString("X");
        }

        public string[] GetTableHeaders()
        {
            return truthTableHelper.GetHeaders();
        }

        public List<char> GetLeaves()
        {
            leaves.Sort((x, y) => x.CompareTo(y));
            return leaves;
        }

        public string GetTreeImage()
        {
            return GraphHelper.GenerateGraphFromTree(this);
        }

        private bool IsFormulaValid(string formula)
        {
            // The regex is created depicturing rather ~(A) or [&|>=](A,B) type, so by continuous check 
            // and simplification we can see if the formula ends up correctly
            string pattern = @"([~]\([A-Z0-1a-z]\))|([&|>=]\([A-Z0-1a-z],[A-Z0-1a-z]\))";
            string patternNAND = @"([%]\([A-Z0-1a-z],[A-Z0-1a-z]\))";
            string singleChar = @"^[A-Z0-1a-z]$";
            Regex r = new Regex(pattern);
            Regex r1 = new Regex(singleChar);
            Regex rNAND = new Regex(patternNAND);
            if (r1.Match(formula).Success)
            {
                return true;
            }
            if (formula.Contains('%'))
            {
                while (rNAND.Match(formula).Success)
                {
                    formula = rNAND.Replace(formula, "A");
                }
            }
            else
            {
                while (r.Match(formula).Success)
                {
                    formula = r.Replace(formula, "A");
                }
            }
            if (formula != "A")
            {
                throw new InvalidFormula("Provided formula is invalid, try again!");
            }
            return true;
        }

        private Node CreateABinaryTree(ref string formula, Node node)
        {
            if (node == null)
            {
                switch (formula[0])
                {
                    case '~':
                        formula = formula.Remove(0, 1);
                        node = new Negation(null);
                        break;
                    case '>':
                        formula = formula.Remove(0, 1);
                        node = new Implication(null, null);
                        break;
                    case '=':
                        formula = formula.Remove(0, 1);
                        node = new Biconditional(null, null);
                        break;
                    case '&':
                        formula = formula.Remove(0, 1);
                        node = new Conjunction(null, null);
                        break;
                    case '|':
                        formula = formula.Remove(0, 1);
                        node = new Disjunction(null, null);
                        break;
                    case '%':
                        formula = formula.Remove(0, 1);
                        formula = formula.Insert(0, "&");
                        node = new Negation(null);
                        break;
                    case '(':
                        formula = formula.Remove(0, 1);
                        return CreateABinaryTree(ref formula, node);
                    case ',':
                        formula = formula.Remove(0, 1);
                        return CreateABinaryTree(ref formula, node);
                    case ')':
                        formula = formula.Remove(0, 1);
                        return CreateABinaryTree(ref formula, node);
                    default:
                        node = new Leaf(formula[0]);
                        if (!leaves.Exists(e => e == node.Value))
                            leaves.Add(node.Value);
                        formula = formula.Remove(0, 1);
                        break;
                }
                if (!(node is Leaf))
                {
                    node.leftChild = CreateABinaryTree(ref formula, node.leftChild);
                    if (!(node is Negation))
                        node.rightChild = CreateABinaryTree(ref formula, node.rightChild);
                }
            }
            return node;
        }
    }
}
