namespace Doctruyenchua.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixStringLengthMoTaTruyen : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Truyens", "MoTaNgan", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Truyens", "MoTaNgan", c => c.String(maxLength: 255));
        }
    }
}
