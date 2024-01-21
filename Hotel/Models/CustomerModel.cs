using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "name")]
        public string Name { get; set; }
        [Display(Name = "RoomType")]
        public string RoomType { get; set; }
        [Display(Name = "TotalMembers")]
        public int TotalMembers { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "PhoneNumber")]
        public int Phone { get; set; }


    }
}
