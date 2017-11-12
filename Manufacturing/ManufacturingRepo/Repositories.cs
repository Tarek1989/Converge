using ManufacturingDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Collections.Concurrent;

namespace ManufacturingRepo
{
    public abstract class Repositories<T> where T:class
    {
        //where T:class fixes the issue with .SET


        //Repository class constructor once initialized will instantiate  datamodel
        //Manufacturing data model instantiate because it models table

        ManufacturingDataModel MDM;
        public Repositories( ManufacturingDataModel mdm)
        {
            MDM = mdm;
        }

        public List<T> GetHardware()
        {
            //Creating new list and adding data from db in it

            List<T> data = new List<T>();
            foreach(var i in MDM.Set<T>())
            {
                data.Add(i);
            }
            return data;
        }

        public void AddHardware(T item)
        {
            MDM.Set<T>().Add(item);
            MDM.SaveChanges();

        }


        public void RemoveHardware(T item)
        {
            MDM.Set<T>().Remove(item);
            MDM.SaveChanges();
        }

        public void UpdateHardware(T item)
        {
            MDM.Set<T>().AddOrUpdate(item);
            MDM.SaveChanges();
        }





    }
}
