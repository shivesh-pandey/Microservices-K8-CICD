using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ProductContext _context;
        public ProductController(ILogger<ProductController> logger,ProductContext productContext)
        {
            _logger = logger;
            _context = productContext;
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> Get() {
            //var filter = Builders<Product>.Filter.Eq(p => p.Category, "Electronics");
            return await _context.Products.Find(x=>true).ToListAsync();
        }
    }
}
