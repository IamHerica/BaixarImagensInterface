namespace Diego
{
    partial class Form_Baixar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Baixar));
            this.button_selecionar = new System.Windows.Forms.Button();
            this.button_destino = new System.Windows.Forms.Button();
            this.button_baixar = new System.Windows.Forms.Button();
            this.label_selecionar = new System.Windows.Forms.Label();
            this.label_destino = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_listaImagens = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_selecionar
            // 
            this.button_selecionar.BackColor = System.Drawing.Color.Transparent;
            this.button_selecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_selecionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_selecionar.Location = new System.Drawing.Point(409, 156);
            this.button_selecionar.Name = "button_selecionar";
            this.button_selecionar.Size = new System.Drawing.Size(168, 43);
            this.button_selecionar.TabIndex = 0;
            this.button_selecionar.Text = "Selecionar lista";
            this.button_selecionar.UseVisualStyleBackColor = false;
            this.button_selecionar.Click += new System.EventHandler(this.button_selecionar_Click);
            // 
            // button_destino
            // 
            this.button_destino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_destino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_destino.Location = new System.Drawing.Point(409, 220);
            this.button_destino.Name = "button_destino";
            this.button_destino.Size = new System.Drawing.Size(168, 43);
            this.button_destino.TabIndex = 1;
            this.button_destino.Text = "Selecionar destino";
            this.button_destino.UseVisualStyleBackColor = true;
            this.button_destino.Click += new System.EventHandler(this.button_destino_Click);
            // 
            // button_baixar
            // 
            this.button_baixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_baixar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_baixar.Location = new System.Drawing.Point(409, 279);
            this.button_baixar.Name = "button_baixar";
            this.button_baixar.Size = new System.Drawing.Size(168, 43);
            this.button_baixar.TabIndex = 2;
            this.button_baixar.Text = "Baixar imagens";
            this.button_baixar.UseVisualStyleBackColor = true;
            this.button_baixar.Click += new System.EventHandler(this.button_baixar_Click);
            // 
            // label_selecionar
            // 
            this.label_selecionar.AutoSize = true;
            this.label_selecionar.BackColor = System.Drawing.Color.Transparent;
            this.label_selecionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_selecionar.Location = new System.Drawing.Point(3, 149);
            this.label_selecionar.Name = "label_selecionar";
            this.label_selecionar.Size = new System.Drawing.Size(226, 20);
            this.label_selecionar.TabIndex = 3;
            this.label_selecionar.Text = "1 - Selecione a lista de imagens\r\n";
            // 
            // label_destino
            // 
            this.label_destino.AutoSize = true;
            this.label_destino.BackColor = System.Drawing.Color.Transparent;
            this.label_destino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_destino.Location = new System.Drawing.Point(3, 216);
            this.label_destino.Name = "label_destino";
            this.label_destino.Size = new System.Drawing.Size(257, 20);
            this.label_destino.TabIndex = 4;
            this.label_destino.Text = "2 - Selecione o destino das imagens";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "3 - Clique em baixar para iniciar o download";
            // 
            // label_listaImagens
            // 
            this.label_listaImagens.AutoSize = true;
            this.label_listaImagens.BackColor = System.Drawing.Color.Transparent;
            this.label_listaImagens.Location = new System.Drawing.Point(19, 263);
            this.label_listaImagens.Name = "label_listaImagens";
            this.label_listaImagens.Size = new System.Drawing.Size(12, 20);
            this.label_listaImagens.TabIndex = 7;
            this.label_listaImagens.Text = ".";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(140)))), ((int)(((byte)(32)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(19, 434);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(528, 280);
            this.listBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(140)))), ((int)(((byte)(32)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Imagens Baixadas:";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form_Baixar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(589, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_listaImagens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_destino);
            this.Controls.Add(this.label_selecionar);
            this.Controls.Add(this.button_baixar);
            this.Controls.Add(this.button_destino);
            this.Controls.Add(this.button_selecionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Baixar";
            this.Text = "Baixar imagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_selecionar;
        private System.Windows.Forms.Button button_destino;
        private System.Windows.Forms.Button button_baixar;
        private System.Windows.Forms.Label label_selecionar;
        private System.Windows.Forms.Label label_destino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_listaImagens;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}
