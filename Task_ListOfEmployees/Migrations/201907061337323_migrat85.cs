namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat85 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Departament_Id", "dbo.Departaments");
            DropForeignKey("dbo.Employees", "Language_Id", "dbo.Languages");
            DropIndex("dbo.Employees", new[] { "Departament_Id" });
            DropIndex("dbo.Employees", new[] { "Language_Id" });
            AddColumn("dbo.Departaments", "Employee_Id", c => c.Int());
            AddColumn("dbo.Languages", "Employee_Id", c => c.Int());
            CreateIndex("dbo.Departaments", "Employee_Id");
            CreateIndex("dbo.Languages", "Employee_Id");
            AddForeignKey("dbo.Departaments", "Employee_Id", "dbo.Employees", "Id");
            AddForeignKey("dbo.Languages", "Employee_Id", "dbo.Employees", "Id");
            DropColumn("dbo.Employees", "Departament_Id");
            DropColumn("dbo.Employees", "Language_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Language_Id", c => c.Int());
            AddColumn("dbo.Employees", "Departament_Id", c => c.Int());
            DropForeignKey("dbo.Languages", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Departaments", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Languages", new[] { "Employee_Id" });
            DropIndex("dbo.Departaments", new[] { "Employee_Id" });
            DropColumn("dbo.Languages", "Employee_Id");
            DropColumn("dbo.Departaments", "Employee_Id");
            CreateIndex("dbo.Employees", "Language_Id");
            CreateIndex("dbo.Employees", "Departament_Id");
            AddForeignKey("dbo.Employees", "Language_Id", "dbo.Languages", "Id");
            AddForeignKey("dbo.Employees", "Departament_Id", "dbo.Departaments", "Id");
        }
    }
}
