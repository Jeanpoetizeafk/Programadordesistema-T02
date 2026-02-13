namespace exibirnome
{
    partial class frmExibirNome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.bntExibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(144, 148);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(195, 38);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // bntExibir
            // 
            this.bntExibir.BackColor = System.Drawing.SystemColors.Desktop;
            this.bntExibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntExibir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExibir.ForeColor = System.Drawing.Color.Gold;
            this.bntExibir.Location = new System.Drawing.Point(144, 207);
            this.bntExibir.Name = "bntExibir";
            this.bntExibir.Size = new System.Drawing.Size(195, 43);
            this.bntExibir.TabIndex = 1;
            this.bntExibir.Text = "Exibir";
            this.bntExibir.UseVisualStyleBackColor = false;
            this.bntExibir.Click += new System.EventHandler(this.Exibir_Click);
            // 
            // frmExibirNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntExibir);
            this.Controls.Add(this.txtNome);
            this.Name = "frmExibirNome";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button bntExibir;
    }
}

