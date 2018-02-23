namespace RedditClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageLinkToPostModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "ImageLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "ImageLink");
        }
    }
}
