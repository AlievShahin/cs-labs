using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_2
{
    public class ComputerFirstLvl
    {
        private readonly string NameOfProcessor;
        private readonly double ProcessorClockSpeed;
        private readonly int AmountOfRAM;
        public virtual double getQuality()
        {
            return 0.1 * ProcessorClockSpeed + AmountOfRAM;
        }
        public override string ToString()
        {
            return "наименование процессора: " + NameOfProcessor + '\n' +
                "тактовая частота процессора (МГц): " + ProcessorClockSpeed + '\n' +
                "объем оперативной памяти (Мб): " + AmountOfRAM + '\n';
        }
        public ComputerFirstLvl(string n, double p, int a)
        {
            NameOfProcessor = n;
            ProcessorClockSpeed = p;
            AmountOfRAM = a;
        }
    }
    public class ComputerSecondLvl : ComputerFirstLvl
    {
        private readonly int AmountOfHardDisk;
        public ComputerSecondLvl(string n, double p, int a, int disk) : base(n, p, a)
        {
            AmountOfHardDisk = disk;
        }
        public override double getQuality()
        {
            return base.getQuality() + 0.5 * AmountOfHardDisk;
        }
        public override string ToString()
        {
            return base.ToString() + "объем винчестера (Гб): " + AmountOfHardDisk;
        }
    }
}
