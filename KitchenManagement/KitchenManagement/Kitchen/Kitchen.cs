using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenManagement.Employee;

namespace KitchenManagement
{
    class Kitchen
    {
        public Chef Chef { get; private set; }
        public ICollection<Cook> Cooks { get; private set; }
        public ICollection<Helper> Helpers { get; private set; }

        public Kitchen()
        {
            Chef = null;
            Cooks = new List<Cook>();
            Helpers = new List<Helper>();
        }
               
        public void SetChef(Chef chef)
        {
            Chef = chef;
        }

        public void AddNewCook(Cook cook)
        {
            Cooks.Add(cook);
        }

        public void AddNewHelper(Helper helper)
        {
            Helpers.Add(helper);
        }
    }
}
