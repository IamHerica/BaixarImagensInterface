using System.Net;

namespace AppDownload
{
    public class BaixarImagens : IBaixar
    {
        public string Baixar(string arquivo)
        {
            var client = new WebClient();
            client.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla / 5.0(Windows NT 6.1; WOW64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 43.0.2357.134 Safari / 537.36");
            var site = client.DownloadString($@"https://www.google.com/search?q= {arquivo}&tbm=isch");
            var indexURL = site.IndexOf("https://encrypted");
            return site.Substring(indexURL, 110);
        }
    }
}
