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
        public int id { get; set; }
        public int  Nodes { get; set; }
        public int  Repeaters { get; set; }
        public int  Hubs { get; set; }

    }
}
