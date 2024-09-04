using First_Project.BLL.Interfaces;
using First_Project.DAL.Entities;

namespace First_Project.BLL.Services;

public class TourService : ITourService
{
    public Task CreateTour(string tourName, string description, string destination, string durstion, List<string> photo, int price, int rating, DateTime startdate, DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTour(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Tours>> GetTour()
    {
        throw new NotImplementedException();
    }
}
