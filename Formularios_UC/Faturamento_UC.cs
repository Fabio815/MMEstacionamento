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
    public partial class Faturamento_UC : UserControl
    {
        public Faturamento_UC()
        {
            InitializeComponent();

            Veiculo.Unit veiculos = new Veiculo.Unit();
            label1.Text = veiculos.faturamentoTotal.ToString();
        }
    }
}
