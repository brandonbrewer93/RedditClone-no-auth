using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedditClone.Models;

namespace RedditClone.Controllers
{
    public class SubredditController : Controller
    {
        private List<SubredditViewModel> _subredditList { get; set; }

        public SubredditController()
        {
            _subredditList = new List<SubredditViewModel>
            {
                new SubredditViewModel {SubredditId = 1, SubredditName = "Music"},
                new SubredditViewModel {SubredditId = 2, SubredditName = "Gaming"},
                new SubredditViewModel {SubredditId = 3, SubredditName = "Movies"},
                new SubredditViewModel {SubredditId = 4, SubredditName = "Art"},
                new SubredditViewModel {SubredditId = 5, SubredditName = "Funny"},
                new SubredditViewModel {SubredditId = 6, SubredditName = "News"},
                new SubredditViewModel {SubredditId = 7, SubredditName = "Science"}
            };
        }

        // GET: Subreddit
        public ActionResult Index()
        {
            var subredditList = new SubredditListViewModel
            {
                Subreddits = _subredditList
            };

            return View(subredditList);
        }

        public SubredditViewModel GetSubreddit(int id)
        {
            SubredditViewModel subredditToReturn = null;

            foreach (var subreddit in _subredditList)
            {
                if (subreddit.SubredditId == id)
                {
                    subredditToReturn = subreddit;
                }
            }

            return subredditToReturn;
        }

        public ActionResult SubredditPosts(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var subreddit = GetSubreddit(id.Value);

            return View(subreddit);
        }
    }
}