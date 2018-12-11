namespace BusTicket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buses", "Comportable", c => c.String(maxLength: 1));
            AddColumn("dbo.People", "Gender", c => c.String(maxLength: 1));
            AddColumn("dbo.People", "IsMember", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "IsMember");
            DropColumn("dbo.People", "Gender");
            DropColumn("dbo.Buses", "Comportable");
        }
    }
}
