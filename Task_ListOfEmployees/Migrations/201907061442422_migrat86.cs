namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat86 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "language", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "language");
        }
    }
}
