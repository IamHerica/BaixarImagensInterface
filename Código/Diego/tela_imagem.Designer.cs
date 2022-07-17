namespace appDownload
{
    partial class tela_imagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_imagem));
            this.button_mostrarImagem = new System.Windows.Forms.Button();
            this.button_ocultar = new System.Windows.Forms.Button();
            this.localImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.localImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // button_mostrarImagem
            // 
            this.button_mostrarImagem.Location = new System.Drawing.Point(30, 366);
            this.button_mostrarImagem.Name = "button_mostrarImagem";
            this.button_mostrarImagem.Size = new System.Drawing.Size(143, 29);
            this.button_mostrarImagem.TabIndex = 0;
            this.button_mostrarImagem.Text = "Mostrar imagem";
            this.button_mostrarImagem.UseVisualStyleBackColor = true;
            this.button_mostrarImagem.Click += new System.EventHandler(this.button_mostrarImagem_Click);
            // 
            // button_ocultar
            // 
            this.button_ocultar.Location = new System.Drawing.Point(726, 366);
            this.button_ocultar.Name = "button_ocultar";
            this.button_ocultar.Size = new System.Drawing.Size(130, 29);
            this.button_ocultar.TabIndex = 1;
            this.button_ocultar.Text = "Ocultar imagem";
            this.button_ocultar.UseVisualStyleBackColor = true;
            this.button_ocultar.Click += new System.EventHandler(this.button_ocultar_Click);
            // 
            // localImagem
            // 
            this.localImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.localImagem.ImageLocation = "";
            this.localImagem.Location = new System.Drawing.Point(0, -1);
            this.localImagem.Name = "localImagem";
            this.localImagem.Size = new System.Drawing.Size(907, 349);
            this.localImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.localImagem.TabIndex = 2;
            this.localImagem.TabStop = false;
            this.localImagem.Click += new System.EventHandler(this.localImagem_Click);
            // 
            // tela_imagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(906, 431);
            this.ControlBox = false;
            this.Controls.Add(this.localImagem);
            this.Controls.Add(this.button_ocultar);
            this.Controls.Add(this.button_mostrarImagem);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tela_imagem";
            this.Text = "Aqui está sua imagem";
            this.Load += new System.EventHandler(this.tela_imagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_mostrarImagem;
        private System.Windows.Forms.Button button_ocultar;
        private System.Windows.Forms.PictureBox localImagem;
    }
}