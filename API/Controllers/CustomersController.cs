using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("v1/[controller]")]
public sealed class CustomersController : ControllerBase
{
	private readonly DataContext _context;

    public CustomersController(DataContext context)
	{
        _context = context;
    }

	[HttpGet]
	public ActionResult<IEnumerable<Customer>> GetCustomers()
	{
		var customers = _context.Customer.ToList();

		return customers;
	}

	[HttpGet("{id}")]
	public ActionResult<Customer> GetCustomerById(int id)
	{
		return _context.Customer.Find(id);
	}
}
