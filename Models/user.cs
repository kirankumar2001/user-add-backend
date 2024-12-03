using System.ComponentModel.DataAnnotations;

namespace web_api_dot_net.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public String name { get; set; } = "";
        [Required]
        public String address { get; set; } = "";
    }
}
