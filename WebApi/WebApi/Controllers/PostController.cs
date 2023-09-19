using System;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repository;


namespace WebApi.Controller
{
    [ApiController]
    [Route("PostList")]
    public class PostController:ControllerBase 
    {
        private readonly PostInMemory _postMemory;

        public PostController()
        {
            _postMemory = new PostInMemory();
        }

        [HttpGet]
        public IEnumerable<Post> GetPostList()
        {
            var posts = _postMemory.GetPostList();
            return posts;
        }

    }
}