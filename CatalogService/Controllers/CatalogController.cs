using CatalogService.Data;
using CatalogService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly DataBaseContext _dataBaseContext;

        public CatalogController(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _dataBaseContext.Products.ToList();
        }
    }
}
