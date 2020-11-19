namespace LPP.Nodes
{
    public class Disjunction : Node
    {
        public Disjunction(Node leftChild, Node rightChild) : base(leftChild, rightChild)
        {
            Value = '˅';
        }

        public override bool CalculateTTValue()
        {
            return leftChild.CalculateTTValue() || rightChild.CalculateTTValue();
        }

        public override string Nandify()
        {
            return $"%(%({leftChild.Nandify()},{leftChild.Nandify()}),%({rightChild.Nandify()},{rightChild.Nandify()}))";
        }
    }
}
