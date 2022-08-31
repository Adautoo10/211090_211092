namespace _211090_211092
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
            this.btn_Importar = new System.Windows.Forms.Button();
            this.btn_Desmarcar = new System.Windows.Forms.Button();
            this.btn_Marcar = new System.Windows.Forms.Button();
            this.dgv_Empresa = new System.Windows.Forms.DataGridView();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.ofd_Arquivo = new System.Windows.Forms.OpenFileDialog();
            this.lbl_sfasf = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empresa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Importar
            // 
            this.btn_Importar.Location = new System.Drawing.Point(12, 12);
            this.btn_Importar.Name = "btn_Importar";
            this.btn_Importar.Size = new System.Drawing.Size(145, 47);
            this.btn_Importar.TabIndex = 0;
            this.btn_Importar.Text = "Importar Arquivo";
            this.btn_Importar.UseVisualStyleBackColor = true;
            this.btn_Importar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // btn_Desmarcar
            // 
            this.btn_Desmarcar.Location = new System.Drawing.Point(1152, 12);
            this.btn_Desmarcar.Name = "btn_Desmarcar";
            this.btn_Desmarcar.Size = new System.Drawing.Size(145, 47);
            this.btn_Desmarcar.TabIndex = 1;
            this.btn_Desmarcar.Text = "Desmarcar Todos";
            this.btn_Desmarcar.UseVisualStyleBackColor = true;
            this.btn_Desmarcar.Click += new System.EventHandler(this.btn_Desmarcar_Click);
            // 
            // btn_Marcar
            // 
            this.btn_Marcar.Location = new System.Drawing.Point(934, 12);
            this.btn_Marcar.Name = "btn_Marcar";
            this.btn_Marcar.Size = new System.Drawing.Size(145, 47);
            this.btn_Marcar.TabIndex = 2;
            this.btn_Marcar.Text = "Marcar todos";
            this.btn_Marcar.UseVisualStyleBackColor = true;
            this.btn_Marcar.Click += new System.EventHandler(this.btn_Marcar_Click);
            // 
            // dgv_Empresa
            // 
            this.dgv_Empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empresa.Location = new System.Drawing.Point(12, 75);
            this.dgv_Empresa.Name = "dgv_Empresa";
            this.dgv_Empresa.Size = new System.Drawing.Size(1285, 351);
            this.dgv_Empresa.TabIndex = 3;
            this.dgv_Empresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Empresa_CellContentClick);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(1152, 474);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(145, 47);
            this.btn_Fechar.TabIndex = 4;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(977, 474);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(145, 47);
            this.btn_Remover.TabIndex = 5;
            this.btn_Remover.Text = "Remover Produto";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // ofd_Arquivo
            // 
            this.ofd_Arquivo.FileName = "openFileDialog1";
            // 
            // lbl_sfasf
            // 
            this.lbl_sfasf.AutoSize = true;
            this.lbl_sfasf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sfasf.Location = new System.Drawing.Point(12, 491);
            this.lbl_sfasf.Name = "lbl_sfasf";
            this.lbl_sfasf.Size = new System.Drawing.Size(88, 16);
            this.lbl_sfasf.TabIndex = 6;
            this.lbl_sfasf.Text = "Valor Total:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Total.Location = new System.Drawing.Point(120, 483);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(71, 31);
            this.lbl_Total.TabIndex = 7;
            this.lbl_Total.Text = "0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 547);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_sfasf);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.dgv_Empresa);
            this.Controls.Add(this.btn_Marcar);
            this.Controls.Add(this.btn_Desmarcar);
            this.Controls.Add(this.btn_Importar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Importar;
        private System.Windows.Forms.Button btn_Desmarcar;
        private System.Windows.Forms.Button btn_Marcar;
        private System.Windows.Forms.DataGridView dgv_Empresa;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.OpenFileDialog ofd_Arquivo;
        private System.Windows.Forms.Label lbl_sfasf;
        private System.Windows.Forms.Label lbl_Total;
    }
}

