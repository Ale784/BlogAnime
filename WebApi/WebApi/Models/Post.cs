using System;


namespace WebApi.Models{

    public class Post{

        public Guid PostId { get; init; }
        public string? Title { get; init; }
        public string? Content { get; init; }
        public DateTimeOffset CreateTime { get; init; }
        public DateTimeOffset UpdatedTime { get; init; }
        public string? AuthorName { get; init; }



    }


}