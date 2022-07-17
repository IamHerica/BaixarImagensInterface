namespace AppDownload
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

        //arquivo auto gerado
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Baixar));
            this.button_baixar = new System.Windows.Forms.Button();
            this.pesquisaImagem = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_baixar
            // 
            this.button_baixar.BackColor = System.Drawing.Color.Transparent;
            this.button_baixar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_baixar.BackgroundImage")));
            this.button_baixar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_baixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_baixar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_baixar.Location = new System.Drawing.Point(755, 251);
            this.button_baixar.Margin = new System.Windows.Forms.Padding(0);
            this.button_baixar.Name = "button_baixar";
            this.button_baixar.Size = new System.Drawing.Size(103, 45);
            this.button_baixar.TabIndex = 2;
            this.button_baixar.UseVisualStyleBackColor = false;
            this.button_baixar.Click += new System.EventHandler(this.button_baixar_Click);
            // 
            // pesquisaImagem
            // 
            this.pesquisaImagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pesquisaImagem.CausesValidation = false;
            this.pesquisaImagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pesquisaImagem.Location = new System.Drawing.Point(47, 263);
            this.pesquisaImagem.Multiline = false;
            this.pesquisaImagem.Name = "pesquisaImagem";
            this.pesquisaImagem.Size = new System.Drawing.Size(686, 28);
            this.pesquisaImagem.TabIndex = 12;
            this.pesquisaImagem.Text = "";
            this.pesquisaImagem.TextChanged += new System.EventHandler(this.pesquisaImagem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(549, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "S.I 2020";
            // 
            // Form_Baixar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(906, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pesquisaImagem);
            this.Controls.Add(this.button_baixar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_Baixar";
            this.Text = "Baixar imagens";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_baixar;
        private System.Windows.Forms.RichTextBox pesquisaImagem;
        private System.Windows.Forms.Label label1;
    }
}
