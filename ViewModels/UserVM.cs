using System.ComponentModel.DataAnnotations;

namespace WebSec3_IPN.ViewModels
{
    public class UserVM
    {
         [Key]
        public string Email { get; set; }

    }
}
