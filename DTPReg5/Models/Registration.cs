using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTPReg5.Models
{
    public class Registration
    {
        //Id офрмлення ДТП
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        //ПІП порушника
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "NameRequired")]
        [Display(Name = "Name", ResourceType = typeof(Resources.Resource))]
        [StringLength(50, MinimumLength = 3, ErrorMessageResourceName = "NameLength", ErrorMessageResourceType = typeof(Resources.Resource))]
        public string PIP { get; set; }
        //Номер водійського посвідчення порушника
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "NumberCertificationRequired")]
        [Display(Name = "NumberCertification", ResourceType = typeof(Resources.Resource))]
        [StringLength(10, MinimumLength = 9, ErrorMessageResourceName = "NumberCertificationLength", ErrorMessageResourceType = typeof(Resources.Resource))]
        public string NPos { get; set; }
        //Дата народження порушника
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "DateBirthRequired")]
        [Display(Name = "DateBirth", ResourceType = typeof(Resources.Resource))]
        [RegularExpression("([0][1-9]|[2][0-9]|[3][0-1]|[1-9]|[1][0-9])/([0][1-9]|[1][0-2]|[1-9])/([1-2][0-9][0-9][0-9]|[0-9][0-9])", ErrorMessageResourceName = "DateBirthLength", ErrorMessageResourceType = typeof(Resources.Resource))]
        public string Date_Birth { get; set; }
        //Марка автомобіля
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "ModelRequired")]
        [Display(Name = "Model", ResourceType = typeof(Resources.Resource))]
        public string Marka_Auto { get; set; }
        //Номерний знак автомобіля
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "NumberAutoRequired")]
        [Display(Name = "NumberAuto", ResourceType = typeof(Resources.Resource))]
        public string Nomer_Auto { get; set; }
        //Адреса порушення
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "AddressRequired")]
        [Display(Name = "Address", ResourceType = typeof(Resources.Resource))]
        [StringLength(70, MinimumLength = 3, ErrorMessageResourceName = "AddressLength", ErrorMessageResourceType = typeof(Resources.Resource))]
        public string Address { get; set; }
        //Дата порушення
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "DateViolationRequired")]
        [Display(Name = "DateViolation", ResourceType = typeof(Resources.Resource))]
        [RegularExpression("([0][1-9]|[2][0-9]|[3][0-1]|[1-9]|[1][0-9])/([0][1-9]|[1][0-2]|[1-9])/([1-2][0-9][0-9][0-9]|[0-9][0-9])", ErrorMessageResourceName = "DateViolationLength", ErrorMessageResourceType = typeof(Resources.Resource))]
        public string Date_Por { get; set; }
    }
}