namespace BusTicket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignkeytry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Person_ID = c.Int(),
                        Staff_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.Person_ID)
                .ForeignKey("dbo.People", t => t.Staff_ID)
                .Index(t => t.Person_ID)
                .Index(t => t.Staff_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Staff_ID", "dbo.People");
            DropForeignKey("dbo.Tickets", "Person_ID", "dbo.People");
            DropIndex("dbo.Tickets", new[] { "Staff_ID" });
            DropIndex("dbo.Tickets", new[] { "Person_ID" });
            DropTable("dbo.Tickets");
        }
    }
}
