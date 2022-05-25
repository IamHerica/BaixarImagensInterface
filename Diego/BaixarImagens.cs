using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

            var driverService = EdgeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            EdgeOptions options = new EdgeOptions();
            options.AddArgument("--headless");
            var mozila = new EdgeDriver(driverService, options);
            var AtivosNaoBaixados = new List<string>();

            foreach (string linha in File.ReadLines(arquivo))
            {
                try
                {
                    mozila.Navigate().GoToUrl($@"https://www.google.com/search?q= {linha}&tbm=isch");
                    var image = mozila.FindElements(By.TagName("img"));
                    var imageURL = image[3].GetAttribute("src");
                    var path = @$"{destino}\";
                    if (imageURL.Contains("data:image/png;base64"))
                        RealizarDownload(imageURL.Remove(0, 22), linha, path);
                    else if (imageURL.Contains("data:image/jpeg;base64,"))
                        RealizarDownload(imageURL.Remove(0, 23), linha, path);

                    if (FoiBaixado(path, linha)) AtivosNaoBaixados.Add(linha);
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

        public void RealizarDownload(string base64, string linha, string path)
        {
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64));
            Bitmap bmp = new Bitmap(ms);
            bmp.Save(@path + $"{linha}.jpeg", ImageFormat.Jpeg);
        }

        public bool FoiBaixado(string path, string linha)
        {
            if (File.Exists(path + linha))
                return true;
            else
                return false;
        }

       
    }
}
