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
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.bnt_procurar = new System.Windows.Forms.Button();
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
            this.bnt_limpar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.dataEntrada = new System.Windows.Forms.Label();
            this.dataSaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(3, 27);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(100, 20);
            this.txt_placa.TabIndex = 0;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(3, 11);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(35, 13);
            this.lbl_placa.TabIndex = 1;
            this.lbl_placa.Text = "label1";
            // 
            // bnt_procurar
            // 
            this.bnt_procurar.Location = new System.Drawing.Point(176, 210);
            this.bnt_procurar.Name = "bnt_procurar";
            this.bnt_procurar.Size = new System.Drawing.Size(75, 23);
            this.bnt_procurar.TabIndex = 2;
            this.bnt_procurar.Text = "button1";
            this.bnt_procurar.UseVisualStyleBackColor = true;
            this.bnt_procurar.Click += new System.EventHandler(this.bnt_alterar_Click);
            // 
            // lbl_proprietario
            // 
            this.lbl_proprietario.AutoSize = true;
            this.lbl_proprietario.Location = new System.Drawing.Point(3, 71);
            this.lbl_proprietario.Name = "lbl_proprietario";
            this.lbl_proprietario.Size = new System.Drawing.Size(35, 13);
            this.lbl_proprietario.TabIndex = 3;
            this.lbl_proprietario.Text = "label2";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(3, 131);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(35, 13);
            this.lbl_modelo.TabIndex = 4;
            this.lbl_modelo.Text = "label3";
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Location = new System.Drawing.Point(3, 194);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(35, 13);
            this.lbl_cor.TabIndex = 5;
            this.lbl_cor.Text = "label4";
            // 
            // lbl_dataEntrada
            // 
            this.lbl_dataEntrada.AutoSize = true;
            this.lbl_dataEntrada.Location = new System.Drawing.Point(173, 11);
            this.lbl_dataEntrada.Name = "lbl_dataEntrada";
            this.lbl_dataEntrada.Size = new System.Drawing.Size(35, 13);
            this.lbl_dataEntrada.TabIndex = 6;
            this.lbl_dataEntrada.Text = "label5";
            // 
            // txt_proprietario
            // 
            this.txt_proprietario.Location = new System.Drawing.Point(6, 87);
            this.txt_proprietario.Name = "txt_proprietario";
            this.txt_proprietario.Size = new System.Drawing.Size(100, 20);
            this.txt_proprietario.TabIndex = 7;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(3, 147);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_modelo.TabIndex = 8;
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(6, 210);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(100, 20);
            this.txt_cor.TabIndex = 9;
            // 
            // lbl_dataSaida
            // 
            this.lbl_dataSaida.AutoSize = true;
            this.lbl_dataSaida.Location = new System.Drawing.Point(173, 71);
            this.lbl_dataSaida.Name = "lbl_dataSaida";
            this.lbl_dataSaida.Size = new System.Drawing.Size(35, 13);
            this.lbl_dataSaida.TabIndex = 12;
            this.lbl_dataSaida.Text = "label6";
            // 
            // lbl_tipoVeiculo
            // 
            this.lbl_tipoVeiculo.AutoSize = true;
            this.lbl_tipoVeiculo.Location = new System.Drawing.Point(173, 147);
            this.lbl_tipoVeiculo.Name = "lbl_tipoVeiculo";
            this.lbl_tipoVeiculo.Size = new System.Drawing.Size(35, 13);
            this.lbl_tipoVeiculo.TabIndex = 13;
            this.lbl_tipoVeiculo.Text = "label7";
            // 
            // rdb_tipoCarro
            // 
            this.rdb_tipoCarro.AutoSize = true;
            this.rdb_tipoCarro.Location = new System.Drawing.Point(176, 163);
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
            this.rdb_tipoMoto.Location = new System.Drawing.Point(176, 186);
            this.rdb_tipoMoto.Name = "rdb_tipoMoto";
            this.rdb_tipoMoto.Size = new System.Drawing.Size(85, 17);
            this.rdb_tipoMoto.TabIndex = 15;
            this.rdb_tipoMoto.TabStop = true;
            this.rdb_tipoMoto.Text = "radioButton2";
            this.rdb_tipoMoto.UseVisualStyleBackColor = true;
            // 
            // bnt_limpar
            // 
            this.bnt_limpar.Location = new System.Drawing.Point(268, 210);
            this.bnt_limpar.Name = "bnt_limpar";
            this.bnt_limpar.Size = new System.Drawing.Size(75, 23);
            this.bnt_limpar.TabIndex = 16;
            this.bnt_limpar.Text = "button2";
            this.bnt_limpar.UseVisualStyleBackColor = true;
            this.bnt_limpar.Click += new System.EventHandler(this.bnt_limpar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(361, 208);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizar.TabIndex = 19;
            this.btn_atualizar.Text = "button2";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // dataEntrada
            // 
            this.dataEntrada.AutoSize = true;
            this.dataEntrada.Location = new System.Drawing.Point(173, 30);
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.Size = new System.Drawing.Size(35, 13);
            this.dataEntrada.TabIndex = 17;
            this.dataEntrada.Text = "label7";
            // 
            // dataSaida
            // 
            this.dataSaida.AutoSize = true;
            this.dataSaida.Location = new System.Drawing.Point(173, 94);
            this.dataSaida.Name = "dataSaida";
            this.dataSaida.Size = new System.Drawing.Size(35, 13);
            this.dataSaida.TabIndex = 18;
            this.dataSaida.Text = "label7";
            // 
            // ProcuraVeiculo_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.dataSaida);
            this.Controls.Add(this.dataEntrada);
            this.Controls.Add(this.bnt_limpar);
            this.Controls.Add(this.rdb_tipoMoto);
            this.Controls.Add(this.rdb_tipoCarro);
            this.Controls.Add(this.lbl_tipoVeiculo);
            this.Controls.Add(this.lbl_dataSaida);
            this.Controls.Add(this.txt_cor);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.txt_proprietario);
            this.Controls.Add(this.lbl_dataEntrada);
            this.Controls.Add(this.lbl_cor);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.lbl_proprietario);
            this.Controls.Add(this.bnt_procurar);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.txt_placa);
            this.Name = "ProcuraVeiculo_UC";
            this.Size = new System.Drawing.Size(492, 268);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.Button bnt_procurar;
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
        private System.Windows.Forms.Button bnt_limpar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label dataEntrada;
        private System.Windows.Forms.Label dataSaida;
    }
}
