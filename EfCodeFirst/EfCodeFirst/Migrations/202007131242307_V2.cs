namespace EfCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Autoes", "SitzeFarbe", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Autoes", "SitzeFarbe");
        }
    }
}
