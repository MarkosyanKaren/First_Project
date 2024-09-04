using First_Project.DAL.Entities;
using First_Project.DAL.Interfaces;

namespace First_Project.DAL.Repositories;

public class PaymentRepo : IPaymentRepo
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
