using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model_2;

namespace view_2
{
    public partial class Form1 : Form
    {
        ComputerFirstLvl computer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Известен объем винчестера?", "Вопрос",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form3 formWithDisk = new Form3();
                formWithDisk.Owner = this;
                formWithDisk.ShowDialog();
                 computer = new ComputerSecondLvl(formWithDisk.nameOfProcessor,
                    formWithDisk.processorClockSpeed, formWithDisk.AmountOfRAM, formWithDisk.AmountOfHardDisk);
            }
            else
            {
                Form2 form = new Form2();
                form.Owner = this;
                form.ShowDialog();
                computer = new ComputerFirstLvl(form.nameOfProcessor,
                    form.processorClockSpeed, form.AmountOfRAM);
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(computer.ToString() + "\nКачество компьютера: " + computer.getQuality());
        }
    }
}
