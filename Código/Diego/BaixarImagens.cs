using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AppDownload
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

                //UserAgent p mostrar quem fez a requisição para o site (para não suspeitar de bots)
                client.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla / 5.0(Windows NT 6.1; WOW64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 43.0.2357.134 Safari / 537.36");

                //Baixando o site que o google fornece, que vem "encriptado"
                var site = client.DownloadString($@"https://www.google.com/search?q= {linha}&tbm=isch");

                //verifica se possui X link 
                var existeLink = site.Contains("https://encrypted");

                //Pega o indíce do link 
                var indexURL = site.IndexOf("https://encrypted");

                //URL do link vai de indexURL, +110 
                var URLimagem = site.Substring(indexURL, 110);

                //Tenta baixar a imagem, se ocorrer QUALQUER ERRO, cai no catch
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
                //Só faz a lista de Não Baixados apenas se possuir imagens não baixadas 
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
            //Conexao com o WebClient
            using (var client = new WebClient())
            {
                //Baixa a imagem 
                client.DownloadFile(url, path + linha + ".png");

                //Verifica se a imagem foi baixada, se não foi adiciona na lista de nao baixados
                if (!FoiBaixado(path, linha)) ImagensNaoBaixadas.Add(linha);
            }
        }

        //Verifica se a imagem foi baixada
        public bool FoiBaixado(string path, string linha)
        {
            if (File.Exists(path + linha + ".png"))
            {
                //Criando um novo objeto Imagem
                var imagemBaixada = new Imagem(linha, path, DateTime.Now);

                //Adiciona na lista de imagens baixadas
                ImagensBaixadas.Add(imagemBaixada);
                return true;
            }
            else return false;
        }
    }
}
