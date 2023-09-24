using System;
using System.Collections.Generic;
using WebApi.Models;
using System.Linq;

namespace WebApi.Repository {

    public class BlogInMemory : IBlogRepository{

        private readonly List<Post> postList = new() 
        {
            new Post{
                PostId = Guid.NewGuid(),
                Title = "Example 1",
                Content = "Example 1...",
                CreateTime = DateTimeOffset.UtcNow,
                UpdatedTime = DateTimeOffset.UtcNow,
                AuthorName = "User1"
            },
            new Post{
                PostId = Guid.NewGuid(),
                Title = "Example 2",
                Content = "Example 2..",
                CreateTime = DateTimeOffset.UtcNow,
                UpdatedTime = DateTimeOffset.UtcNow,
                AuthorName = "User2"
            }
        };


        public IEnumerable<Post> GetPostList()
        {
            return postList;
        }

        public Post? GetPostById(Guid GuidPostId)
        {
            return postList.Where(x => x.PostId == GuidPostId).FirstOrDefault();
        }


    }

}
