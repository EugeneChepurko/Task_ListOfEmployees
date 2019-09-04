namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat96 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Departament_Id", c => c.Int());
            AddColumn("dbo.Employees", "Language_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Departament_Id");
            CreateIndex("dbo.Employees", "Language_Id");
            AddForeignKey("dbo.Employees", "Departament_Id", "dbo.Departaments", "Id");
            AddForeignKey("dbo.Employees", "Language_Id", "dbo.Languages", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Language_Id", "dbo.Languages");
            DropForeignKey("dbo.Employees", "Departament_Id", "dbo.Departaments");
            DropIndex("dbo.Employees", new[] { "Language_Id" });
            DropIndex("dbo.Employees", new[] { "Departament_Id" });
            DropColumn("dbo.Employees", "Language_Id");
            DropColumn("dbo.Employees", "Departament_Id");
        }
    }
}
