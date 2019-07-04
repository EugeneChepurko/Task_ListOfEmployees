namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat71 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "departament_Id", "dbo.Departaments");
            DropIndex("dbo.Employees", new[] { "departament_Id" });
            AddColumn("dbo.Employees", "departament", c => c.String());
            DropColumn("dbo.Employees", "departament_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "departament_Id", c => c.Int());
            DropColumn("dbo.Employees", "departament");
            CreateIndex("dbo.Employees", "departament_Id");
            AddForeignKey("dbo.Employees", "departament_Id", "dbo.Departaments", "Id");
        }
    }
}
