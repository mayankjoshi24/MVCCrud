namespace Assignment6.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeUsers", "State", c => c.String(nullable: false));
            AlterColumn("dbo.EmployeeUsers", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeUsers", "City", c => c.String());
            AlterColumn("dbo.EmployeeUsers", "State", c => c.String());
        }
    }
}
