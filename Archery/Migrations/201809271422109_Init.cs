namespace Archery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Administrators", "Password", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Administrators", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Administrators", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Administrators", "BirthDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Archers", "Password", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Archers", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Archers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Archers", "BirthDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            DropColumn("dbo.Administrators", "ConfirmedPassword");
            DropColumn("dbo.Archers", "ConfirmedPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Archers", "ConfirmedPassword", c => c.String());
            AddColumn("dbo.Administrators", "ConfirmedPassword", c => c.String());
            AlterColumn("dbo.Archers", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Archers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Archers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Archers", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Administrators", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Administrators", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Administrators", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Administrators", "Password", c => c.String(nullable: false));
        }
    }
}
