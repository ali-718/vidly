namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class birthDateAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "birthDate", c => c.String(nullable: true));
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "birthDate");
        }
    }
}
