using First_Project.DAL.Entities;

namespace First_Project.BLL.Interfaces;

public interface ITourService
{
    public Task<List<Tours>> GetTour();
    public Task CreateTour(string tourName, string description, string destination,
        string durstion, List<string> photo, int price, int rating, DateTime startdate, DateTime endDate);
    public Task DeleteTour(int id);
}
