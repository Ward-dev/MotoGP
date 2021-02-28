using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public ICollection<Rider> Riders { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

    }
}
