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

        public void Yell(Ingredients ingredient)
        {
            Console.WriteLine("We are out from " + ingredient.ToString());
        }

        public void AddIngredient(Ingredients ingredient)
        {
            Ingredients[(int)ingredient]++;
        }

        public bool GiveIngredientToChef(Ingredients ingredient)
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
