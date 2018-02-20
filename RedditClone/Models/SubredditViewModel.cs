using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.Models
{
    public class SubredditViewModel
    {
        public int? SubredditId { get; set; }
        public string SubredditName { get; set; }
        public string[] Posts { get; set; }
    }
}