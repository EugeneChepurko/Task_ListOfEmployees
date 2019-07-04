namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Gender", c => c.Byte(nullable: false));
        }
    }
}
