namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updateBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET birthDate= '15/8/1998' WHERE Id=1");
            Sql("UPDATE Customers SET birthDate= '8/10/1999' WHERE Id=2");
        }

        public override void Down()
        {
        }
    }
}
