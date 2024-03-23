using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Movie : Art
    {
        protected string Director { get; set; }
        protected string Genre { get; set; }
        protected int Year { get; set; }
    }
}
