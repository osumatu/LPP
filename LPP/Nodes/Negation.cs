using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Nodes
{
    public class Negation : Node
    {
        public Negation(Node leftChild) : base(leftChild, null)
        {
            this.Value = '~'; 
        }

        public override string ToString()
        {
            return $"{this.Value}({this.leftChild})";
        }
    }
}
