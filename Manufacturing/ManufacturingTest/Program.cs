
using ManufacturingDB;
using ManufacturingRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturingTest
{
    class Program
    {
        static void Main(string[] args)
        {  

            ManufacturingDataModel MDM = new ManufacturingDataModel();
            Test t = new Test(MDM);

            Hardware h6 = new Hardware();
            h6.Nodes = 3000;
            h6.Repeaters = 1600;
            h6.Hubs = 1200;


           // t.AddHardware(h6);

           /* Hardware hardware = new Hardware();
            
            hardware.Nodes = 55;
            hardware.Repeaters = 46;
            hardware.Hubs = 82;*/

            //t.AddHardware(hardware);


            //This for the remove method
            //Reason is that you need to get the data and through it select the object to delete.

         //  List<Hardware> RemoveList = t.GetHardware();


            /*foreach(Hardware i in RemoveList)
            {
                if(i.ID == 2 )
                {
                    t.RemoveHardware(i); //i here is the item
                }
            }*/

           
            //This is updated
           /*List<Hardware> UpdateList = t.GetHardware();

            foreach(Hardware i in UpdateList)
            {
                if(i.ID == 3)
                {
                    //subtitution taking place
                    i.Nodes = 1;
                    i.Repeaters = 1;
                    i.Hubs = 1;
                    
                    t.UpdateHardware(i);

                }
            }*/


            
           


            
          
           
            
            

            
            

        }
    }

    
}
