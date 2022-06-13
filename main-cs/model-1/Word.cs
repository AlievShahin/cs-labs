using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_1
{
    public class Word
    {

        private string word = "";
        public string WordGS
        {
            get { return word; }
            set { word = value; }
        }
        public Word(string str)
        {
            word = str;
        }
    }
}
