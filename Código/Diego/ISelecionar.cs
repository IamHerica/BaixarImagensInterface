using System;

namespace AppDownload
{

    //Interface de cada ação dos botões da tela
    interface ISelecionar
    {
        public void button_baixar_Click(object sender, EventArgs e);
        public void button_destino_Click(object sender, EventArgs e);
        public void button_selecionar_Click(Object sender, EventArgs e);
        public void button_ocultar_Click(object sender, EventArgs e);
        public void button_mostrar_Click(object sender, EventArgs e);
    }
}
