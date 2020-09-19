﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Nodes
{
    public abstract class Node
    {
        public Node leftChild { get; set; }
        public Node rightChild { get; set; }
        public char Value { get; set; }

        public Node(Node leftChild, Node rightChild, char value)
        {
            this.leftChild = leftChild;
            this.rightChild = rightChild;
            this.Value = value;
        }
        public Node(Node leftChild, Node rightChild)
        {
            this.leftChild = leftChild;
            this.rightChild = rightChild;
        }

        public abstract bool CalculateTTValue();

        public override string ToString()
        {
            return $"({leftChild} {this.Value} {rightChild})";
        }
    }
}
