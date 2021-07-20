namespace Doctruyenchua.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixTruyen : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Truyens", "TenTruyen", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Truyens", "TenTruyen", c => c.String());
        }
    }
}
