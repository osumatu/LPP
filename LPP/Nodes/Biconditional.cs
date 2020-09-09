using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Nodes
{
    public class Biconditional : Node
    {
        public Biconditional(Node leftChild, Node rightChild) : base(leftChild, rightChild)
        {
            this.Value = '=';
        }
    }
}
