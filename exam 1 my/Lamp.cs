using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_1_my
{
    // Класс для лампы, наследует от базового класса устройства
    internal class Lamp : Device
    {
        public int Brightness { get; set; }

        public Lamp(string name) : base(name)
        {
            Brightness = 50; // Начальная яркость
        }

        public void AdjustBrightness(int newBrightness)
        {
            // Убеждаемся, что яркость находится в пределах от 0 до 100
            Brightness = Math.Max(0, Math.Min(100, newBrightness));
            Console.WriteLine($"{Name} яркость установлена на {Brightness}%");
        }
    }
}
