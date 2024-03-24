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
            // Deixa "Todas" como elemento que já vem selecionado por padrão na ComboBox 
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
            string[] jogadores;
            string retorno = Jogo.ListarJogadores(idPartida);
            if(retorno.Length < 1)
            {
                retorno = "Não há jogadores na sala.";
                lstJogadores.Items.Clear();
                lstJogadores.Items.Add(retorno);
            }
            else
            {
                retorno = retorno.Replace("\r", "");
                retorno = retorno.Substring(0, retorno.Length - 1);
                jogadores = retorno.Split('\n');
                lstJogadores.Items.Clear();
                for (int i = 0; i < jogadores.Length; i++)
                {
                    lstJogadores.Items.Add(jogadores[i]);
                }
            }
            
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomePartida.Text;
            string senha = txtSenhaPartida.Text;
            string retorno = Jogo.CriarPartida(nome, senha, this.nomeDoGrupo);
            if(retorno.Contains("ERRO:"))
            {
                lblStatus.Text = "Status: " + retorno;
            }
            else
            {
                txtIdPartida.Text = retorno;
                lblStatus.Text = "Status: Partida criada com sucesso";
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string idPartida = txtIdPartida.Text;
            string senhaPartida = txtSenhaPartida.Text;
            string nomeJogador = txtNomeJogador.Text;
            string retorno = Jogo.EntrarPartida(int.Parse(idPartida), nomeJogador, senhaPartida);
            if (retorno.Contains("ERRO"))
            {
                lblStatus.Text = "Status: " + retorno;
            }
            else
            {
                string[] info = retorno.Split(',');
                string idJogador = info[0];
                string senhaJogador = info[1];
                txtIdJogador.Text = idJogador;
                txtSenhaJogador.Text= senhaJogador;
                lblStatus.Text = "Status: Jogador entrou na partida com sucesso";
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string senhaJogador = txtSenhaJogador.Text;
            string idJogador = txtIdJogador.Text;
            string retorno = Jogo.IniciarPartida(int.Parse(idJogador), senhaJogador);
            if (retorno.Contains("ERRO"))
            {
                lblStatus.Text = "Status: " + retorno;
            }
            else
            {
                lblStatus.Text = "Status: ";
                string idPartida = txtIdPartida.Text;
                ExibirTurno(retorno, idPartida);
            }
        }

        private void ExibirTurno(string retorno, string idPartida) // separei a função para reusar na verificação de vez e no iniciar partida
        {
            string[] jogadores;
            string jogadoresNaSala = Jogo.ListarJogadores(int.Parse(idPartida));
            jogadoresNaSala = jogadoresNaSala.Replace("\r", "");
            jogadoresNaSala = jogadoresNaSala.Substring(0, jogadoresNaSala.Length - 1);
            jogadores = jogadoresNaSala.Split('\n');
            string[] jogadorSorteado;
            if (jogadores[0].Contains(retorno))
            {
                jogadorSorteado = jogadores[0].Split(',');
                lblTurno.Text = "Turno do Jogador: " + jogadorSorteado[1] + "\n\r Id do Jogador: " + jogadorSorteado[0];
            }
            else
            {
                jogadorSorteado = jogadores[1].Split(',');
                lblTurno.Text = "Turno do Jogador: " + jogadorSorteado[1] + "\n\r Id do Jogador: " + jogadorSorteado[0];
            }
            ExibirCartas(jogadores.Length);
        }

        private void ExibirCartas(int jogadores)
        {
            string idPartida = txtIdPartida.Text; // Pega o ID da partida

            string retornoCartas = Jogo.ConsultarMao(int.Parse(idPartida));  // Retorna o jogador, naipe e posição
            retornoCartas = retornoCartas.Substring(0, retornoCartas.Length - 1);

            string[] cartasJogador = retornoCartas.Split('\n'); // Separando as cartas dos jogadores

            lstCartas.Items.Clear(); // Limpa a lista de cartas
      
            for(int i = 0; i < cartasJogador.Length; i++)
            {
                string dadosJogador = cartasJogador[i];
                lstCartas.Items.Add(dadosJogador);
                //tirei o if pois atualizando as cartas vai ficando desigual um lado do outro
                /*if (i == 11)
                {
                    lstCartas.Items.Add("\n");
                }*/
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string idJogador = txtIdJogador.Text;
            string senhaJogador = txtSenhaJogador.Text;
            string posicaoCarta = txtIdCarta.Text;
            string retorno = Jogo.Jogar(int.Parse(idJogador), senhaJogador, int.Parse(posicaoCarta)); //retorna o valor da carta jogada
            if (retorno.Contains("ERRO"))
            {
                lblStatus.Text = "Status: " + retorno;
            } else
            {
                lblStatus.Text = "Status: "; //limpa o status
                lblValorCarta.Text = "Valor da Carta: " + retorno; //exibe o valor da carta jogada
            }
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            string idJogador = txtIdJogador.Text;
            string senhaJogador = txtSenhaJogador.Text;
            string posicaoCarta = txtIdCarta.Text;
            string retorno = Jogo.Apostar(int.Parse(idJogador), senhaJogador, int.Parse(posicaoCarta)); //retorna o valor da carta
            if (retorno.Contains("ERRO"))
            {
                lblStatus.Text = "Status: " + retorno;
            }
            else
            {
                lblStatus.Text = "Status: ";
                lblValorCarta.Text = "Valor da Carta: " + retorno; //valor da carta apostada
            }
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            string idPartida = txtIdPartida.Text;
            string retorno = Jogo.VerificarVez(int.Parse(idPartida)); //retorna o historico da partida
            retorno = retorno.Replace("/r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);

            string[] info = retorno.Split('\n'); //info[0] exibe o turno atual e apartir do 1-(info.lenght-1) exibe as jogadas feitas

            string[] roundAtual = info[0].Split(','); //isola o status da partida, id do jogador da vez, rodada, Se esta apostando ou jogando

            ExibirTurno(roundAtual[1], idPartida); //manda o id do jogador da vez pra exibir o turno

            lstJogadas.Items.Clear();
            for(int i = 1; i < info.Length; i++)
            {
                lstJogadas.Items.Add(info[i]); //exibe as jogadas do turno atual
            }
        }
    }
}
