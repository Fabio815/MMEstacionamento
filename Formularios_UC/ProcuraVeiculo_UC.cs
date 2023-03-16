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
    public partial class ProcuraVeiculo_UC : UserControl
    {
        public ProcuraVeiculo_UC()
        {
            InitializeComponent();

            lbl_placa.Text = "Placa";
            lbl_proprietario.Text = "Propriétario";
            lbl_modelo.Text = "Modelo";
            lbl_cor.Text = "Cor";
            lbl_dataEntrada.Text = "Data Entrada";
            lbl_dataSaida.Text = "Data Saída";
            rdb_tipoCarro.Text = "Carro";
            rdb_tipoMoto.Text = "Moto";
            lbl_tipoVeiculo.Text = "Tipo do veículo";
            dataEntrada.Visible = false;
            dataSaida.Visible = false;

            tool_Principal.Items[0].Text = "Buscar veículo";
            tool_Principal.Items[1].Text = "Alterar veículo";
            tool_Principal.Items[2].Text = "Limpar formulário";
            tool_Principal.Items[3].Text = "Deletar dados do veículo";
            gb_formulario.Text = "Dados do veículo";
            gb_listaDeVeiculos.Text = "Lista de veículos";

            AtualizaGrid();
            Limpar();
        }

        Veiculo.Unit InserirDados()
        {
            Veiculo.Unit vei = new Veiculo.Unit();
            vei.Placa = txt_placa.Text;
            vei.Proprietario = txt_proprietario.Text;
            vei.Modelo= txt_modelo.Text;
            vei.Cor = txt_cor.Text;
            vei.DataEntrada = vei.GuardaHoraEntrada;
            if (rdb_tipoCarro.Checked)
            {
                vei.TipoVeiculo = TipoVeiculo.Carro;
            }
            else if (rdb_tipoMoto.Checked)
            {
                vei.TipoVeiculo = TipoVeiculo.Moto;
            }
            return vei;
        }
    
        void EscreverFormulario(Veiculo.Unit veiculo)
        {
            txt_proprietario.Text = veiculo.Proprietario;
            txt_modelo.Text = veiculo.Modelo;
            txt_cor.Text = veiculo.Cor;
            dataEntrada.Visible = true;
            dataEntrada.Text = veiculo.DataEntrada.ToString();
            dataSaida.Visible = true;
            dataSaida.Text = veiculo.DataSaida.ToString();
            if (veiculo.TipoVeiculo == TipoVeiculo.Carro)
            {
                rdb_tipoCarro.Checked = true;
            }
            else if (veiculo.TipoVeiculo == TipoVeiculo.Moto)
            {
                rdb_tipoMoto.Checked = true;
            }
        }

        void Limpar()
        {
            txt_placa.Clear();
            txt_proprietario.Clear();
            txt_modelo.Clear();
            txt_cor.Clear();
            dataSaida.Text = "";
            dataEntrada.Text = "";
            if (rdb_tipoCarro.Checked || rdb_tipoMoto.Checked)
            {
                rdb_tipoCarro.Checked = false;
                rdb_tipoMoto.Checked = false;
            }
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_placa.Text == "")
                {
                    MessageBox.Show("Insira a placa do carro que deseja procurar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Veiculo.Unit veiculo = new Veiculo.Unit();
                    veiculo = veiculo.BuscarFicharioDB(txt_placa.Text, "Veiculo");
                    if (veiculo == null)
                    {
                        MessageBox.Show("Veículo não encontrado... Tente outro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        EscreverFormulario(veiculo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.Message}");
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_placa.Text == "" || txt_proprietario.Text == "" || txt_modelo.Text == "" || txt_cor.Text == "" || rdb_tipoCarro.Checked == false && rdb_tipoMoto.Checked == false)
                {
                    MessageBox.Show("Preencha os campos do formulário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Veiculo.Unit veiculo = new Veiculo.Unit();
                    veiculo = InserirDados();
                    veiculo.AlterarFichaDB(txt_placa.Text, "Veiculo");
                    MessageBox.Show("Dados atualizados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tool_exluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_placa.Text == "")
                {
                    MessageBox.Show("Insira os dados do veículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Veiculo.Unit veiculo = new Veiculo.Unit();
                    veiculo = veiculo.BuscarFicharioDB(txt_placa.Text, "Veiculo");
                    EscreverFormulario(veiculo);
                    var resp = MessageBox.Show("Deseja realmente deletar o item?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resp == DialogResult.OK)
                    {
                        veiculo.ExcluirFicharioDb(txt_placa.Text, "Veiculo");
                        MessageBox.Show("Veículo removido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        AtualizaGrid();
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizaGrid()
        {
            try
            {
                Veiculo.Unit v = new Veiculo.Unit();
                var listBusca = v.BuscaFicharioTodos("Veiculo");
                dataGrid_ListaVeiculos.Rows.Clear();

                for (int i = 0; i <= listBusca.Count - 1; i++)
                {
                    //Instanciando um grid do tipo formulario.
                    DataGridViewRow dataGrid = new DataGridViewRow();
                    //É como se estivesse criando celulas dentro dessa linha.
                    //Grid do Formulário.
                    dataGrid.CreateCells(dataGrid_ListaVeiculos);
                    //Nessas celulas vou escrever.
                    //To pegando a celula da coluna [0] e adicionando um valor. Na posição i na coluna 0. Que no caso vai pegar o ID.
                    dataGrid.Cells[0].Value = listBusca[i][0].ToString();
                    //To pegando a celula da coluna [0] e adicionando um valor. Na posição i na coluna 1. Que no caso vai pegar o Nome.
                    dataGrid.Cells[1].Value = listBusca[i][1].ToString();
                    //Vou adicionar dentro do Grid a linha.
                    dataGrid_ListaVeiculos.Rows.Add(dataGrid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
