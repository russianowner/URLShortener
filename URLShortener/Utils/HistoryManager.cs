using System.Text.Json;
using URLShortener.Models;

namespace URLShortener.Utils
{
    public static class HistoryManager
    {
        private const string FileName = "history.json";
        public static List<UrlEntry> Load()
        {
            if (!File.Exists(FileName)) return new List<UrlEntry>();
            string json = File.ReadAllText(FileName);
            return JsonSerializer.Deserialize<List<UrlEntry>>(json) ?? new List<UrlEntry>();
        }
        public static void Save(List<UrlEntry> history)
        {
            string json = JsonSerializer.Serialize(history, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FileName, json);
        }
    }
}
