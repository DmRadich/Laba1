
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
            Name = Console.ReadLine();
            Kurs = Convert.ToInt32(Console.ReadLine());
            Gender = Console.ReadLine();
        }
        public void Watch()
        {

            Console.Write(" " + Name);
            Console.Write(" " + Kurs);
            Console.Write(" " + Gender);
        }       
    }
}
