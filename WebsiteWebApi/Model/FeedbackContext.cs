using Microsoft.EntityFrameworkCore;

namespace WebsiteWebApi;

public class FeedbackContext:DbContext
{

public FeedbackContext(DbContextOptions<FeedbackContext> options) : base(options){}

        public DbSet<Feedback>bFeedbackTable{ get; set; }
}
