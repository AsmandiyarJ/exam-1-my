using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_1_my
{
    // Базовый класс для устройств
    internal  class Device
    {
        public string Name { get; set; }
        public bool IsOn { get; set; }

        public Device(string name)
        {
            Name = name;
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} включено");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} выключено");
        }
    }
}
