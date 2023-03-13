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
    public partial class Cadastro_UC : UserControl
    {
        public Cadastro_UC()
        {
            InitializeComponent();
            btn_confirmar.Text = "Confirmar";
            rb_tipoCarro.Text = "Carro";
            rb_tipoMoto.Text = "Moto";
        }

        //Botão que confirma inserção de dados no banco de dados.
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            //Vamos tentar
            try
            {
                if (tb_cor.Text == "" || tb_modelo.Text == "" || tb_placa.Text == "" || tb_proprietario.Text == "" || rb_tipoCarro.Checked == false && rb_tipoMoto.Checked == false)
                {
                    MessageBox.Show("Preencha todos os campos corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Vamos instanciar a classe de veículos.
                    Veiculo.Unit veic = new Veiculo.Unit();
                    //Fazer a classe receber os dados digitados pelo usuário
                    veic = InserirAoFormulario();
                    //Com o método de inclusão vamos adicionar os dados ao banco.
                    veic.IncluirFicharioDB("Veiculo");
                    //Mensagem de sucesso.
                    MessageBox.Show("Veículo cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //Caso não dê bom vamos gerar uma excessão.
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.Message}", "Aviso" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Veiculo.Unit InserirAoFormulario()
        {
            Veiculo.Unit v = new Veiculo.Unit();
            v.Placa = tb_placa.Text;
            v.Proprietario = tb_proprietario.Text;
            v.Modelo = tb_modelo.Text;
            v.Cor = tb_cor.Text;
            v.DataEntrada = DateTime.Now;
            v.GuardaHoraEntrada = v.DataEntrada;
            if (rb_tipoCarro.Checked)
            {
                v.TipoVeiculo = TipoVeiculo.Carro;
            }
            else if (rb_tipoMoto.Checked)
            {
                v.TipoVeiculo = TipoVeiculo.Moto;
            }
            return v;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
