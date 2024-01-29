using interview_project_sharebuilders.Models;

namespace interview_project_sharebuilders.Services
{
    public interface IStationService
    {
        Task<List<Station>> GetStationsAsync();
    }
}
