using Microsoft.EntityFrameworkCore;
using WebApiPractise;
namespace WebApiPractise.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
