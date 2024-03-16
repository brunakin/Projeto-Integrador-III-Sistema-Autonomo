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
            this.lstPartidas.Location = new System.Drawing.Point(30, 86);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstPartidas.Size = new System.Drawing.Size(209, 173);
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
            this.lblGrupo.Location = new System.Drawing.Point(27, 677);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(68, 13);
            this.lblGrupo.TabIndex = 3;
            this.lblGrupo.Text = "Copenhaque";
            // 
            // lblDll
            // 
            this.lblDll.AutoSize = true;
            this.lblDll.Location = new System.Drawing.Point(175, 677);
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
            this.lstJogadores.Size = new System.Drawing.Size(209, 147);
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
            this.lblDataPartida.Location = new System.Drawing.Point(253, 86);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(90, 13);
            this.lblDataPartida.TabIndex = 8;
            this.lblDataPartida.Text = "Data de Criação: ";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(257, 285);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(132, 46);
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
            this.lblSenhaPartida.Location = new System.Drawing.Point(444, 11);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(92, 13);
            this.lblSenhaPartida.TabIndex = 12;
            this.lblSenhaPartida.Text = "Senha da Partida:";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(447, 27);
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
            this.lblStatus.Location = new System.Drawing.Point(257, 229);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(257, 113);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(94, 13);
            this.lblNomeJogador.TabIndex = 17;
            this.lblNomeJogador.Text = "Nome do Jogador:";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(257, 129);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(167, 20);
            this.txtNomeJogador.TabIndex = 18;
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(257, 178);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(91, 20);
            this.txtIdJogador.TabIndex = 20;
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(254, 162);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(75, 13);
            this.lblIdJogador.TabIndex = 19;
            this.lblIdJogador.Text = "Id do Jogador:";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(257, 350);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(132, 46);
            this.btnEntrarPartida.TabIndex = 21;
            this.btnEntrarPartida.Text = "Entrar Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            // 
            // PrimeiraEntrega
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 699);
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
    }
}

