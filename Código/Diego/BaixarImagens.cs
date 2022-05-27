using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Diego
{
    //Contrato com a interface
    public class BaixarImagens : IBaixar
    {
        List<Imagem> ImagensBaixadas = new List<Imagem>();
        List<string> ImagensNaoBaixadas = new List<string>();

        public List<Imagem> Baixar(string arquivo, string destino)
        {
            //Abrindo conexão, hide navegador e terminal (Selenium)
            //var driverService = EdgeDriverService.CreateDefaultService();
            //driverService.HideCommandPromptWindow = true;
            //EdgeOptions options = new EdgeOptions();
            //options.AddArgument("--headless");
            //var mozila = new EdgeDriver(driverService, options);

            //Destino das imagens já com a formatação para o windows reconhecer
            var path = @$"{destino}\";

            //Para cada linha do .txt, faça...
            foreach (string linha in File.ReadLines(arquivo))
            {
                //Pesquisando no google X imagem, usando filtro de imagem do próprio google (outro jeito)
                //mozila.Navigate().GoToUrl($@"https://www.google.com/search?q= {linha}&tbm=isch");

                //WebClient simplicado para mandar e receber 
                var client = new WebClient();

                //Baixando o site que o google fornece, que vem "encriptado"
                var site = client.DownloadString($@"https://www.google.com/search?q= {linha}&tbm=isch");

                //verifica se possui X link 
                var existeLink = site.Contains("https://encrypted");

                //Pega o indíce do link 
                var indexURL = site.IndexOf("https://encrypted");

                //URL do link vai de indexURL, +120 
                var URLimagem = site.Substring(indexURL, 120);
                

                try
                {
                    RealizarDownload(URLimagem, linha, path);
                }
                catch
                {
                    ImagensNaoBaixadas.Add(linha);
                }
            }

            if (ImagensNaoBaixadas.Count > 0)
            {
                //Só faz a lista de Não Baixados apenas se possuir
                var writer = new StreamWriter(@$"{destino}\ImagensNaoBaixados.txt");
                foreach (var item in ImagensNaoBaixadas)
                    writer.WriteLine(item);
            }
            else
            {
                MessageBox.Show("Todos as imagens foram baixadas com sucesso!");    
            }
            // mozila.Close();
            // mozila.Dispose();

            return ImagensBaixadas;
        }


        //O método que usa o link para realizar o download e colocar na pasta destino 
        public void RealizarDownload(string url, string linha, string path)
        {
            using (var client = new WebClient())
            {
                client.DownloadFileTaskAsync(url, path + linha + ".png");
                if (!FoiBaixado(path, linha)) ImagensNaoBaixadas.Add(linha);
                var imagemBaixada = new Imagem(linha, path, DateTime.Now);
                ImagensBaixadas.Add(imagemBaixada);
            }
        }

        //Verifica se foi baixado algum arquivo
        public bool FoiBaixado(string path, string linha)
        {
            if (File.Exists(path + linha + ".png"))
                return true;
            else
                return false;
        }
    }
}
