using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.Models
{
    public class CommentViewModel
    {
        public CommentViewModel()
        {
            Comments = new List<Comment>();
        }

        public int CommentId { get; set; }
        public string CommentBody { get; set; }
        public DateTime Date { get; set; }

        public PostViewModel PostViewModel { get; set; }

        public ICollection<Comment> Comments;
    }
}