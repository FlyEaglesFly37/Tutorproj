using System;
using System.ComponentModel.DataAnnotations;

namespace Tutor.Models
{
    public class ValidateUser
    {
        [Key]
        public int UserId {get; set;}
        [Required]
        [MinLength(2)]
        public string FirstName {get; set;}
        [Required]
        [MinLength(2)]
        public string LastName {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string ConfirmPw {get; set;}
    }
}