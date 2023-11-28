namespace swebapi.Models;

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

public class CustomIdentityUser : IdentityUser
{
    [PersonalData]
    [Display(Name = "Nombre")]
    public string? Nombre { get; set; }
}
