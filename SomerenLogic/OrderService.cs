using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class OrderService
    {
        public int Sold { get; set; }

        public OrderService()
        {

        }

        public void CreateOrder(Drink drink, Student student)
        {
            OrderDao orderDao = new OrderDao();
            orderDao.CreateOrder(student, drink);
        }
    }
}
