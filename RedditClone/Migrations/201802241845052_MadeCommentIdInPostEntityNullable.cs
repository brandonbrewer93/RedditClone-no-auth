namespace RedditClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeCommentIdInPostEntityNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "CommentId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "CommentId", c => c.Int(nullable: false));
        }
    }
}
