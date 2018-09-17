using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement.Employee
{
    class Chef : KnifeOwner
    {
        public Chef(string name, int salary, DateTime birthDate): base(name, salary, birthDate)
        {
        }

        public override void DoCooking()
        {
            Console.WriteLine("Argh argh!");
        }

        public void YellForIngerdients(Ingredients ingredient, Kitchen kitchen)
        {
            foreach (var helper in kitchen.Helpers)
            {
                if (helper.GiveIngredientToChef(ingredient))
                {
                    foreach (var cook in kitchen.Cooks)
                    {
                        cook.DoCooking();
                    }
                    return;
                }
            }

            foreach (var helper in kitchen.Helpers)
            {
                helper.Yell(ingredient);
            }
        }
    }
}
