using MVCGlobalizationSample.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCGlobalizationSample.Models
{
    public class UserModel
    {
        [Required(ErrorMessageResourceType = typeof(FormErrorSample), ErrorMessageResourceName = "RequiredMessage")]
        [Display(ResourceType = typeof(SiteLanguage), Name = "UserName")]
        public string UserName { get; set; }

        [MinLength(8, ErrorMessageResourceType = typeof(FormErrorSample), ErrorMessageResourceName = "PasswordErrorMessage")]
        [Display(ResourceType = typeof(SiteLanguage), Name = "Password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessageResourceType = typeof(FormErrorSample), ErrorMessageResourceName = "PasswordCompareErrorMessage")]
        [Display(ResourceType = typeof(SiteLanguage), Name = "PasswordConfirm")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessageResourceType = typeof(FormErrorSample), ErrorMessageResourceName = "RequiredMessage")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessageResourceType = typeof(FormErrorSample), ErrorMessageResourceName = "EmailErrorMessage")]
        [Display(ResourceType = typeof(SiteLanguage), Name = "Email")]
        public string Email { get; set; }

    }
}