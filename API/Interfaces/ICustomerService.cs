using CineVerse.API.Models;

namespace CineVerse.API.Interfaces;

public interface ICustomerService
{
    Task<Customer> CreateCustomerAsync(Customer customer);
    Task<List<Customer>> GetAllCustomersAsync();
    Task<Customer> GetCustomerByIdAsync(int id);
    Task UpdateCustomerAsync(int id, Customer customer);
    Task DeleteCustomerAsync(int id);
}
