using First_Project.DAL.Entities;

namespace First_Project.DAL.Interfaces;

public interface ICustomerRepo
{
    public Task CreateCustomer(string name, string surname, string email, string phoneNumber,
        string userType);
}
