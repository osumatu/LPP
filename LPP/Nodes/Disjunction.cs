﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Nodes
{
    public class Disjunction : Node
    {
        public Disjunction(Node leftChild, Node rightChild) : base(leftChild, rightChild)
        {
            this.Value = '˅';
        }

        public override bool CalculateTTValue()
        {
            return this.leftChild.CalculateTTValue() || this.rightChild.CalculateTTValue();
        }

        public override string Nandify()
        {
            return $"%(%({this.leftChild.Nandify()},{this.leftChild.Nandify()}),%({this.rightChild.Nandify()},{this.rightChild.Nandify()}))";
        }
    }
}
