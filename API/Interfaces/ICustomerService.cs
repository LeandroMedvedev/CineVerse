using CineVerse.API.Models;

namespace CineVerse.API.Interfaces;

public interface ICustomerService
{
    Task<Customer> CreateCustomerAsync(Customer customer);
    Task<List<Customer>> GetAllCustomersAsync();
    Task<Customer> GetCustomerByIdAsync(int id);
    Task UpdateCustomerAsync(Customer customer, Customer data);
    Task DeleteCustomerAsync(Customer customer);
    Task<bool> CustomerExistsAsync(string email);
    Task<Customer> CustomerByIdAsync(int id);
}
