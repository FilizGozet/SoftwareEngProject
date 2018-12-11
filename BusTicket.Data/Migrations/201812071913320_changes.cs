namespace BusTicket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        From = c.String(),
                        To = c.String(),
                        TimeofDep = c.DateTime(nullable: false),
                        TimeofArr = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LicensePlate = c.Int(nullable: false),
                        Brand = c.String(),
                        Model = c.String(),
                        NumberofSeat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BusRoutes",
                c => new
                    {
                        Bus_ID = c.Int(nullable: false),
                        Route_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Bus_ID, t.Route_ID })
                .ForeignKey("dbo.Buses", t => t.Bus_ID, cascadeDelete: true)
                .ForeignKey("dbo.Routes", t => t.Route_ID, cascadeDelete: true)
                .Index(t => t.Bus_ID)
                .Index(t => t.Route_ID);
            
            AddColumn("dbo.Tickets", "Route_ID", c => c.Int());
            CreateIndex("dbo.Tickets", "Route_ID");
            AddForeignKey("dbo.Tickets", "Route_ID", "dbo.Routes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Route_ID", "dbo.Routes");
            DropForeignKey("dbo.BusRoutes", "Route_ID", "dbo.Routes");
            DropForeignKey("dbo.BusRoutes", "Bus_ID", "dbo.Buses");
            DropIndex("dbo.BusRoutes", new[] { "Route_ID" });
            DropIndex("dbo.BusRoutes", new[] { "Bus_ID" });
            DropIndex("dbo.Tickets", new[] { "Route_ID" });
            DropColumn("dbo.Tickets", "Route_ID");
            DropTable("dbo.BusRoutes");
            DropTable("dbo.Buses");
            DropTable("dbo.Routes");
        }
    }
}
