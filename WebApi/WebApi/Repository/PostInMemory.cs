using System;
using System.Collections.Generic;
using WebApi.Models;
using System.Linq;

namespace WebApi.Repository {

    public class PostInMemory {

        private readonly List<Post> postList = new() 
        {
            new Post{
                PostId = Guid.NewGuid(),
                Title = "Best Anime of the season",
                Content = "JJk is the best anime of this season because...",
                createTime = DateTimeOffset.UtcNow,
                updatedTime = DateTimeOffset.UtcNow,
                AuthorId = "123456789asd"
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
