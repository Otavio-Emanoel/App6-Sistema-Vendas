using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App6_Sistema_Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            string nomeProduto = nomeProdutoTxt.Text;
            double precoProduto = Convert.ToDouble(precoProdutoTxt.Text);
            int quantidadeProduto = Convert.ToInt32(qntdProdutoTxt.Text);

            double valorTotal = precoProduto * quantidadeProduto;

            MessageBox.Show(nomeProduto + "\n" + precoProduto + "\n" + quantidadeProduto + "\n" + valorTotal);

            string[] produtos = { };


        }
    }
}
