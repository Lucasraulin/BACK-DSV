using System.Linq;
using BACK_DSV.Models;
using BACK_DSV.Data;
using Microsoft.AspNetCore.Mvc;

namespace BACK_DSV.Controllers
{
    [ApiController]
    [Route("api/movie")]

     public class MovieController : ControllerBase
    {
        private readonly DataContext _context;
        public MovieController(DataContext context) => _context = context;

        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return Created("", movie);
        }


        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Movies.ToList());
    }

}