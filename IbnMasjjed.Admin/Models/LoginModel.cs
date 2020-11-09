using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbnMasjjed.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "ادخل اسم المستخدم", AllowEmptyStrings = false)]
        [MaxLength(20, ErrorMessage = "اسم المستخدم طويل")]
        public string Username { get; set; }

        [Required(ErrorMessage = "ادخل كلمة المرور", AllowEmptyStrings = false)]
        [MaxLength(20, ErrorMessage = "كلمة المرور طويلة")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
