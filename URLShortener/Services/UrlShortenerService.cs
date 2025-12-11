namespace URLShortener.Services
{
    public static class UrlShortenerService
    {
        private static readonly HttpClient http = new HttpClient();

        public static async Task<string> ShortenUrl(string longUrl)
        {
            string requestUrl = $"https://is.gd/create.php?format=simple&url={System.Uri.EscapeDataString(longUrl)}";
            return await http.GetStringAsync(requestUrl);
        }
    }
}
