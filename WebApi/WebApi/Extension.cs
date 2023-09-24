using System;
using WebApi.DTO;
using WebApi.Models;


namespace WebApi {
    public static class Extension {
        public static PostDTO ASPostDTO(this Post post) {

            return new PostDTO {
                PostId = post.PostId,
                Title = post.Title,
                Content = post.Content,
                CreateTime = post.CreateTime,
                UpdatedTime = post.UpdatedTime,
                AuthorName = post.AuthorName
            };

        }

    }

}