using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Validation_And_Password_Encryption_DB_Assignment.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}