namespace BusTicket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roleeklendi : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Person", name: "Discriminator", newName: "Discriminator1");
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Person", "Role_ID", c => c.Int());
            CreateIndex("dbo.Person", "Role_ID");
            AddForeignKey("dbo.Person", "Role_ID", "dbo.Role", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person", "Role_ID", "dbo.Role");
            DropIndex("dbo.Person", new[] { "Role_ID" });
            DropColumn("dbo.Person", "Role_ID");
            DropTable("dbo.Role");
            RenameColumn(table: "dbo.Person", name: "Discriminator1", newName: "Discriminator");
        }
    }
}
