using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTrickServer;

namespace PrimeiraEntrega
{
    public partial class PrimeiraEntrega : Form
    {
        string tipoDePartida;
        string nomeDoGrupo = "Copenhague";

        public PrimeiraEntrega()
        {
            InitializeComponent();
            // Deixa "Todas" como elemento padrão que já vem selecionado na ComboBox 
            cboTipoDePartida.SelectedIndex = 0;
            this.tipoDePartida = cboTipoDePartida.SelectedItem.ToString();
        }

        private void cboTipoDePartida_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipoDePartida = cboTipoDePartida.SelectedItem.ToString();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            // Pegando a primeira letra do tipo de partida 
            string retorno = Jogo.ListarPartidas(this.tipoDePartida.Substring(0,1));
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0,retorno.Length-1);

            // Listar a partida
            string[] partidas = retorno.Split('\n');
            lstPartidas.Items.Clear();

            for (int i = 0; i < partidas.Length; i++)
            {
                lstPartidas.Items.Add(partidas[i]);
            }
        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partida = lstPartidas.SelectedItem.ToString();

            string[] dados = partida.Split(',');

            int idPartida = Convert.ToInt32(dados[0]);
            string nomePartida = dados[1];
            string data = dados[2];
            string status = dados[3];

            if (status == "A")
                status = "Aberto";
            else if (status == "J")
                status = "Jogando";
            else
                status = "Finalizada";

            // Mostrar informações da partida selecionada
            txtNomePartida.Text = nomePartida;
            txtIdPartida.Text = idPartida.ToString();
            lblDataPartida.Text = "Data de Criação: " + data;
            lblStatus.Text = "Status: " + status;

            // Mostrar jogadores
            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] jogadores = retorno.Split('\n');

            lstJogadores.Items.Clear();
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstJogadores.Items.Add(jogadores[i]);
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomePartida.Text;
            string senha = txtSenhaPartida.Text;
            string retorno = Jogo.CriarPartida(nome, senha, this.nomeDoGrupo);
            if(retorno == "ERRO: Partida já existente" || retorno == "ERRO: Senha obrigatória" || retorno == "ERRO: Nome da partida está vazio")
            {
                lblStatus.Text = "Status: " + retorno;
            }
            else
            {
                txtIdPartida.Text = retorno;
                lblStatus.Text = "Status: Partida criada com sucesso";
            }
        }
    }
}
