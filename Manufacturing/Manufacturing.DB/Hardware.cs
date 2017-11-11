using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturingDB
{
    public class Hardware
    {
        [Key]
        public string Nodes { get; set; }
        public string Repeaters { get; set; }
        public string Hubs { get; set; }
    }
}
