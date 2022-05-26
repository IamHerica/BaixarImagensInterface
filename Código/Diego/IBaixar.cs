using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego
{
    public interface IBaixar
    {
        public void Baixar(string arquivo, string destino);
        public bool FoiBaixado(string path, string linha);
        public void RealizarDownload(string base64, string linha, string path);
    }
}
