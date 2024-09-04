using First_Project.DAL.Entities;

namespace First_Project.BLL.Interfaces;

public interface IBookingService
{
    public Task<List<Bookings>> GetBooking();
    public Task CreatBooking(DateTime bookingDate, int numberOfPeople, int totalprice,
        Customers customerId, Tours tourId);
    public Task DeleteBooking(int Id);
}
