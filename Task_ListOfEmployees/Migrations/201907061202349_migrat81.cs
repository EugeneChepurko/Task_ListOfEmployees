namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat81 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departaments", "Name", c => c.String());
            DropColumn("dbo.Departaments", "Depart_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departaments", "Depart_Name", c => c.String());
            DropColumn("dbo.Departaments", "Name");
        }
    }
}
