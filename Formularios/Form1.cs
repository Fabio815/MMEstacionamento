using MMEstacionamento.Formularios_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMEstacionamento
{
    public partial class F_principal : Form
    {
        int contadorCadastro = 0;
        int contadorAlterar = 0;
        int contadorListaVeiculo = 0;
        int contadorProcurarVeiculo = 0;
        int contadorSaidaVeiculo = 0;

        public F_principal()
        {
            InitializeComponent();
        }

        #region "Abrir Abas"
        private void cadastrarVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contadorCadastro == 0)
            {
                contadorCadastro++;
                //Instanciando o UC.
                Cadastro_UC cadastro = new Cadastro_UC();
                //Criando a aba que vai abrir o UC.
                TabPage pagina = new TabPage();
                pagina.Name = "cadastroVeic";
                pagina.Text = "Cadastro de Veículos";
                //Em seguinda vamos adiciona na aba.
                pagina.Controls.Add(cadastro);
                //E por último adicionamos ao TabPages, para mostrar ao usuário.
                tab_principal.TabPages.Add(pagina);
            }
            else
            {
                MessageBox.Show("Aba de cadastro já esta aberta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saídaDeVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contadorSaidaVeiculo == 0)
            {
                contadorSaidaVeiculo++;
                SaidaVeiculo_UC saidaVeiculos = new SaidaVeiculo_UC();
                TabPage pagina = new TabPage();
                pagina.Name = "saidaVeic";
                pagina.Text = "Saída de Veículos";
                pagina.Controls.Add(saidaVeiculos);
                tab_principal.TabPages.Add(pagina);
            }
            else
            {
                MessageBox.Show("Aba de saída veículo já esta aberta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void procurarVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contadorProcurarVeiculo == 0)
            {
                contadorProcurarVeiculo++;
                ProcuraVeiculo_UC procurarVeiculo = new ProcuraVeiculo_UC();
                TabPage pagina = new TabPage();
                pagina.Name = "procuraVeic";
                pagina.Text = "Procurar Veículo";
                pagina.Controls.Add(procurarVeiculo);
                tab_principal.TabPages.Add(pagina);
            }
            else
            {
                MessageBox.Show("Aba de procurar veículo já esta aberta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void listaDeVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contadorListaVeiculo == 0)
            {
                contadorListaVeiculo++;
                ListaVeiculos_UC listaVeiculos = new ListaVeiculos_UC();
                TabPage pagina = new TabPage();
                pagina.Name = "listaVeic";
                pagina.Text = "Lista de Veículos";
                pagina.Controls.Add(listaVeiculos);
                tab_principal.TabPages.Add(pagina);
            }
            else
            {
                MessageBox.Show("Aba de saída de veículo já esta aberta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region "Menu Flutuante"

        #region "Métodos Auxiliares"
        ToolStripMenuItem CriaItemMenu(string texto)
        {
            var vToolStrip = new ToolStripMenuItem();
            vToolStrip.Text = texto;
            return vToolStrip;
        }

        //Deleta as abas no geral.
        void DeletarAba(TabPage tabPage)
        {
            if (tabPage.Name == "cadastroVeic")
            {
                contadorCadastro = 0;
            }
            if (tabPage.Name == "saidaVeic")
            {
                contadorSaidaVeiculo = 0;
            }
            if (tabPage.Name == "alterarVeic")
            {
                contadorAlterar = 0;
            }
            if (tabPage.Name == "listaVeic")
            {
                contadorListaVeiculo = 0;
            }
            if (tabPage.Name == "procuraVeic")
            {
                contadorProcurarVeiculo = 0;
            }

            tab_principal.TabPages.Remove(tabPage);
        }

        //Nesse método vamos receber a posição que o usuário digitou e vamos deletar da direita para a esquerda.
        void DeletaEsquerda(int posicaoInicial)
        {
            for (int i = posicaoInicial - 1; i >= 0; i--)
            {
                DeletarAba(tab_principal.TabPages[i]);
                //tab_principal.TabPages.Remove(tab_principal.TabPages[i]);
            }
        }

        void DeletaDireita(int posicaoInicial, int totalAbas)
        {
            for (int i = totalAbas - 1; i > posicaoInicial; i--)
            {
                DeletarAba(tab_principal.TabPages[i]);
            }
        }
        void DeletarTodas(int totalAbas)
        {
            for (int i = totalAbas - 1; i >= 0; i--)
            {
                DeletarAba(tab_principal.TabPages[i]);
            }
        }
        #endregion
        private void tab_principal_MouseDown(object sender, MouseEventArgs e)
        {
            //Quando usuário clicar com o botão direito.
            if (e.Button == MouseButtons.Right)
            {
                //Instanciando o menuStrip, exibi um menu de atalho
                ContextMenuStrip menuContext = new ContextMenuStrip();
                //Criando a variável que vai receber a mensagem.
                var fecharAbaSelecionada = CriaItemMenu("Fechar aba selecionada");
                var fecharAbasEsquerda = CriaItemMenu("Fechar abas esquerda");
                var fecharAbasDireita = CriaItemMenu("Fechar abas direita");
                var fecharTodasMenosEsta = CriaItemMenu("Fechar todas menos está");
                var fecharTodas = CriaItemMenu("Fechar todas as abas");

                //Adicinando ao MenuStrip, para que seja mostrado quando o usuário clicar.
                menuContext.Items.Add(fecharAbaSelecionada);
                menuContext.Items.Add(fecharAbasDireita);
                menuContext.Items.Add(fecharAbasEsquerda);
                menuContext.Items.Add(fecharTodasMenosEsta);
                menuContext.Items.Add(fecharTodas);

                //Vai mostrar no ponto em que o usuário digitou, com base na posição do mause.
                menuContext.Show(this, new Point(e.X, e.Y));

                fecharAbaSelecionada.Click += new EventHandler(DeletarAbaSelecionada_Click);
                fecharAbasEsquerda.Click += new EventHandler(DeletarAbasEsquerda_Click);
                fecharAbasDireita.Click += new EventHandler(DeletarAbasDireita_Click);
                fecharTodasMenosEsta.Click += new EventHandler(DeletarTodasMenosSelecionada_Click);
                fecharTodas.Click += new EventHandler(DeletarTodasAbas_Click);

            }

            void DeletarAbaSelecionada_Click(object sender1, EventArgs e1)
            {
                if (tab_principal.SelectedTab != null)
                {
                    DeletarAba(tab_principal.SelectedTab);
                }
            }

            void DeletarAbasEsquerda_Click(object sender2, EventArgs e2)
            {
                if (!(tab_principal.SelectedTab == null))
                {
                    //Passamos como parametro a posição que o usuário esta com o mause.
                    DeletaEsquerda(tab_principal.SelectedIndex) ;
                }
            }

            void DeletarAbasDireita_Click(object sender3, EventArgs e3)
            {
                if (tab_principal.SelectedTab != null)
                {
                    DeletaDireita(tab_principal.SelectedIndex, tab_principal.TabCount);
                }
            }

            void DeletarTodasMenosSelecionada_Click(object sender4, EventArgs e4)
            {
                if (tab_principal.SelectedTab != null)
                {
                    DeletaEsquerda(tab_principal.SelectedIndex);
                    DeletaDireita(tab_principal.SelectedIndex, tab_principal.TabCount);
                }
            }

            void DeletarTodasAbas_Click(object sender5, EventArgs e5)
            {
                DeletarTodas(tab_principal.TabCount);
            }
        }
        #endregion
    }
}
