using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DTPReg5.Models
{
    public class Type
    {
        //ID типу правопорушення
        public int Id { get; set; }
        //Тип правопорушення
        [Display(Name = "Type", ResourceType = typeof(Resources.Resource))]
        public string Name { get; set; }
        //Тип покарання за скоєне ДТП
        [Display(Name = "Punishment", ResourceType = typeof(Resources.Resource))]
        public string Punishment { get; set; }
    }
}