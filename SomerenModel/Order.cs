using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int OrderId { get; set; }

        public int DrinkID { get; set; }

        public int Price { get; set; }

        public int Sold { get; set; }

        //public DateTime OrderTime { get; set; }
    }   
}
