using System.ComponentModel.DataAnnotations;

namespace First_Project.DAL.Entities;

public class Bookings
{
    public int Id { get; set; }
    public DateTime BookingDate { get; set; }
    public int NumberOfPeople { get; set; }
    public int TotalPrice { get; set; }
    public Customers CustomerId { get; set; }
    public Tours TourId { get; set; }
}
