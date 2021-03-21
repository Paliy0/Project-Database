﻿using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class DrinkService
    {
        DrinksDao drinksdb;

        public DrinkService()
        {
            drinksdb = new DrinksDao();
        }

        public List<Drink> GetDrinks()
        {
            try
            {
                List<Drink> drink = drinksdb.GetAllDrinks();
                return drink;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void DeleteDrink(Drink drink)
        {
            //DrinksDao.Delete(drink);
        }
    }
}