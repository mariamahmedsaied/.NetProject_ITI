using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolLibraryStore.Models
{
    public class User
    {
        public int UserId { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 15 char")]
        [Required(ErrorMessage = "The User First Name is required.")]
        [DisplayName("User First Name")]
        public string? FirstName { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 15 char")]
        [Required(ErrorMessage = "The User Last Name is required.")]
        [DisplayName("User Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "The Student Email is required.")]
        [EmailAddress]
        [DisplayName("Student Email")]
        public string? Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}

