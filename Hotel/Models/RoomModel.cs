using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class RoomModel

    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "RoomNumber")]
        public int RoomNumber { get; set; }
        [Required]
        [Display(Name = "RoomType")]
        public string RoomType { get; set; }
        [Required]
        public int Active { get; set; }
        [Display(Name = "BadCont")]
        [Required]
        public int BadCont { get; set; }
        [Display(Name = "Rent")]
        [Required]
        public int Rent { get; set; }
        [Display(Name = "PhoneNumber")]
        [Required]
        public int Phone { get; set; }


    }
}
