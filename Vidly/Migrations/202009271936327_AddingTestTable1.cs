namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingTestTable1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tests", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Tests", "occupation", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tests", "occupation", c => c.String());
            AlterColumn("dbo.Tests", "Name", c => c.String());
        }
    }
}
