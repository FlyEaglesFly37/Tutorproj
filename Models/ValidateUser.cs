using System;
using Tutor.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tutor.Models
{
    public class ValidateUser
    {
        [Key]
        public int UserId {get; set;}
        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPw {get; set;}
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Password {get; set;}
        [Required]
        public DateTime DOB {get; set;}
        [Required]
        public string Street {get; set;}
        [Required]
        public string City {get; set;}
        [Required]
        [MinLength(2)]
        [MaxLength(2)]
        public string State {get; set;}
        [Required]
        public int ZipCode {get; set;}
        public string Tutor {get; set;}
        public string Travel {get; set;}
        public int Wage {get; set;} = 0;
    }
}