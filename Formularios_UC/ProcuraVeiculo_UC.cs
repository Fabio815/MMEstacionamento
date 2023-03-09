using MMEstacionamento.Classes;
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
    public partial class ProcuraVeiculo_UC : UserControl
    {
        public ProcuraVeiculo_UC()
        {
            InitializeComponent();

            lbl_placa.Text = "Placa";
            lbl_proprietario.Text = "Propriétario";
            lbl_modelo.Text = "Modelo";
            lbl_cor.Text = "Cor";
            lbl_dataEntrada.Text = "Data Entrada";
            lbl_dataSaida.Text = "Data Saída";
            rdb_tipoCarro.Text = "Carro";
            rdb_tipoMoto.Text = "Moto";
            lbl_tipoVeiculo.Text = "Tipo do veículo";
            dataEntrada.Visible = false;
            dataSaida.Visible = false;
            bnt_procurar.Text = "Procurar";
            bnt_limpar.Text = "Limpar";
            btn_atualizar.Text = "Atualizar";
        }

        private void bnt_limpar_Click(object sender, EventArgs e)
        {
            txt_placa.Clear();
            txt_proprietario.Clear();
            txt_modelo.Clear();
            txt_cor.Clear();
            dataSaida.Text = "";
            dataEntrada.Text = "";
            if (rdb_tipoCarro.Checked || rdb_tipoMoto.Checked)
            {
                rdb_tipoCarro.Checked = false;
                rdb_tipoMoto.Checked = false;
            }
        }

        private void bnt_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo.Unit veiculo = new Veiculo.Unit();
                veiculo = veiculo.BuscarFicharioDB(txt_placa.Text, "Veiculo");
                EscreverFormulario(veiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veículo não encontrado... Erro {ex.Message}");
            }
        }

        Veiculo.Unit InserirDados()
        {
            Veiculo.Unit vei = new Veiculo.Unit();
            vei.Placa = txt_placa.Text;
            vei.Proprietario = txt_proprietario.Text;
            vei.Modelo= txt_modelo.Text;
            vei.Cor = txt_cor.Text;
            if (rdb_tipoCarro.Checked)
            {
                vei.TipoVeiculo = TipoVeiculo.Carro;
            }
            else if (rdb_tipoMoto.Checked)
            {
                vei.TipoVeiculo = TipoVeiculo.Moto;
            }
            return vei;
        }
    
        void EscreverFormulario(Veiculo.Unit veiculo)
        {
            txt_proprietario.Text = veiculo.Proprietario;
            txt_modelo.Text = veiculo.Modelo;
            txt_cor.Text = veiculo.Cor;
            dataEntrada.Visible = true;
            dataEntrada.Text = veiculo.DataEntrada.ToString();
            dataSaida.Visible = true;
            dataSaida.Text = veiculo.DataSaida.ToString();
            if (veiculo.TipoVeiculo == TipoVeiculo.Carro)
            {
                rdb_tipoCarro.Checked = true;
            }
            else if (veiculo.TipoVeiculo == TipoVeiculo.Moto)
            {
                rdb_tipoMoto.Checked = true;
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo.Unit veiculo = new Veiculo.Unit();
                veiculo = InserirDados();
                
                veiculo.AlterarFichaDB(txt_placa.Text ,"Veiculo");
                MessageBox.Show("Dados atualizados com sucesso!", "Aviso" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
