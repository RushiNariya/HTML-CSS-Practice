namespace ProductManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SmallIMagePathRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "SmallImagePath", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "SmallImagePath", c => c.String());
        }
    }
}
