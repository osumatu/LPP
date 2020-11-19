namespace LPP.Nodes
{
    public class Biconditional : Node
    {
        public Biconditional(Node leftChild, Node rightChild) : base(leftChild, rightChild)
        {
            Value = '↔';
        }

        public override bool CalculateTTValue()
        {
            Node l = new Implication(leftChild, rightChild);
            Node r = new Implication(rightChild, leftChild);
            return l.CalculateTTValue() && r.CalculateTTValue();
        }

        public override string Nandify()
        {
            return $"%(%(%({leftChild.Nandify()},{leftChild.Nandify()}),%({rightChild.Nandify()},{rightChild.Nandify()})),%({leftChild.Nandify()},{rightChild.Nandify()}))";
        }
    }
}
