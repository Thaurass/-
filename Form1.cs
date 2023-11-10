using System.Numerics;

namespace Теория_информации_метод_Хоффмана
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Symbol> Message = new();

        private void Fill_table(object sender, EventArgs e)
        {
            //textBox1.Text = "фотограф фотала фото";
            string inputText = textBox1.Text;

            Message.Clear();

            // Подсчитать вероятность каждой буквы
            Symbol_probabilities(inputText);
            Symbol_codes();

            // Очистите DataGridView
            resultGrid.Rows.Clear();

            foreach (var _symbol in Message)
            {
                resultGrid.Rows.Add(
                    _symbol._name,
                    Math.Round(_symbol._probability, 2),
                    _symbol._code,
                    _symbol._code.Length,
                    Math.Round(_symbol._code.Length * Math.Round(_symbol._probability, 2), 3)
                );
            }
        }

        void Symbol_probabilities(string inputText)
        {
            int totalCharacters = inputText.Length;

            foreach (char character in inputText)
            {
                if (Message.Exists(x => x._value == character.ToString()))
                {
                    int index = Message.FindIndex(x => x._value == character.ToString());
                    var symbol = Message[index];
                    symbol._probability += 1.0 / totalCharacters;
                    Message[index] = symbol;
                }
                else
                {
                    var symbol = new Symbol(character.ToString(), 1.0 / totalCharacters);
                    Message.Add(symbol);
                }
            }

            Message.Sort(Symbol.ReverseCompareByProbability);
        }

        void Symbol_codes()
        {
            List<Node> TempNodes = new();

            foreach (var _symbol in Message)
            {
                TempNodes.Add(new Node(_symbol));
            }

            while (TempNodes.Count != 1)
            {
                var minNode1 = TempNodes.FindMin();
                TempNodes.Remove(minNode1);

                var minNode2 = TempNodes.FindMin();
                TempNodes.Remove(minNode2);

                TempNodes.Add(new Node(minNode1, minNode2));
            }

            string code = "";
            TempNodes[0].Find_code(code);
        }

        private void Specifications(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            double ShennonEntropy = 0.0;
            double MidNumber = 0.0;

            Message.Clear();

            // Подсчитать вероятность каждой буквы
            Symbol_probabilities(inputText);
            Symbol_codes();

            foreach (var _symbol in Message)
            {
                ShennonEntropy += _symbol._probability * Math.Log2(_symbol._probability);
                MidNumber += _symbol._probability * _symbol._code.Length;
            }

            Hmax.Text = Math.Round(Math.Log2(Message.Count), 3).ToString() + " бит/символ";
            Hx.Text = (Math.Round(-ShennonEntropy, 3)).ToString() + " бит/символ";
            Lmid.Text = (Math.Round(MidNumber, 3)).ToString() + " бит/символ";
            pk.Text = (Math.Round(1 - Math.Round(-ShennonEntropy, 3) / Math.Round(MidNumber, 3), 3)).ToString() + " %";
            R.Text = (Math.Round(Math.Round(MidNumber, 3) - Math.Round(-ShennonEntropy, 3), 3)).ToString() + " бит/символ";
        }

        private void Encrypt_the_message(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            string codedMessage = "";

            Message.Clear();

            // Подсчитать вероятность каждой буквы
            Symbol_probabilities(inputText);
            Symbol_codes();

            foreach (var character in inputText)
            {
                codedMessage += Message.Find(x => x._value == character.ToString())._code;
            }

            EncodedMessage.Text = codedMessage;
        }

        private void Decode_the_message(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            char[] codedMessage = EncodedMessage.Text.ToCharArray();
            string decodedMessage = "";

            Message.Clear();

            // Подсчитать вероятность каждой буквы
            Symbol_probabilities(inputText);
            Symbol_codes();

            while (codedMessage.Length > 0)
            {
                int symbolLength = 0;
                if (codedMessage.Length <= Message.Count)
                {
                    symbolLength = codedMessage.Length;
                }
                else
                {
                    symbolLength = Message.Count;
                }

                bool stop = false;
                while (!stop && symbolLength > 0)
                {
                    if (Message.Exists(x => x._code == Get_code(symbolLength, codedMessage)))
                    {
                        char[] newCodedMessage = new char[codedMessage.Length - symbolLength];

                        for (int i = 0; i < newCodedMessage.Length; i++)
                        {
                            newCodedMessage[i] = codedMessage[i + symbolLength];
                        }

                        decodedMessage += Message.Find(x => x._code == Get_code(symbolLength, codedMessage))._value;
                        codedMessage = newCodedMessage;

                        stop = true;
                    }
                    else
                    {
                        symbolLength -= 1;
                    }
                }

            }

            DecodedMessage.Text = decodedMessage;
        }

        string Get_code(int symbolLength, char[] codedMessage)
        {
            string code = "";

            for (int i = 0; i < symbolLength; i++)
            {
                code += codedMessage[i];
            }

            return code;
        }
    }

    public static class Extensions
    {
        public static Node FindMin(this IList<Node> items)
        {
            double minVal = Double.MaxValue;
            Node minNode = null;

            foreach (var _node in items)
            {
                if (_node._value < minVal)
                {
                    minVal = _node._value;
                    minNode = _node;
                }
            }

            return minNode;
        }
    }
}