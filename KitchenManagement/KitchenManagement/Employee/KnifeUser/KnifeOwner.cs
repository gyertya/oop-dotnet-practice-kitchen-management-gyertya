using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement.Employee
{
    class KnifeOwner : Employee
    {
        private bool knifeSet;

        public KnifeOwner(string name, int salary, DateTime birthDate) : base(name, salary, birthDate) { }
        
        public void HasKnifeSet()
        {
            Console.WriteLine(knifeSet ? "I have a set of knife" : "I don't have a set of knife");
        }

        public void GiveKnifeSet()
        {
            Console.WriteLine(knifeSet ? "Oh, a new set? Thanks, the old knives were bad." : "Yee, new knives!");
            knifeSet = true;
        }

        public virtual void DoCooking() { }
    }
}
