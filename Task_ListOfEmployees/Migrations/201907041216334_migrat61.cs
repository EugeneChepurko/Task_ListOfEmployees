namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat61 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "departament_Id", c => c.Int());
            CreateIndex("dbo.Employees", "departament_Id");
            AddForeignKey("dbo.Employees", "departament_Id", "dbo.Departaments", "Id");
            DropColumn("dbo.Employees", "Departament");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Departament", c => c.String());
            DropForeignKey("dbo.Employees", "departament_Id", "dbo.Departaments");
            DropIndex("dbo.Employees", new[] { "departament_Id" });
            DropColumn("dbo.Employees", "departament_Id");
        }
    }
}
