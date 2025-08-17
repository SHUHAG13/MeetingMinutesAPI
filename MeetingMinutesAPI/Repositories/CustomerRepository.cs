using MeetingMinutesAPI.Data;
using MeetingMinutesAPI.Interfaces;
using MeetingMinutesAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeetingMinutesAPI.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<CorporateCustomer>> GetCorporateCustomersAsync()
        {
            return await _context.CorporateCustomers.ToListAsync();
        }


        public async Task<IEnumerable<IndividualCustomer>> GetIndividualCustomersAsync()
        {
            return await _context.IndividualCustomers.ToListAsync();
        }
    }
   
}
