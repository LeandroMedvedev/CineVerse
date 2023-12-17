using CineVerse.API.Data;
using CineVerse.API.Interfaces;
using CineVerse.API.Models;

using Microsoft.EntityFrameworkCore;

namespace CineVerse.API.Services;

public sealed class CustomerService : ICustomerService
{
    private readonly DataContext _context;

    public CustomerService(DataContext context) => _context = context;

    public async Task<Customer> CreateCustomerAsync(Customer customer)
    {
        customer.CreatedAt = DateTime.Now;
        customer.UpdatedAt = DateTime.Now;

        _context.Customer.Add(customer);
        await _context.SaveChangesAsync();

        return customer;
    }

    public async Task<List<Customer>> GetAllCustomersAsync()
        => await _context.Customer.ToListAsync();
 
    public async Task<Customer> GetCustomerByIdAsync(int id)
        => await _context.Customer.FindAsync(id);

    public async Task UpdateCustomerAsync(int id, Customer data)
    {
        var customer = await _context.Customer.FindAsync(id);

        customer.UserName = data.UserName;
        customer.FirstName = data.FirstName;
        customer.LastName = data.LastName;
        customer.Email = data.Email;
        customer.Password = data.Password;
        customer.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();
    }

    public async Task DeleteCustomerAsync(int id)
    {
        var customer = await _context.Customer.FindAsync(id);
        if (customer != null)
        {
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
        }
    }
}
