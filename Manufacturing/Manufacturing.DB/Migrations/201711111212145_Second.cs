namespace Manufacturing.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hardwares",
                c => new
                    {
                        SensorNodes = c.String(nullable: false, maxLength: 128),
                        Repeaters = c.String(),
                        Hubs = c.String(),
                    })
                .PrimaryKey(t => t.SensorNodes);
            
            DropTable("dbo.Hubs");
            DropTable("dbo.Nodes");
            DropTable("dbo.Repeaters");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Repeaters",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "dbo.Nodes",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "dbo.Hubs",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.name);
            
            DropTable("dbo.Hardwares");
        }
    }
}
