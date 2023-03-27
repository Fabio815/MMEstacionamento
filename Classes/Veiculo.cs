using MMEstacionamento.DataBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEstacionamento.Classes
{
    public class Veiculo
    {
        public class Unit
        {

            [Key]
            [Required(ErrorMessage = "Placa é obrigatório.")]
            [StringLength(8, ErrorMessage = "A placa deve conter 8 dígitos.")]
            public string Placa { get; set; }

            [Required(ErrorMessage = "Preencha o campo do proprietário.")]
            [StringLength(50, ErrorMessage = "O nome do proprietário deve conter no máximo 50 caracteres.")]
            public string Proprietario { get; set; }

            [Required(ErrorMessage = "O modelo do carro é obrigatório.")]
            [StringLength(20, ErrorMessage = "O modelo não pode conter mais que 20 caracteres.")]
            public string Modelo { get; set; }


            [Required(ErrorMessage = "O veículo deve conter cor.")]
            [StringLength(50, ErrorMessage = "O modelo não pode conter mais que 50 caracteres.")]
            public string Cor { get; set; }

            public DateTime DataEntrada { get; set; }

            public DateTime GuardaHoraEntrada { get; set; }

            public DateTime DataSaida { get; set; }

            [Required]
            public TipoVeiculo TipoVeiculo { get; set; }

            public double valorCobrado { get; set; }


            public string _placa
            {
                get
                {
                    return Placa;
                }
                set
                {
                    if (value.Length != 8)
                    {
                        throw new Exception("A placa deve conter 8 caracteres.");
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        if (char.IsDigit(value[i]))
                        {
                            throw new Exception("Os 3 primeiros caracteres devem conter números.");
                        }
                    }
                    if (value[3] != '-')
                    {
                        throw new Exception("O 4º caractere deve conter um -");
                    }
                    for (int i = 4; i < 8; i++)
                    {
                        if (!char.IsDigit(value[i]))
                        {
                            throw new Exception("Apos o - deve conter números.");
                        }
                    }
                    Placa = value;
                }
            }

            #region "CRUD LOCAL DB"

            public void IncluirFicharioDB(string conexao)
            {
                //Aqui vou transformar o JSON em classe (caracteres).
                string clienteJson = Veiculo.SerializeClassUnit(this);
                FicharioDB fichario = new FicharioDB(conexao);
                if (fichario.status)
                {
                    fichario.Incluir(this.Placa, clienteJson);
                    //Se der erro.
                    if (!(fichario.status))
                    {
                        throw new Exception(fichario.mensagem);
                    }
                }
                else
                {
                    throw new Exception(fichario.mensagem);
                }
            }

            public Unit BuscarFicharioDB(string placa, string conexao)
            {
                //Abrindo a conexão.
                FicharioDB fichario = new FicharioDB(conexao);
                if (fichario.status)
                {
                    //Colocanso os dados dentro de uma string, com base no id.
                    string clienteJson = fichario.Buscar(placa);
                    //Com o Desserializa, vou transformar a classe em JSON.
                    return Veiculo.DesSerializedClassUnit(clienteJson);
                }
                else
                {
                    throw new Exception(fichario.mensagem);
                }
            }

            public void AlterarFichaDB(string placa, string conexao)
            {
                string vJson = Veiculo.SerializeClassUnit(this);
                FicharioDB fichario = new FicharioDB(conexao);
                if (fichario.status)
                {
                    fichario.Atualizar(placa, vJson);
                    if (!(fichario.status))
                    {
                        throw new Exception(fichario.mensagem);
                    }
                }
                else
                {
                    throw new Exception(fichario.mensagem);
                }
            }

            public void ExcluirFicharioDb(string placa, string conexao)
            {
                FicharioDB fichario = new FicharioDB(conexao);
                if (fichario.status)
                {
                    fichario.Excluir(placa);
                    if (!(fichario.status))
                    {
                        throw new Exception(fichario.mensagem);
                    }
                }
                else
                {
                    throw new Exception(fichario.mensagem);
                }
            }

            //Esse método vai retornar uma lista bidimensional.
            public List<List<string>> BuscaFicharioTodos(string conexao)
            {
                FicharioDB fichario = new FicharioDB(conexao);
                if (fichario.status)
                {
                    //Essa lista de string vai guardar os dados armazenados na função BuscaTodos.
                    List<string> lista = new List<string>();
                    lista = fichario.BuscarTodos();
                    if (fichario.status)
                    {
                        //Essa lista vai retornar a Placa e o proprietário do veículo.
                        List<List<string>> ls = new List<List<string>>();
                        for (int i = 0; i <= lista.Count - 1; i++)
                        {
                            //Aqui a variável v estou transformando o JSON em classe, conforme sua posição.
                            Veiculo.Unit v = Veiculo.DesSerializedClassUnit(lista[i]);
                            ls.Add(new List<string> { v.Placa, v.Proprietario });
                        }
                        return ls;
                    }
                    else
                    {
                        throw new Exception(fichario.mensagem);
                    }
                }
                else
                {
                    throw new Exception(fichario.mensagem);
                }
            }
            #endregion
        }

        //vai transformar Classe em JSON (converter em objeto).
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
