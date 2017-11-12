namespace ManufacturingDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ManufacturingDataModel : DbContext
    {
        public ManufacturingDataModel()
            : base("name=ManufacturingDataModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Hardware> Hardware { get; set; }
    }
}
