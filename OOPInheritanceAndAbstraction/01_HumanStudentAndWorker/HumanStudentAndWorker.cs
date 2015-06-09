using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HumanStudentAndWorker
{
    class HumanStudentAndWorker
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student ivan = new Student("Ivan", "Ivanov", 100234);
            students.Add(ivan);
            Student pesho = new Student("Petar", "Petrov", 100985);
            students.Add(pesho);
            Student gosho = new Student("Georgi", "Georgiev", 100784);
            students.Add(gosho);
            Student ivanka = new Student("Ivanka", "Ivanova", 100589);
            students.Add(ivanka);
            Student obama = new Student("Barack", "Ivanov", 100457);
            students.Add(obama);
            //students.Sort();
            var sortedByFacNum = students.OrderBy(s => s.FacultyNumber).ToList();
            foreach (Student student in sortedByFacNum)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            Worker stamat = new Worker("Stamat", "Stamatov", 1000, 8);
            workers.Add(stamat);
            Worker boiko = new Worker("Boiko", "Borisov", 100000, 2);
            workers.Add(boiko);
            Worker maria = new Worker("Maria", "Petrova", 100, 12);
            workers.Add(maria);
            workers.Sort();
            workers.Reverse();
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            List<Human> allHumans = new List<Human>();
            allHumans.AddRange(students);
            allHumans.AddRange(workers);
            var sortedByNames = allHumans
                .OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName).ToList();
            foreach (Human human in sortedByNames)
            {
                Console.WriteLine(human);
            }
        }
    }
}
