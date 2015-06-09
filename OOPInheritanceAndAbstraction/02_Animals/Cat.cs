using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Animals
{
    class Cat : Animal
    {
        

        public override void ProduceSound()
        {
            Console.WriteLine("Miaaaay");
        }

        public Cat(string name, int age, Gender gender) 
            : base(name, age, gender)
        {

        }
    }
}
