using appDownload;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppDownload
{
    partial class Form_Baixar : Form, ISelecionar
    {
        private string _arquivo;
        tela_imagem tela;


        public Form_Baixar()
        {
            InitializeComponent();
            PesquisaImagem.Select();
        }

        public async void button_baixar_Click(object sender, EventArgs e)
        {
            if (_arquivo == null)
            {
                MessageBox.Show("Por favor, escreva alguma coisa no campo de pesquisa.");
                MessageBoxButtons.OK.Equals(_arquivo);
                return;
            }
            if (Application.OpenForms.OfType<tela_imagem>().Count() <= 0)
            {
                tela_imagem telaNova = new tela_imagem();
                tela = telaNova;
            }

            try
            {
                BaixarImagens download = new BaixarImagens();
                var imagem = await download.Baixar(_arquivo);
                tela.TelaImagem.Load(imagem);
                tela.TelaImagem.Visible = true;
                tela.Show();
                tela.ocultarImagem.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao mostrar a imagem.\n{ex.Message}");
                MessageBoxButtons.OK.Equals(ex.Message);
            }

        }

        private void PesquisaImagem_TextChanged(object sender, EventArgs e)
        {
            _arquivo = PesquisaImagem.Text;
        }
    }
}
