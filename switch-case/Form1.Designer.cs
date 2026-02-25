namespace switch_case
{
    partial class Frmswitch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblDescriacao = new System.Windows.Forms.Label();
            this.txtCodigoinserido = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.lblDescriacao);
            this.panel1.Controls.Add(this.txtCodigoinserido);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnEnviar.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Moccasin;
            this.btnEnviar.Location = new System.Drawing.Point(199, 270);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(89, 34);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEnviar_MouseClick);
            // 
            // lblDescriacao
            // 
            this.lblDescriacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescriacao.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriacao.Location = new System.Drawing.Point(177, 225);
            this.lblDescriacao.Name = "lblDescriacao";
            this.lblDescriacao.Size = new System.Drawing.Size(137, 23);
            this.lblDescriacao.TabIndex = 2;
            this.lblDescriacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoinserido
            // 
            this.txtCodigoinserido.BackColor = System.Drawing.Color.Moccasin;
            this.txtCodigoinserido.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoinserido.Location = new System.Drawing.Point(193, 170);
            this.txtCodigoinserido.Name = "txtCodigoinserido";
            this.txtCodigoinserido.Size = new System.Drawing.Size(100, 33);
            this.txtCodigoinserido.TabIndex = 1;
            this.txtCodigoinserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Moccasin;
            this.lblTitulo.Location = new System.Drawing.Point(112, 123);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Insira o codigo de 1 a 6";
            // 
            // Frmswitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Frmswitch";
            this.Text = "CondicionalSwitch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCodigoinserido;
        private System.Windows.Forms.Label lblDescriacao;
        private System.Windows.Forms.Button btnEnviar;
    }
}

