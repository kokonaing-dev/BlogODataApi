using BlogODataApi.Data;
using BlogODataApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace BlogODataApi.Controllers;

public class PostsController : ODataController
{
    private readonly AppDbContext _context;

    public PostsController(AppDbContext context)
    {
        _context = context;
    }

    [EnableQuery]
    [HttpGet]
    public IQueryable<Post> Get()
    {
        return _context.Posts;
    }
}