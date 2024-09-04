using First_Project.BLL.Interfaces;
using First_Project.DAL.Entities;

namespace First_Project.BLL.Services;

public class PaymentService : IPaymentService
{
    public Task CreatPayment(DateTime paymentDate, int amount, string paymentMethod, Bookings bookingId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Payments>> GetPayments()
    {
        throw new NotImplementedException();
    }
}
