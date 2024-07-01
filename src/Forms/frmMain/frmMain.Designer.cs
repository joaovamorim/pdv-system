namespace PDV
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuMain = new MenuStrip();
            menuCadastros = new ToolStripMenuItem();
            menuFuncionarios = new ToolStripMenuItem();
            menuClientes = new ToolStripMenuItem();
            menuUsuarios = new ToolStripMenuItem();
            menuCargos = new ToolStripMenuItem();
            menuFornecedor = new ToolStripMenuItem();
            menuProdutos = new ToolStripMenuItem();
            menu_Produto = new ToolStripMenuItem();
            menuEstoque = new ToolStripMenuItem();
            menuMovimentacoes = new ToolStripMenuItem();
            menuFluxoCaixa = new ToolStripMenuItem();
            menuLancVenda = new ToolStripMenuItem();
            menuEntradasSaidas = new ToolStripMenuItem();
            menuDespesas = new ToolStripMenuItem();
            menuRelatorio = new ToolStripMenuItem();
            menuRelProdutos = new ToolStripMenuItem();
            menuRelVendas = new ToolStripMenuItem();
            menuRelMovimentacoes = new ToolStripMenuItem();
            menuRelEntradasSaidas = new ToolStripMenuItem();
            menuRelDespesas = new ToolStripMenuItem();
            menuSair = new ToolStripMenuItem();
            image03 = new PictureBox();
            image02 = new PictureBox();
            image01 = new PictureBox();
            image04 = new PictureBox();
            menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image03).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image04).BeginInit();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { menuCadastros, menuProdutos, menuMovimentacoes, menuRelatorio, menuSair });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(800, 24);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            menuCadastros.DropDownItems.AddRange(new ToolStripItem[] { menuFuncionarios, menuClientes, menuUsuarios, menuCargos, menuFornecedor });
            menuCadastros.Name = "menuCadastros";
            menuCadastros.Size = new Size(71, 20);
            menuCadastros.Text = "Cadastros";
            // 
            // menuFuncionarios
            // 
            menuFuncionarios.Name = "menuFuncionarios";
            menuFuncionarios.Size = new Size(142, 22);
            menuFuncionarios.Text = "Funcionários";
            // 
            // menuClientes
            // 
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(142, 22);
            menuClientes.Text = "Clientes";
            // 
            // menuUsuarios
            // 
            menuUsuarios.Name = "menuUsuarios";
            menuUsuarios.Size = new Size(142, 22);
            menuUsuarios.Text = "Usuários";
            // 
            // menuCargos
            // 
            menuCargos.Name = "menuCargos";
            menuCargos.Size = new Size(142, 22);
            menuCargos.Text = "Cargos";
            // 
            // menuFornecedor
            // 
            menuFornecedor.Name = "menuFornecedor";
            menuFornecedor.Size = new Size(142, 22);
            menuFornecedor.Text = "Fornecedor";
            // 
            // menuProdutos
            // 
            menuProdutos.DropDownItems.AddRange(new ToolStripItem[] { menu_Produto, menuEstoque });
            menuProdutos.Name = "menuProdutos";
            menuProdutos.Size = new Size(67, 20);
            menuProdutos.Text = "Produtos";
            // 
            // menu_Produto
            // 
            menu_Produto.Name = "menu_Produto";
            menu_Produto.Size = new Size(117, 22);
            menu_Produto.Text = "Produto";
            // 
            // menuEstoque
            // 
            menuEstoque.Name = "menuEstoque";
            menuEstoque.Size = new Size(117, 22);
            menuEstoque.Text = "Estoque";
            // 
            // menuMovimentacoes
            // 
            menuMovimentacoes.DropDownItems.AddRange(new ToolStripItem[] { menuFluxoCaixa, menuLancVenda, menuEntradasSaidas, menuDespesas });
            menuMovimentacoes.Name = "menuMovimentacoes";
            menuMovimentacoes.Size = new Size(104, 20);
            menuMovimentacoes.Text = "Movimentações";
            // 
            // menuFluxoCaixa
            // 
            menuFluxoCaixa.Name = "menuFluxoCaixa";
            menuFluxoCaixa.Size = new Size(163, 22);
            menuFluxoCaixa.Text = "Fluxo Caixa";
            // 
            // menuLancVenda
            // 
            menuLancVenda.Name = "menuLancVenda";
            menuLancVenda.Size = new Size(163, 22);
            menuLancVenda.Text = "Lançar Venda";
            // 
            // menuEntradasSaidas
            // 
            menuEntradasSaidas.Name = "menuEntradasSaidas";
            menuEntradasSaidas.Size = new Size(163, 22);
            menuEntradasSaidas.Text = "Entradas / Saidas";
            // 
            // menuDespesas
            // 
            menuDespesas.Name = "menuDespesas";
            menuDespesas.Size = new Size(163, 22);
            menuDespesas.Text = "Despesas";
            // 
            // menuRelatorio
            // 
            menuRelatorio.DropDownItems.AddRange(new ToolStripItem[] { menuRelProdutos, menuRelVendas, menuRelMovimentacoes, menuRelEntradasSaidas, menuRelDespesas });
            menuRelatorio.Name = "menuRelatorio";
            menuRelatorio.Size = new Size(66, 20);
            menuRelatorio.Text = "Relatório";
            // 
            // menuRelProdutos
            // 
            menuRelProdutos.Name = "menuRelProdutos";
            menuRelProdutos.Size = new Size(163, 22);
            menuRelProdutos.Text = "Produtos";
            // 
            // menuRelVendas
            // 
            menuRelVendas.Name = "menuRelVendas";
            menuRelVendas.Size = new Size(163, 22);
            menuRelVendas.Text = "Vendas";
            // 
            // menuRelMovimentacoes
            // 
            menuRelMovimentacoes.Name = "menuRelMovimentacoes";
            menuRelMovimentacoes.Size = new Size(163, 22);
            menuRelMovimentacoes.Text = "Movimentações";
            // 
            // menuRelEntradasSaidas
            // 
            menuRelEntradasSaidas.Name = "menuRelEntradasSaidas";
            menuRelEntradasSaidas.Size = new Size(163, 22);
            menuRelEntradasSaidas.Text = "Entradas / Saidas";
            // 
            // menuRelDespesas
            // 
            menuRelDespesas.Name = "menuRelDespesas";
            menuRelDespesas.Size = new Size(163, 22);
            menuRelDespesas.Text = "Despesas";
            // 
            // menuSair
            // 
            menuSair.Name = "menuSair";
            menuSair.Size = new Size(38, 20);
            menuSair.Text = "Sair";
            // 
            // image03
            // 
            image03.Image = Properties.Resources.despesas1;
            image03.InitialImage = null;
            image03.Location = new Point(168, 270);
            image03.Name = "image03";
            image03.Size = new Size(200, 200);
            image03.SizeMode = PictureBoxSizeMode.Zoom;
            image03.TabIndex = 2;
            image03.TabStop = false;
            // 
            // image02
            // 
            image02.Image = Properties.Resources.circular_economy_6762714;
            image02.Location = new Point(391, 49);
            image02.Name = "image02";
            image02.Size = new Size(200, 200);
            image02.SizeMode = PictureBoxSizeMode.Zoom;
            image02.TabIndex = 3;
            image02.TabStop = false;
            // 
            // image01
            // 
            image01.Image = Properties.Resources.bank_check_4032790;
            image01.InitialImage = null;
            image01.Location = new Point(87, 49);
            image01.Name = "image01";
            image01.Size = new Size(200, 200);
            image01.SizeMode = PictureBoxSizeMode.Zoom;
            image01.TabIndex = 5;
            image01.TabStop = false;
            // 
            // image04
            // 
            image04.Image = Properties.Resources.fluxo_de_caixa;
            image04.InitialImage = null;
            image04.Location = new Point(479, 270);
            image04.Name = "image04";
            image04.Size = new Size(200, 200);
            image04.SizeMode = PictureBoxSizeMode.Zoom;
            image04.TabIndex = 6;
            image04.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 534);
            Controls.Add(image04);
            Controls.Add(image01);
            Controls.Add(image02);
            Controls.Add(image03);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "frmMain";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image03).EndInit();
            ((System.ComponentModel.ISupportInitialize)image02).EndInit();
            ((System.ComponentModel.ISupportInitialize)image01).EndInit();
            ((System.ComponentModel.ISupportInitialize)image04).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuMain;
        private ToolStripMenuItem menuCadastros;
        private ToolStripMenuItem menuProdutos;
        private ToolStripMenuItem menuMovimentacoes;
        private ToolStripMenuItem menuRelatorio;
        private ToolStripMenuItem menuSair;
        private PictureBox image03;
        private PictureBox image02;
        private PictureBox image01;
        private PictureBox image04;
        private ToolStripMenuItem menuFuncionarios;
        private ToolStripMenuItem menuClientes;
        private ToolStripMenuItem menuUsuarios;
        private ToolStripMenuItem menuCargos;
        private ToolStripMenuItem menuFornecedor;
        private ToolStripMenuItem menu_Produto;
        private ToolStripMenuItem menuEstoque;
        private ToolStripMenuItem menuFluxoCaixa;
        private ToolStripMenuItem menuLancVenda;
        private ToolStripMenuItem menuEntradasSaidas;
        private ToolStripMenuItem menuDespesas;
        private ToolStripMenuItem menuRelProdutos;
        private ToolStripMenuItem menuRelVendas;
        private ToolStripMenuItem menuRelMovimentacoes;
        private ToolStripMenuItem menuRelEntradasSaidas;
        private ToolStripMenuItem menuRelDespesas;
    }
}
