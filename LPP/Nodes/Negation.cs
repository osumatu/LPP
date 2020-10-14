using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Nodes
{
    public class Negation : Node
    {
        public Negation(Node leftChild) : base(leftChild, null)
        {
            this.Value = '¬'; 
        }

        public override bool CalculateTTValue()
        {
            return !(this.leftChild.CalculateTTValue());
        }

        public override string Nandify()
        {
            return $"%({this.leftChild.Nandify()},{this.leftChild.Nandify()})";
        }

        public override string ToString()
        {
            return $"{this.Value}({this.leftChild})";
        }
    }
}
