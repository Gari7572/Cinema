using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Ticket
    {
        int Id { get; set; }
        int Price { get; set; }
        string Name { get; set; }
        string Place { get; set; }
        string Day_Time { get; set; }
        // агрегація від класу EventPlace
        Art art;

        public void CheckPlace()
        {

        }
        public void GeneratedTicket()
        {

        }
    }
}
