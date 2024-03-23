using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Perfomance : Art
    {
        protected string Author { get; set; }
        protected string Genre { get; set; }
        protected int Year { get; set; }
        
        int Age_to_go { set { Age_to_go = 0; } }
    }
}
