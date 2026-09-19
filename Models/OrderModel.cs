namespace VestaTask.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string CitySender { get; set; } = string.Empty;
        public string AdressSender { get; set; } = string.Empty;
        public string CityReceiver { get; set; } = string.Empty;
        public string AdressReceiver { get; set; } = string.Empty;
        public decimal Weight { get; set; }
        public DateTime PickDate { get; set; }
    }
}
