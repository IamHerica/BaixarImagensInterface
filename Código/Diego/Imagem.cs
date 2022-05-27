using System;

namespace AppDownload
{
    public class Imagem
    {
        public string nomeImagem { get; set; }
        public string caminho { get; set; }
        public DateTime data { get; set; }

        public Imagem(string nome, string destino, DateTime dataHora)
        {
            nomeImagem = nome;
            caminho = destino;
            data = dataHora;
        }

        //Sobreescrita do método ToString()
        public override string ToString()
        {
            return $"Downlaod de {nomeImagem} feito no dia {data}";
        }
    }
}