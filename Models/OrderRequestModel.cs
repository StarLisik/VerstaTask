using System.ComponentModel.DataAnnotations;

namespace VestaTask.Models
{
    public class OrderRequestModel
    {
        [Required]
        public string CitySender { get; set; } = string.Empty;

        [Required]
        public string AdressSender { get; set; } = string.Empty;

        [Required]
        public string CityReceiver { get; set; } = string.Empty;

        [Required]
        public string AdressReceiver { get; set; } = string.Empty;

        [Range(0.01, 100000, ErrorMessage = "Недопустимый вес груза (от 0.01 до 100000)")]
        public decimal Weight { get; set; }

        [Required]
        public DateTime PickDate { get; set; }
    }
}
