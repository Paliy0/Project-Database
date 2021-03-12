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
    public class RoomService
    {
        RoomDao roomdb = new RoomDao();

        public List<Room> GetRooms()
        {
            try
            {
                List<Room> rooms = roomdb.GetAllRooms();
                return rooms;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }
        }
    }
}
