using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _211090_211092
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total, selecao, valor_total;

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_Empresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_Empresa.RowCount > 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dgv_Empresa.CurrentRow.Cells[0].Value) == false)
                {
                    dgv_Empresa.CurrentRow.Cells[0].Value = true;
                    selecao += Convert.ToDouble(dgv_Empresa.CurrentRow.Cells[3].Value);
                }
                else
                {
                    dgv_Empresa.CurrentRow.Cells[0].Value = false;
                    selecao -= Convert.ToDouble(dgv_Empresa.CurrentRow.Cells[3].Value);
                }
              
            }

        }

        private void btn_Desmarcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dgv_Empresa.Rows)
                linha.Cells[0].Value = false;
       

        }

        private void btn_Marcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dgv_Empresa.Rows)
            {
                linha.Cells[0].Value = true;
                selecao += Convert.ToDouble(linha.Cells[3].Value);
            }
            
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {

            if (dgv_Empresa.Rows.Count > 0)
            {
                dgv_Empresa.Rows.RemoveAt(dgv_Empresa.CurrentCell.RowIndex);

                MessageBox.Show("Produto Excluido com Sucesso!!", "Exclusão",

                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                lbl_Total.Text = dgv_Empresa.RowCount.ToString();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_Empresa.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgv_Empresa.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgv_Empresa.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgv_Empresa.Columns.Insert(3, new DataGridViewTextBoxColumn());
            dgv_Empresa.Columns.Insert(4, new DataGridViewTextBoxColumn());
            dgv_Empresa.Columns.Insert(5, new DataGridViewTextBoxColumn());
      


            dgv_Empresa.Columns[0].Name = "ID";
            dgv_Empresa.Columns[1].Name = "CODIGO DE BARRAS";
            dgv_Empresa.Columns[2].Name = "PRODUTO";
            dgv_Empresa.Columns[3].Name = "VALOR COMPRA";
            dgv_Empresa.Columns[4].Name = "VALOR VENDA";
            dgv_Empresa.Columns[5].Name = "ESTOQUE";


            dgv_Empresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_Empresa.ReadOnly = true;
            dgv_Empresa.AllowUserToAddRows = false;
            dgv_Empresa.AllowUserToDeleteRows = false;
            dgv_Empresa.AllowUserToOrderColumns = true;

            dgv_Empresa.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_Empresa.Columns[3].DefaultCellStyle.Format = "###,###,##0.00";

            dgv_Empresa.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_Empresa.Columns[4].DefaultCellStyle.Format = "###,###,##0.00";
        }

        private void btn_Importar_Click(object sender, EventArgs e)
        {
            dgv_Empresa.RowCount = 0;

            ofd_Arquivo.FileName = "";
            ofd_Arquivo.ShowDialog();

            StreamReader arquivo = File.OpenText(ofd_Arquivo.FileName);

            String linha;
            while ((linha = arquivo.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                string codigo = dados[0];
                string estoque = dados[4];
                string descricao = dados[1];
        
                double valor_venda = double.Parse(dados[2]);
                double valor_compra= double.Parse(dados[3]);
                double valor_total = double.Parse(dados[2]);
               


                dgv_Empresa.Rows.Add(false, codigo, descricao, valor_venda, valor_compra, estoque);
                total += valor_total = valor_compra - valor_venda;
            }
            lbl_Total.Text = total.ToString("C");
        }

    }
}

