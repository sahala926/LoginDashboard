using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication3.Models
{
    public class HomeModel
    {
        [Required]
        public string text { get; set; }
    }
}
