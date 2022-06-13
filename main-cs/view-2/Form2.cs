using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string nameOfProcessor;
        public double processorClockSpeed;
        public int AmountOfRAM;
        public int AmountOfHardDisk;
        private void button1_Click(object sender, EventArgs e)
        {
            nameOfProcessor = textBox1.Text;
            processorClockSpeed = double.Parse(textBox2.Text);
            AmountOfRAM = int.Parse(textBox3.Text);
            this.Close();
        }
    }
}
