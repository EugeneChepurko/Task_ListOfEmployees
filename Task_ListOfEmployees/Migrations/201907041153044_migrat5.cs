namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DepartName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "DepartName");
        }
    }
}
