using System;

namespace Diego
{
    public class Imagem
    {
        public string nomeImagem;
        public string caminho;
        public DateTime data;

        public Imagem()
        {

        }

        public Imagem(string nome, string destino, DateTime dataHora)
        {
            nomeImagem = nome;
            caminho = destino;
            data = dataHora;
        }
    }
}