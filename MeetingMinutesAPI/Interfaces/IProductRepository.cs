using MeetingMinutesAPI.Models.Entities;

namespace MeetingMinutesAPI.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductService>> GetProductsAsync();
    }
}
