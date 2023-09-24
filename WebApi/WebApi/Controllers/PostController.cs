using System;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTO;
using WebApi.Models;
using WebApi.Repository;


namespace WebApi.Controller
{
    [ApiController]
    [Route("PostList")]
    public class PostController:ControllerBase 
    {
        private readonly IBlogRepository _blogRepository;

        public PostController(IBlogRepository repository)
        {
            _blogRepository = repository;
        }

        [HttpGet]
        public IEnumerable<PostDTO> GetPostList()
        {

            var post = _blogRepository.GetPostList().Select(post => post.ASPostDTO());

            return post;
        }

        [HttpGet("{Id}")]
        public ActionResult<PostDTO> GetPostById(Guid Id)
        {
            var post = _blogRepository.GetPostById(Id);

            if(post is null){
                return NotFound();
            }

            return post.ASPostDTO();
        }

    }
}