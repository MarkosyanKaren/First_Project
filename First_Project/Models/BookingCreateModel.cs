using First_Project.DAL.Entities;

namespace First_Project.Models;

public class BookingCreateModel
{
    public DateTime BookingDate { get; set; }
    public int NumberOfPeople { get; set; }
    public int TotalPrice { get; set; }
    public Customers CustomerId { get; set; }
    public Tours TourId { get; set; }
}
