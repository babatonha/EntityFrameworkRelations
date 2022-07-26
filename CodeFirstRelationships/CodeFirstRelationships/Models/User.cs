﻿namespace CodeFirstRelationships.Models
{
    public class User
    {
        public int ID { get; set; } 
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<ElectricJob> ElectricJobs { get; set; }
        public Address Address { get; set; }
        public ICollection<Roles> Roles { get; set; }
    }
}
