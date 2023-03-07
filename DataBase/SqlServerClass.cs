using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEstacionamento.DataBase
{
    public class SqlServerClass
    {
        //Aqui vai receber a string de conexão;
        public string stringConexao;
        public SqlConnection connBD;

        public SqlServerClass()
        {
            try
            {
                //String de conexão com o banco de dados.
                stringConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\fabio\\Desktop\\Projeto Estacionamento\\MMEstacionamento-master\\MMEstacionamento-master\\DataBase\\Fabbio.mdf\";Integrated Security=True;Connect Timeout=30";
                //Criando uma variavel do tipo conexão, porque ai poderei manipular as coisas.
                //Estou guardando a conexão dentro dessa classe.
                connBD = new SqlConnection(stringConexao);
                connBD.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Esse método serve para alterar os dados do banco.
        public string SQLCommand(string SQL)
        {
            try
            {
                //Passando o pacote de comando e a conexão.
                var myCommand = new SqlCommand(SQL, connBD);
                //Quando o timeuout dor iguala zero, significa que vai esperar o tempo que for necessário.
                myCommand.CommandTimeout = 0;
                //Enviando o comando para o banco de dados.
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método que vai retornar dados (Pesquisa).
        public DataTable SQLQuery(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                var myCommand = new SqlCommand(SQL, connBD);

                myCommand.CommandTimeout = 0;

                var myReader = myCommand.ExecuteReader();

                dt.Load(myReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public void Close()
        {
            this.connBD.Close();
        }
    }
}
