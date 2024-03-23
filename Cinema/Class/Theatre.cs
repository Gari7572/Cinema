using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Theatre : EventPlace
    {
        int Num_num_of_rows { get; set; }
        List<bool> FreeSeats { get; set; }
    }
}
