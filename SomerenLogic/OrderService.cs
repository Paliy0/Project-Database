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
        List<Order> orders;

        public int Turnover
        {
            get
            {
                int total = 0;
                foreach (Order o in orders)
                {
                    total += o.Price * o.Sold;
                }
                return total;
            }
        }
        /*
        public int NrOfStudents
        {
            get
            {
                int count = 0;

                foreach (Order o in orders)
                {
                    if()
                    {

                    }
                }
                return count;
            }
        }
        */
        public OrderService()
        {

        }

        public void CreateOrder(Drink drink, Student student)
        {
            OrderDao orderDao = new OrderDao();
            orderDao.CreateOrder(student, drink);
        }

        public void CreateReport()
        {
            OrderDao orderDao = new OrderDao();
            orderDao.GetAllOrders();
        }
    }
}
