using appDownload;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppDownload
{
    partial class Form_Baixar : Form, ISelecionar 
    {
        private string _arquivo; 
        tela_imagem tela = new tela_imagem();
       
        public Form_Baixar()
        {
            InitializeComponent();
            
        }

        public void button_baixar_Click(object sender, EventArgs e) 
        {
            BaixarImagens download = new BaixarImagens();
            var imagem = download.Baixar(_arquivo); 
            tela.TelaImagem.Load(imagem);
            tela.Show();
            tela.ocultarImagem.Visible = true;
        }

        private void pesquisaImagem_TextChanged(object sender, EventArgs e)
        {
            _arquivo = pesquisaImagem.Text;
        }
    }
}
