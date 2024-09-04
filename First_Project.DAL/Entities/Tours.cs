namespace First_Project.DAL.Entities;

public class Tours
{
    public string Id { get; set; }
    public string TourName { get; set; }
    public string Description { get; set; }
    public string Destination { get; set; }
    public string Durstion { get; set; }
    public List<string> Photo { get; set; }
    public int Price { get; set; }
    public int Rating { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

}
