using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class User
    {
        public int id { get; set; }
        public string Username { get; set; } = string.Empty;
        public int MyProperty { get; set; }
        public byte[] Password { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];
    }
}