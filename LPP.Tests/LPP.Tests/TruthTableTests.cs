using LPP.Data_structures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Tests
{
    [TestFixture]
    public class TruthTableTests
    {

        [TestCase("A", "10")]
        [TestCase("&(|(A,~(B)),C)", "10100010")]
        [TestCase("= (> (A, |(B,A)), ~(&(C,B)))", "01110111")]
        [TestCase("~ (> (A, |(B,A)))", "0000")]
        [TestCase(">(&(>(p,q),p),q)", "1111")]
        public void TestTruthTableCreation(string formula, string expectedHashCode)
        {
            int hashCodeInBinary = Convert.ToInt32(expectedHashCode, 2);
            BinaryTree tree = new BinaryTree(formula);
            TruthTable table = new TruthTable(tree);
            Assert.AreEqual(table.GetHashCode(table.OriginalTable), hashCodeInBinary);
        }

        [TestCase("A", "10")]
        [TestCase("&(|(A,~(B)),C)", "1100000")]
        [TestCase("= (> (A, |(B,A)), ~(&(C,B)))", "1100")]
        [TestCase("~ (> (A, |(B,A)))", "0000")]
        [TestCase(">(&(>(p,q),p),q)", "1")]
        public void TestSimplifiedTruthTableCreation(string formula, string expectedHashCode)
        {
            int hashCodeInBinary = Convert.ToInt32(expectedHashCode, 2);
            BinaryTree tree = new BinaryTree(formula);
            TruthTable table = new TruthTable(tree);
            Assert.AreEqual(table.GetHashCode(table.SimplifiedTable), hashCodeInBinary);
        }

        [TestCase("A")]
        [TestCase("= (> (A, |(B,A)), ~(&(C,B)))")]
        [TestCase("~ (> (A, |(B,A)))")]
        [TestCase("%(%(A,A),%(B,B))")]
        [TestCase(">(&(>(p,q),p),q)")]
        public void TestTruthTableDNF(string formula)
        {
            BinaryTree tree = new BinaryTree(formula);
            TruthTable table = new TruthTable(tree);
            var dnf = table.GetDNF(table.OriginalTable);
            if(table.GetHashCode(table.OriginalTable) != 0)
            {
                BinaryTree treeFromDnf = new BinaryTree(dnf.PrefixFormat);
                TruthTable tableFromDnf = new TruthTable(treeFromDnf);
                Assert.AreEqual(table.GetHashCode(table.OriginalTable), tableFromDnf.GetHashCode(tableFromDnf.OriginalTable));
                string formulaWithoutBrackets = treeFromDnf.PrintParsedFormula().Replace("(", "");
                formulaWithoutBrackets = formulaWithoutBrackets.Replace(")", "");
                formulaWithoutBrackets = formulaWithoutBrackets.Replace(" ", "");
                string infixWithoutBrackets = dnf.InfixFormat.Replace("(", "");
                infixWithoutBrackets = infixWithoutBrackets.Replace(")", "");
                infixWithoutBrackets = infixWithoutBrackets.Replace(" ", "");
                Assert.AreEqual(formulaWithoutBrackets, infixWithoutBrackets);
            }
            else
            {
                Assert.AreEqual(dnf.PrefixFormat, "");
                Assert.AreEqual(dnf.InfixFormat, "");
            }
        }

        [TestCase("A")]
        [TestCase("~ (> (A, |(B,A)))")]
        [TestCase("%(%(A,A),%(B,B))")]
        [TestCase(">(&(>(p,q),p),q)")]
        public void TestSimplifiedTruthTableDNF(string formula)
        {
            BinaryTree tree = new BinaryTree(formula);
            TruthTable table = new TruthTable(tree);
            var dnf = table.GetDNF(table.SimplifiedTable);
            if (table.GetHashCode(table.OriginalTable) != 0 && Convert.ToString(table.GetHashCode(table.OriginalTable), 2).Contains('0'))
            {
                BinaryTree treeFromDnf = new BinaryTree(dnf.PrefixFormat);
                TruthTable tableFromDnf = new TruthTable(treeFromDnf);
                Assert.AreEqual(table.GetHashCode(table.OriginalTable), tableFromDnf.GetHashCode(tableFromDnf.OriginalTable));
                string formulaWithoutBrackets = treeFromDnf.PrintParsedFormula().Replace("(", "");
                formulaWithoutBrackets = formulaWithoutBrackets.Replace(")", "");
                formulaWithoutBrackets = formulaWithoutBrackets.Replace(" ", "");
                string infixWithoutBrackets = dnf.InfixFormat.Replace("(", "");
                infixWithoutBrackets = infixWithoutBrackets.Replace(")", "");
                infixWithoutBrackets = infixWithoutBrackets.Replace(" ", "");
                Assert.AreEqual(formulaWithoutBrackets, infixWithoutBrackets);
            }
            else
            {
                Assert.AreEqual(dnf.PrefixFormat, "");
                string infixWithoutBrackets = dnf.InfixFormat.Replace("(", "");
                infixWithoutBrackets = infixWithoutBrackets.Replace(")", "");
                infixWithoutBrackets = infixWithoutBrackets.Replace(" ", "");
                Assert.AreEqual(infixWithoutBrackets, "");
            }
        }
    }
}
