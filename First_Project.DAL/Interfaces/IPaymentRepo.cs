using First_Project.DAL.Entities;

namespace First_Project.DAL.Interfaces;

public interface IPaymentRepo
{
    public Task<List<Payments>> GetPayments();
    public Task CreatPayment(DateTime paymentDate, int amount, string paymentMethod, Bookings bookingId);
}
