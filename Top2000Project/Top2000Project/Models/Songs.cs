using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Top2000Project.Models
{
    public class Songs
    {
        [Key]
        public int songid { get; set; }
        public int artiestid { get; set; }
        public string titel { get; set; }
        public int jaar { get; set; }
    }
}
