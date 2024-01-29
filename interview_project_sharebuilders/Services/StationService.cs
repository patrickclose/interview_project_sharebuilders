using interview_project_sharebuilders.Models;

namespace interview_project_sharebuilders.Services
{
    public class StationService : IStationService
    {
        public Task<List<Station>> GetStationsAsync()
        {
            return Task.FromResult(new List<Station>
        {
            new Station("KTLA-TV", "Los Angeles", "CW"),
            new Station("KABC-TV", "Los Angeles", "ABC"),
            new Station("WABC-TV", "New York", "ABC"),
            new Station("KNBC", "Los Angeles", "NBC")
        });
        }
    }
}
