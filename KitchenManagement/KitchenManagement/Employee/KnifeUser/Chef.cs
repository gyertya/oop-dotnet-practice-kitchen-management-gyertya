using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement.Employee
{
    class Chef : KnifeUser
    {
        public Chef(string name, int salary, DateTime birthDate)
        {
            Name = name;
            SalaryInUSD = salary;
            BirthDate = birthDate;
        }

        public override void DoCooking()
        {
            Console.WriteLine("Argh argh!");
        }
    }
}
