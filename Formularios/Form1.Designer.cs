namespace MMEstacionamento
{
    partial class F_principal
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
            this.tab_principal = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaDeVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarApenasCarrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarApenasMotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_principal
            // 
            this.tab_principal.Location = new System.Drawing.Point(-2, 22);
            this.tab_principal.Name = "tab_principal";
            this.tab_principal.SelectedIndex = 0;
            this.tab_principal.Size = new System.Drawing.Size(865, 350);
            this.tab_principal.TabIndex = 0;
            this.tab_principal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tab_principal_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarVeículoToolStripMenuItem,
            this.saídaDeVeículoToolStripMenuItem,
            this.procurarVeículoToolStripMenuItem,
            this.listaDeVeículoToolStripMenuItem,
            this.listarApenasCarrosToolStripMenuItem,
            this.listarApenasMotosToolStripMenuItem,
            this.faturamentoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastrarVeículoToolStripMenuItem
            // 
            this.cadastrarVeículoToolStripMenuItem.Name = "cadastrarVeículoToolStripMenuItem";
            this.cadastrarVeículoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.cadastrarVeículoToolStripMenuItem.Text = "Cadastrar veículo";
            this.cadastrarVeículoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarVeículoToolStripMenuItem_Click);
            // 
            // saídaDeVeículoToolStripMenuItem
            // 
            this.saídaDeVeículoToolStripMenuItem.Name = "saídaDeVeículoToolStripMenuItem";
            this.saídaDeVeículoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saídaDeVeículoToolStripMenuItem.Text = "Saída de veículo";
            this.saídaDeVeículoToolStripMenuItem.Click += new System.EventHandler(this.saídaDeVeículoToolStripMenuItem_Click);
            // 
            // procurarVeículoToolStripMenuItem
            // 
            this.procurarVeículoToolStripMenuItem.Name = "procurarVeículoToolStripMenuItem";
            this.procurarVeículoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.procurarVeículoToolStripMenuItem.Text = "Procurar veículo";
            this.procurarVeículoToolStripMenuItem.Click += new System.EventHandler(this.procurarVeículoToolStripMenuItem_Click);
            // 
            // listaDeVeículoToolStripMenuItem
            // 
            this.listaDeVeículoToolStripMenuItem.Name = "listaDeVeículoToolStripMenuItem";
            this.listaDeVeículoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listaDeVeículoToolStripMenuItem.Text = "Lista de veículo";
            this.listaDeVeículoToolStripMenuItem.Click += new System.EventHandler(this.listaDeVeículoToolStripMenuItem_Click);
            // 
            // listarApenasCarrosToolStripMenuItem
            // 
            this.listarApenasCarrosToolStripMenuItem.Name = "listarApenasCarrosToolStripMenuItem";
            this.listarApenasCarrosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listarApenasCarrosToolStripMenuItem.Text = "Listar apenas Carros";
            // 
            // listarApenasMotosToolStripMenuItem
            // 
            this.listarApenasMotosToolStripMenuItem.Name = "listarApenasMotosToolStripMenuItem";
            this.listarApenasMotosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listarApenasMotosToolStripMenuItem.Text = "Listar apenas Motos";
            // 
            // faturamentoToolStripMenuItem
            // 
            this.faturamentoToolStripMenuItem.Name = "faturamentoToolStripMenuItem";
            this.faturamentoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.faturamentoToolStripMenuItem.Text = "Faturamento";
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 359);
            this.Controls.Add(this.tab_principal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_principal";
            this.Text = "Estacionamento MM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_principal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaDeVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarApenasCarrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarApenasMotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem;
    }
}

