namespace SourceControlAssignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cls : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String());
        }
    }
}
