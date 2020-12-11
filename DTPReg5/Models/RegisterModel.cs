using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DTPReg5.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Поле Прізвище повинно бути встановлено")]
        [Display(Name = "Прізвище")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Довжина рядка повинна бути від 3 до 50 символів")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Поле Ім'я повинно бути встановлено")]
        [Display(Name = "Ім'я")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Довжина рядка повинна бути від 3 до 50 символів")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Поле По батькові повинно бути встановлено")]
        [Display(Name = "По батькові")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Довжина рядка повинна бути від 3 до 50 символів")]
        public string FatherName { get; set; }
        [Required(ErrorMessage = "Поле Дата народження повинно бути встановлено")]
        [Display(Name = "Дата народження")]
        [RegularExpression("([0][1-9]|[2][0-9]|[3][0-1]|[1-9]|[1][0-9])/([0][1-9]|[1][0-2]|[1-9])/([1-2][0-9][0-9][0-9]|[0-9][0-9])", ErrorMessage = "Некоректно введена дата. Правильний флормат введення: ММ/ДД/РРРР")]
        public string Date_Birth { get; set; }
        [Required]
        [Display(Name = "Логін")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Електронна пошта")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Пароль повинен мати від 6 до 100 символів", MinimumLength = 6)] 
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Підтвердити пароль")]
        [Compare("Password", ErrorMessage = "Паролі не співпадають.")]
        public string ConfirmPassword { get; set; }
    }
}