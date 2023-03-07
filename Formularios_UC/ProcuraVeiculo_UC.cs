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
            bnt_alterar.Text = "Alterar";
            bnt_alterar.Text = "Limpar";
        }
    }
}
