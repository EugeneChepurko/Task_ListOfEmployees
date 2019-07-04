namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Departament", c => c.String());
            DropColumn("dbo.Employees", "DepartName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "DepartName", c => c.String());
            DropColumn("dbo.Employees", "Departament");
        }
    }
}
