using MeetingMinutesAPI.Data;
using MeetingMinutesAPI.Interfaces;
using MeetingMinutesAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeetingMinutesAPI.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<ProductService>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        
    }
}
