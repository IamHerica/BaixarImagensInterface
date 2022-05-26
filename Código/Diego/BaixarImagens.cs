using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Diego
{
    public class BaixarImagens : IBaixar
    {
        public void Baixar(string arquivo, string destino)
        {
            //var driverService = FirefoxDriverService.CreateDefaultService();
            //driverService.HideCommandPromptWindow = true;
            //FirefoxOptions options = new FirefoxOptions();
            //options.BrowserExecutableLocation = (@"C:\Program Files\Mozilla Firefox\firefox.exe");
            //options.AddArgument("--headless");
            //var mozila = new FirefoxDriver(driverService, options);
            //var AtivosNaoBaixados = new List<string>();

            var driverService = EdgeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            EdgeOptions options = new EdgeOptions();
            options.AddArgument("--headless");
            var mozila = new EdgeDriver(driverService, options);
            var AtivosNaoBaixados = new List<string>();
            var path = @$"{destino}\";

            foreach (string linha in File.ReadLines(arquivo))
            {
                mozila.Navigate().GoToUrl($@"https://www.google.com/search?q= {linha}&tbm=isch");
                var client = new WebClient();
                var site = client.DownloadString($@"https://www.google.com/search?q= {linha}&tbm=isch");
                var existeLink = site.Contains("https://encrypted");
                var indexURL = site.IndexOf("https://encrypted");
                var URLimagem = site.Substring(indexURL, 120);

                try
                {
                    RealizarDownload(URLimagem, linha, path);
                    if (!FoiBaixado(path, linha)) AtivosNaoBaixados.Add(linha);
                }
                catch
                {
                    AtivosNaoBaixados.Add(linha);
                }
            }

            if (AtivosNaoBaixados.Count > 0)
            {
                var writer = new StreamWriter(@$"{destino}\AtivosNaoBaixados.txt");
                foreach (var item in AtivosNaoBaixados)
                    writer.WriteLine(item);
            }
            else
            {
                MessageBox.Show("Todos as imagens foram baixadas com sucesso!");
            }
            mozila.Close();
            mozila.Dispose();
        }

        public async void RealizarDownload(string url, string linha, string path)
        {
            using (var client = new WebClient())
            {
                await client.DownloadFileTaskAsync(url, path + linha + ".png");
            }
        }

        public bool FoiBaixado(string path, string linha)
        {
            if (File.Exists(path + linha + ".png"))
                return true;
            else
                return false;
        }
    }
}
