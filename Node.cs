namespace Теория_информации_метод_Хоффмана
{
    public class Node
    {
        public Node(Node component1, Node component2)
        {
            _value = component1._value + component2._value;
            Component1 = component1;
            Component2 = component2;
        }

        public Node(Symbol parent)
        {
            _value = parent._probability;
            Parent = parent;
        }

        internal double _value { get; }
        internal Node Component1 { get; }
        internal Node Component2 { get; }
        internal Symbol Parent { get; }

        public void Find_code(string code)
        {
            if (this.Parent == null)
            {
                this.Component1.Find_code(code + "1");
            }
            else
            {
                this.Parent._code = code;
            }

            if (this.Parent == null)
            {
                this.Component2.Find_code(code + "0");
            }
            else
            {
                this.Parent._code = code;
            }
        }
    }
}
