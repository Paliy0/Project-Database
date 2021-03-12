using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Room
    {
        public int Number { get; set; } // RoomNumber, e.g. 206
        public int Capacity { get; set; } // number of beds, either 4,6,8,12 or 16
        public string Type { get; set; } // student = false, teacher = true
    }
}
