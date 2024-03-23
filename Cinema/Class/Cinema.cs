using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema : EventPlace
    {
        int Num_of_rows { get; set; }
        string Color_hall { get; set; }
        List<bool> FreeSeats { get; set; }
    }
}
