using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement.Employee
{
    class KnifeUser : Employee
    {
        public bool KnifeSet { get; set; }

        public virtual void DoCooking() { }
    }
}
