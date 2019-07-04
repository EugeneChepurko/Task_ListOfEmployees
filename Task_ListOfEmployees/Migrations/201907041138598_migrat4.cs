namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Id_department", c => c.Int());
            AlterColumn("dbo.Employees", "Id_Lang", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Id_Lang", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "Id_department", c => c.Int(nullable: false));
        }
    }
}
