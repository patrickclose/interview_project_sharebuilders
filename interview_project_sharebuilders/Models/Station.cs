namespace interview_project_sharebuilders.Models
{
    public class Station
    {
        public string? CallLetters { get; set; }
        public string? Market { get; set; }
        public string? Affiliation { get; set; }

        public Station(string callLetters, string market, string affiliation)
        {
            CallLetters = callLetters;
            Market = market;
            Affiliation = affiliation;
        }
    }

}
