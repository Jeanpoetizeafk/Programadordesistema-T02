namespace QuantidadeDeEstoque
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(305, 90);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(229, 16);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Quabtidade em estoque Calças:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(342, 130);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(155, 22);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.Text = "Quantidade a Estoque";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(349, 176);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(140, 25);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar Estoque";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(349, 225);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(140, 51);
            this.lblResultado.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 477);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

