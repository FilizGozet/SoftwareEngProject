namespace BusTicket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimeSlots",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TimeofDep = c.DateTime(nullable: false),
                        TimeofArr = c.DateTime(nullable: false),
                        Bus_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buses", t => t.Bus_ID)
                .Index(t => t.Bus_ID);
            
            AddColumn("dbo.Buses", "IsAvailable", c => c.String(maxLength: 1));
            AddColumn("dbo.Routes", "WhereFrom", c => c.String());
            AddColumn("dbo.Routes", "ToWhere", c => c.String());
            AddColumn("dbo.Routes", "IsMin", c => c.String(maxLength: 1));
            AddColumn("dbo.Routes", "TimeInterval", c => c.Int(nullable: false));
            AddColumn("dbo.Routes", "price", c => c.Int(nullable: false));
            AddColumn("dbo.Seats", "CoupleSeat", c => c.String(maxLength: 1));
            AddColumn("dbo.Seats", "Ticket_ID", c => c.Int());
            AddColumn("dbo.Tickets", "TimeSlot_ID", c => c.Int());
            CreateIndex("dbo.Seats", "Ticket_ID");
            CreateIndex("dbo.Tickets", "TimeSlot_ID");
            AddForeignKey("dbo.Tickets", "TimeSlot_ID", "dbo.TimeSlots", "ID");
            AddForeignKey("dbo.Seats", "Ticket_ID", "dbo.Tickets", "ID");
            DropColumn("dbo.Routes", "FromW");
            DropColumn("dbo.Routes", "ToW");
            DropColumn("dbo.Routes", "TimeofDep");
            DropColumn("dbo.Routes", "TimeofArr");
            DropColumn("dbo.Seats", "IsDouble");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Seats", "IsDouble", c => c.Int(nullable: false));
            AddColumn("dbo.Routes", "TimeofArr", c => c.DateTime(nullable: false));
            AddColumn("dbo.Routes", "TimeofDep", c => c.DateTime(nullable: false));
            AddColumn("dbo.Routes", "ToW", c => c.String());
            AddColumn("dbo.Routes", "FromW", c => c.String());
            DropForeignKey("dbo.Seats", "Ticket_ID", "dbo.Tickets");
            DropForeignKey("dbo.Tickets", "TimeSlot_ID", "dbo.TimeSlots");
            DropForeignKey("dbo.TimeSlots", "Bus_ID", "dbo.Buses");
            DropIndex("dbo.TimeSlots", new[] { "Bus_ID" });
            DropIndex("dbo.Tickets", new[] { "TimeSlot_ID" });
            DropIndex("dbo.Seats", new[] { "Ticket_ID" });
            DropColumn("dbo.Tickets", "TimeSlot_ID");
            DropColumn("dbo.Seats", "Ticket_ID");
            DropColumn("dbo.Seats", "CoupleSeat");
            DropColumn("dbo.Routes", "price");
            DropColumn("dbo.Routes", "TimeInterval");
            DropColumn("dbo.Routes", "IsMin");
            DropColumn("dbo.Routes", "ToWhere");
            DropColumn("dbo.Routes", "WhereFrom");
            DropColumn("dbo.Buses", "IsAvailable");
            DropTable("dbo.TimeSlots");
        }
    }
}
