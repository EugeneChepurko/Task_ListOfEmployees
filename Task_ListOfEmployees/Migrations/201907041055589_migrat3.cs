namespace Task_ListOfEmployees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Departaments", "Id_Emp");
            DropColumn("dbo.Languages", "Id_Emp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Languages", "Id_Emp", c => c.Int(nullable: false));
            AddColumn("dbo.Departaments", "Id_Emp", c => c.Int(nullable: false));
        }
    }
}
