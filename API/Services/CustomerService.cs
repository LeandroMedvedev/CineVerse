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
        _context.Customer.Add(customer);
        await _context.SaveChangesAsync();

        return customer;
    }

    public async Task<List<Customer>> GetAllCustomersAsync()
        => await _context.Customer.ToListAsync();

    public async Task<Customer> GetCustomerByIdAsync(int id)
        => await _context.Customer.FindAsync(id);

    public async Task UpdateCustomerAsync(Customer customer, Customer data)
    {
        customer.UpdatedAt = DateTime.UtcNow;
        customer.FirstName = data.FirstName;
        customer.LastName = data.LastName;
        customer.UserName = data.UserName;
        customer.Password = data.Password;
        customer.Email = data.Email;

        await _context.SaveChangesAsync();
    }

    public async Task DeleteCustomerAsync(Customer customer)
    {
        _context.Customer.Remove(customer);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CustomerExistsAsync(string email)
        => await _context.Customer.AnyAsync(x => x.Email == email.ToLower());

    public async Task<Customer> CustomerByIdAsync(int id)
        => await _context.Customer.FindAsync(id);
}
