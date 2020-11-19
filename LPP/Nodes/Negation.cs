namespace LPP.Nodes
{
    public class Negation : Node
    {
        public Negation(Node leftChild) : base(leftChild, null)
        {
            Value = '¬';
        }

        public override bool CalculateTTValue()
        {
            return !(leftChild.CalculateTTValue());
        }

        public override string Nandify()
        {
            return $"%({leftChild.Nandify()},{leftChild.Nandify()})";
        }

        public override string ToString()
        {
            return $"{Value}({leftChild})";
        }
    }
}
