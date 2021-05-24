namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writerTest1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "Writertest", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "Writertest");
        }
    }
}
