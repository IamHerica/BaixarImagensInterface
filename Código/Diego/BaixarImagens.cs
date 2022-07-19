using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDownload
{
    public class BaixarImagens : IBaixar
    {
        public async Task<string> Baixar(string arquivo)
        {
            try
            {
                var client = new WebClient();
                client.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla / 5.0(Windows NT 6.1; WOW64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 43.0.2357.134 Safari / 537.36");
                var site = client.DownloadString($@"https://www.google.com/search?q= {arquivo}&tbm=isch");
                var indexURL = site.IndexOf("https://encrypted");
                return site.Substring(indexURL, 110);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao baixar a imagem.\n{ex.Message}");
                return "";
            }
           
        }
    }
}
