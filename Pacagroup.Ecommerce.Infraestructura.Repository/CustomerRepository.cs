using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Infraestructura.Interface;
using Pacagroup.Ecommerce.Transversal.Common;
using Dapper;
using System;
using System.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Infraestructura.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public CustomerRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public bool Insert(Customer customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public bool Update(Customer customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }


        public Task<bool> InsertAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Get(string customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
