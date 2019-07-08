namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat93 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departaments", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Languages", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Departaments", new[] { "Employee_Id" });
            DropIndex("dbo.Languages", new[] { "Employee_Id" });
            DropColumn("dbo.Departaments", "Employee_Id");
            DropColumn("dbo.Languages", "Employee_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Languages", "Employee_Id", c => c.Int());
            AddColumn("dbo.Departaments", "Employee_Id", c => c.Int());
            CreateIndex("dbo.Languages", "Employee_Id");
            CreateIndex("dbo.Departaments", "Employee_Id");
            AddForeignKey("dbo.Languages", "Employee_Id", "dbo.Employees", "Id");
            AddForeignKey("dbo.Departaments", "Employee_Id", "dbo.Employees", "Id");
        }
    }
}
