using NBA_Teams.Models;
using Newtonsoft.Json;

namespace NBA_Teams.Database
{
    public static class NBAdatabase
    {
        public static string _filePath = @"Teams\TeamsDb.json";
        public static List<Team> Teams()
        {
            using (StreamReader sr = new StreamReader(_filePath))
            {
                string content = sr.ReadToEnd();
                List<Team> result = JsonConvert.DeserializeObject<List<Team>>(content);

                return result ?? new List<Team>();
            }
        }

        

    }
}
