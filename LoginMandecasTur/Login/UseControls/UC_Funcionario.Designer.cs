namespace Login.UseControls
{
    partial class UC_Funcionario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Funcionario));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnBuscarFuncionario = new BotaoPadraoMandecas();
            txtBuscaFuncionario = new TextBox();
            dvgFuncionarios = new DataGridView();
            btnEditar = new DataGridViewImageColumn();
            btnExcluir = new DataGridViewImageColumn();
            pnlCadastraAcesso = new Panel();
            CBPerfilAcesso = new ComboBox();
            pnlTitulo = new Panel();
            lbCadastraAcesso = new Label();
            pnlSeparador = new Panel();
            pnlBotoesCAcesso = new Panel();
            btnCancelarCAcesso = new BotaoPadraoMandecas();
            btnSalvarCAcesso = new BotaoPadraoMandecas();
            pnlSeparador2 = new Panel();
            txtSenhaCAcesso = new TextBox();
            lbSenhaCAcesso = new Label();
            txtEmailCAcesso = new TextBox();
            lbEmailCAcesso = new Label();
            lbPerfilAcessoCAcesso = new Label();
            txtCPFCAcesso = new TextBox();
            txtNomeCAcesso = new TextBox();
            lbCPFAcesso = new Label();
            lbNomeCAcesso = new Label();
            lblLimparFiltro = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgFuncionarios).BeginInit();
            pnlCadastraAcesso.SuspendLayout();
            pnlTitulo.SuspendLayout();
            pnlBotoesCAcesso.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscarFuncionario
            // 
            btnBuscarFuncionario.BackColor = Color.FromArgb(68, 252, 124);
            btnBuscarFuncionario.FlatAppearance.BorderSize = 0;
            btnBuscarFuncionario.FlatStyle = FlatStyle.Flat;
            btnBuscarFuncionario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarFuncionario.ForeColor = Color.Black;
            btnBuscarFuncionario.Location = new Point(464, 46);
            btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            btnBuscarFuncionario.Size = new Size(75, 27);
            btnBuscarFuncionario.TabIndex = 3;
            btnBuscarFuncionario.Text = "Buscar";
            btnBuscarFuncionario.UseVisualStyleBackColor = false;
            btnBuscarFuncionario.Click += btnBuscarFuncionario_Click;
            // 
            // txtBuscaFuncionario
            // 
            txtBuscaFuncionario.Location = new Point(39, 48);
            txtBuscaFuncionario.Name = "txtBuscaFuncionario";
            txtBuscaFuncionario.PlaceholderText = "  Buscar por Nome ou CPF";
            txtBuscaFuncionario.Size = new Size(415, 23);
            txtBuscaFuncionario.TabIndex = 2;
            txtBuscaFuncionario.TextChanged += txtBuscaFuncionario_TextChanged;
            txtBuscaFuncionario.KeyDown += txtNomeCAcesso_KeyDown;
            // 
            // dvgFuncionarios
            // 
            dvgFuncionarios.AllowUserToAddRows = false;
            dvgFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgFuncionarios.BackgroundColor = Color.White;
            dvgFuncionarios.BorderStyle = BorderStyle.None;
            dvgFuncionarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvgFuncionarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgFuncionarios.ColumnHeadersHeight = 40;
            dvgFuncionarios.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnExcluir });
            dvgFuncionarios.EnableHeadersVisualStyles = false;
            dvgFuncionarios.Location = new Point(39, 109);
            dvgFuncionarios.Name = "dvgFuncionarios";
            dvgFuncionarios.RowHeadersVisible = false;
            dvgFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgFuncionarios.Size = new Size(723, 134);
            dvgFuncionarios.TabIndex = 5;
            dvgFuncionarios.CellClick += dvgFuncionarios_CellClick;
            dvgFuncionarios.Paint += dvgFuncionarios_Paint;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.Padding = new Padding(8);
            btnEditar.DefaultCellStyle = dataGridViewCellStyle2;
            btnEditar.HeaderText = "";
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnEditar.Name = "btnEditar";
            btnEditar.Width = 50;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            dataGridViewCellStyle3.Padding = new Padding(8);
            btnExcluir.DefaultCellStyle = dataGridViewCellStyle3;
            btnExcluir.HeaderText = "";
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Width = 50;
            // 
            // pnlCadastraAcesso
            // 
            pnlCadastraAcesso.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastraAcesso.BackColor = Color.White;
            pnlCadastraAcesso.BorderStyle = BorderStyle.FixedSingle;
            pnlCadastraAcesso.Controls.Add(CBPerfilAcesso);
            pnlCadastraAcesso.Controls.Add(pnlTitulo);
            pnlCadastraAcesso.Controls.Add(pnlSeparador);
            pnlCadastraAcesso.Controls.Add(pnlBotoesCAcesso);
            pnlCadastraAcesso.Controls.Add(pnlSeparador2);
            pnlCadastraAcesso.Controls.Add(txtSenhaCAcesso);
            pnlCadastraAcesso.Controls.Add(lbSenhaCAcesso);
            pnlCadastraAcesso.Controls.Add(txtEmailCAcesso);
            pnlCadastraAcesso.Controls.Add(lbEmailCAcesso);
            pnlCadastraAcesso.Controls.Add(lbPerfilAcessoCAcesso);
            pnlCadastraAcesso.Controls.Add(txtCPFCAcesso);
            pnlCadastraAcesso.Controls.Add(txtNomeCAcesso);
            pnlCadastraAcesso.Controls.Add(lbCPFAcesso);
            pnlCadastraAcesso.Controls.Add(lbNomeCAcesso);
            pnlCadastraAcesso.Location = new Point(39, 270);
            pnlCadastraAcesso.Name = "pnlCadastraAcesso";
            pnlCadastraAcesso.Size = new Size(724, 199);
            pnlCadastraAcesso.TabIndex = 6;
            pnlCadastraAcesso.Resize += pnlCadastraAcesso_Resize;
            // 
            // CBPerfilAcesso
            // 
            CBPerfilAcesso.Anchor = AnchorStyles.Right;
            CBPerfilAcesso.FormattingEnabled = true;
            CBPerfilAcesso.Items.AddRange(new object[] { "Selecione", "Administrador", "Padrão" });
            CBPerfilAcesso.Location = new Point(414, 109);
            CBPerfilAcesso.Name = "CBPerfilAcesso";
            CBPerfilAcesso.Size = new Size(172, 23);
            CBPerfilAcesso.TabIndex = 4;
            CBPerfilAcesso.KeyDown += txtNomeCAcesso_KeyDown;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(232, 232, 232);
            pnlTitulo.Controls.Add(lbCadastraAcesso);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(722, 53);
            pnlTitulo.TabIndex = 0;
            // 
            // lbCadastraAcesso
            // 
            lbCadastraAcesso.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCadastraAcesso.AutoSize = true;
            lbCadastraAcesso.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastraAcesso.Location = new Point(18, 20);
            lbCadastraAcesso.Name = "lbCadastraAcesso";
            lbCadastraAcesso.Size = new Size(112, 17);
            lbCadastraAcesso.TabIndex = 0;
            lbCadastraAcesso.Text = "Cadastrar Acesso";
            // 
            // pnlSeparador
            // 
            pnlSeparador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSeparador.BackColor = Color.FromArgb(232, 232, 232);
            pnlSeparador.Location = new Point(3, 99);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(724, 1);
            pnlSeparador.TabIndex = 5;
            // 
            // pnlBotoesCAcesso
            // 
            pnlBotoesCAcesso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlBotoesCAcesso.Controls.Add(btnCancelarCAcesso);
            pnlBotoesCAcesso.Controls.Add(btnSalvarCAcesso);
            pnlBotoesCAcesso.Location = new Point(277, 148);
            pnlBotoesCAcesso.Name = "pnlBotoesCAcesso";
            pnlBotoesCAcesso.Size = new Size(200, 46);
            pnlBotoesCAcesso.TabIndex = 15;
            // 
            // btnCancelarCAcesso
            // 
            btnCancelarCAcesso.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarCAcesso.BackColor = Color.FromArgb(194, 194, 194);
            btnCancelarCAcesso.FlatAppearance.BorderSize = 0;
            btnCancelarCAcesso.FlatStyle = FlatStyle.Flat;
            btnCancelarCAcesso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarCAcesso.ForeColor = Color.Black;
            btnCancelarCAcesso.Location = new Point(13, 9);
            btnCancelarCAcesso.Name = "btnCancelarCAcesso";
            btnCancelarCAcesso.Size = new Size(82, 26);
            btnCancelarCAcesso.TabIndex = 13;
            btnCancelarCAcesso.Text = "Cancelar";
            btnCancelarCAcesso.UseVisualStyleBackColor = false;
            btnCancelarCAcesso.Click += btnCancelarCAcesso_Click;
            // 
            // btnSalvarCAcesso
            // 
            btnSalvarCAcesso.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvarCAcesso.BackColor = Color.FromArgb(68, 252, 124);
            btnSalvarCAcesso.FlatAppearance.BorderSize = 0;
            btnSalvarCAcesso.FlatStyle = FlatStyle.Flat;
            btnSalvarCAcesso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarCAcesso.ForeColor = Color.Black;
            btnSalvarCAcesso.Location = new Point(104, 9);
            btnSalvarCAcesso.Name = "btnSalvarCAcesso";
            btnSalvarCAcesso.Size = new Size(82, 26);
            btnSalvarCAcesso.TabIndex = 5;
            btnSalvarCAcesso.Text = "Salvar";
            btnSalvarCAcesso.UseVisualStyleBackColor = false;
            btnSalvarCAcesso.Click += btnSalvarCAcesso_Click;
            // 
            // pnlSeparador2
            // 
            pnlSeparador2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSeparador2.BackColor = Color.FromArgb(232, 232, 232);
            pnlSeparador2.Location = new Point(0, 140);
            pnlSeparador2.Name = "pnlSeparador2";
            pnlSeparador2.Size = new Size(724, 1);
            pnlSeparador2.TabIndex = 11;
            // 
            // txtSenhaCAcesso
            // 
            txtSenhaCAcesso.Anchor = AnchorStyles.Right;
            txtSenhaCAcesso.Location = new Point(592, 65);
            txtSenhaCAcesso.Name = "txtSenhaCAcesso";
            txtSenhaCAcesso.Size = new Size(110, 23);
            txtSenhaCAcesso.TabIndex = 2;
            txtSenhaCAcesso.KeyDown += txtNomeCAcesso_KeyDown;
            // 
            // lbSenhaCAcesso
            // 
            lbSenhaCAcesso.Anchor = AnchorStyles.Right;
            lbSenhaCAcesso.AutoSize = true;
            lbSenhaCAcesso.Location = new Point(544, 71);
            lbSenhaCAcesso.Name = "lbSenhaCAcesso";
            lbSenhaCAcesso.Size = new Size(42, 15);
            lbSenhaCAcesso.TabIndex = 9;
            lbSenhaCAcesso.Text = "Senha:";
            // 
            // txtEmailCAcesso
            // 
            txtEmailCAcesso.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmailCAcesso.Location = new Point(62, 109);
            txtEmailCAcesso.Name = "txtEmailCAcesso";
            txtEmailCAcesso.Size = new Size(235, 23);
            txtEmailCAcesso.TabIndex = 3;
            txtEmailCAcesso.KeyDown += txtNomeCAcesso_KeyDown;
            // 
            // lbEmailCAcesso
            // 
            lbEmailCAcesso.Anchor = AnchorStyles.Left;
            lbEmailCAcesso.AutoSize = true;
            lbEmailCAcesso.Location = new Point(18, 114);
            lbEmailCAcesso.Name = "lbEmailCAcesso";
            lbEmailCAcesso.Size = new Size(39, 15);
            lbEmailCAcesso.TabIndex = 6;
            lbEmailCAcesso.Text = "Email:";
            // 
            // lbPerfilAcessoCAcesso
            // 
            lbPerfilAcessoCAcesso.Anchor = AnchorStyles.Right;
            lbPerfilAcessoCAcesso.AutoSize = true;
            lbPerfilAcessoCAcesso.Location = new Point(315, 114);
            lbPerfilAcessoCAcesso.Name = "lbPerfilAcessoCAcesso";
            lbPerfilAcessoCAcesso.Size = new Size(93, 15);
            lbPerfilAcessoCAcesso.TabIndex = 5;
            lbPerfilAcessoCAcesso.Text = "Perfil de Acesso:";
            // 
            // txtCPFCAcesso
            // 
            txtCPFCAcesso.Anchor = AnchorStyles.Right;
            txtCPFCAcesso.Location = new Point(352, 65);
            txtCPFCAcesso.Name = "txtCPFCAcesso";
            txtCPFCAcesso.Size = new Size(176, 23);
            txtCPFCAcesso.TabIndex = 1;
            txtCPFCAcesso.KeyDown += txtNomeCAcesso_KeyDown;
            // 
            // txtNomeCAcesso
            // 
            txtNomeCAcesso.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNomeCAcesso.Location = new Point(62, 66);
            txtNomeCAcesso.Name = "txtNomeCAcesso";
            txtNomeCAcesso.Size = new Size(235, 23);
            txtNomeCAcesso.TabIndex = 0;
            txtNomeCAcesso.KeyDown += txtNomeCAcesso_KeyDown;
            // 
            // lbCPFAcesso
            // 
            lbCPFAcesso.Anchor = AnchorStyles.Right;
            lbCPFAcesso.AutoSize = true;
            lbCPFAcesso.Location = new Point(315, 71);
            lbCPFAcesso.Name = "lbCPFAcesso";
            lbCPFAcesso.Size = new Size(31, 15);
            lbCPFAcesso.TabIndex = 2;
            lbCPFAcesso.Text = "CPF:";
            // 
            // lbNomeCAcesso
            // 
            lbNomeCAcesso.Anchor = AnchorStyles.Left;
            lbNomeCAcesso.AutoSize = true;
            lbNomeCAcesso.Location = new Point(18, 71);
            lbNomeCAcesso.Name = "lbNomeCAcesso";
            lbNomeCAcesso.Size = new Size(43, 15);
            lbNomeCAcesso.TabIndex = 1;
            lbNomeCAcesso.Text = "Nome:";
            // 
            // lblLimparFiltro
            // 
            lblLimparFiltro.AutoSize = true;
            lblLimparFiltro.Location = new Point(561, 58);
            lblLimparFiltro.Name = "lblLimparFiltro";
            lblLimparFiltro.Size = new Size(129, 15);
            lblLimparFiltro.TabIndex = 7;
            lblLimparFiltro.Text = "Limpar Filtros de Busca";
            lblLimparFiltro.Click += lblLimparFiltro_Click;
            // 
            // UC_Funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblLimparFiltro);
            Controls.Add(pnlCadastraAcesso);
            Controls.Add(dvgFuncionarios);
            Controls.Add(btnBuscarFuncionario);
            Controls.Add(txtBuscaFuncionario);
            Name = "UC_Funcionario";
            Size = new Size(826, 506);
            Load += UC_Funcionario_Load;
            ((System.ComponentModel.ISupportInitialize)dvgFuncionarios).EndInit();
            pnlCadastraAcesso.ResumeLayout(false);
            pnlCadastraAcesso.PerformLayout();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBotoesCAcesso.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BotaoPadraoMandecas btnBuscarFuncionario;
        private TextBox txtBuscaFuncionario;
        private DataGridView dvgFuncionarios;
        private Panel pnlCadastraAcesso;
        private Panel pnlTitulo;
        private Label lbCadastraAcesso;
        private Panel pnlSeparador;
        private Panel pnlBotoesCAcesso;
        private BotaoPadraoMandecas btnCancelarCAcesso;
        private BotaoPadraoMandecas btnSalvarCAcesso;
        private Panel pnlSeparador2;
        private TextBox txtSenhaCAcesso;
        private Label lbSenhaCAcesso;
        private TextBox txtEmailCAcesso;
        private Label lbEmailCAcesso;
        private Label lbPerfilAcessoCAcesso;
        private TextBox txtCPFCAcesso;
        private TextBox txtNomeCAcesso;
        private Label lbCPFAcesso;
        private Label lbNomeCAcesso;
        private ComboBox CBPerfilAcesso;
        private Label lblLimparFiltro;
        private DataGridViewImageColumn btnEditar;
        private DataGridViewImageColumn btnExcluir;
    }
}
