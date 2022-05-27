using System.Collections.Generic;

namespace AppDownload
{

    //Interface dos métodos de Download
    public interface IBaixar
    {
        public List<Imagem> Baixar(string arquivo, string destino);
        public bool FoiBaixado(string path, string linha);
        public void RealizarDownload(string base64, string linha, string path);
    }
}
