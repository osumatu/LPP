﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Nodes
{
    public class Implication : Node
    {
        public Implication(Node leftChild, Node rightChild) : base(leftChild, rightChild)
        {
            this.Value = '>';
        }
    }
}