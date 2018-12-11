namespace BusTicket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sonartik : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.TimeSlots", new[] { "Buses_ID" });
            DropColumn("dbo.TimeSlots", "Bus_ID");
            RenameColumn(table: "dbo.Tickets", name: "People_ID", newName: "Person_ID");
            RenameColumn(table: "dbo.Tickets", name: "Routes_ID", newName: "Route_ID");
            RenameColumn(table: "dbo.TimeSlots", name: "Buses_ID", newName: "Bus_ID");
            RenameColumn(table: "dbo.Tickets", name: "TimeSlots_ID", newName: "TimeSlot_ID");
            RenameColumn(table: "dbo.Seats", name: "Buses_ID", newName: "Bus_ID");
            RenameIndex(table: "dbo.Tickets", name: "IX_People_ID", newName: "IX_Person_ID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Routes_ID", newName: "IX_Route_ID");
            RenameIndex(table: "dbo.Tickets", name: "IX_TimeSlots_ID", newName: "IX_TimeSlot_ID");
            RenameIndex(table: "dbo.Seats", name: "IX_Buses_ID", newName: "IX_Bus_ID");
            AlterColumn("dbo.TimeSlots", "Bus_ID", c => c.Int());
            CreateIndex("dbo.TimeSlots", "Bus_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.TimeSlots", new[] { "Bus_ID" });
            AlterColumn("dbo.TimeSlots", "Bus_ID", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Seats", name: "IX_Bus_ID", newName: "IX_Buses_ID");
            RenameIndex(table: "dbo.Tickets", name: "IX_TimeSlot_ID", newName: "IX_TimeSlots_ID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Route_ID", newName: "IX_Routes_ID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Person_ID", newName: "IX_People_ID");
            RenameColumn(table: "dbo.Seats", name: "Bus_ID", newName: "Buses_ID");
            RenameColumn(table: "dbo.Tickets", name: "TimeSlot_ID", newName: "TimeSlots_ID");
            RenameColumn(table: "dbo.TimeSlots", name: "Bus_ID", newName: "Buses_ID");
            RenameColumn(table: "dbo.Tickets", name: "Route_ID", newName: "Routes_ID");
            RenameColumn(table: "dbo.Tickets", name: "Person_ID", newName: "People_ID");
            AddColumn("dbo.TimeSlots", "Bus_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.TimeSlots", "Buses_ID");
        }
    }
}
