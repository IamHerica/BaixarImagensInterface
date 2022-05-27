using System;
using System.Windows.Forms;

namespace AppDownload
{
    partial class Form_Baixar : Form, ISelecionar //o form baixar ta herdando form e ISelecionar, is é um contrato que os botoes vao implementar os metodos
    {
        //atributos globais
        /* essas variaveis globais vao passar pra outros métodos */
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
            /* o bloco using vai selecionar o arquivo e despachar oq tiver na memória se tiver alguma coisa, e por isso usamos ele */

            using (OpenFileDialog abrirTxt = new OpenFileDialog())  //definindo atributos do componente
            {
                //Configurações de filtros 
                abrirTxt.Title = "Selecione a lista de imagens";    //titulo da janela onde vc vai selecionar o txt
                abrirTxt.CheckFileExists = true;                    //aqui ele vai checar se existe a file txt 
                abrirTxt.CheckPathExists = true;                    //aqui ele vai checar se existe a pasta
                abrirTxt.DefaultExt = "txt";                        //padrozinando que txt
                abrirTxt.Filter = "txt files (*.txt)|*.txt";        //aqui ele so vai mostrar arquivos txt
                abrirTxt.ReadOnlyChecked = true;                    //definindo que o txt é apenas para leitura para utilização no código

                //Abre a janela de seleção do windows

                if (abrirTxt.ShowDialog() == DialogResult.OK)     //vai abrir a janela de seleção  
                    MessageBox.Show($"O arquivo {abrirTxt.FileName} foi selecionado."); //se selecionar um arquivo txt, da a mensagem de tudo certo
                else
                    MessageBox.Show("Alguma coisa deu errado."); //se nao, algo deu errado

                //Importante essa atribuição global pois será passado como parametro futuramente 

                _arquivo = abrirTxt.FileName;  //atribuo esse variavel local na global pra usar em outros metodos
                                               //ela pega o nome do arquivo que selecionei 
            }
        }

        //Método do disparo do botão selecionar pasta
        public void button_destino_Click(object sender, EventArgs e) //pegar a url de destino de onde vao ser salvo as minhas imagens 
        {
            //Componente de seleção de pasta
            using (var abrirDestino = new FolderBrowserDialog())    //ele verifica se abriu o arquivo, se nao tem espaço, faz verificações e etc
            {
                if (abrirDestino.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(abrirDestino.SelectedPath))
                    MessageBox.Show($"O arquivo {abrirDestino.SelectedPath} foi selecionado."); //se selecionar uma pasta, da a mensagem de tudo certo
                else
                    MessageBox.Show("Alguma coisa deu errado."); //se nao selecionar uma pasta de destino, da a mensagem de erro

                //Importante essa atribuição global pois será passado como parametro futuramente 
                _destino = abrirDestino.SelectedPath; //salva o caminho da pasta de onde vou salvar as imagens
            }
        }

        //Método do disparo do botão baixar imagens
        public void button_baixar_Click(object sender, EventArgs e) //chamando o baixar imagens
        {
            //Criando um novo objeto que no caso é uma nova instancia #
            BaixarImagens download = new BaixarImagens();

            var imagem = download.Baixar(_arquivo, _destino); //passando as variaveis globais pro meu método
                                                              //e estou recebendo uma lista das imagens baixadas pra apresentar na minha interface (lisbox)

            //Agora que baixou, deixa o botão de mostrar o que foi baixado visivel
            button_mostrarImagens.Visible = true; //transformo o botao mostrar imagens baixadas visiveis

            //Imprime no ListBox o que foi baixado atraves de sobre escreita #
            foreach (var i in imagem)
            {
                listBoxImagensBaixadas.Items.Add(i.ToString());
            }
        }

        //Método do botao mostrar, que só aparece depois que as imagens foram baixadas
        public void button_mostrar_Click(object sender, EventArgs e)
        {
            label_imagensBaixadas.Visible = true;   //vai mostrar o titulo "imagens baixadas"
            listBoxImagensBaixadas.Visible = true;  //vai mostrar a listBox doq foi baixado
            button_ocultar.Visible = true;          //vai mostrar o botao ocultar apos mostrar a listBox
        }

        //Método do botao que oculta o nome das imagens 
        public void button_ocultar_Click(object sender, EventArgs e)
        {
            label_imagensBaixadas.Visible = false;      //vai ocultar o titulo "imagens baixadas"
            listBoxImagensBaixadas.Visible = false;     //vai ocultar a listBox
            button_ocultar.Visible = false;             //vai ocultar o botao ocultar ate que o clique novamente para mostrar a listbox
        }

    }
}
