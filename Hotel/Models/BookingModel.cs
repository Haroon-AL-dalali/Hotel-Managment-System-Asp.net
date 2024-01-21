using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class BookingModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "name")]
        [MinLength(10, ErrorMessage ="the miniumm length is 10 characters"),MaxLength(70,ErrorMessage = "the maxiumm length is 70 characters")]
        public string Name { get; set; }
        [Display(Name = "select RoomType")]
        public string RoomType { get; set; }
        [Display(Name = "TotalMembers")]
        public int TotalMembers { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "ArrivalDate")]
        public DateTime ArrivalDate { get; set; }
        [Display(Name = "DepatureDate")]
        public DateTime DepatureDate { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "PhoneNumber")]
        public int Phone { get; set; }

    }
}
