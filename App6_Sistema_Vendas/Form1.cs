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
        private List<Produto> produtos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            string nomeProduto = nomeProdutoTxt.Text;
            decimal precoProduto = Convert.ToDecimal(precoProdutoTxt.Text);
            int quantidadeProduto = Convert.ToInt32(qntdProdutoTxt.Text);

            if (!decimal.TryParse(precoProdutoTxt.Text, out precoProduto))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            Produto novoProduto = new Produto(nomeProduto, precoProduto, quantidadeProduto);
            
            produtos.Add(novoProduto);

            AtualizarExibicaoProdutos();

            nomeProdutoTxt.Text = "";
            precoProdutoTxt.Text = "";
            qntdProdutoTxt.Text = "";


        }

        private void  AtualizarExibicaoProdutos()
        {
            pnlProdutos.Controls.Clear();

            int yPosition = 10;
            foreach (var produto in produtos)
            {
                Label lblProduto = new Label
                {
                    Text = $"{produto.Nome} - R${produto.Preco:F2} - Quantidade: {produto.Quantidade} - Valor Total R${produto.ValorTotal:F2}",
                    Location = new Point(10, yPosition),
                    AutoSize = true
                };
                pnlProdutos.Controls.Add(lblProduto);
                yPosition += 25;
            }
        }

        private void LimparBtn_Click(object sender, EventArgs e)
        {
            produtos.Clear();
            AtualizarExibicaoProdutos();
        }

        private void SairBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por utilizar nosso Programa!");
            Close();
        }
    }

    public class Produto
    {
        public string Nome {get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }

        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            ValorTotal = preco * quantidade;

        }
    }
}

