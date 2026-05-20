namespace Login.UseControls
{
    partial class UC_EditarAcesso
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTitulo = new Panel();
            pnlCadastro = new Panel();
            pnlBotoes = new Panel();
            btnVoltarEditarAcesso = new BotaoPadraoDois();
            btnSalvarEditarAcesso = new BotaoPadraoMandecas();
            cbmperfil = new ComboBox();
            pnlEditarCadastro = new Panel();
            txtemailacesso = new TextBox();
            txtcpfacesso = new TextBox();
            lbPerfilAcesso = new Label();
            lbEmail = new Label();
            lbCPF = new Label();
            txtnomeacesso = new TextBox();
            lbNome = new Label();
            lbDadosAcesso = new Label();
            label1 = new Label();
            lbCodigo = new Label();
            pnlCadastro.SuspendLayout();
            pnlBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTitulo.BackColor = Color.FromArgb(68, 252, 124);
            pnlTitulo.Font = new Font("Segoe UI", 9F);
            pnlTitulo.Location = new Point(17, 78);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(811, 2);
            pnlTitulo.TabIndex = 0;
            // 
            // pnlCadastro
            // 
            pnlCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(pnlBotoes);
            pnlCadastro.Controls.Add(cbmperfil);
            pnlCadastro.Controls.Add(pnlEditarCadastro);
            pnlCadastro.Controls.Add(txtemailacesso);
            pnlCadastro.Controls.Add(txtcpfacesso);
            pnlCadastro.Controls.Add(lbPerfilAcesso);
            pnlCadastro.Controls.Add(lbEmail);
            pnlCadastro.Controls.Add(lbCPF);
            pnlCadastro.Controls.Add(txtnomeacesso);
            pnlCadastro.Controls.Add(lbNome);
            pnlCadastro.Font = new Font("Segoe UI", 9F);
            pnlCadastro.Location = new Point(82, 122);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(746, 261);
            pnlCadastro.TabIndex = 1;
            pnlCadastro.Resize += pnlCadastro_Resize;
            // 
            // pnlBotoes
            // 
            pnlBotoes.BackColor = Color.Transparent;
            pnlBotoes.Controls.Add(btnVoltarEditarAcesso);
            pnlBotoes.Controls.Add(btnSalvarEditarAcesso);
            pnlBotoes.Location = new Point(312, 210);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(200, 48);
            pnlBotoes.TabIndex = 15;
            // 
            // btnVoltarEditarAcesso
            // 
            btnVoltarEditarAcesso.BackColor = Color.FromArgb(194, 194, 194);
            btnVoltarEditarAcesso.FlatAppearance.BorderSize = 0;
            btnVoltarEditarAcesso.FlatStyle = FlatStyle.Flat;
            btnVoltarEditarAcesso.Font = new Font("Segoe UI Semibold", 10F);
            btnVoltarEditarAcesso.ForeColor = Color.Black;
            btnVoltarEditarAcesso.Location = new Point(12, 12);
            btnVoltarEditarAcesso.Name = "btnVoltarEditarAcesso";
            btnVoltarEditarAcesso.Size = new Size(82, 26);
            btnVoltarEditarAcesso.TabIndex = 15;
            btnVoltarEditarAcesso.Text = "Voltar";
            btnVoltarEditarAcesso.UseVisualStyleBackColor = false;
            btnVoltarEditarAcesso.Click += btnVoltarEditarAcesso_Click;
            // 
            // btnSalvarEditarAcesso
            // 
            btnSalvarEditarAcesso.BackColor = Color.FromArgb(68, 252, 124);
            btnSalvarEditarAcesso.FlatAppearance.BorderSize = 0;
            btnSalvarEditarAcesso.FlatStyle = FlatStyle.Flat;
            btnSalvarEditarAcesso.Font = new Font("Segoe UI Semibold", 11F);
            btnSalvarEditarAcesso.ForeColor = Color.Black;
            btnSalvarEditarAcesso.Location = new Point(102, 12);
            btnSalvarEditarAcesso.Name = "btnSalvarEditarAcesso";
            btnSalvarEditarAcesso.Size = new Size(82, 26);
            btnSalvarEditarAcesso.TabIndex = 14;
            btnSalvarEditarAcesso.Text = "Salvar";
            btnSalvarEditarAcesso.UseVisualStyleBackColor = false;
            btnSalvarEditarAcesso.Click += btnSalvarEditarAcesso_Click;
            // 
            // cbmperfil
            // 
            cbmperfil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbmperfil.FormattingEnabled = true;
            cbmperfil.Items.AddRange(new object[] { "Administrador", "Padrão" });
            cbmperfil.Location = new Point(228, 155);
            cbmperfil.Name = "cbmperfil";
            cbmperfil.Size = new Size(467, 23);
            cbmperfil.TabIndex = 12;
            // 
            // pnlEditarCadastro
            // 
            pnlEditarCadastro.BackColor = Color.FromArgb(232, 232, 232);
            pnlEditarCadastro.Font = new Font("Segoe UI", 9F);
            pnlEditarCadastro.Location = new Point(0, 203);
            pnlEditarCadastro.Name = "pnlEditarCadastro";
            pnlEditarCadastro.Size = new Size(746, 2);
            pnlEditarCadastro.TabIndex = 1;
            // 
            // txtemailacesso
            // 
            txtemailacesso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtemailacesso.Location = new Point(228, 109);
            txtemailacesso.Name = "txtemailacesso";
            txtemailacesso.Size = new Size(467, 23);
            txtemailacesso.TabIndex = 8;
            // 
            // txtcpfacesso
            // 
            txtcpfacesso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtcpfacesso.Location = new Point(228, 71);
            txtcpfacesso.Name = "txtcpfacesso";
            txtcpfacesso.Size = new Size(467, 23);
            txtcpfacesso.TabIndex = 7;
            // 
            // lbPerfilAcesso
            // 
            lbPerfilAcesso.AutoSize = true;
            lbPerfilAcesso.Location = new Point(43, 163);
            lbPerfilAcesso.Name = "lbPerfilAcesso";
            lbPerfilAcesso.Size = new Size(93, 15);
            lbPerfilAcesso.TabIndex = 6;
            lbPerfilAcesso.Text = "Perfil de Acesso:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(43, 117);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(39, 15);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email:";
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Location = new Point(43, 79);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(31, 15);
            lbCPF.TabIndex = 4;
            lbCPF.Text = "CPF:";
            // 
            // txtnomeacesso
            // 
            txtnomeacesso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtnomeacesso.Location = new Point(228, 33);
            txtnomeacesso.Name = "txtnomeacesso";
            txtnomeacesso.Size = new Size(467, 23);
            txtnomeacesso.TabIndex = 3;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(43, 36);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(43, 15);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome:";
            // 
            // lbDadosAcesso
            // 
            lbDadosAcesso.AutoSize = true;
            lbDadosAcesso.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDadosAcesso.Location = new Point(10, 39);
            lbDadosAcesso.Name = "lbDadosAcesso";
            lbDadosAcesso.Size = new Size(281, 32);
            lbDadosAcesso.TabIndex = 10;
            lbDadosAcesso.Text = "Editar Dados de Acesso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 83);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 12;
            label1.Text = "Código do Funcionário:";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Location = new Point(170, 83);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(38, 15);
            lbCodigo.TabIndex = 13;
            lbCodigo.Text = "label2";
            // 
            // UC_EditarAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lbCodigo);
            Controls.Add(label1);
            Controls.Add(lbDadosAcesso);
            Controls.Add(pnlCadastro);
            Controls.Add(pnlTitulo);
            Name = "UC_EditarAcesso";
            Size = new Size(922, 458);
            Load += UC_EditarAcesso_Load;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            pnlBotoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlCadastro;
        private Label lbNome;
        private TextBox txtnomeacesso;
        private TextBox txtemailacesso;
        private TextBox txtcpfacesso;
        private Label lbPerfilAcesso;
        private Label lbEmail;
        private Label lbCPF;
        private Label lbDadosAcesso;
        private Panel pnlEditarCadastro;
        private ComboBox cbmperfil;
        private BotaoPadraoMandecas btnSalvarEditarAcesso;
        private Panel pnlBotoes;
        private BotaoPadraoDois btnVoltarEditarAcesso;
        private Label label1;
        private Label lbCodigo;
    }


}


