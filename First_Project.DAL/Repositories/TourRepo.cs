using First_Project.DAL.Entities;
using First_Project.DAL.Interfaces;

namespace First_Project.DAL.Repositories;

public class TourRepo : ITourRepo
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
