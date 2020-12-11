using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DTPReg5.Models
{
    public class LogOnModel
    {
        [Required]
        [Display(Name = "Логін")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [Display(Name = "Запам'ятати")]
        public bool RememberMe { get; set; }
    }
}