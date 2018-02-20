namespace RedditClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subreddits",
                c => new
                    {
                        SubredditId = c.Int(nullable: false, identity: true),
                        SubredditName = c.String(),
                    })
                .PrimaryKey(t => t.SubredditId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subreddits");
        }
    }
}
