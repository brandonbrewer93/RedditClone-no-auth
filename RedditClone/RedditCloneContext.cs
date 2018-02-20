using RedditClone.Models;
using System.Data.Entity;

namespace RedditClone
{ 
    public class RedditCloneContext : DbContext
    {
        public RedditCloneContext() : base("name=RedditCloneContext")
        {
        }

        public virtual DbSet<Subreddit> Subreddits { get; set; }
    }
}