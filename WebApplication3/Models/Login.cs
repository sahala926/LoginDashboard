using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    [Table("login")]
    public class Login
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? password { get; set; }
        public string? email { get; set; }
    }
}
