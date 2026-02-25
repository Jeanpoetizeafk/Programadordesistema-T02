namespace Calcularidade
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
            this.label1 = new System.Windows.Forms.Label();
            this.AnoAtual = new System.Windows.Forms.Label();
            this.txtAnoNasc = new System.Windows.Forms.TextBox();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ano de Nascimento";
            // 
            // AnoAtual
            // 
            this.AnoAtual.AutoSize = true;
            this.AnoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnoAtual.ForeColor = System.Drawing.Color.White;
            this.AnoAtual.Location = new System.Drawing.Point(311, 185);
            this.AnoAtual.Name = "AnoAtual";
            this.AnoAtual.Size = new System.Drawing.Size(92, 24);
            this.AnoAtual.TabIndex = 1;
            this.AnoAtual.Text = "Ano Atual";
            // 
            // txtAnoNasc
            // 
            this.txtAnoNasc.Location = new System.Drawing.Point(280, 138);
            this.txtAnoNasc.Name = "txtAnoNasc";
            this.txtAnoNasc.Size = new System.Drawing.Size(154, 20);
            this.txtAnoNasc.TabIndex = 2;
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Location = new System.Drawing.Point(280, 222);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(154, 20);
            this.txtAnoAtual.TabIndex = 3;
            this.txtAnoAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoAtual_KeyPress);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(345, 264);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(24, 25);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "0";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtAnoAtual);
            this.Controls.Add(this.txtAnoNasc);
            this.Controls.Add(this.AnoAtual);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Calcular Idade";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AnoAtual;
        private System.Windows.Forms.TextBox txtAnoNasc;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.Label lblIdade;
    }
}

