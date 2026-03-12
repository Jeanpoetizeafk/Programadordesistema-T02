namespace picturebox
{
    partial class FrmPictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPictureBox));
            this.pbComputador = new System.Windows.Forms.PictureBox();
            this.pbCidade = new System.Windows.Forms.PictureBox();
            this.btnVerimagem = new System.Windows.Forms.Button();
            this.pbanexarImagem = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanexarImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComputador
            // 
            this.pbComputador.Image = ((System.Drawing.Image)(resources.GetObject("pbComputador.Image")));
            this.pbComputador.Location = new System.Drawing.Point(95, 42);
            this.pbComputador.Name = "pbComputador";
            this.pbComputador.Size = new System.Drawing.Size(257, 119);
            this.pbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComputador.TabIndex = 0;
            this.pbComputador.TabStop = false;
            // 
            // pbCidade
            // 
            this.pbCidade.Location = new System.Drawing.Point(95, 204);
            this.pbCidade.Name = "pbCidade";
            this.pbCidade.Size = new System.Drawing.Size(257, 128);
            this.pbCidade.TabIndex = 1;
            this.pbCidade.TabStop = false;
            // 
            // btnVerimagem
            // 
            this.btnVerimagem.BackColor = System.Drawing.Color.Maroon;
            this.btnVerimagem.ForeColor = System.Drawing.Color.Gold;
            this.btnVerimagem.Location = new System.Drawing.Point(172, 352);
            this.btnVerimagem.Name = "btnVerimagem";
            this.btnVerimagem.Size = new System.Drawing.Size(96, 36);
            this.btnVerimagem.TabIndex = 2;
            this.btnVerimagem.Text = "Ver Imagem";
            this.btnVerimagem.UseVisualStyleBackColor = false;
            this.btnVerimagem.Click += new System.EventHandler(this.btnVerimagem_Click);
            // 
            // pbanexarImagem
            // 
            this.pbanexarImagem.Location = new System.Drawing.Point(492, 25);
            this.pbanexarImagem.Name = "pbanexarImagem";
            this.pbanexarImagem.Size = new System.Drawing.Size(220, 285);
            this.pbanexarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbanexarImagem.TabIndex = 3;
            this.pbanexarImagem.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(492, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Anexar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbanexarImagem);
            this.Controls.Add(this.btnVerimagem);
            this.Controls.Add(this.pbCidade);
            this.Controls.Add(this.pbComputador);
            this.Name = "FrmPictureBox";
            this.Text = "Pìcture Box";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanexarImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbComputador;
        private System.Windows.Forms.PictureBox pbCidade;
        private System.Windows.Forms.Button btnVerimagem;
        private System.Windows.Forms.PictureBox pbanexarImagem;
        private System.Windows.Forms.Button button1;
    }
}

