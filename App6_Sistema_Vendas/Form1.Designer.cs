namespace App6_Sistema_Vendas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomeProdutoTxt = new System.Windows.Forms.TextBox();
            this.precoProdutoTxt = new System.Windows.Forms.TextBox();
            this.qntdProdutoTxt = new System.Windows.Forms.TextBox();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.sairBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.sairBtn);
            this.panel1.Controls.Add(this.limparBtn);
            this.panel1.Controls.Add(this.cadastrarBtn);
            this.panel1.Controls.Add(this.qntdProdutoTxt);
            this.panel1.Controls.Add(this.precoProdutoTxt);
            this.panel1.Controls.Add(this.nomeProdutoTxt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 464);
            this.panel1.TabIndex = 0;
            // 
            // nomeProdutoTxt
            // 
            this.nomeProdutoTxt.Location = new System.Drawing.Point(3, 50);
            this.nomeProdutoTxt.Name = "nomeProdutoTxt";
            this.nomeProdutoTxt.Size = new System.Drawing.Size(306, 20);
            this.nomeProdutoTxt.TabIndex = 0;
            // 
            // precoProdutoTxt
            // 
            this.precoProdutoTxt.Location = new System.Drawing.Point(3, 122);
            this.precoProdutoTxt.Name = "precoProdutoTxt";
            this.precoProdutoTxt.Size = new System.Drawing.Size(306, 20);
            this.precoProdutoTxt.TabIndex = 1;
            // 
            // qntdProdutoTxt
            // 
            this.qntdProdutoTxt.Location = new System.Drawing.Point(4, 202);
            this.qntdProdutoTxt.Name = "qntdProdutoTxt";
            this.qntdProdutoTxt.Size = new System.Drawing.Size(305, 20);
            this.qntdProdutoTxt.TabIndex = 2;
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.BackColor = System.Drawing.SystemColors.Window;
            this.cadastrarBtn.Location = new System.Drawing.Point(4, 285);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(75, 23);
            this.cadastrarBtn.TabIndex = 3;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = false;
            this.cadastrarBtn.Click += new System.EventHandler(this.CadastrarBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.BackColor = System.Drawing.SystemColors.Window;
            this.limparBtn.Location = new System.Drawing.Point(116, 284);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 23);
            this.limparBtn.TabIndex = 4;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = false;
            // 
            // sairBtn
            // 
            this.sairBtn.BackColor = System.Drawing.SystemColors.Window;
            this.sairBtn.Location = new System.Drawing.Point(234, 285);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(75, 23);
            this.sairBtn.TabIndex = 5;
            this.sairBtn.Text = "Sair";
            this.sairBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(405, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 393);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Preço Unitário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantidade ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App6_Sistema_Vendas.Properties.Resources.shadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 488);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 527);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sairBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.TextBox qntdProdutoTxt;
        private System.Windows.Forms.TextBox precoProdutoTxt;
        private System.Windows.Forms.TextBox nomeProdutoTxt;
    }
}

