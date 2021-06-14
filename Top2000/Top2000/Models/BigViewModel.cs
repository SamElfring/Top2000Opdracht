using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Top2000.Models
{
    public class BigViewModel
    {
        [Key]
        public int ID { get; set; }
        public Lijst Lijst { get; set; }
        public Song Song { get; set; }
    }
}
