using System.ComponentModel.DataAnnotations;

public class LoginModel
{
    [EmailAddress]
    [Display(Name = "Insert your Email")]
    [StringLength(100)]
    public string Email { get; set; }

    [Required]
    [Display(Name = "Insert your Password")]
    [StringLength(8)]
    public string Password { get; set; }


    public string ErrorText { get; set; }


    public LoginModel()
    {

    }

}