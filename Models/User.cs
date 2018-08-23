using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Tutor.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public DateTime DOB {get; set;}
        public string Street {get; set;}
        public string City {get; set;}
        [MinLength(2)]
        [MaxLength(2)]
        public string State {get; set;}
        [MinLength(5)]
        [MaxLength(5)]
        public int ZipCode {get; set;}
        public string Tutor {get; set;}
        public List<Language> Languages {get; set;}
        public string Travel {get; set;}
        public int Wage {get; set;} = 0;
        public int Rating {get; set;} = 0;
        public User(){
            Languages = new List<Language>();
        }
    }
}