namespace LPP.Nodes
{
    /// <summary>
    /// The abstract Node class.
    /// Contains information about left and right child to ensure tree data structure.
    /// Also, needed for calculating truth tables and displaying parsed formula.
    /// </summary>
    public abstract class Node
    {
        public Node leftChild { get; set; }
        public Node rightChild { get; set; }
        public char Value { get; set; }

        public Node(Node leftChild, Node rightChild, char value)
        {
            this.leftChild = leftChild;
            this.rightChild = rightChild;
            Value = value;
        }
        public Node(Node leftChild, Node rightChild)
        {
            this.leftChild = leftChild;
            this.rightChild = rightChild;
        }

        public abstract bool CalculateTTValue();
        public abstract string Nandify();

        public override string ToString()
        {
            return $"({leftChild} {Value} {rightChild})";
        }
    }
}
