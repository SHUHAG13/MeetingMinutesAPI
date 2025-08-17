using MeetingMinutesAPI.Models.Entities;

namespace MeetingMinutesAPI.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CorporateCustomer>> GetCorporateCustomersAsync();
        Task<IEnumerable<IndividualCustomer>> GetIndividualCustomersAsync();
    }
}
