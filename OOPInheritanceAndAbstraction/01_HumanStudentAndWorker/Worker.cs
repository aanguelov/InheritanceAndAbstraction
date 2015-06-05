using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HumanStudentAndWorker
{
    class Worker : Human, IComparable<Worker>
    {
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour(decimal weekSalary, int workHoursPerDay)
        {
            decimal paymentByHour = weekSalary / (workHoursPerDay * 5);
            return paymentByHour;
        }

        public int CompareTo(Worker other)
        {
            return MoneyPerHour(this.WeekSalary, this.WorkHoursPerDay)
                .CompareTo(MoneyPerHour(other.WeekSalary, other.WorkHoursPerDay));
        }

        public override string ToString()
        {
            return string.Format("Worker: {0} {1}, Hour payment: {2:F2}", 
                this.FirstName, this.LastName, MoneyPerHour(this.WeekSalary, this.WorkHoursPerDay));
        }
    }
}
