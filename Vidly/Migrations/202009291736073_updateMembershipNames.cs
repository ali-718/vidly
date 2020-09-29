namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updateMembershipNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as you go' WHERE Id = 1;");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2 ;");
            Sql("UPDATE MembershipTypes SET Name = 'Qauterly' WHERE Id = 3;");
            Sql("UPDATE MembershipTypes SET Name = 'Annually' WHERE Id = 4;");

        }

        public override void Down()
        {
        }
    }
}
