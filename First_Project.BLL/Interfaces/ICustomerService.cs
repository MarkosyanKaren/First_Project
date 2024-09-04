namespace First_Project.BLL.Interfaces;

public interface ICustomerService
{
    public Task CreateCustomer(string name, string surname, string email, string phoneNumber,
        string userType);
}
