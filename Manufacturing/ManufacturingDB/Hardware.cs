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
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int  Nodes { get; set; }
        public int  Repeaters { get; set; }
        public int  Hubs { get; set; }

        public Hardware()
        {
            /*Upon instantiation the datetime is given therefore once you add the hardware through repo add method 
            automatically it adds the date*/
            Date = DateTime.Now;
        }

        

    }
}
