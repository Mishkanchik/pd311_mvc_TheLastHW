
using System.ComponentModel.DataAnnotations;


namespace pd311_mvc_aspnet.Models
{
    public class Promo : BaseModel<string>
    {


        [Required]
        [MaxLength(100)]
        public string? NamePromo { get; set; }

        [Range(0, int.MaxValue)]
        public int Discount { get; set; }




    }
}
