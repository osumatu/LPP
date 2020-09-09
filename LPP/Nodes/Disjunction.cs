using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Nodes
{
    public class Disjunction : Node
    {
        public Disjunction(Node leftChild, Node rightChild) : base(leftChild, rightChild)
        {
            this.Value = '|';
        }
    }
}
