﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement.Employee
{
    class Helper : Employee
    {
        public int[] Ingredients { get; set; } = new int[3] { 0, 0, 0 };

        public Helper(string name, int salary, DateTime birthDate) : base(name, salary, birthDate)
        {
        }

        public void Yell()
        {
            Console.WriteLine("We are out");
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients[(int)ingredient]++;
        }

        public bool GiveIngredientToChef(Ingredient ingredient)
        {
            if (Ingredients[(int)ingredient] > 0)
            {
                Ingredients[(int)ingredient]--;
                return true;
            }
            return false;
        }

    }
}
