
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string Name { get; set; }

        public int Kurs { get; set; }

        public string Gender { get; set; }
    
        public void add()
        {
            Console.WriteLine("Введите имя:");
            Name = Console.ReadLine();
            Console.WriteLine("Введите курс:");
            Kurs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пол: ");
            Gender = Console.ReadLine();
        }
        public void Watch()
        {
            Console.WriteLine("Name" + Name + " Kurs: " + Kurs + "Gendre:" + Gender);
        }       
    }
}
