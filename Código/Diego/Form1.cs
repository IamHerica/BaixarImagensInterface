using System;
using System.Windows.Forms;

namespace AppDownload
{
    partial class Form_Baixar : Form, ISelecionar
    {
        //atributos globais
        private string _arquivo;
        private string _destino;

        //Inicializando o componente(tela)
        public Form_Baixar()
        {
            InitializeComponent();
        }

        //Método do disparo do botão selecionar arquivo
        public void button_selecionar_Click(object sender, EventArgs e)
        {
            //Componente para selecionar um arquivo
            using (OpenFileDialog abrirTxt = new OpenFileDialog())
            {
                //Configurações de filtros 
                abrirTxt.Title = "Selecione a lista de imagens";
                abrirTxt.CheckFileExists = true;
                abrirTxt.CheckPathExists = true;
                abrirTxt.DefaultExt = "txt";
                abrirTxt.Filter = "txt files (*.txt)|*.txt";
                abrirTxt.ReadOnlyChecked = true;

                //Abre a janela de seleção do windows
                if (abrirTxt.ShowDialog() == DialogResult.OK)
                    MessageBox.Show($"O arquivo {abrirTxt.FileName} foi selecionado.");
                else
                    MessageBox.Show("Alguma coisa deu errado.");

                //Importante essa atribuição global pois será passado como parametro futuramente 
                _arquivo = abrirTxt.FileName;
            }
        }

        //Método do disparo do botão selecionar pasta
        public void button_destino_Click(object sender, EventArgs e)
        {
            //Componente de seleção de pasta
            using (var abrirDestino = new FolderBrowserDialog())
            {
                if (abrirDestino.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(abrirDestino.SelectedPath))
                    MessageBox.Show($"O arquivo {abrirDestino.SelectedPath} foi selecionado.");
                else
                    MessageBox.Show("Alguma coisa deu errado.");

                //Importante essa atribuição global pois será passado como parametro futuramente 
                _destino = abrirDestino.SelectedPath;
            }
        }

        //Método do disparo do botão baixar imagens
        public void button_baixar_Click(object sender, EventArgs e)
        {
            //Criando um novo objeto/instancia
            BaixarImagens download = new BaixarImagens();
            var imagem = download.Baixar(_arquivo, _destino);

            //Agora que baixou, deixa o botão de mostrar o que foi baixado visivel
            button_mostrarImagens.Visible = true;

            //Imprime no ListBox o que foi baixado
            foreach (var i in imagem)
            {
                listBoxImagensBaixadas.Items.Add(i.ToString());
            }
        }

        //Método do botao mostrar, que só aparece depois que as imagens foram baixadas
        private void button_mostrar_Click(object sender, EventArgs e)
        {
            label_imagensBaixadas.Visible = true;
            listBoxImagensBaixadas.Visible = true;
            button_ocultar.Visible = true;
        }

        //Método do botao que oculta o nome das imagens 
        private void button_ocultar_Click(object sender, EventArgs e)
        {
            label_imagensBaixadas.Visible = false;
            listBoxImagensBaixadas.Visible = false;
            button_ocultar.Visible = false;
        }   
    }
}
