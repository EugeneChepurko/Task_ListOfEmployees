namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat7 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "departament1_Id", newName: "departament_Id");
            RenameIndex(table: "dbo.Employees", name: "IX_departament1_Id", newName: "IX_departament_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employees", name: "IX_departament_Id", newName: "IX_departament1_Id");
            RenameColumn(table: "dbo.Employees", name: "departament_Id", newName: "departament1_Id");
        }
    }
}
