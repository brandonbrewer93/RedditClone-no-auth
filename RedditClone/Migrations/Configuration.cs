using System.Collections.Generic;
using System.Configuration;

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

            context.Posts.AddOrUpdate(
                p => p.PostId,
                new Post { PostId = 1, SubredditId = 1, Title = "Test 1", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 2, SubredditId = 1, Title = "Test 2", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 3, SubredditId = 1, Title = "Test 3", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 4, SubredditId = 1, Title = "Test 4", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 5, SubredditId = 2, Title = "Test 1", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 6, SubredditId = 2, Title = "Test 2", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 7, SubredditId = 2, Title = "Test 3", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 8, SubredditId = 2, Title = "Test 4", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 9, SubredditId = 3, Title = "Test 1", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 10, SubredditId = 3, Title = "Test 2", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 11, SubredditId = 3, Title = "Test 3", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 12, SubredditId = 3, Title = "Test 4", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 13, SubredditId = 4, Title = "Test 1", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 14, SubredditId = 4, Title = "Test 2", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 15, SubredditId = 4, Title = "Test 3", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 16, SubredditId = 4, Title = "Test 4", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 17, SubredditId = 5, Title = "Test 1", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 18, SubredditId = 5, Title = "Test 2", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 19, SubredditId = 5, Title = "Test 3", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now },
                new Post { PostId = 20, SubredditId = 5, Title = "Test 4", Body = "TESTTESTTESTTESTTESTTESTTESTTEST", Date = DateTime.Now }

            );
        }
    }
}
