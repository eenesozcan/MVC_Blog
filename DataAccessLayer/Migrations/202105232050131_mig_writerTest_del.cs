namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writerTest_del : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Writers", "Writertest");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "Writertest", c => c.Boolean(nullable: false));
        }
    }
}
