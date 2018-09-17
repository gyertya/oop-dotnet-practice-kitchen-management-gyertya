    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenManagement.Employee;

namespace KitchenManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();

            kitchen.SetChef(new Chef("Simulation John", 1000, new DateTime(1986, 03, 16)));

            kitchen.AddNewCook(new Cook("Simulation Cook", 700, new DateTime(1989, 05, 06)));
            kitchen.AddNewCook(new Cook("Bad Simulation Cook", 400, new DateTime(1988, 05, 25)));

            kitchen.AddNewHelper(new Helper("Simulation Helper", 350, new DateTime(1956, 01, 23)));
            kitchen.AddNewHelper(new Helper("Better Simulation Helper", 450, new DateTime(1965, 11, 06)));
            kitchen.AddNewHelper(new Helper("Favourite Simulation Helper", 1100, new DateTime(1985, 09, 01)));

            Random rnd = new Random();

            foreach (var helper in kitchen.Helpers)
            {
                helper.AddIngredient((Ingredient)rnd.Next(0, 3));
            }

            kitchen.Chef.YellForIngerdients(Ingredient.CARROT, kitchen);
            kitchen.Chef.YellForIngerdients(Ingredient.MEAT, kitchen);
            kitchen.Chef.YellForIngerdients(Ingredient.POTATOE, kitchen);

          
        }
    }
}
