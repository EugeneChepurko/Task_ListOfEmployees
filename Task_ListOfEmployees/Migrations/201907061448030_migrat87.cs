namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat87 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Languages", "LangName", c => c.String());
            DropColumn("dbo.Languages", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Languages", "Name", c => c.String());
            DropColumn("dbo.Languages", "LangName");
        }
    }
}
