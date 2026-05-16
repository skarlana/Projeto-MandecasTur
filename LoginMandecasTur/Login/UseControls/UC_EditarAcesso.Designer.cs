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
            btnSalvarEditarAcesso = new BotaoPadraoMandecas();
            cbmperfil = new ComboBox();
            pnlEditarCadastro = new Panel();
            btnVoltar = new BotaoPadraoMandecas();
            txtemailacesso = new TextBox();
            txtcpfacesso = new TextBox();
            lbPerfilAcesso = new Label();
            lbEmail = new Label();
            lbCPF = new Label();
            txtnomeacesso = new TextBox();
            lbNome = new Label();
            lbDadosAcesso = new Label();
            lbCodigo = new Label();
            pnlCadastro.SuspendLayout();
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
            pnlCadastro.Controls.Add(btnSalvarEditarAcesso);
            pnlCadastro.Controls.Add(cbmperfil);
            pnlCadastro.Controls.Add(pnlEditarCadastro);
            pnlCadastro.Controls.Add(btnVoltar);
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
            pnlCadastro.Size = new Size(746, 278);
            pnlCadastro.TabIndex = 1;
            // 
            // btnSalvarEditarAcesso
            // 
            btnSalvarEditarAcesso.BackColor = Color.FromArgb(68, 252, 124);
            btnSalvarEditarAcesso.FlatAppearance.BorderSize = 0;
            btnSalvarEditarAcesso.FlatStyle = FlatStyle.Flat;
            btnSalvarEditarAcesso.Font = new Font("Segoe UI Semibold", 11F);
            btnSalvarEditarAcesso.ForeColor = Color.Black;
            btnSalvarEditarAcesso.Location = new Point(376, 228);
            btnSalvarEditarAcesso.Name = "btnSalvarEditarAcesso";
            btnSalvarEditarAcesso.Size = new Size(94, 36);
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
            pnlEditarCadastro.Location = new Point(0, 208);
            pnlEditarCadastro.Name = "pnlEditarCadastro";
            pnlEditarCadastro.Size = new Size(746, 2);
            pnlEditarCadastro.TabIndex = 1;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(194, 194, 194);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 11F);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(266, 228);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 36);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
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
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Location = new Point(69, 83);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(32, 15);
            lbCodigo.TabIndex = 11;
            lbCodigo.Text = "label";
            // 
            // UC_EditarAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lbCodigo);
            Controls.Add(lbDadosAcesso);
            Controls.Add(pnlCadastro);
            Controls.Add(pnlTitulo);
            Name = "UC_EditarAcesso";
            Size = new Size(922, 458);
            Load += UC_EditarAcesso_Load;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
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
        private Label lbCodigo;
        private BotaoPadraoMandecas btnVoltar;
        private Panel pnlEditarCadastro;
        private ComboBox cbmperfil;
        private BotaoPadraoMandecas btnSalvarEditarAcesso;
    }


}


