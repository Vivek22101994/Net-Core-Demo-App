using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

public class RegistrationModel
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Language { get; set; }

    [Required]
    public string AccountType { get; set; } // PMS / Hotel

    [Required]
    public string CompanyName { get; set; }

    [Required]
    [Remote(controller:"Home",action: "CheckEmail")]
    public string UserEmail { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }
}