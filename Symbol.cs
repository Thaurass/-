namespace Теория_информации_метод_Хоффмана
{
    public class Symbol
    {
        public Symbol(string value, double probability)
        {
            _value = value;

            if (value == " ")
            {
                _name = "пробел";
            }
            else
            {
                _name = value;
            }

            _probability = probability;
            _code = "";
        }

        internal string _value { get; set; }
        internal string _name { get; set; }
        internal double _probability { get; set; }
        internal string _code { get; set; }

        public static int ReverseCompareByProbability(Symbol symbol_1, Symbol symbol_2)
        {
            return symbol_2._probability.CompareTo(symbol_1._probability);
        }
    }
}
