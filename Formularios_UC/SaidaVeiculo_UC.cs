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
        public SaidaVeiculo_UC()
        {
            InitializeComponent();
            lbl_placa.Text = "Placa";
            lbl_proprietario.Text = "Proprietário";
            lbl_modelo.Text = "Modelo";
            lbl_cor.Text = "Cor";
        }
    }
}
