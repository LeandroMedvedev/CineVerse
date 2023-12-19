using CineVerse.API.Helpers;
using CineVerse.API.Models;
using CineVerse.API.Services;

using Microsoft.AspNetCore.Mvc;

namespace CineVerse.API.Controllers;

public sealed class CustomersController : BaseAPIController
{
    private readonly CustomerService _customerService;

    public CustomersController(CustomerService customerService)
        => _customerService = customerService;

    [HttpGet]
	public async Task<ActionResult<IEnumerable<Customer>>> GetAllCustomersAsync()
        => await _customerService.GetAllCustomersAsync();

	[HttpGet("{id}")]
	public async Task<ActionResult<Customer>> GetCustomerByIdAsync(int id)
	{
		var customer = await _customerService.GetCustomerByIdAsync(id);

        if (customer == null) return NotFound(new { Message = "Cliente não encontrado" });

        return StatusCode(200, customer);
	}

    [HttpPost("register")]
    public async Task<ActionResult<Customer>> CreateMovieAsync([FromBody] Customer data)
    {
        if (await _customerService.CustomerExistsAsync(data.Email)) return Conflict(
            new { Message = "O filme já existe no banco de dados" }
        );

        var customer = new Customer
        {
            FirstName = Text.CapitalizeWords(data.FirstName),
            LastName = Text.CapitalizeWords(data.LastName),
            Email = data.Email.ToLower(),
            Password = data.Password,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        };

        await _customerService.CreateCustomerAsync(customer);

        return StatusCode(201, data);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCustomerAsync([FromBody] Customer data, int id)
    {
        var customer = await _customerService.CustomerByIdAsync(id);

        if (customer == null) return NotFound(new { Message = "Cliente não encontrado" });

        await _customerService.UpdateCustomerAsync(customer, data);
        
        return StatusCode(200);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCustomerAsync(int id)
    {
        var customer = await _customerService.CustomerByIdAsync(id);

        if (customer == null) return NotFound(new { Message = "Cliente não encontrado" });

        await _customerService.DeleteCustomerAsync(customer);

        return StatusCode(204);
    }
}
