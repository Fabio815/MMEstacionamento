using MMEstacionamento.Formularios_UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEstacionamento.Classes
{
    public class Patio : SaidaVeiculo_UC
    {
        public double Total { get; set; }
        public double SomaTotal(double valor)
        {
            return Total += valor;
        }
    }
}
