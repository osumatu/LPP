namespace LPP.Nodes
{
    public class Leaf : Node
    {
        public Leaf(char value) : base(null, null)
        {
            Value = value;
        }

        public override bool CalculateTTValue()
        {
            return Value == '1' ? true : false;
        }

        public override string Nandify()
        {
            return Value.ToString();
        }

        public override string ToString()
        {
            return Value.ToString();
        }


    }
}
