

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebsiteWebApi
{
    [Route("[controller]")]
    [ApiController]

public class FeedbackController: ControllerBase
{
private readonly FeedbackContext _context;

        public FeedbackController(FeedbackContext context)
        {
            _context = context;
        }

  // GET: api/CustomerData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Feedback>>> GetCustomerData()
        {
            return await _context.bFeedbackTable.ToListAsync();
        }

        // POST: api/CustomerData
        [HttpPost]
        public async Task<ActionResult<Feedback>> PostCustomerData(Feedback customer)
        {
            _context.bFeedbackTable.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCustomerData), new { id = customer.Name }, customer);
        }
    }
}




