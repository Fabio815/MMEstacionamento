﻿using Microsoft.VisualBasic;
using MMEstacionamento.Classes;
using MMEstacionamento.Formularios_UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void Incluir(string placa, string jsonUnit)
        {
            status = true;
            try
            {
                //INSERT INTO [TABELA] (Id, Proprietario) VALUES (1, 'Fábio', '{....}');
                //Comando SQL de inclusão, e como se fosse no Sql Server.
                var SQL = "INSERT INTO " + tabela + " (Placa ,JSON) VALUES ('" + placa + "', '" + jsonUnit + "')";
                //A classe SqlCommand é usada para representar um comando SQL
                db.SQLCommand(SQL);
                mensagem = $"Veículo adicionado com sucesso! Identificardor: {placa}";
            }
            catch
            {
                status = false;
                mensagem = $"Erro ao adicionar o veículo, tente outra placa!";
            }
        }

        public string Buscar(string placa)
        {
            status = true;
            try
            {
                // SELECT ID, JSON FROM CLIENTE WHERE ID = '000010'
                //Comando SQL para buscar um objeto.
                var SQL = "SELECT Placa, JSON FROM " + tabela + " WHERE Placa = '" + placa + "'";
                //Passando o comando para o SQLQuery.
                var dt = db.SQLQuery(SQL);
                //caso as colunas que tenha no banco seja maior que 0, ou seja, tenha algum dado na tabela.
                if (dt.Rows.Count > 0)
                {
                    //Vamos passar o conteúdo para uma string e retornar ela.
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    return conteudo;
                }
                else
                {
                    status = false;
                    mensagem = "Item não encontrado... Tente outro";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Erro ao procurar os dados do veículo! Erro: {ex.Message}";
            }
            return "";
        }

        public void Atualizar(string placa, string dadosJson)
        {
            status = true;
            try
            {
                //UPDATE [TABELA] SET [COLUNA] WHERE id = {...};
                var SQL = "SELECT Placa, JSON FROM " + tabela + " WHERE Placa = '" + placa + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    SQL = "UPDATE " + tabela + " SET JSON = '" + dadosJson + "' WHERE Placa = '" + placa + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    mensagem = "Veículo alterado com sucesso!";
                }
                else
                {
                    status = false;
                    mensagem = "Veículo não cadastrado, ou já foi registrado a sua saída... Tente outro";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = $"Erro ao alterar! Erro: {ex.Message}";
            }
        }

        public void Excluir(string placa)
        {
            status = true;
            try
            {
                string SQL = "SELECT Placa, JSON FROM " + tabela + " WHERE Placa = '" + placa + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    SQL = "DELETE FROM " + tabela + " WHERE Placa = '" + placa + "'";
                    db.SQLCommand(SQL);
                    mensagem = "Item excluído com sucesso!";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao excluir o veículo do banco de dados " + ex.Message;
            }
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> list = new List<string>();
            try
            {
                //Conferencia para ver se tem dados no banco.
                //SELECT Placa, JSON FROM [TABELA]
                var SQL = "SELECT Placa, JSON FROM " + tabela;
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    //Aqui vamos fazer uma estrutura de repetição, para colocar dentro da lista os dados do banco.
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        //Estamos pegando a placa conforme o for e o seus dados respectivamente.
                        string conteudo = dt.Rows[i]["JSON"].ToString();
                        list.Add(conteudo);
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = ex.Message;
            }
            return list;
        }
        #endregion

        public void Faturamento(int id, string faturamento)
        {
            status = true;
            try
            {
                string SQL = "INSERT INTO " + tabela + " (Id, Faturamento) VALUES (" + id + ", '" + faturamento + "')";
                db.SQLCommand(SQL);
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = ex.Message;
            }
        }

        public void UpdateFaturamento(int id, double faturamento)
        {
            status = true;
            try
            {
                SaidaVeiculo_UC saida = new SaidaVeiculo_UC();
                //UPDATE produtos SET quantidade = quantidade + 1 WHERE nome_produto = 'Tênis de Futebol'
                string SQL = "UPDATE " + tabela + " SET Faturamento = " + faturamento + " + " + saida.valorCobrado + " WHERE Id = " + id;
                db.SQLCommand(SQL);
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = ex.Message;
            }
        }
    }
}
