namespace BusTicket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BusRoutes", newName: "RouteBus");
            DropPrimaryKey("dbo.RouteBus");
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SeatNumber = c.Int(nullable: false),
                        IsDouble = c.Int(nullable: false),
                        SeatPlace = c.String(),
                        Bus_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buses", t => t.Bus_ID)
                .Index(t => t.Bus_ID);
            
            AddColumn("dbo.Routes", "FromW", c => c.String());
            AddColumn("dbo.Routes", "ToW", c => c.String());
            AddColumn("dbo.Tickets", "Fiyat", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.RouteBus", new[] { "Route_ID", "Bus_ID" });
            DropColumn("dbo.Routes", "From");
            DropColumn("dbo.Routes", "To");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Routes", "To", c => c.String());
            AddColumn("dbo.Routes", "From", c => c.String());
            DropForeignKey("dbo.Seats", "Bus_ID", "dbo.Buses");
            DropIndex("dbo.Seats", new[] { "Bus_ID" });
            DropPrimaryKey("dbo.RouteBus");
            DropColumn("dbo.Tickets", "Fiyat");
            DropColumn("dbo.Routes", "ToW");
            DropColumn("dbo.Routes", "FromW");
            DropTable("dbo.Seats");
            AddPrimaryKey("dbo.RouteBus", new[] { "Bus_ID", "Route_ID" });
            RenameTable(name: "dbo.RouteBus", newName: "BusRoutes");
        }
    }
}
