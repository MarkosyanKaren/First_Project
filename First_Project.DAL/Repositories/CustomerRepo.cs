using First_Project.DAL.Interfaces;

namespace First_Project.DAL.Repositories;

public class CustomerRepo : ICustomerRepo
{
    public Task CreateCustomer(string name, string surname, string email, string phoneNumber, string userType)
    {
        throw new NotImplementedException();
    }
}
