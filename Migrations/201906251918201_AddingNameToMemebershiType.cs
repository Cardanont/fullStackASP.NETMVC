namespace FullStackMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNameToMemebershiType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
