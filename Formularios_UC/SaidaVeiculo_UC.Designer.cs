namespace MMEstacionamento.Formularios_UC
{
    partial class SaidaVeiculo_UC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaidaVeiculo_UC));
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.txt_proprietario = new System.Windows.Forms.TextBox();
            this.lbl_proprietario = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.lbl_cor = new System.Windows.Forms.Label();
            this.lbl_tipoVeiculo = new System.Windows.Forms.Label();
            this.lbl_dataEntrada = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.colarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.gb_formulario = new System.Windows.Forms.GroupBox();
            this.gb_lisaVeiculos = new System.Windows.Forms.GroupBox();
            this.dataGrid_listaVeiculo = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.gb_formulario.SuspendLayout();
            this.gb_lisaVeiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listaVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(53, 32);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(35, 13);
            this.lbl_placa.TabIndex = 0;
            this.lbl_placa.Text = "label1";
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(56, 48);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(100, 20);
            this.txt_placa.TabIndex = 1;
            // 
            // txt_proprietario
            // 
            this.txt_proprietario.Location = new System.Drawing.Point(56, 107);
            this.txt_proprietario.Name = "txt_proprietario";
            this.txt_proprietario.Size = new System.Drawing.Size(100, 20);
            this.txt_proprietario.TabIndex = 3;
            // 
            // lbl_proprietario
            // 
            this.lbl_proprietario.AutoSize = true;
            this.lbl_proprietario.Location = new System.Drawing.Point(53, 91);
            this.lbl_proprietario.Name = "lbl_proprietario";
            this.lbl_proprietario.Size = new System.Drawing.Size(35, 13);
            this.lbl_proprietario.TabIndex = 2;
            this.lbl_proprietario.Text = "label2";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(56, 176);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_modelo.TabIndex = 5;
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(53, 160);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(35, 13);
            this.lbl_modelo.TabIndex = 4;
            this.lbl_modelo.Text = "label3";
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(56, 237);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(100, 20);
            this.txt_cor.TabIndex = 7;
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Location = new System.Drawing.Point(53, 221);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(35, 13);
            this.lbl_cor.TabIndex = 6;
            this.lbl_cor.Text = "label4";
            // 
            // lbl_tipoVeiculo
            // 
            this.lbl_tipoVeiculo.AutoSize = true;
            this.lbl_tipoVeiculo.Location = new System.Drawing.Point(256, 51);
            this.lbl_tipoVeiculo.Name = "lbl_tipoVeiculo";
            this.lbl_tipoVeiculo.Size = new System.Drawing.Size(35, 13);
            this.lbl_tipoVeiculo.TabIndex = 8;
            this.lbl_tipoVeiculo.Text = "label3";
            // 
            // lbl_dataEntrada
            // 
            this.lbl_dataEntrada.AutoSize = true;
            this.lbl_dataEntrada.Location = new System.Drawing.Point(256, 110);
            this.lbl_dataEntrada.Name = "lbl_dataEntrada";
            this.lbl_dataEntrada.Size = new System.Drawing.Size(35, 13);
            this.lbl_dataEntrada.TabIndex = 9;
            this.lbl_dataEntrada.Text = "label3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colarToolStripButton,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(779, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // colarToolStripButton
            // 
            this.colarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripButton.Image")));
            this.colarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripButton.Name = "colarToolStripButton";
            this.colarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.colarToolStripButton.Text = "C&olar";
            this.colarToolStripButton.Click += new System.EventHandler(this.colarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(256, 32);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(35, 13);
            this.lbl_tipo.TabIndex = 11;
            this.lbl_tipo.Text = "label3";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(256, 91);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(35, 13);
            this.lbl_data.TabIndex = 12;
            this.lbl_data.Text = "label3";
            // 
            // gb_formulario
            // 
            this.gb_formulario.Controls.Add(this.txt_placa);
            this.gb_formulario.Controls.Add(this.lbl_data);
            this.gb_formulario.Controls.Add(this.lbl_placa);
            this.gb_formulario.Controls.Add(this.lbl_tipo);
            this.gb_formulario.Controls.Add(this.lbl_proprietario);
            this.gb_formulario.Controls.Add(this.txt_proprietario);
            this.gb_formulario.Controls.Add(this.lbl_dataEntrada);
            this.gb_formulario.Controls.Add(this.lbl_modelo);
            this.gb_formulario.Controls.Add(this.lbl_tipoVeiculo);
            this.gb_formulario.Controls.Add(this.txt_modelo);
            this.gb_formulario.Controls.Add(this.txt_cor);
            this.gb_formulario.Controls.Add(this.lbl_cor);
            this.gb_formulario.Location = new System.Drawing.Point(3, 43);
            this.gb_formulario.Name = "gb_formulario";
            this.gb_formulario.Size = new System.Drawing.Size(411, 272);
            this.gb_formulario.TabIndex = 13;
            this.gb_formulario.TabStop = false;
            this.gb_formulario.Text = "groupBox1";
            // 
            // gb_lisaVeiculos
            // 
            this.gb_lisaVeiculos.Controls.Add(this.dataGrid_listaVeiculo);
            this.gb_lisaVeiculos.Location = new System.Drawing.Point(420, 43);
            this.gb_lisaVeiculos.Name = "gb_lisaVeiculos";
            this.gb_lisaVeiculos.Size = new System.Drawing.Size(345, 272);
            this.gb_lisaVeiculos.TabIndex = 14;
            this.gb_lisaVeiculos.TabStop = false;
            this.gb_lisaVeiculos.Text = "groupBox1";
            // 
            // dataGrid_listaVeiculo
            // 
            this.dataGrid_listaVeiculo.AllowUserToAddRows = false;
            this.dataGrid_listaVeiculo.AllowUserToDeleteRows = false;
            this.dataGrid_listaVeiculo.AllowUserToOrderColumns = true;
            this.dataGrid_listaVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_listaVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.Proprietario,
            this.Data});
            this.dataGrid_listaVeiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_listaVeiculo.Location = new System.Drawing.Point(3, 16);
            this.dataGrid_listaVeiculo.Name = "dataGrid_listaVeiculo";
            this.dataGrid_listaVeiculo.ReadOnly = true;
            this.dataGrid_listaVeiculo.Size = new System.Drawing.Size(339, 253);
            this.dataGrid_listaVeiculo.TabIndex = 0;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 80;
            // 
            // Proprietario
            // 
            this.Proprietario.HeaderText = "Proprietario";
            this.Proprietario.Name = "Proprietario";
            this.Proprietario.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data de entrada";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 115;
            // 
            // SaidaVeiculo_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_lisaVeiculos);
            this.Controls.Add(this.gb_formulario);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SaidaVeiculo_UC";
            this.Size = new System.Drawing.Size(779, 333);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gb_formulario.ResumeLayout(false);
            this.gb_formulario.PerformLayout();
            this.gb_lisaVeiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listaVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.TextBox txt_proprietario;
        private System.Windows.Forms.Label lbl_proprietario;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.Label lbl_cor;
        private System.Windows.Forms.Label lbl_tipoVeiculo;
        private System.Windows.Forms.Label lbl_dataEntrada;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton colarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.GroupBox gb_formulario;
        private System.Windows.Forms.GroupBox gb_lisaVeiculos;
        private System.Windows.Forms.DataGridView dataGrid_listaVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proprietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}
