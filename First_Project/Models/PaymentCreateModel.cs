using First_Project.DAL.Entities;

namespace First_Project.Models;

public class PaymentCreateModel
{
    public DateTime PaymentDate { get; set; }
    public int Amount { get; set; }
    public string PaymentMethod { get; set; }
    public Bookings BookingId { get; set; }
}
