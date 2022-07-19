using System.Threading.Tasks;

namespace AppDownload
{
    public interface IBaixar
    {
        public Task<string> Baixar(string arquivo);
    }
}
