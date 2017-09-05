using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestRespons
    {
        [Required(ErrorMessage ="Будь-ласка, введіть своє ім'я")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Будь-ласка, введіть email ")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Ви ввелт некоректний Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Будь-ласка, введіть телефон")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Будь-ласка. вкажіть, будети ви на вечірці")]
        public bool? WillAttend { get; set; }
    }
}