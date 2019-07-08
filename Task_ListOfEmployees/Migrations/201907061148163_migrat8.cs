namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departaments", "Depart_Name", c => c.String());
            DropColumn("dbo.Departaments", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departaments", "Name", c => c.String());
            DropColumn("dbo.Departaments", "Depart_Name");
        }
    }
}
