namespace BusTicket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class calismadi : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Buses", newName: "Bus");
            RenameTable(name: "dbo.Routes", newName: "Route");
            RenameTable(name: "dbo.Tickets", newName: "Ticket");
            RenameTable(name: "dbo.People", newName: "Person");
            RenameTable(name: "dbo.TimeSlots", newName: "TimeSlot");
            RenameTable(name: "dbo.Seats", newName: "Seat");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Seat", newName: "Seats");
            RenameTable(name: "dbo.TimeSlot", newName: "TimeSlots");
            RenameTable(name: "dbo.Person", newName: "People");
            RenameTable(name: "dbo.Ticket", newName: "Tickets");
            RenameTable(name: "dbo.Route", newName: "Routes");
            RenameTable(name: "dbo.Bus", newName: "Buses");
        }
    }
}
