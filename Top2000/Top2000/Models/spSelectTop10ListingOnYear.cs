using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Top2000.Models
{
    [Keyless]
    public class spSelectTop10ListingOnYear
    {
        public string Titel { get; set; }

        public int Uitgebracht { get; set; }

        public int Top2000jaar { get; set; }

        public int Positie { get; set; }
    }
}
