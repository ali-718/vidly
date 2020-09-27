namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingTestTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        occupation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "TestTable_Id", c => c.Int());
            CreateIndex("dbo.Customers", "TestTable_Id");
            AddForeignKey("dbo.Customers", "TestTable_Id", "dbo.Tests", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "TestTable_Id", "dbo.Tests");
            DropIndex("dbo.Customers", new[] { "TestTable_Id" });
            DropColumn("dbo.Customers", "TestTable_Id");
            DropTable("dbo.Tests");
        }
    }
}
