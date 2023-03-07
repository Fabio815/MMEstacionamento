using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEstacionamento.DataBase
{
    public class FicharioDB
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public SqlServerClass db;

        public FicharioDB(string Tabela)
        {
            status = true;
            try
            {
                db = new SqlServerClass();
                tabela = Tabela;
                mensagem = "Conexão feita com sucesso!";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Conexão falhou... Erro: {ex.Message}";
            }
        }

        #region "CRUD"

        public void Incluir(int id, string jsonUnit)
        {
            status = true;
            try
            {
                //INSERT INTO [TABELA] (Id, Proprietario) VALUES (1, 'Fábio', '{....}');

                var SQL = "INSERT INTO " + tabela + " (Id, JSON) VALUES ('" + id + "', '" + jsonUnit + "')";
                db.SQLCommand(SQL);
                mensagem = $"Veículo adicionado com sucesso! Identificardor: {id}";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Erro ao adicionar o veículo {ex.Message}";
            }
        }


        #endregion
    }
}
