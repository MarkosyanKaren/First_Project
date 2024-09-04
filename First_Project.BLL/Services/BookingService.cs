using First_Project.BLL.Interfaces;
using First_Project.DAL.Entities;

namespace First_Project.BLL.Services;

public class BookingService : IBookingService
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
