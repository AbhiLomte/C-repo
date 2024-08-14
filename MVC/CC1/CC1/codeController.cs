using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YourNamespace.Models; // Replace with your actual namespace
using System.Linq;
using System.Threading.Tasks;

public class CodeController : Controller
{
    private readonly NorthwindContext _context;

    public CodeController(NorthwindContext context)
    {
        _context = context;
    }

    // Action method to return all customers residing in Germany
    public async Task<IActionResult> CustomersInGermany()
    {
        var customers = await _context.Customers
            .Where(c => c.Country == "Germany")
            .ToListAsync();

        return View(customers);
    }

    // Action method to return customer details with orderId==10248
    public async Task<IActionResult> CustomerByOrderId(int orderId)
    {
        var customer = await _context.Orders
            .Where(o => o.OrderId == orderId)
            .Select(o => o.Customer)
            .FirstOrDefaultAsync();

        if (customer == null)
        {
            return NotFound();
        }

        return View(customer);
    }
}
