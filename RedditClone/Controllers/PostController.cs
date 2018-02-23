using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;
using RedditClone.Models;

namespace RedditClone.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index(int id)
        {
            using (var redditCloneContext = new RedditCloneContext())
            {
                var post = redditCloneContext.Posts.Select(p => new PostViewModel
                {
                    PostId = p.PostId,
                    Title = p.Title,
                    Body = p.Body,
                    Date = p.Date
                }).SingleOrDefault(p => p.PostId == id);

                if (post == null)
                {
                    return new HttpNotFoundResult();
                }

                return View(post);
            }
        }
    }
}