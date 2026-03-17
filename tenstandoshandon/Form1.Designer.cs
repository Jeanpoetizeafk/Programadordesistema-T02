namespace Testando_showhide
{
    partial class frmShowHide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowHide));
            this.btnMostrarLogo = new System.Windows.Forms.Button();
            this.pbLogoTipo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarLogo
            // 
            this.btnMostrarLogo.Location = new System.Drawing.Point(905, 456);
            this.btnMostrarLogo.Name = "btnMostrarLogo";
            this.btnMostrarLogo.Size = new System.Drawing.Size(164, 87);
            this.btnMostrarLogo.TabIndex = 1;
            this.btnMostrarLogo.Text = "Clique";
            this.btnMostrarLogo.UseVisualStyleBackColor = true;
            this.btnMostrarLogo.Click += new System.EventHandler(this.btnMostrarLogo_Click);
            // 
            // pbLogoTipo
            // 
            this.pbLogoTipo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoTipo.Image")));
            this.pbLogoTipo.Location = new System.Drawing.Point(816, 181);
            this.pbLogoTipo.Name = "pbLogoTipo";
            this.pbLogoTipo.Size = new System.Drawing.Size(344, 243);
            this.pbLogoTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoTipo.TabIndex = 0;
            this.pbLogoTipo.TabStop = false;
            this.pbLogoTipo.Click += new System.EventHandler(this.pbLogoTipo_Click);
            // 
            // frmShowHide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.btnMostrarLogo);
            this.Controls.Add(this.pbLogoTipo);
            this.Location = new System.Drawing.Point(816, 181);
            this.Name = "frmShowHide";
            this.Text = "Show e Hide Control";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogoTipo;
        private System.Windows.Forms.Button btnMostrarLogo;
    }
}

