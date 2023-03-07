using MMEstacionamento.Classes;
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

        public string Buscar(string id)
        {
            status = true;
            try
            {
                // SELECT ID, JSON FROM CLIENTE WHERE ID = '000010'
                //Comando SQL para buscar um objeto.
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE Id = '" + id + "'";
                //Passando o comando para o SQLQuery.
                var dt = db.SQLQuery(SQL);
                //caso as colunas que tenha no banco seja maior que 0, ou seja, tenha algum dado na tabela.
                if (dt.Rows.Count > 0)
                {
                    //Vamos passar o conteúdo para uma string e retornar ela.
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    mensagem = $"Veículo encontrado com sucesso. Placa: {id}";
                    return conteudo;
                }
                else
                {
                    mensagem = "Item não encontrado... Tente outro";
                }
            } 
            catch(Exception ex)
            {
                status = false;
                mensagem = $"Erro ao procurar os dados do veículo! Erro: {ex.Message}";
            }
            return "";
        }
        #endregion
    }
}
