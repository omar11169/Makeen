using System.ComponentModel.DataAnnotations;

namespace Eventom.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }


        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Phone]
        public int PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string City { get; set; }

        public string UserType { get; set; } // Admin , Event Creator , Volunteer

        public string IsActive { get; set; }

        [DataType(DataType.Date)]
        public DateOnly CreatedDate { get; set; }

        [DataType(DataType.Date)]
        public DateOnly LastLoginDate { get; set; }



    }
}
