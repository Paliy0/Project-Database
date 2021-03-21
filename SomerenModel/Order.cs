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

        public int StudentNumber { get; set; }

        public int DrinkID { get; set; }

        public int Price { get; set; }

        public DateTime OrderTime { get; set; }

        public Order(Student student, Drink drink)
        {
            this.StudentNumber = student.Number;
            this.DrinkID = drink.ID;
        }
    }   
}
