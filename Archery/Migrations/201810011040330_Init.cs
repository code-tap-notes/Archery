namespace Archery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mail = c.String(nullable: false, maxLength: 150),
                        Password = c.String(nullable: false, maxLength: 150),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Mail, unique: true);
            
            CreateTable(
                "dbo.Archers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LicenseNumber = c.String(),
                        Mail = c.String(nullable: false, maxLength: 150),
                        Password = c.String(nullable: false, maxLength: 150),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Mail, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Archers", new[] { "Mail" });
            DropIndex("dbo.Administrators", new[] { "Mail" });
            DropTable("dbo.Archers");
            DropTable("dbo.Administrators");
        }
    }
}
