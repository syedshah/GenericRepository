using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using NorthwindRepo.Entities.Models;
using NorthwindRepo.Repository.Models;
using NorthwindRepo.Repository.Repositories;
using Repository.Pattern.Repositories;
using Service.Pattern;

namespace NorthwindRepo.Service
{
    
    public class CustomerService : Service<Customer>, ICustomerService
    {
        private readonly IRepositoryAsync<Customer> _repository;

        public CustomerService(IRepositoryAsync<Customer> repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Customer>> GetAsync()
        {
            return _repository.Query().SelectAsync();
        }

        public Task<Customer> FindAsync(string id)
        {
            return _repository.FindAsync(id);
        }

        public decimal CustomerOrderTotalByYear(string customerId, int year)
        {
            return _repository.GetCustomerOrderTotalByYear(customerId, year);
        }

        public IEnumerable<Customer> CustomersByCompany(string companyName)
        {
            return _repository.CustomersByCompany(companyName);
        }

        public IEnumerable<CustomerOrder> GetCustomerOrder(string country)
        {
            return _repository.GetCustomerOrder(country);
        }

        public override void Insert(Customer entity)
        {
            base.Insert(entity);
        }

        public override void Delete(object id)
        {
            base.Delete(id);
        }
    }
}