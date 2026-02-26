namespace diadasemana
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
            this.lblNumeros = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.btnVerificardiasemana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumeros
            // 
            this.lblNumeros.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.Location = new System.Drawing.Point(156, 9);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(478, 59);
            this.lblNumeros.TabIndex = 0;
            this.lblNumeros.Text = "Convensor de Numeros Em Dias Semanais";
            // 
            // txtDia
            // 
            this.txtDia.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.Location = new System.Drawing.Point(265, 101);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(261, 30);
            this.txtDia.TabIndex = 1;
            this.txtDia.Text = "Insira o Dia da Semana";
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerificardiasemana
            // 
            this.btnVerificardiasemana.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificardiasemana.Location = new System.Drawing.Point(265, 148);
            this.btnVerificardiasemana.Name = "btnVerificardiasemana";
            this.btnVerificardiasemana.Size = new System.Drawing.Size(261, 31);
            this.btnVerificardiasemana.TabIndex = 2;
            this.btnVerificardiasemana.Text = "Verificar Dia da Semana";
            this.btnVerificardiasemana.UseVisualStyleBackColor = true;
            this.btnVerificardiasemana.Click += new System.EventHandler(this.btnVerificardiasemana_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 44);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificardiasemana);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblNumeros);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Button btnVerificardiasemana;
        private System.Windows.Forms.Label label1;
    }
}

