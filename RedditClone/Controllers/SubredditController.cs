using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedditClone.Models;

namespace RedditClone.Controllers
{
    public class SubredditController : Controller
    {
        // GET: Subreddit
        public ActionResult Index()
        {
            using (var subredditContext = new RedditCloneContext())
            {
                var subredditList = new SubredditListViewModel
                {
                    Subreddits = subredditContext.Subreddits.Select(s => new SubredditViewModel
                    {
                        SubredditId = s.SubredditId,
                        SubredditName = s.SubredditName
                    }).ToList()
                };
                return View(subredditList);
            }
        }

        //public ActionResult SubredditPosts(int id)
        //{
        //    using (var redditCloneContext = new RedditCloneContext())
        //    {
        //        var subreddit = redditCloneContext.Subreddits.Include(s => s.Posts).SingleOrDefault(s => s.SubredditId == id);
        //        if (subreddit != null)
        //        {
        //            var subredditViewModel = new SubredditViewModel
        //            {
        //                SubredditId = subreddit.SubredditId,
        //                SubredditName = subreddit.SubredditName,
        //                Posts = subreddit.Posts
        //            };

        //            return View(subredditViewModel);
        //        }
        //    }
        //    return new HttpNotFoundResult();
        //}



        public ActionResult SubredditPosts(int id)
        {
            using (var redditCloneContext = new RedditCloneContext())
            {
                var subreddit = redditCloneContext.Subreddits.Select(s => new SubredditViewModel
                {
                    SubredditId = s.SubredditId,
                    SubredditName = s.SubredditName,
                    Posts = s.Posts
                }).SingleOrDefault(s => s.SubredditId == id);

                if (subreddit == null)
                {
                    return new HttpNotFoundResult();
                }

                return View(subreddit);
            }
        }
    }
}