using System.Data.Entity.Migrations;

namespace TestingDemo.Infrastructure.Migrations
{
    public partial class RequiredFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employee", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Employee", "FirstName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee", "FirstName", c => c.String());
            AlterColumn("dbo.Employee", "LastName", c => c.String());
        }
    }
}
