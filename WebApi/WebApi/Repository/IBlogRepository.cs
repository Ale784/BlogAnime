using WebApi.Models;

namespace WebApi.Repository {
    
    public interface IBlogRepository{
        IEnumerable<Post> GetPostList();
        Post? GetPostById(Guid GuidPostId);

    }
}