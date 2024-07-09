using FactoryDbContext.Models;
using FactoryDbContext.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FactoryDbContext.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ProductRepository _repository;

        public HomeController(ProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data1 = await _repository.GetAllAsync(true);
            var data2 = await _repository.GetAllAsync(false);
            return Ok(new { data1, data2 });
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product entity)
        {
            await _repository.AddAsync(entity);
            return Ok(entity);
        }
    }
}
