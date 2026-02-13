namespace alertas
{
    partial class Alertas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtmalertaSimples = new System.Windows.Forms.Button();
            this.btmAlertaRobusto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(54, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(309, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Teste de alertas abaixos";
            // 
            // BtmalertaSimples
            // 
            this.BtmalertaSimples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(103)))), ((int)(((byte)(86)))));
            this.BtmalertaSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmalertaSimples.ForeColor = System.Drawing.Color.White;
            this.BtmalertaSimples.Location = new System.Drawing.Point(124, 94);
            this.BtmalertaSimples.Name = "BtmalertaSimples";
            this.BtmalertaSimples.Size = new System.Drawing.Size(149, 44);
            this.BtmalertaSimples.TabIndex = 1;
            this.BtmalertaSimples.Text = "Alerta Simples";
            this.BtmalertaSimples.UseVisualStyleBackColor = false;
            this.BtmalertaSimples.Click += new System.EventHandler(this.BtmalertaSimples_Click);
            // 
            // btmAlertaRobusto
            // 
            this.btmAlertaRobusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btmAlertaRobusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmAlertaRobusto.FlatAppearance.BorderSize = 0;
            this.btmAlertaRobusto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btmAlertaRobusto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAlertaRobusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btmAlertaRobusto.Location = new System.Drawing.Point(124, 209);
            this.btmAlertaRobusto.Name = "btmAlertaRobusto";
            this.btmAlertaRobusto.Size = new System.Drawing.Size(149, 34);
            this.btmAlertaRobusto.TabIndex = 2;
            this.btmAlertaRobusto.Text = "Alerta Robusto";
            this.btmAlertaRobusto.UseVisualStyleBackColor = false;
            this.btmAlertaRobusto.Click += new System.EventHandler(this.btmAlertaRobusto_Click);
            // 
            // Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmAlertaRobusto);
            this.Controls.Add(this.BtmalertaSimples);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Alertas";
            this.Text = "Alertas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtmalertaSimples;
        private System.Windows.Forms.Button btmAlertaRobusto;
    }
}

