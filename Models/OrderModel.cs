namespace VerstaTask.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string CitySender { get; set; } = string.Empty;
        public string AddressSender { get; set; } = string.Empty;
        public string CityReceiver { get; set; } = string.Empty;
        public string AddressReceiver { get; set; } = string.Empty;
        public decimal Weight { get; set; }
        public DateTime? PickDate { get; set; }
    }
}
