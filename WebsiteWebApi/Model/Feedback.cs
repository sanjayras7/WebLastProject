using System.ComponentModel.DataAnnotations;

namespace WebsiteWebApi;

public class Feedback

{
    [Key]
    public string Name { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
}

