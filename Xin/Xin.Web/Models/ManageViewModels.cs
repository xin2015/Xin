using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace Xin.Web.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "新密码")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "确认新密码")]
        [Compare("NewPassword", ErrorMessage = "新密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "当前密码")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "新密码")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "确认新密码")]
        [Compare("NewPassword", ErrorMessage = "新密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }
    }

    public class AddEmailViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "电子邮件")]
        public string Email { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "电话号码")]
        public string Number { get; set; }
    }
}