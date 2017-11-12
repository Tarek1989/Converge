namespace ManufacturingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hardwares",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nodes = c.Int(nullable: false),
                        Repeaters = c.Int(nullable: false),
                        Hubs = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hardwares");
        }
    }
}
