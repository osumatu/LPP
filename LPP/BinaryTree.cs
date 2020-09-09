using LPP.Exceptions;
using LPP.Helpers;
using LPP.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LPP
{
    public class BinaryTree
    {
        public Node Root { get; private set; }
        private List<Node> leaves;
        private GraphHelper graphHelper;

        public BinaryTree(string formula)
        {
            this.leaves = new List<Node>();
            formula = formula.Replace(" ", "");
            this.Root = this.CreateABinaryTree(ref formula, null);
            graphHelper = new GraphHelper();
        }

        public string PrintParsedFormula()
        {
            return this.Root.ToString();
        }

        public char[] GetLeaves()
        {
            this.leaves.Sort((x, y) => x.Value.CompareTo(y.Value));
            int size = this.leaves.Count * 2;
            char[] variables = new char[size];
            int i = 0;
            foreach (Node l in this.leaves)
            {
                variables[i] = l.Value;
                i++;
                variables[i] = ' ';
                i++;
            }
            return variables;
        }

        public string GetTreeImage()
        {
            return this.graphHelper.GenerateGraphFromTree(this);
        }

        private Node CreateABinaryTree(ref string formula, Node node)
        {
            try
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
                        case '(':
                            formula = formula.Remove(0, 1);
                            return this.CreateABinaryTree(ref formula, node);
                        case ',':
                            formula = formula.Remove(0, 1);
                            return this.CreateABinaryTree(ref formula, node);
                        case ')':
                            formula = formula.Remove(0, 1);
                            return this.CreateABinaryTree(ref formula, node);
                        default:
                            node = new Leaf(formula[0]);
                            if (!leaves.Exists(e => e.Value == node.Value))
                                this.leaves.Add(node);
                            formula = formula.Remove(0, 1);
                            break;
                    }
                    if (!(node is Leaf))
                        node.leftChild = CreateABinaryTree(ref formula, node.leftChild);

                    if (!(node is Negation) && !(node is Leaf))
                        node.rightChild = CreateABinaryTree(ref formula, node.rightChild);

                    return node;
                }
                else
                {
                    return node;
                }
            }
            catch ( Exception e)
            {
                throw new InvalidFormula("Provided formula is invalid, try again!");
            }
        }
    }
}
