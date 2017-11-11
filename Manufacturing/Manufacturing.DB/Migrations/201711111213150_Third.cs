namespace Manufacturing.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Hardwares");
            AddColumn("dbo.Hardwares", "Nodes", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Hardwares", "Nodes");
            DropColumn("dbo.Hardwares", "SensorNodes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hardwares", "SensorNodes", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Hardwares");
            DropColumn("dbo.Hardwares", "Nodes");
            AddPrimaryKey("dbo.Hardwares", "SensorNodes");
        }
    }
}
