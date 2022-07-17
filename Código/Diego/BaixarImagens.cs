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
        public string Baixar(string arquivo)
        {
            //Abrindo conexão, hide navegador e terminal (Selenium)
            //var driverService = EdgeDriverService.CreateDefaultService();
            //driverService.HideCommandPromptWindow = true;
            //EdgeOptions options = new EdgeOptions();
            //options.AddArgument("--headless");
            //var mozila = new EdgeDriver(driverService, options);

            //Pesquisando no google X imagem, usando filtro de imagem do próprio google (outro jeito)
            //mozila.Navigate().GoToUrl($@"https://www.google.com/search?q= {linha}&tbm=isch");

            //WebClient simplicado para mandar e receber, criacao de objeto
            var client = new WebClient();

            //UserAgent p mostrar quem fez a requisição para o site (para não suspeitar de bots)
            client.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla / 5.0(Windows NT 6.1; WOW64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 43.0.2357.134 Safari / 537.36");

            //Baixando o site que o google fornece, que vem "encriptado"
            var site = client.DownloadString($@"https://www.google.com/search?q= {arquivo}&tbm=isch");

            //verifica se possui X link 
            var existeLink = site.Contains("https://encrypted");

            //Pega o indíce do link 
            var indexURL = site.IndexOf("https://encrypted");

            //URL do link vai de indexURL, +110 
            return site.Substring(indexURL, 110);

            //Tenta baixar a imagem, se ocorrer QUALQUER ERRO, cai no catch

            // mozila.Close();
            // mozila.Dispose();
        }
    }
}
