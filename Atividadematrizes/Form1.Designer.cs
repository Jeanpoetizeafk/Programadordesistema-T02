namespace Atividadematrizes
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
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnPreencher = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(76, 72);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(451, 200);
            this.dgvMatriz.TabIndex = 0;
            // 
            // btnPreencher
            // 
            this.btnPreencher.Location = new System.Drawing.Point(76, 298);
            this.btnPreencher.Name = "btnPreencher";
            this.btnPreencher.Size = new System.Drawing.Size(75, 23);
            this.btnPreencher.TabIndex = 1;
            this.btnPreencher.Text = "Preencher Matriz";
            this.btnPreencher.UseVisualStyleBackColor = true;
            this.btnPreencher.Click += new System.EventHandler(this.btnPreencher_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(211, 298);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "Somar Elementos";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 46);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(367, 23);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(131, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Tabela de soma de 3 colunas";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnPreencher);
            this.Controls.Add(this.dgvMatriz);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnPreencher;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

