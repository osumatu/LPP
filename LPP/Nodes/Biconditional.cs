using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Nodes
{
    public class Biconditional : Node
    {
        public Biconditional(Node leftChild, Node rightChild) : base(leftChild, rightChild)
        {
            this.Value = '⇔';
        }

        public override bool CalculateTTValue()
        {
            Node l = new Implication(this.leftChild, this.rightChild);
            Node r = new Implication(this.rightChild, this.leftChild);
            return l.CalculateTTValue() && r.CalculateTTValue();
        }
    }
}
