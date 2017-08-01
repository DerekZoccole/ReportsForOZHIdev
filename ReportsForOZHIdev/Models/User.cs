using System.ComponentModel.DataAnnotations;

namespace ReportsForOZHIdev.Models
{
    public class User
    {
        public string UserId { get; set; }

        public string Username { get; set; }
        
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string Company { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}