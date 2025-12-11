using URLShortener.Models;
using URLShortener.Services;
using URLShortener.Utils;

namespace URLShortener
{
    public partial class Form1 : Form
    {
        private List<UrlEntry> history;

        public Form1()
        {
            InitializeComponent();
            history = HistoryManager.Load();
            RefreshHistoryList();
        }
        private async void btnShorten_Click(object sender, EventArgs e)
        {
            string longUrl = txtLongUrl.Text.Trim();
            if (string.IsNullOrEmpty(longUrl)) return;
            try
            {
                string shortUrl = await UrlShortenerService.ShortenUrl(longUrl);
                txtShortUrl.Text = shortUrl;
                var entry = new UrlEntry
                {
                    OriginalUrl = longUrl,
                    ShortUrl = shortUrl,
                    CreatedAt = DateTime.Now
                };
                history.Add(entry);
                HistoryManager.Save(history);
                RefreshHistoryList();
            }
            catch { }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtShortUrl.Text))
                Clipboard.SetText(txtShortUrl.Text);
        }
        private void RefreshHistoryList()
        {
            lstHistory.Items.Clear();
            foreach (var item in history)
            {
                lstHistory.Items.Add($"{item.OriginalUrl} -> {item.ShortUrl}");
            }
        }
    }
}
