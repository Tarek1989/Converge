using ManufacturingRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManufacturingDB;

namespace ManufacturingTest
{
    public class Test : Repositories<Hardware>
    {
        public Test(ManufacturingDataModel mdm) : base(mdm)
        {
        }

       

    }
}
