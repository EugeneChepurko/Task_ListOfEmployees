namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat63 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "departament1_Id", c => c.Int());
            CreateIndex("dbo.Employees", "departament1_Id");
            AddForeignKey("dbo.Employees", "departament1_Id", "dbo.Departaments", "Id");
            DropColumn("dbo.Employees", "departament");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "departament", c => c.String());
            DropForeignKey("dbo.Employees", "departament1_Id", "dbo.Departaments");
            DropIndex("dbo.Employees", new[] { "departament1_Id" });
            DropColumn("dbo.Employees", "departament1_Id");
        }
    }
}
