using First_Project.DAL.Entities;

namespace First_Project.BLL.Interfaces;

public interface IPaymentService
{
    public Task<List<Payments>> GetPayments();
    public Task CreatPayment(DateTime paymentDate, int amount, string paymentMethod, Bookings bookingId);
}
