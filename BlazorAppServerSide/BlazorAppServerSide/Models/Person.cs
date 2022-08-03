using System.ComponentModel.DataAnnotations;

namespace BlazorAppServerSide.Models
{
    public class Person
    {
        [Required]
        [StringLength(100, ErrorMessage = "FirstName is too long.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "LastName is too long.")]
        public string LastName { get; set; }
        [Required]
        [Range(1, 1000)]
        public int EmployeeNumber{ get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
