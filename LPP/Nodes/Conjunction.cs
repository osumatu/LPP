﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Nodes
{
    public class Conjunction : Node
    {
        public Conjunction(Node leftChild, Node rightChild) : base(leftChild, rightChild)
        {
            this.Value = '&';
        }
    }
}