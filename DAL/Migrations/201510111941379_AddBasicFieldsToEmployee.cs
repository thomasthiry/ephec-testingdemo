namespace TestingDemo.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBasicFieldsToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "IsMarried", c => c.Boolean(nullable: false));
            AddColumn("dbo.Employee", "NumberOfChildren", c => c.Int(nullable: false));
            AddColumn("dbo.Employee", "HasMealVouchers", c => c.Boolean(nullable: false));
            AddColumn("dbo.Employee", "HealthInsuranceMonthlyAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Employee", "GroupInsuranceMonthlyAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Employee", "CellphoneMonthlyAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Employee", "LastName", c => c.String());
            AlterColumn("dbo.Employee", "FirstName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Employee", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.Employee", "CellphoneMonthlyAmount");
            DropColumn("dbo.Employee", "GroupInsuranceMonthlyAmount");
            DropColumn("dbo.Employee", "HealthInsuranceMonthlyAmount");
            DropColumn("dbo.Employee", "HasMealVouchers");
            DropColumn("dbo.Employee", "NumberOfChildren");
            DropColumn("dbo.Employee", "IsMarried");
        }
    }
}
