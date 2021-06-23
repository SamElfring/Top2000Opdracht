using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Top2000.Models
{
    public class spSelectAllArtist
    {
        [Key]
        public int Artiestid { get; set; }
        public string naam { get; set; }
    }
}
