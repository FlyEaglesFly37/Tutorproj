using System;

namespace Tutor.Models
{
    public class Tutor
    {
        public int TutorId {get; set;}
        public int UserId {get; set;}
        public User User {get; set;}
        public int LanguageId {get; set;}
        public Language Language {get; set;}
    }
}