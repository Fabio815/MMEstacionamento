﻿namespace MMEstacionamento.Formularios_UC
{
    partial class Cadastro_UC
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
            this.lbl_proprietario = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.lbl_cor = new System.Windows.Forms.Label();
            this.lbl_tipoVeiclo = new System.Windows.Forms.Label();
            this.tb_proprietario = new System.Windows.Forms.TextBox();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.tb_placa = new System.Windows.Forms.TextBox();
            this.tb_cor = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.rb_tipoCarro = new System.Windows.Forms.RadioButton();
            this.rb_tipoMoto = new System.Windows.Forms.RadioButton();
            this.gb_cadastro = new System.Windows.Forms.GroupBox();
            this.gb_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_proprietario
            // 
            this.lbl_proprietario.AutoSize = true;
            this.lbl_proprietario.Location = new System.Drawing.Point(14, 36);
            this.lbl_proprietario.Name = "lbl_proprietario";
            this.lbl_proprietario.Size = new System.Drawing.Size(60, 13);
            this.lbl_proprietario.TabIndex = 0;
            this.lbl_proprietario.Text = "Proprietário";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(14, 91);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(42, 13);
            this.lbl_modelo.TabIndex = 1;
            this.lbl_modelo.Text = "Modelo";
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(14, 131);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(34, 13);
            this.lbl_placa.TabIndex = 2;
            this.lbl_placa.Text = "Placa";
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Location = new System.Drawing.Point(14, 178);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(23, 13);
            this.lbl_cor.TabIndex = 3;
            this.lbl_cor.Text = "Cor";
            this.lbl_cor.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_tipoVeiclo
            // 
            this.lbl_tipoVeiclo.AutoSize = true;
            this.lbl_tipoVeiclo.Location = new System.Drawing.Point(286, 39);
            this.lbl_tipoVeiclo.Name = "lbl_tipoVeiclo";
            this.lbl_tipoVeiclo.Size = new System.Drawing.Size(82, 13);
            this.lbl_tipoVeiclo.TabIndex = 4;
            this.lbl_tipoVeiclo.Text = "Tipo do veículo";
            // 
            // tb_proprietario
            // 
            this.tb_proprietario.Location = new System.Drawing.Point(17, 52);
            this.tb_proprietario.Name = "tb_proprietario";
            this.tb_proprietario.Size = new System.Drawing.Size(160, 20);
            this.tb_proprietario.TabIndex = 0;
            // 
            // tb_modelo
            // 
            this.tb_modelo.Location = new System.Drawing.Point(17, 107);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(160, 20);
            this.tb_modelo.TabIndex = 5;
            // 
            // tb_placa
            // 
            this.tb_placa.Location = new System.Drawing.Point(17, 147);
            this.tb_placa.Name = "tb_placa";
            this.tb_placa.Size = new System.Drawing.Size(100, 20);
            this.tb_placa.TabIndex = 6;
            // 
            // tb_cor
            // 
            this.tb_cor.Location = new System.Drawing.Point(17, 194);
            this.tb_cor.Name = "tb_cor";
            this.tb_cor.Size = new System.Drawing.Size(160, 20);
            this.tb_cor.TabIndex = 7;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(289, 192);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(101, 23);
            this.btn_confirmar.TabIndex = 10;
            this.btn_confirmar.Text = "button1";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // rb_tipoCarro
            // 
            this.rb_tipoCarro.AutoSize = true;
            this.rb_tipoCarro.Location = new System.Drawing.Point(289, 58);
            this.rb_tipoCarro.Name = "rb_tipoCarro";
            this.rb_tipoCarro.Size = new System.Drawing.Size(85, 17);
            this.rb_tipoCarro.TabIndex = 11;
            this.rb_tipoCarro.TabStop = true;
            this.rb_tipoCarro.Text = "radioButton1";
            this.rb_tipoCarro.UseVisualStyleBackColor = true;
            // 
            // rb_tipoMoto
            // 
            this.rb_tipoMoto.AutoSize = true;
            this.rb_tipoMoto.Location = new System.Drawing.Point(289, 94);
            this.rb_tipoMoto.Name = "rb_tipoMoto";
            this.rb_tipoMoto.Size = new System.Drawing.Size(85, 17);
            this.rb_tipoMoto.TabIndex = 12;
            this.rb_tipoMoto.TabStop = true;
            this.rb_tipoMoto.Text = "radioButton2";
            this.rb_tipoMoto.UseVisualStyleBackColor = true;
            // 
            // gb_cadastro
            // 
            this.gb_cadastro.Controls.Add(this.tb_proprietario);
            this.gb_cadastro.Controls.Add(this.rb_tipoMoto);
            this.gb_cadastro.Controls.Add(this.lbl_proprietario);
            this.gb_cadastro.Controls.Add(this.rb_tipoCarro);
            this.gb_cadastro.Controls.Add(this.lbl_modelo);
            this.gb_cadastro.Controls.Add(this.btn_confirmar);
            this.gb_cadastro.Controls.Add(this.lbl_placa);
            this.gb_cadastro.Controls.Add(this.tb_cor);
            this.gb_cadastro.Controls.Add(this.lbl_cor);
            this.gb_cadastro.Controls.Add(this.tb_placa);
            this.gb_cadastro.Controls.Add(this.lbl_tipoVeiclo);
            this.gb_cadastro.Controls.Add(this.tb_modelo);
            this.gb_cadastro.Location = new System.Drawing.Point(82, 28);
            this.gb_cadastro.Name = "gb_cadastro";
            this.gb_cadastro.Size = new System.Drawing.Size(439, 246);
            this.gb_cadastro.TabIndex = 13;
            this.gb_cadastro.TabStop = false;
            this.gb_cadastro.Text = "groupBox1";
            // 
            // Cadastro_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_cadastro);
            this.Name = "Cadastro_UC";
            this.Size = new System.Drawing.Size(618, 308);
            this.gb_cadastro.ResumeLayout(false);
            this.gb_cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_proprietario;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.Label lbl_cor;
        private System.Windows.Forms.Label lbl_tipoVeiclo;
        private System.Windows.Forms.TextBox tb_proprietario;
        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.TextBox tb_placa;
        private System.Windows.Forms.TextBox tb_cor;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.RadioButton rb_tipoCarro;
        private System.Windows.Forms.RadioButton rb_tipoMoto;
        private System.Windows.Forms.GroupBox gb_cadastro;
    }
}
