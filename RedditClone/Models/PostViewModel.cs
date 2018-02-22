using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.Models
{
    public class PostViewModel
    {
        public int? PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }

        public SubredditViewModel SubredditViewModel { get; set; }
    }
}