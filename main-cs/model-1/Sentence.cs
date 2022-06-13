using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_1
{
    public class Sentence
    {

        private string sentence = "";
        public string SentenceGS
        {
            get { return sentence; }
            set { sentence = value; }
        }
        public Sentence(string str)
        {
            sentence = str;
        }
        public void AddWord(Word word)
        {
            sentence += word.WordGS + " ";
        }
    }
}
