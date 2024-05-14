using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PeopleManager.Model
{
    public class Person
    {
        public int Id { get; set; }

        [DisplayName("First name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        
        public string? Password { get; set; } // Add this line

        //Optional
        public int? OrganizationId { get; set; }
        public Organization? Organization { get; set; }
    }
}
