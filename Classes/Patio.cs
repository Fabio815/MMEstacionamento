using MMEstacionamento.DataBase;
using MMEstacionamento.Formularios_UC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MMEstacionamento.Classes.Veiculo;

namespace MMEstacionamento.Classes
{
    public class Patio
    {
        public class Unit
        {
            [Key]
            [Required]
            public int Id { get; set; }
            public Double Faturamento { get; set; }

            public void PatioAdicionar(string conexao)
            {
                string clienteJson = Patio.SerializeClassUnit(this);
                FicharioDB f = new FicharioDB(conexao);

                if (f.status)
                {
                    f.Faturamento(this.Id, clienteJson);
                    if (!f.status)
                    {
                        throw new Exception(f.mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.mensagem);
                }
            }

            public void PatioAlterar(string conexao)
            {
                string vJosn = Patio.SerializeClassUnit(this);
                FicharioDB f = new FicharioDB(conexao);
                if (f.status)
                {
                    f.UpdateFaturamento(this.Id ,vJosn);
                    if (!f.status)
                    {
                        throw new Exception(f.mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.mensagem);
                }
            }
        }

        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        //Vai transformar o JSON em classe (converter em cadeia).
        public static string SerializeClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
