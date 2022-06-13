using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_1
{
    // Создать объект класса Текст, используя классы Предложение, Слово. 
    // Методы: дополнить текст, вывести текст, заголовок текста.
    public class Text
    {

        private string text = "";
        public string TextGS
        {
            get { return text; }
            set { text = value; }
        }
        public Text(string str)
        {
            text = str;
        }

        public string OutText()
        {
            return text;
        }
        public void AddSentece(Sentence sent)
        {
            text += sent.SentenceGS;
        }
        public void AddWord(Word word)
        {
            text += word.WordGS + " ";

        }
        public string ZagolovokTexta()
        {
            if (text.Length == 0)
                return "текст пуст";
            string res = "";
            int i = 0;
            while (text[i] != ' ' && i != text.Length)
            {
                res += text[i];
                i++;
            }
            return res;
        }
    }
}
