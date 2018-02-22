namespace RedditClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Body = c.String(),
                        Date = c.DateTime(nullable: false),
                        SubredditId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Subreddits", t => t.SubredditId, cascadeDelete: true)
                .Index(t => t.SubredditId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "SubredditId", "dbo.Subreddits");
            DropIndex("dbo.Posts", new[] { "SubredditId" });
            DropTable("dbo.Posts");
        }
    }
}
