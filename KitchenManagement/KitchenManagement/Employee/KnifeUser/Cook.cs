using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement.Employee
{
    class Cook : KnifeUser
    {
        public override void DoCooking()
        {
            Console.WriteLine($"{this.Name} is cooking.");
        }

        public Cook(string name, int salary, DateTime birthDate) : base(name, salary, birthDate) { }

    }
}
