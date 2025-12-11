namespace URLShortener.Models
{
    public class UrlEntry
    {
        public string? OriginalUrl { get; set; }
        public string? ShortUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
