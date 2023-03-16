namespace MMEstacionamento.Formularios_UC
{
    partial class ProcuraVeiculo_UC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcuraVeiculo_UC));
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.lbl_proprietario = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_cor = new System.Windows.Forms.Label();
            this.lbl_dataEntrada = new System.Windows.Forms.Label();
            this.txt_proprietario = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.lbl_dataSaida = new System.Windows.Forms.Label();
            this.lbl_tipoVeiculo = new System.Windows.Forms.Label();
            this.rdb_tipoCarro = new System.Windows.Forms.RadioButton();
            this.rdb_tipoMoto = new System.Windows.Forms.RadioButton();
            this.dataEntrada = new System.Windows.Forms.Label();
            this.dataSaida = new System.Windows.Forms.Label();
            this.tool_Principal = new System.Windows.Forms.ToolStrip();
            this.tool_abrir = new System.Windows.Forms.ToolStripButton();
            this.tool_salvar = new System.Windows.Forms.ToolStripButton();
            this.tool_limpar = new System.Windows.Forms.ToolStripButton();
            this.tool_exluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bDEstacionamentoDataSet = new MMEstacionamento.BDEstacionamentoDataSet();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoTableAdapter = new MMEstacionamento.BDEstacionamentoDataSetTableAdapters.VeiculoTableAdapter();
            this.bDEstacionamentoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid_ListaVeiculos = new System.Windows.Forms.DataGridView();
            this.gb_formulario = new System.Windows.Forms.GroupBox();
            this.gb_listaDeVeiculos = new System.Windows.Forms.GroupBox();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JSON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tool_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDEstacionamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEstacionamentoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ListaVeiculos)).BeginInit();
            this.gb_formulario.SuspendLayout();
            this.gb_listaDeVeiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(34, 50);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(100, 20);
            this.txt_placa.TabIndex = 0;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(34, 34);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(35, 13);
            this.lbl_placa.TabIndex = 1;
            this.lbl_placa.Text = "label1";
            // 
            // lbl_proprietario
            // 
            this.lbl_proprietario.AutoSize = true;
            this.lbl_proprietario.Location = new System.Drawing.Point(34, 94);
            this.lbl_proprietario.Name = "lbl_proprietario";
            this.lbl_proprietario.Size = new System.Drawing.Size(35, 13);
            this.lbl_proprietario.TabIndex = 3;
            this.lbl_proprietario.Text = "label2";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(34, 154);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(35, 13);
            this.lbl_modelo.TabIndex = 4;
            this.lbl_modelo.Text = "label3";
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Location = new System.Drawing.Point(34, 217);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(35, 13);
            this.lbl_cor.TabIndex = 5;
            this.lbl_cor.Text = "label4";
            // 
            // lbl_dataEntrada
            // 
            this.lbl_dataEntrada.AutoSize = true;
            this.lbl_dataEntrada.Location = new System.Drawing.Point(204, 34);
            this.lbl_dataEntrada.Name = "lbl_dataEntrada";
            this.lbl_dataEntrada.Size = new System.Drawing.Size(35, 13);
            this.lbl_dataEntrada.TabIndex = 6;
            this.lbl_dataEntrada.Text = "label5";
            // 
            // txt_proprietario
            // 
            this.txt_proprietario.Location = new System.Drawing.Point(37, 110);
            this.txt_proprietario.Name = "txt_proprietario";
            this.txt_proprietario.Size = new System.Drawing.Size(100, 20);
            this.txt_proprietario.TabIndex = 7;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(34, 170);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_modelo.TabIndex = 8;
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(37, 233);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(100, 20);
            this.txt_cor.TabIndex = 9;
            // 
            // lbl_dataSaida
            // 
            this.lbl_dataSaida.AutoSize = true;
            this.lbl_dataSaida.Location = new System.Drawing.Point(204, 94);
            this.lbl_dataSaida.Name = "lbl_dataSaida";
            this.lbl_dataSaida.Size = new System.Drawing.Size(35, 13);
            this.lbl_dataSaida.TabIndex = 12;
            this.lbl_dataSaida.Text = "label6";
            // 
            // lbl_tipoVeiculo
            // 
            this.lbl_tipoVeiculo.AutoSize = true;
            this.lbl_tipoVeiculo.Location = new System.Drawing.Point(204, 170);
            this.lbl_tipoVeiculo.Name = "lbl_tipoVeiculo";
            this.lbl_tipoVeiculo.Size = new System.Drawing.Size(35, 13);
            this.lbl_tipoVeiculo.TabIndex = 13;
            this.lbl_tipoVeiculo.Text = "label7";
            // 
            // rdb_tipoCarro
            // 
            this.rdb_tipoCarro.AutoSize = true;
            this.rdb_tipoCarro.Location = new System.Drawing.Point(207, 186);
            this.rdb_tipoCarro.Name = "rdb_tipoCarro";
            this.rdb_tipoCarro.Size = new System.Drawing.Size(85, 17);
            this.rdb_tipoCarro.TabIndex = 14;
            this.rdb_tipoCarro.TabStop = true;
            this.rdb_tipoCarro.Text = "radioButton1";
            this.rdb_tipoCarro.UseVisualStyleBackColor = true;
            // 
            // rdb_tipoMoto
            // 
            this.rdb_tipoMoto.AutoSize = true;
            this.rdb_tipoMoto.Location = new System.Drawing.Point(298, 186);
            this.rdb_tipoMoto.Name = "rdb_tipoMoto";
            this.rdb_tipoMoto.Size = new System.Drawing.Size(85, 17);
            this.rdb_tipoMoto.TabIndex = 15;
            this.rdb_tipoMoto.TabStop = true;
            this.rdb_tipoMoto.Text = "radioButton2";
            this.rdb_tipoMoto.UseVisualStyleBackColor = true;
            // 
            // dataEntrada
            // 
            this.dataEntrada.AutoSize = true;
            this.dataEntrada.Location = new System.Drawing.Point(204, 53);
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.Size = new System.Drawing.Size(35, 13);
            this.dataEntrada.TabIndex = 17;
            this.dataEntrada.Text = "label7";
            // 
            // dataSaida
            // 
            this.dataSaida.AutoSize = true;
            this.dataSaida.Location = new System.Drawing.Point(204, 117);
            this.dataSaida.Name = "dataSaida";
            this.dataSaida.Size = new System.Drawing.Size(35, 13);
            this.dataSaida.TabIndex = 18;
            this.dataSaida.Text = "label7";
            // 
            // tool_Principal
            // 
            this.tool_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_abrir,
            this.tool_salvar,
            this.tool_limpar,
            this.tool_exluir,
            this.toolStripSeparator});
            this.tool_Principal.Location = new System.Drawing.Point(0, 0);
            this.tool_Principal.Name = "tool_Principal";
            this.tool_Principal.Size = new System.Drawing.Size(779, 25);
            this.tool_Principal.TabIndex = 20;
            this.tool_Principal.Text = "toolStrip1";
            // 
            // tool_abrir
            // 
            this.tool_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_abrir.Image = ((System.Drawing.Image)(resources.GetObject("tool_abrir.Image")));
            this.tool_abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_abrir.Name = "tool_abrir";
            this.tool_abrir.Size = new System.Drawing.Size(23, 22);
            this.tool_abrir.Text = "&Abrir";
            this.tool_abrir.Click += new System.EventHandler(this.abrirToolStripButton_Click);
            // 
            // tool_salvar
            // 
            this.tool_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_salvar.Image = ((System.Drawing.Image)(resources.GetObject("tool_salvar.Image")));
            this.tool_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_salvar.Name = "tool_salvar";
            this.tool_salvar.Size = new System.Drawing.Size(23, 22);
            this.tool_salvar.Text = "&Salvar";
            this.tool_salvar.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // tool_limpar
            // 
            this.tool_limpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_limpar.Image = ((System.Drawing.Image)(resources.GetObject("tool_limpar.Image")));
            this.tool_limpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_limpar.Name = "tool_limpar";
            this.tool_limpar.Size = new System.Drawing.Size(23, 22);
            this.tool_limpar.Text = "&Novo";
            this.tool_limpar.Click += new System.EventHandler(this.novoToolStripButton_Click);
            // 
            // tool_exluir
            // 
            this.tool_exluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_exluir.Image = global::MMEstacionamento.Properties.Resources.lixo1;
            this.tool_exluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_exluir.Name = "tool_exluir";
            this.tool_exluir.Size = new System.Drawing.Size(23, 22);
            this.tool_exluir.Text = "toolStripButton1";
            this.tool_exluir.Click += new System.EventHandler(this.tool_exluir_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bDEstacionamentoDataSet
            // 
            this.bDEstacionamentoDataSet.DataSetName = "BDEstacionamentoDataSet";
            this.bDEstacionamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "Veiculo";
            this.veiculoBindingSource.DataSource = this.bDEstacionamentoDataSet;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // bDEstacionamentoDataSetBindingSource
            // 
            this.bDEstacionamentoDataSetBindingSource.DataSource = this.bDEstacionamentoDataSet;
            this.bDEstacionamentoDataSetBindingSource.Position = 0;
            // 
            // veiculoBindingSource1
            // 
            this.veiculoBindingSource1.DataMember = "Veiculo";
            this.veiculoBindingSource1.DataSource = this.bDEstacionamentoDataSetBindingSource;
            // 
            // veiculoBindingSource2
            // 
            this.veiculoBindingSource2.DataMember = "Veiculo";
            // 
            // dataGrid_ListaVeiculos
            // 
            this.dataGrid_ListaVeiculos.AllowUserToAddRows = false;
            this.dataGrid_ListaVeiculos.AllowUserToDeleteRows = false;
            this.dataGrid_ListaVeiculos.AllowUserToOrderColumns = true;
            this.dataGrid_ListaVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ListaVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.JSON});
            this.dataGrid_ListaVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_ListaVeiculos.Location = new System.Drawing.Point(3, 16);
            this.dataGrid_ListaVeiculos.Name = "dataGrid_ListaVeiculos";
            this.dataGrid_ListaVeiculos.ReadOnly = true;
            this.dataGrid_ListaVeiculos.Size = new System.Drawing.Size(339, 253);
            this.dataGrid_ListaVeiculos.TabIndex = 21;
            // 
            // gb_formulario
            // 
            this.gb_formulario.Controls.Add(this.txt_placa);
            this.gb_formulario.Controls.Add(this.lbl_placa);
            this.gb_formulario.Controls.Add(this.lbl_proprietario);
            this.gb_formulario.Controls.Add(this.dataSaida);
            this.gb_formulario.Controls.Add(this.lbl_modelo);
            this.gb_formulario.Controls.Add(this.dataEntrada);
            this.gb_formulario.Controls.Add(this.lbl_cor);
            this.gb_formulario.Controls.Add(this.rdb_tipoMoto);
            this.gb_formulario.Controls.Add(this.lbl_dataEntrada);
            this.gb_formulario.Controls.Add(this.rdb_tipoCarro);
            this.gb_formulario.Controls.Add(this.txt_proprietario);
            this.gb_formulario.Controls.Add(this.lbl_tipoVeiculo);
            this.gb_formulario.Controls.Add(this.txt_modelo);
            this.gb_formulario.Controls.Add(this.lbl_dataSaida);
            this.gb_formulario.Controls.Add(this.txt_cor);
            this.gb_formulario.Location = new System.Drawing.Point(3, 38);
            this.gb_formulario.Name = "gb_formulario";
            this.gb_formulario.Size = new System.Drawing.Size(411, 272);
            this.gb_formulario.TabIndex = 22;
            this.gb_formulario.TabStop = false;
            this.gb_formulario.Text = "groupBox1";
            // 
            // gb_listaDeVeiculos
            // 
            this.gb_listaDeVeiculos.Controls.Add(this.dataGrid_ListaVeiculos);
            this.gb_listaDeVeiculos.Location = new System.Drawing.Point(420, 38);
            this.gb_listaDeVeiculos.Name = "gb_listaDeVeiculos";
            this.gb_listaDeVeiculos.Size = new System.Drawing.Size(345, 272);
            this.gb_listaDeVeiculos.TabIndex = 23;
            this.gb_listaDeVeiculos.TabStop = false;
            this.gb_listaDeVeiculos.Text = "groupBox2";
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // JSON
            // 
            this.JSON.HeaderText = "Proprietário";
            this.JSON.Name = "JSON";
            this.JSON.ReadOnly = true;
            this.JSON.Width = 195;
            // 
            // ProcuraVeiculo_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_listaDeVeiculos);
            this.Controls.Add(this.gb_formulario);
            this.Controls.Add(this.tool_Principal);
            this.Name = "ProcuraVeiculo_UC";
            this.Size = new System.Drawing.Size(779, 333);
            this.tool_Principal.ResumeLayout(false);
            this.tool_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDEstacionamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDEstacionamentoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ListaVeiculos)).EndInit();
            this.gb_formulario.ResumeLayout(false);
            this.gb_formulario.PerformLayout();
            this.gb_listaDeVeiculos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.Label lbl_proprietario;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_cor;
        private System.Windows.Forms.Label lbl_dataEntrada;
        private System.Windows.Forms.TextBox txt_proprietario;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.Label lbl_dataSaida;
        private System.Windows.Forms.Label lbl_tipoVeiculo;
        private System.Windows.Forms.RadioButton rdb_tipoCarro;
        private System.Windows.Forms.RadioButton rdb_tipoMoto;
        private System.Windows.Forms.Label dataEntrada;
        private System.Windows.Forms.Label dataSaida;
        private System.Windows.Forms.ToolStrip tool_Principal;
        private System.Windows.Forms.ToolStripButton tool_limpar;
        private System.Windows.Forms.ToolStripButton tool_abrir;
        private System.Windows.Forms.ToolStripButton tool_salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tool_exluir;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private BDEstacionamentoDataSet bDEstacionamentoDataSet;
        private BDEstacionamentoDataSetTableAdapters.VeiculoTableAdapter veiculoTableAdapter;
        private System.Windows.Forms.BindingSource bDEstacionamentoDataSetBindingSource;
        private System.Windows.Forms.BindingSource veiculoBindingSource1;

        private System.Windows.Forms.BindingSource veiculoBindingSource2;

        private System.Windows.Forms.DataGridView dataGrid_ListaVeiculos;
        private System.Windows.Forms.GroupBox gb_formulario;
        private System.Windows.Forms.GroupBox gb_listaDeVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn JSON;
    }
}
