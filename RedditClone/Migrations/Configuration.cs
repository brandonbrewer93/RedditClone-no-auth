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

            context.Comments.AddOrUpdate(
                c => c.CommentId,
                new Comment { CommentId = 1, PostId = 1, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now},
                new Comment { CommentId = 2, PostId = 1, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 3, PostId = 1, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 4, PostId = 1, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 5, PostId = 1, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 6, PostId = 1, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 7, PostId = 1, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 8, PostId = 1, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 9, PostId = 2, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 10, PostId = 2, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 11, PostId = 2, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 12, PostId = 2, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fn lkjnl sakjd nlkaj dfnl kjasd fnll", Date = DateTime.Now },
                new Comment { CommentId = 13, PostId = 2, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 14, PostId = 2, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 15, PostId = 2, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 16, PostId = 2, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 17, PostId = 3, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 18, PostId = 3, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 19, PostId = 3, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 20, PostId = 3, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 21, PostId = 3, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 22, PostId = 3, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 23, PostId = 3, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 24, PostId = 3, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 25, PostId = 4, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 26, PostId = 4, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 27, PostId = 4, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 28, PostId = 4, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 29, PostId = 4, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 30, PostId = 4, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 31, PostId = 4, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now },
                new Comment { CommentId = 32, PostId = 4, CommentBody = "lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl lkjnl sakjd nlkaj dfnl kjasd fnl", Date = DateTime.Now }
            );

            context.Posts.AddOrUpdate(
                p => p.PostId,
                new Post
                {
                    PostId = 1,
                    SubredditId = 1,
                    Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://images.unsplash.com/photo-1442508748335-fde9c3f58fd9?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=efb6133a444ebb07753d8fa38eb6d2f6&auto=format&fit=crop&w=500&q=60",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 2,
                    SubredditId = 1,
                    Title = "Test 2",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://images.unsplash.com/photo-1482192596544-9eb780fc7f66?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=bbe0bd1ecfaaa91394e0c9effb8b0415&auto=format&fit=crop&w=500&q=60",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 3,
                    SubredditId = 1,
                    Title = "Test 3",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://i.imgur.com/Fr6xeWv.gif",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 4,
                    SubredditId = 1,
                    Title = "Test 4",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 5,
                    SubredditId = 2,
                    Title = "Test 1",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 6,
                    SubredditId = 2,
                    Title = "Test 2",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 7,
                    SubredditId = 2,
                    Title = "Test 3",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 8,
                    SubredditId = 2,
                    Title = "Test 4",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 9,
                    SubredditId = 3,
                    Title = "Test 1",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 10,
                    SubredditId = 3,
                    Title = "Test 2",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 11,
                    SubredditId = 3,
                    Title = "Test 3",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 12,
                    SubredditId = 3,
                    Title = "Test 4",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 13,
                    SubredditId = 4,
                    Title = "Test 1",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 14,
                    SubredditId = 4,
                    Title = "Test 2",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 15,
                    SubredditId = 4,
                    Title = "Test 3",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 16,
                    SubredditId = 4,
                    Title = "Test 4",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 17,
                    SubredditId = 5,
                    Title = "Test 1",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 18,
                    SubredditId = 5,
                    Title = "Test 2",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 19,
                    SubredditId = 5,
                    Title = "Test 3",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                },
                new Post
                {
                    PostId = 20,
                    SubredditId = 5,
                    Title = "Test 4",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    Date = DateTime.Now
                }

            );
        }
    }
}
