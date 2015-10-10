using System.Data.Entity.Migrations;

namespace TestingDemo.Infrastructure.Migrations
{
    public partial class AddSalary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "Salary");
        }
    }
}
