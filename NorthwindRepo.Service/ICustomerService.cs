using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NorthwindRepo.Entities.Models;
using NorthwindRepo.Repository.Models;
using Service.Pattern;

namespace NorthwindRepo.Service
{
    public interface ICustomerService : IService<Customer>
    {
        Task<IEnumerable<Customer>> GetAsync();
        Task<Customer>  FindAsync(string id);
        //Customer Add(Customer customer);
        //Customer Update(Customer customer);
        decimal CustomerOrderTotalByYear(string customerId, int year);
        IEnumerable<Customer> CustomersByCompany(string companyName);
        IEnumerable<CustomerOrder> GetCustomerOrder(string country);
    }
}