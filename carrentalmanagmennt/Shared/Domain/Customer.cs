namespace carrentalmanagmennt.Shared.Domain
{
    public class Customer:Class1
    {
        public string? DrivingLicense { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }
        public virtual List<Booking>? Bookings { get; set; }
    }
}