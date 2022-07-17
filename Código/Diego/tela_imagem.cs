using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDownload
{
    public partial class tela_imagem : Form
    {

        public Button ocultarImagem
        {
            get { return button_ocultar; }
            set { button_ocultar = value; }
        }

        public Button MostrarImagem
        {
            get { return button_mostrarImagem; }
            set { button_mostrarImagem = value; }
        }

        public PictureBox TelaImagem
        {
            get { return localImagem; }
            set { localImagem = value; }
        }
        public tela_imagem()
        {
            InitializeComponent();
        }

        private void tela_imagem_Load(object sender, EventArgs e)
        {
            MostrarImagem.Visible = false;
        }

        private void button_mostrarImagem_Click(object sender, EventArgs e)
        {
            localImagem.Visible = true;
            ocultarImagem.Visible = true;
            MostrarImagem.Visible = false;
        }

        private void button_ocultar_Click(object sender, EventArgs e)
        {
            localImagem.Visible = false;
            ocultarImagem.Visible = false;
            MostrarImagem.Visible = true;
        }

        private void localImagem_Click(object sender, EventArgs e)
        {

        }
    }
}
