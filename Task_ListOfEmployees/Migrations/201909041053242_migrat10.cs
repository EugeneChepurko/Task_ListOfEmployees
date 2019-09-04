namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat10 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "Departament_Id", newName: "DepartamentId");
            RenameColumn(table: "dbo.Employees", name: "Language_Id", newName: "LanguageId");
            RenameIndex(table: "dbo.Employees", name: "IX_Departament_Id", newName: "IX_DepartamentId");
            RenameIndex(table: "dbo.Employees", name: "IX_Language_Id", newName: "IX_LanguageId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employees", name: "IX_LanguageId", newName: "IX_Language_Id");
            RenameIndex(table: "dbo.Employees", name: "IX_DepartamentId", newName: "IX_Departament_Id");
            RenameColumn(table: "dbo.Employees", name: "LanguageId", newName: "Language_Id");
            RenameColumn(table: "dbo.Employees", name: "DepartamentId", newName: "Departament_Id");
        }
    }
}
