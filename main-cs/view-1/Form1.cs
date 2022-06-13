using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model_1;
namespace view_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sentence sent = new Sentence("");
        Text text = new Text("");
        private void button1_Click(object sender, EventArgs e)
        {
            Word word = new Word(textBox1.Text.ToString());
            sent.AddWord(word);
            textBox2.Text = sent.SentenceGS.ToString();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text.AddSentece(sent);
            textBox3.Text = text.TextGS;
            sent.SentenceGS = " ";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Word word = new Word(textBox1.Text.ToString());
            text.AddWord(word);
            textBox1.Text = "";
            textBox3.Text = text.TextGS;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text.TextGS);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text.ZagolovokTexta());
            
        }
    }
}
