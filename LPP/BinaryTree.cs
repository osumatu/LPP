using LPP.Exceptions;
using LPP.Helpers;
using LPP.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LPP
{
    public class BinaryTree
    {
        public Node Root { get; private set; }
        private List<char> leaves;
        private GraphHelper graphHelper;
        private TruthTableHelper truthTableHelper;
        private string intialFormula;
        public BinaryTree(string formula)
        {
            this.leaves = new List<char>();
            this.intialFormula = formula;
            formula = formula.Replace(" ", "");
            this.IsFormulaValid(formula);
            this.Root = this.CreateABinaryTree(ref formula, null);
            graphHelper = new GraphHelper();
            truthTableHelper = new TruthTableHelper();
        }

        public string PrintParsedFormula()
        {
            return this.Root.ToString();
        }

        public string GetTruthTable()
        {
            return this.truthTableHelper.GenerateTruthTable(this, this.intialFormula);
        }

        public List<char> GetLeaves()
        {
            this.leaves.Sort((x, y) => x.CompareTo(y));
            return this.leaves;
        }

        public string GetTreeImage()
        {
            return this.graphHelper.GenerateGraphFromTree(this);
        }

        private bool IsFormulaValid(string formula)
        {
            string pattern = @"^([a-zA-Z0-1]|(((([=|>&](?<BR>\())+([~](?<NEG>\())*)|(([~](?<NEG>\())+([=|>&](?<BR>\())*))+[a-zA-Z0-1]{1}(?<-NEG>\))?(,(([=|>&](?<BR>\())*([~](?<NEG>\())*)*[a-zA-Z0-1]{1}(?(<NEG>)(?<-NEG>\))|(?<-BR>\))))*(?<-BR>\))*(?<-NEG>\))*)(?(BR)(?!))(?(NEG)(?!))(?(CM)(?!)))$";
            Regex notAllowedCharacters = new Regex(pattern);
            if (!notAllowedCharacters.IsMatch(formula))
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
                        if (!leaves.Exists(e => e == node.Value))
                            this.leaves.Add(node.Value);
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
    }
}
