using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement.Employee
{
    class Helper : Employee
    {
        private int[] ingredient = new int[3] { 0, 0, 0 };

        public Helper(string name, int salary, DateTime birthDate) : base(name, salary, birthDate)
        {
        }

        public void Yell(Ingredients ingredient)
        {
            Console.WriteLine("We are out from " + ingredient.ToString());
        }

        public void AddIngredient(Ingredients newIngredient)
        {
            ingredient[(int)newIngredient]++;
        }

        public bool GiveIngredientToChef(Ingredients ing)
        {
            if (ingredient[(int)ing] > 0)
            {
                ingredient[(int)ing]--;
                return true;
            }
            return false;
        }

    }
}
