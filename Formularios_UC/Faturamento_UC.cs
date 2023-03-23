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
using Microsoft.VisualBasic;

namespace MMEstacionamento.Formularios_UC
{
    public partial class Faturamento_UC : UserControl
    {
        public double valor { get; set; }
        public Faturamento_UC()
        {
            InitializeComponent();
            Patio.Unit patio = new Patio.Unit();
            patio = fato();

            patio.PatioAdicionar("Patio");
        }
         
        public void CalculoFaturamento(double valorCobrado)
        {
            valor = valorCobrado;
        }
        
        Patio.Unit fato()
        {
            Patio.Unit patio = new Patio.Unit();
            patio.Id = 1;
            if (Information.IsNumeric(valor))
            {
                Double faturamento = Convert.ToDouble(this.valor);
                if (faturamento < 0)
                {
                    patio.Faturamento = 0;
                }
                else
                {
                    patio.Faturamento = this.valor;
                }
            }
            return patio;
        }
    }
}
