using System;


namespace WebApi.Models{

    public class Post{

        public Guid PostId { get; init; }
        public string? Title { get; init; }
        public string? Content { get; init; }
        public DateTimeOffset createTime { get; init; }
        public DateTimeOffset updatedTime { get; init; }
        public string? AuthorId { get; init; }



    }


}