namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat95 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "OverallTable_Id", c => c.Int());
            CreateIndex("dbo.Employees", "OverallTable_Id");
            AddForeignKey("dbo.Employees", "OverallTable_Id", "dbo.OverallTables", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "OverallTable_Id", "dbo.OverallTables");
            DropIndex("dbo.Employees", new[] { "OverallTable_Id" });
            DropColumn("dbo.Employees", "OverallTable_Id");
        }
    }
}
