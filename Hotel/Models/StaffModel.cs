using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class StaffModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }
        [Display(Name = "PhoneNumber")]
        [Required]
        public int Phone { get; set; }
        [Display(Name = "Date")]
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Display(Name = "Password")]
        [Required]
        public int Password { get; set; }
        [Display(Name = "Confirm Password")]
        [Required]
        public int ConfirmPassword { get; set; }
        [Display(Name = "Salary")]
        [Required]
        public int Salary { get; set; }




    }
}
