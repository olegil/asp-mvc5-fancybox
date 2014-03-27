using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FancyBox.Models
{
    public class SendEmailViewModel
    {

        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }

    }
}