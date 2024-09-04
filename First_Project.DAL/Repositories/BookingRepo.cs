using First_Project.DAL.Entities;
using First_Project.DAL.Interfaces;

namespace First_Project.DAL.Repositories;

public class BookingRepo : IBookingRepo
{
    public Task CreatBooking(DateTime bookingDate, int numberOfPeople, int totalprice, Customers customerId, Tours tourId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteBooking(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Bookings>> GetBooking()
    {
        throw new NotImplementedException();
    }
}
