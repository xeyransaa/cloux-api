using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UserRegisterDto
    {
        public string UserName { get; set; }
        
        public string Email { get; set; }
        public string Password { get; set; }

        [Compare("Password",
            ErrorMessage = "Password and confirmation password don't match.")]
        public string ConfirmPassword { get; set; }
    }
}
