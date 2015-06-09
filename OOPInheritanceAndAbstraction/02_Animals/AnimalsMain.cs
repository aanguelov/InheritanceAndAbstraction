using System;
using System.Linq;

namespace _02_Animals
{
    class AnimalsMain
    {
        static void Main()
        {
            Animal[] animals =
            {
                new Dog("Sharo", 5, Gender.Male),
                new Frog("Bully", 4, Gender.Male),
                new Kitten("Fluffy", 2),
                new Tomcat("Gonzo", 8), 
                new Cat("Popo", 18, Gender.Female),
                new Dog("Pipi", 12, Gender.Male),
                new Frog("Froggy", 15, Gender.Female),
                new Cat("Mumu", 1, Gender.Male), 
            };

            Console.WriteLine("Average age of dogs: {0}", animals.Where(a => a is Dog).Average(y => y.Age));
            Console.WriteLine("Average age of cats: {0}", animals.Where(a => a is Cat).Average(y => y.Age));
            Console.WriteLine("Avarage age of frogs: {0}", animals.Where(a => a is Frog).Average(y => y.Age));
        }
    }
}
