namespace First_Project.DAL.Entities;

public class Payments
{
    public int Id { get; set; }
    public DateTime PaymentDate { get; set; }
    public int Amount { get; set; }
    public string PaymentMethod { get; set; }
    public Bookings BookingId { get; set; }
}
