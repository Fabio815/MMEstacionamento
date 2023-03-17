﻿using MMEstacionamento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMEstacionamento.Formularios_UC
{
    public partial class SaidaVeiculo_UC : UserControl
    {
        public double valorCobrado = 0;
        public SaidaVeiculo_UC()
        {
            InitializeComponent();
            lbl_placa.Text = "Placa";
            lbl_proprietario.Text = "Proprietário";
            lbl_modelo.Text = "Modelo";
            lbl_cor.Text = "Cor";
            lbl_tipo.Text = "Tipo do veículo";
            lbl_data.Text = "Data de entrada";
            lbl_dataEntrada.Visible = false;
            lbl_tipoVeiculo.Visible = false;
            gb_formulario.Text = "Formulário";
            gb_lisaVeiculos.Text = "Lista de veículos";

            toolStrip1.Items[0].Text = "Procurar carro";
            toolStrip1.Items[1].Text = "Registrar saída";
        }

        void EscreverFormulario(Veiculo.Unit escreva)
        {
            txt_proprietario.Text = escreva.Proprietario;
            txt_modelo.Text = escreva.Modelo;
            txt_cor.Text = escreva.Cor;
            lbl_dataEntrada.Visible = true;
            lbl_tipoVeiculo.Visible = true;

            lbl_tipoVeiculo.Text = escreva.TipoVeiculo.ToString();
            lbl_dataEntrada.Text = escreva.GuardaHoraEntrada.ToString();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        void Limpar()
        {
            txt_placa.Text = "";
            txt_proprietario.Text = "";
            txt_modelo.Text = "";
            txt_cor.Text = "";
            lbl_dataEntrada.Text = "";
            lbl_tipoVeiculo.Text = "";
        }

        void SaidaVeiculo(Veiculo.Unit veiculo)
        {
            //Aqui estou declarando a saída do usuário.
            veiculo.DataSaida = DateTime.Now;
            //E calculando o tempo que ele permaneceu.
            var tempoPermanecido = veiculo.DataSaida - veiculo.DataEntrada;
            if (veiculo.TipoVeiculo == TipoVeiculo.Carro)
            {
                //Para cobrar o tempo, vou fazer em minutos.
                //O Math.Ceiling vai arrendondar o número. Ex:. temos o número 1,799 = 2,0
                if (Math.Ceiling(tempoPermanecido.TotalMinutes) > 15 && Math.Ceiling(tempoPermanecido.TotalMinutes) <= 60)
                {
                    valorCobrado += 15;
                }
                if (Math.Ceiling(tempoPermanecido.TotalMinutes) > 60 && Math.Ceiling(tempoPermanecido.TotalMinutes) <= 120)
                {
                    valorCobrado = 26.00;
                }
                if (Math.Ceiling(tempoPermanecido.TotalMinutes) > 120 && Math.Ceiling(tempoPermanecido.TotalMinutes) <= 300)
                {
                    valorCobrado = 40.00;
                }
                if (Math.Ceiling(tempoPermanecido.TotalMinutes) > 300)
                {
                    valorCobrado = Math.Ceiling(tempoPermanecido.TotalHours) * 1.50;
                }
            }
            else if(veiculo.TipoVeiculo == TipoVeiculo.Moto)
            {
                if (Math.Ceiling(tempoPermanecido.TotalMinutes) > 15 && Math.Ceiling(tempoPermanecido.TotalMinutes) <= 60)
                {
                    valorCobrado = 12.00;
                }
                if (Math.Ceiling(tempoPermanecido.TotalMinutes) > 60 && Math.Ceiling(tempoPermanecido.TotalMinutes) <= 120)
                {
                    valorCobrado = 15.00;
                }
                if (Math.Ceiling(tempoPermanecido.TotalMinutes) > 120 && Math.Ceiling(tempoPermanecido.TotalMinutes) <= 300)
                {
                    valorCobrado = 26.00;
                }
                if (Math.Ceiling(tempoPermanecido.TotalMinutes) > 300)
                {
                    valorCobrado = Math.Ceiling(tempoPermanecido.TotalHours) * 1.00;
                }
            }
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_placa.Text == "")
                {
                    MessageBox.Show("Preencha o campo da placa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Veiculo.Unit veicu = new Veiculo.Unit();
                    veicu = veicu.BuscarFicharioDB(txt_placa.Text, "Veiculo");
                    if (veicu == null)
                    {
                        MessageBox.Show("Veículo não encontrado... Tente outro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        EscreverFormulario(veicu);
                        SaidaVeiculo(veicu);
                        var result = MessageBox.Show($"Total a pagar {valorCobrado:c}, deseja realmente cadastrar sua saída? ", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            veicu.ExcluirFicharioDb(veicu.Placa, "Veiculo");
                            MessageBox.Show("Saída cadastrada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpar();
                        }
                        else
                        {
                            MessageBox.Show("Operação cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
