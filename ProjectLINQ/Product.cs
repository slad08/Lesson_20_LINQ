using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLINQ
{
    public class Product
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        //public int Calorized { get; set; }

        public override string ToString()
        {
            return $"{Name} " + $"{Energy.ToString()}";// + $"{Calorized}";//Name +";"+ Energy.ToString()+";"+Calorized.ToString();
        }
    }
}
