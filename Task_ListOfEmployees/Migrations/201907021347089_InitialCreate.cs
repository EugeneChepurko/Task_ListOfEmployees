namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_Emp = c.Int(nullable: false),
                        Name = c.String(),
                        Frool = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_department = c.Int(nullable: false),
                        Id_Lang = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_Emp = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Languages");
            DropTable("dbo.Employees");
            DropTable("dbo.Departaments");
        }
    }
}
