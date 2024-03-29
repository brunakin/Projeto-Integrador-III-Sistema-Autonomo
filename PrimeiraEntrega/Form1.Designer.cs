namespace PrimeiraEntrega
{
    partial class PrimeiraEntrega
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.cboTipoDePartida = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblDll = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.lblDataPartida = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lstCartas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCarta = new System.Windows.Forms.TextBox();
            this.lblIdCarta = new System.Windows.Forms.Label();
            this.btnApostar = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblValorCarta = new System.Windows.Forms.Label();
            this.lstJogadas = new System.Windows.Forms.ListBox();
            this.lblJogadas = new System.Windows.Forms.Label();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(30, 12);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(101, 46);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.Location = new System.Drawing.Point(30, 64);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstPartidas.Size = new System.Drawing.Size(209, 199);
            this.lstPartidas.TabIndex = 1;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // cboTipoDePartida
            // 
            this.cboTipoDePartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDePartida.FormattingEnabled = true;
            this.cboTipoDePartida.Items.AddRange(new object[] {
            "Todas",
            "Aberta",
            "Jogando",
            "Finalizadas"});
            this.cboTipoDePartida.Location = new System.Drawing.Point(153, 26);
            this.cboTipoDePartida.Name = "cboTipoDePartida";
            this.cboTipoDePartida.Size = new System.Drawing.Size(86, 21);
            this.cboTipoDePartida.TabIndex = 2;
            this.cboTipoDePartida.SelectedIndexChanged += new System.EventHandler(this.cboTipoDePartida_SelectedIndexChanged);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(27, 362);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(68, 13);
            this.lblGrupo.TabIndex = 3;
            this.lblGrupo.Text = "Copenhaque";
            // 
            // lblDll
            // 
            this.lblDll.AutoSize = true;
            this.lblDll.Location = new System.Drawing.Point(114, 362);
            this.lblDll.Name = "lblDll";
            this.lblDll.Size = new System.Drawing.Size(99, 13);
            this.lblDll.TabIndex = 4;
            this.lblDll.Text = "Versão da DLL: 1.2";
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(30, 272);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstJogadores.Size = new System.Drawing.Size(209, 69);
            this.lstJogadores.TabIndex = 5;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(254, 10);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(89, 13);
            this.lblNomePartida.TabIndex = 6;
            this.lblNomePartida.Text = "Nome da Partida:";
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(254, 59);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(70, 13);
            this.lblIdPartida.TabIndex = 7;
            this.lblIdPartida.Text = "Id da Partida:";
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Location = new System.Drawing.Point(438, 58);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(90, 13);
            this.lblDataPartida.TabIndex = 8;
            this.lblDataPartida.Text = "Data de Criação: ";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(439, 86);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(167, 34);
            this.btnCriarPartida.TabIndex = 9;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(257, 26);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(167, 20);
            this.txtNomePartida.TabIndex = 11;
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Location = new System.Drawing.Point(436, 10);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(92, 13);
            this.lblSenhaPartida.TabIndex = 12;
            this.lblSenhaPartida.Text = "Senha da Partida:";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(441, 27);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(167, 20);
            this.txtSenhaPartida.TabIndex = 13;
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(330, 56);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(94, 20);
            this.txtIdPartida.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(254, 362);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(254, 86);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(94, 13);
            this.lblNomeJogador.TabIndex = 17;
            this.lblNomeJogador.Text = "Nome do Jogador:";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(257, 102);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(167, 20);
            this.txtNomeJogador.TabIndex = 18;
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(335, 133);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(89, 20);
            this.txtIdJogador.TabIndex = 20;
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(254, 136);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(75, 13);
            this.lblIdJogador.TabIndex = 19;
            this.lblIdJogador.Text = "Id do Jogador:";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(439, 126);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(167, 34);
            this.btnEntrarPartida.TabIndex = 21;
            this.btnEntrarPartida.Text = "Entrar Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(357, 163);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(67, 20);
            this.txtSenhaJogador.TabIndex = 23;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(254, 166);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(97, 13);
            this.lblSenhaJogador.TabIndex = 22;
            this.lblSenhaJogador.Text = "Senha do Jogador:";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(439, 166);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(167, 34);
            this.btnIniciarPartida.TabIndex = 24;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTurno.Location = new System.Drawing.Point(436, 259);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(130, 17);
            this.lblTurno.TabIndex = 25;
            this.lblTurno.Text = "Turno do Jogador: ";
            // 
            // lstCartas
            // 
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.Location = new System.Drawing.Point(640, 26);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(131, 316);
            this.lstCartas.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cartas da Partida";
            // 
            // txtIdCarta
            // 
            this.txtIdCarta.Location = new System.Drawing.Point(330, 213);
            this.txtIdCarta.Name = "txtIdCarta";
            this.txtIdCarta.Size = new System.Drawing.Size(94, 20);
            this.txtIdCarta.TabIndex = 29;
            // 
            // lblIdCarta
            // 
            this.lblIdCarta.AutoSize = true;
            this.lblIdCarta.Location = new System.Drawing.Point(254, 216);
            this.lblIdCarta.Name = "lblIdCarta";
            this.lblIdCarta.Size = new System.Drawing.Size(73, 13);
            this.lblIdCarta.TabIndex = 28;
            this.lblIdCarta.Text = "Carta Jogada:";
            // 
            // btnApostar
            // 
            this.btnApostar.Location = new System.Drawing.Point(257, 299);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(167, 34);
            this.btnApostar.TabIndex = 31;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(257, 259);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(167, 34);
            this.btnJogar.TabIndex = 30;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblValorCarta
            // 
            this.lblValorCarta.AutoSize = true;
            this.lblValorCarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblValorCarta.Location = new System.Drawing.Point(436, 319);
            this.lblValorCarta.Name = "lblValorCarta";
            this.lblValorCarta.Size = new System.Drawing.Size(103, 17);
            this.lblValorCarta.TabIndex = 32;
            this.lblValorCarta.Text = "Valor da Carta:";
            // 
            // lstJogadas
            // 
            this.lstJogadas.FormattingEnabled = true;
            this.lstJogadas.Location = new System.Drawing.Point(777, 27);
            this.lstJogadas.Name = "lstJogadas";
            this.lstJogadas.Size = new System.Drawing.Size(131, 316);
            this.lstJogadas.TabIndex = 33;
            // 
            // lblJogadas
            // 
            this.lblJogadas.AutoSize = true;
            this.lblJogadas.Location = new System.Drawing.Point(774, 9);
            this.lblJogadas.Name = "lblJogadas";
            this.lblJogadas.Size = new System.Drawing.Size(123, 13);
            this.lblJogadas.TabIndex = 34;
            this.lblJogadas.Text = "Jogadas do Turno Atual:";
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(439, 205);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(167, 34);
            this.btnVerificarVez.TabIndex = 35;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // PrimeiraEntrega
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 384);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.lblJogadas);
            this.Controls.Add(this.lstJogadas);
            this.Controls.Add(this.lblValorCarta);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtIdCarta);
            this.Controls.Add(this.lblIdCarta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCartas);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lblDataPartida);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lblDll);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.cboTipoDePartida);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.Name = "PrimeiraEntrega";
            this.Text = "Primeira Entrega";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.ComboBox cboTipoDePartida;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblDll;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Label lblDataPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ListBox lstCartas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCarta;
        private System.Windows.Forms.Label lblIdCarta;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblValorCarta;
        private System.Windows.Forms.ListBox lstJogadas;
        private System.Windows.Forms.Label lblJogadas;
        private System.Windows.Forms.Button btnVerificarVez;
    }
}

