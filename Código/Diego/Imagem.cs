using System;

namespace AppDownload
{
    public class Imagem
    {
        public string nomeImagem;
        public string caminho;
        public DateTime data;

        public Imagem(string nome, string destino, DateTime dataHora)
        {
            nomeImagem = nome;
            caminho = destino;
            data = dataHora;
        }

        public override string ToString()
        {
            return $"Imagem {nomeImagem} no dia {data}";
        }
    }
}