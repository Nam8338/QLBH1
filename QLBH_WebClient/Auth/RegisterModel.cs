using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLBH_WebClient.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is quired")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Email is quired")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Passwords { get; set; }
    }
}