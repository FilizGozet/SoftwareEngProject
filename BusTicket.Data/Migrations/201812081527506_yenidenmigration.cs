namespace BusTicket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yenidenmigration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Seats");
            AddColumn("dbo.Tickets", "TimeSlots_ID", c => c.Int());
            AlterColumn("dbo.People", "IdentificationNumber", c => c.String(maxLength: 15));
            AlterColumn("dbo.People", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.People", "LastName", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Seats", "SeatNumber");
            CreateIndex("dbo.Tickets", "Bus_ID");
            CreateIndex("dbo.Tickets", "Staff_ID");
            CreateIndex("dbo.Tickets", "TimeSlots_ID");
            AddForeignKey("dbo.Tickets", "Bus_ID", "dbo.Buses", "ID");
            AddForeignKey("dbo.Tickets", "Staff_ID", "dbo.People", "ID");
            AddForeignKey("dbo.Tickets", "TimeSlots_ID", "dbo.TimeSlots", "ID");
            DropColumn("dbo.Tickets", "Person_ID");
            DropColumn("dbo.Tickets", "TimeSlot_ID");
            DropColumn("dbo.Tickets", "Route_ID");
            DropColumn("dbo.Seats", "Bus_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Seats", "Bus_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Route_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "TimeSlot_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Person_ID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Tickets", "TimeSlots_ID", "dbo.TimeSlots");
            DropForeignKey("dbo.Tickets", "Staff_ID", "dbo.People");
            DropForeignKey("dbo.Tickets", "Bus_ID", "dbo.Buses");
            DropIndex("dbo.Tickets", new[] { "TimeSlots_ID" });
            DropIndex("dbo.Tickets", new[] { "Staff_ID" });
            DropIndex("dbo.Tickets", new[] { "Bus_ID" });
            DropPrimaryKey("dbo.Seats");
            AlterColumn("dbo.People", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.People", "IdentificationNumber", c => c.String(nullable: false, maxLength: 15));
            DropColumn("dbo.Tickets", "TimeSlots_ID");
            AddPrimaryKey("dbo.Seats", new[] { "SeatNumber", "Bus_ID" });
        }
    }
}
