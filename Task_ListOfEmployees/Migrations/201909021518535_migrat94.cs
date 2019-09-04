namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat94 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OverallTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        DepartamentId = c.Int(),
                        LanguageId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Employees", "Id_department");
            DropColumn("dbo.Employees", "Id_Lang");
            DropColumn("dbo.Employees", "departament");
            DropColumn("dbo.Employees", "language");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "language", c => c.String());
            AddColumn("dbo.Employees", "departament", c => c.String());
            AddColumn("dbo.Employees", "Id_Lang", c => c.Int());
            AddColumn("dbo.Employees", "Id_department", c => c.Int());
            DropTable("dbo.OverallTables");
        }
    }
}
