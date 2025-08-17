using MeetingMinutesAPI.Data;
using MeetingMinutesAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeetingMinutesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductServiceController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductServiceController(IProductRepository repository)
        {
            _repository = repository;
        }


        // GET api/productservice
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _repository.GetProductsAsync();
            return Ok(products);
        }

    }
}
