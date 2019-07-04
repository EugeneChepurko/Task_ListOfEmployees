namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat73 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "departamentName_Id", "dbo.Departaments");
            DropIndex("dbo.Employees", new[] { "departamentName_Id" });
            DropColumn("dbo.Employees", "departamentName_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "departamentName_Id", c => c.Int());
            CreateIndex("dbo.Employees", "departamentName_Id");
            AddForeignKey("dbo.Employees", "departamentName_Id", "dbo.Departaments", "Id");
        }
    }
}
