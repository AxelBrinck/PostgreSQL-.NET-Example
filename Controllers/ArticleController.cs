using System.Linq;
using ArticleApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace ArticleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly DataContext _context;

        public ArticleController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetArticles()
        {
            return Ok(_context.Articles.ToList());
        }
    }
}