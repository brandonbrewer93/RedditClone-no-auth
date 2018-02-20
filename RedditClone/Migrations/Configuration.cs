namespace RedditClone.Migrations
{
    using RedditClone.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RedditClone.RedditCloneContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RedditClone.RedditCloneContext";
        }

        protected override void Seed(RedditClone.RedditCloneContext context)
        {
            context.Subreddits.AddOrUpdate(
                s => s.SubredditId,
                new Subreddit { SubredditId = 1, SubredditName = "Music" },
                new Subreddit { SubredditId = 2, SubredditName = "Art" },
                new Subreddit { SubredditId = 3, SubredditName = "Gaming" },
                new Subreddit { SubredditId = 4, SubredditName = "News" },
                new Subreddit { SubredditId = 5, SubredditName = "Science" },
                new Subreddit { SubredditId = 6, SubredditName = "Funny" }
            );
        }
    }
}
