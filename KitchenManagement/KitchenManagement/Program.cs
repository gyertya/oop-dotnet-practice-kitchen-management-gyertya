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

            kitchen.SetChef(new Chef("Andrea Specht", 1000, new DateTime(1986, 03, 16)));

            kitchen.AddNewCook(new Cook("Rina Willetts", 700, new DateTime(1989, 05, 06)));
            kitchen.AddNewCook(new Cook("Tammara Rarick", 400, new DateTime(1988, 05, 25)));

            kitchen.AddNewHelper(new Helper("Renay Burruel", 350, new DateTime(1956, 01, 23)));
            kitchen.AddNewHelper(new Helper("Kaylee Collington", 450, new DateTime(1965, 11, 06)));
            kitchen.AddNewHelper(new Helper("Lynetta Overson", 1100, new DateTime(1985, 09, 01)));

            Random rnd = new Random();

            foreach (var helper in kitchen.Helpers)
            {
                helper.AddIngredient((Ingredients)rnd.Next(0, 3));
            }

            kitchen.Chef.YellForIngerdients(Ingredients.CARROT, kitchen);
            kitchen.Chef.YellForIngerdients(Ingredients.MEAT, kitchen);
            kitchen.Chef.YellForIngerdients(Ingredients.POTATOE, kitchen);

          
        }
    }
}
