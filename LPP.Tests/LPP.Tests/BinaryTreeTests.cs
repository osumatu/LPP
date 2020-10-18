using LPP.Data_structures;
using LPP.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Tests
{
    [TestFixture]
    public class BinaryTreeTests
    {

        [TestCase("A", "A")]
        [TestCase("= (> (A, |(B,A)), ~(&(C,B)))", "((A → (B ˅ A)) ↔ ¬((C ˄ B)))")]
        [TestCase("~ (> (A, |(B,A)))", "¬((A → (B ˅ A)))")]
        [TestCase("%(%(A,A),%(B,B))", "¬((¬((A ˄ A)) ˄ ¬((B ˄ B))))")]
        public void TestTreeCreationFromCorrectlyFormattedInput(string formula, string expectedOutput)
        {
            BinaryTree tree = new BinaryTree(formula);
            Assert.AreEqual(tree.PrintParsedFormula(), expectedOutput);
        }

        [TestCase("= (> (A, B), C")] // too little brackets
        [TestCase("* (> (A, B), C))")] // unexisting operator
        [TestCase("= (~ (A, B), C))")] // negation with two variables
        [TestCase(" (& (A, B), C))")] // missing operator
        [TestCase("% (~ (A, B), C))")] // NAND operator with normal operators
        [TestCase("| (> (A, B), C)))")] // too many brackets
        [TestCase("")] // empty
        [TestCase("5")] // not allowed symbol
        public void TestTreeCreationFromWronglyFormattedInput(string formula)
        {
            Assert.Throws<InvalidFormula>(() => new BinaryTree(formula));
        }

        [TestCase("A", 'A')]
        [TestCase("= (> (A, |(B,A)), ~(&(C,B)))", 'A', 'B', 'C')]
        [TestCase("~ (> (A, |(D,A)))", 'A', 'D')]
        public void GetTreeLeaves(string formula, params char[] expectedOutput)
        {
            BinaryTree tree = new BinaryTree(formula);
            Assert.AreEqual(tree.GetLeaves().ToArray(), expectedOutput);
        }

        [TestCase("~(A)", "%(A,A)")]
        [TestCase("A", "A")]
        [TestCase("|(A,B)", "%(%(A,A),%(B,B))")]
        [TestCase("&(A,B)", "%(%(A,B),%(A,B))")]
        [TestCase("=(A,B)", "%(%(%(A,A),%(B,B)),%(A,B))")]
        [TestCase(">(A,B)", "%(A,%(B,B))")]
        [TestCase("= (> (A, |(B,A)), ~(&(C,B)))", "%(%(%(%(A,%(%(%(B,B),%(A,A)),%(%(B,B),%(A,A)))),%(A,%(%(%(B,B),%(A,A)),%(%(B,B),%(A,A))))),%(%(%(%(C,B),%(C,B)),%(%(C,B),%(C,B))),%(%(%(C,B),%(C,B)),%(%(C,B),%(C,B))))),%(%(A,%(%(%(B,B),%(A,A)),%(%(B,B),%(A,A)))),%(%(%(C,B),%(C,B)),%(%(C,B),%(C,B)))))")]
        public void NandifyTreeExpression(string formula, string expectedOutput)
        {
            BinaryTree tree = new BinaryTree(formula);
            Assert.AreEqual(tree.NandifyFormula(), expectedOutput);
        }
    }
}
