using First_Project.BLL.Interfaces;

namespace First_Project.BLL.Services;

public class CustomerService : ICustomerService
{
    public Task CreateCustomer(string name, string surname, string email, string phoneNumber, 
        string userType)
    {
        throw new NotImplementedException();
    }
}
