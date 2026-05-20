namespace Login.UseControls
{
    partial class UC_GestaoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GestaoClientes));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtBuscaGCliente = new TextBox();
            btnBuscarGClientes = new BotaoPadraoMandecas();
            dvgClientes = new DataGridView();
            btnEditar = new DataGridViewImageColumn();
            btnExcluir = new DataGridViewImageColumn();
            lbNomeGClientes = new Label();
            lbCPFGClientes = new Label();
            txtNomeGClientes = new TextBox();
            txtCPFGClientes = new TextBox();
            lbDtNascimento = new Label();
            lbEmail = new Label();
            txtEmailGClientes = new TextBox();
            lbTelefone = new Label();
            txtTelefoneGClientes = new TextBox();
            pnlSeparador2 = new Panel();
            pnlBotoes = new Panel();
            btnLimparGClientes = new BotaoPadraoDois();
            btnSalvarGClientes = new BotaoPadraoMandecas();
            pnlSeparador = new Panel();
            pnlTitulo = new Panel();
            lbCadastrarCliente = new Label();
            pnlCadastroCliente = new Panel();
            dtpDataNascGclientes = new DateTimePicker();
            lblLimparFiltro = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgClientes).BeginInit();
            pnlBotoes.SuspendLayout();
            pnlTitulo.SuspendLayout();
            pnlCadastroCliente.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscaGCliente
            // 
            txtBuscaGCliente.Location = new Point(48, 50);
            txtBuscaGCliente.Name = "txtBuscaGCliente";
            txtBuscaGCliente.PlaceholderText = "  Buscar por Nome, CPF";
            txtBuscaGCliente.Size = new Size(415, 23);
            txtBuscaGCliente.TabIndex = 0;
            txtBuscaGCliente.TextChanged += txtBuscaGCliente_TextChanged;
            txtBuscaGCliente.KeyDown += txtBuscaGCliente_KeyDown;
            // 
            // btnBuscarGClientes
            // 
            btnBuscarGClientes.BackColor = Color.FromArgb(68, 252, 124);
            btnBuscarGClientes.FlatAppearance.BorderSize = 0;
            btnBuscarGClientes.FlatStyle = FlatStyle.Flat;
            btnBuscarGClientes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarGClientes.ForeColor = Color.Black;
            btnBuscarGClientes.Location = new Point(473, 48);
            btnBuscarGClientes.Name = "btnBuscarGClientes";
            btnBuscarGClientes.Size = new Size(75, 27);
            btnBuscarGClientes.TabIndex = 1;
            btnBuscarGClientes.Text = "Buscar";
            btnBuscarGClientes.UseVisualStyleBackColor = false;
            btnBuscarGClientes.Click += btnBuscarGClientes_Click;
            // 
            // dvgClientes
            // 
            dvgClientes.AllowUserToAddRows = false;
            dvgClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgClientes.BackgroundColor = Color.White;
            dvgClientes.BorderStyle = BorderStyle.None;
            dvgClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvgClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgClientes.ColumnHeadersHeight = 40;
            dvgClientes.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnExcluir });
            dvgClientes.EnableHeadersVisualStyles = false;
            dvgClientes.Location = new Point(47, 101);
            dvgClientes.Name = "dvgClientes";
            dvgClientes.RowHeadersVisible = false;
            dvgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgClientes.Size = new Size(723, 134);
            dvgClientes.TabIndex = 4;
            dvgClientes.CellClick += dvgClientes_CellClick;
            dvgClientes.Paint += dvgClientes_Paint;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
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
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new Padding(8);
            btnExcluir.DefaultCellStyle = dataGridViewCellStyle3;
            btnExcluir.HeaderText = "";
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Width = 50;
            // 
            // lbNomeGClientes
            // 
            lbNomeGClientes.Anchor = AnchorStyles.Left;
            lbNomeGClientes.AutoSize = true;
            lbNomeGClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNomeGClientes.Location = new Point(9, 68);
            lbNomeGClientes.Name = "lbNomeGClientes";
            lbNomeGClientes.Size = new Size(108, 17);
            lbNomeGClientes.TabIndex = 1;
            lbNomeGClientes.Text = "Nome Completo:";
            // 
            // lbCPFGClientes
            // 
            lbCPFGClientes.Anchor = AnchorStyles.Right;
            lbCPFGClientes.AutoSize = true;
            lbCPFGClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCPFGClientes.Location = new Point(494, 68);
            lbCPFGClientes.Name = "lbCPFGClientes";
            lbCPFGClientes.Size = new Size(32, 17);
            lbCPFGClientes.TabIndex = 2;
            lbCPFGClientes.Text = "CPF:";
            // 
            // txtNomeGClientes
            // 
            txtNomeGClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNomeGClientes.Location = new Point(123, 65);
            txtNomeGClientes.Name = "txtNomeGClientes";
            txtNomeGClientes.Size = new Size(356, 23);
            txtNomeGClientes.TabIndex = 0;
            txtNomeGClientes.KeyDown += txtBuscaGCliente_KeyDown;
            // 
            // txtCPFGClientes
            // 
            txtCPFGClientes.Anchor = AnchorStyles.Right;
            txtCPFGClientes.Location = new Point(528, 65);
            txtCPFGClientes.Name = "txtCPFGClientes";
            txtCPFGClientes.Size = new Size(176, 23);
            txtCPFGClientes.TabIndex = 1;
            txtCPFGClientes.KeyDown += txtBuscaGCliente_KeyDown;
            // 
            // lbDtNascimento
            // 
            lbDtNascimento.Anchor = AnchorStyles.Left;
            lbDtNascimento.AutoSize = true;
            lbDtNascimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDtNascimento.Location = new Point(9, 109);
            lbDtNascimento.Name = "lbDtNascimento";
            lbDtNascimento.Size = new Size(130, 17);
            lbDtNascimento.TabIndex = 5;
            lbDtNascimento.Text = "Data de Nascimento:";
            // 
            // lbEmail
            // 
            lbEmail.Anchor = AnchorStyles.Left;
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(486, 109);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(42, 17);
            lbEmail.TabIndex = 6;
            lbEmail.Text = "Email:";
            // 
            // txtEmailGClientes
            // 
            txtEmailGClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmailGClientes.Location = new Point(529, 106);
            txtEmailGClientes.Name = "txtEmailGClientes";
            txtEmailGClientes.Size = new Size(176, 23);
            txtEmailGClientes.TabIndex = 4;
            txtEmailGClientes.KeyDown += txtBuscaGCliente_KeyDown;
            // 
            // lbTelefone
            // 
            lbTelefone.Anchor = AnchorStyles.Left;
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTelefone.Location = new Point(294, 109);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(60, 17);
            lbTelefone.TabIndex = 9;
            lbTelefone.Text = "Telefone:";
            // 
            // txtTelefoneGClientes
            // 
            txtTelefoneGClientes.Anchor = AnchorStyles.Left;
            txtTelefoneGClientes.Location = new Point(360, 106);
            txtTelefoneGClientes.Name = "txtTelefoneGClientes";
            txtTelefoneGClientes.Size = new Size(119, 23);
            txtTelefoneGClientes.TabIndex = 3;
            txtTelefoneGClientes.KeyDown += txtBuscaGCliente_KeyDown;
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
            // pnlBotoes
            // 
            pnlBotoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlBotoes.BackColor = Color.Transparent;
            pnlBotoes.Controls.Add(btnLimparGClientes);
            pnlBotoes.Controls.Add(btnSalvarGClientes);
            pnlBotoes.Location = new Point(279, 147);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(200, 47);
            pnlBotoes.TabIndex = 15;
            // 
            // btnLimparGClientes
            // 
            btnLimparGClientes.BackColor = Color.FromArgb(194, 194, 194);
            btnLimparGClientes.FlatAppearance.BorderSize = 0;
            btnLimparGClientes.FlatStyle = FlatStyle.Flat;
            btnLimparGClientes.Font = new Font("Segoe UI Semibold", 10F);
            btnLimparGClientes.ForeColor = Color.Black;
            btnLimparGClientes.Location = new Point(15, 11);
            btnLimparGClientes.Name = "btnLimparGClientes";
            btnLimparGClientes.Size = new Size(82, 26);
            btnLimparGClientes.TabIndex = 16;
            btnLimparGClientes.Text = "Limpar";
            btnLimparGClientes.UseVisualStyleBackColor = false;
            btnLimparGClientes.Click += btnLimparGClientes_Click;
            // 
            // btnSalvarGClientes
            // 
            btnSalvarGClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvarGClientes.BackColor = Color.FromArgb(68, 252, 124);
            btnSalvarGClientes.FlatAppearance.BorderSize = 0;
            btnSalvarGClientes.FlatStyle = FlatStyle.Flat;
            btnSalvarGClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarGClientes.ForeColor = Color.Black;
            btnSalvarGClientes.Location = new Point(104, 11);
            btnSalvarGClientes.Name = "btnSalvarGClientes";
            btnSalvarGClientes.Size = new Size(82, 26);
            btnSalvarGClientes.TabIndex = 14;
            btnSalvarGClientes.Text = "Salvar";
            btnSalvarGClientes.UseVisualStyleBackColor = false;
            btnSalvarGClientes.Click += btnSalvarGClientes_Click;
            // 
            // pnlSeparador
            // 
            pnlSeparador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSeparador.BackColor = Color.FromArgb(232, 232, 232);
            pnlSeparador.Location = new Point(3, 96);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(724, 1);
            pnlSeparador.TabIndex = 5;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTitulo.BackColor = Color.FromArgb(232, 232, 232);
            pnlTitulo.Controls.Add(lbCadastrarCliente);
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(722, 53);
            pnlTitulo.TabIndex = 0;
            // 
            // lbCadastrarCliente
            // 
            lbCadastrarCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCadastrarCliente.AutoSize = true;
            lbCadastrarCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastrarCliente.Location = new Point(9, 19);
            lbCadastrarCliente.Name = "lbCadastrarCliente";
            lbCadastrarCliente.Size = new Size(128, 20);
            lbCadastrarCliente.TabIndex = 0;
            lbCadastrarCliente.Text = "Cadastrar Cliente";
            // 
            // pnlCadastroCliente
            // 
            pnlCadastroCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastroCliente.BackColor = Color.White;
            pnlCadastroCliente.BorderStyle = BorderStyle.FixedSingle;
            pnlCadastroCliente.Controls.Add(dtpDataNascGclientes);
            pnlCadastroCliente.Controls.Add(pnlTitulo);
            pnlCadastroCliente.Controls.Add(pnlSeparador);
            pnlCadastroCliente.Controls.Add(pnlBotoes);
            pnlCadastroCliente.Controls.Add(pnlSeparador2);
            pnlCadastroCliente.Controls.Add(txtTelefoneGClientes);
            pnlCadastroCliente.Controls.Add(lbTelefone);
            pnlCadastroCliente.Controls.Add(txtEmailGClientes);
            pnlCadastroCliente.Controls.Add(lbEmail);
            pnlCadastroCliente.Controls.Add(lbDtNascimento);
            pnlCadastroCliente.Controls.Add(txtCPFGClientes);
            pnlCadastroCliente.Controls.Add(txtNomeGClientes);
            pnlCadastroCliente.Controls.Add(lbCPFGClientes);
            pnlCadastroCliente.Controls.Add(lbNomeGClientes);
            pnlCadastroCliente.Location = new Point(47, 263);
            pnlCadastroCliente.Name = "pnlCadastroCliente";
            pnlCadastroCliente.Size = new Size(724, 199);
            pnlCadastroCliente.TabIndex = 3;
            pnlCadastroCliente.Paint += pnlCadastroCliente_Paint;
            pnlCadastroCliente.Resize += pnlCadastroCliente_Resize;
            // 
            // dtpDataNascGclientes
            // 
            dtpDataNascGclientes.Format = DateTimePickerFormat.Short;
            dtpDataNascGclientes.Location = new Point(142, 106);
            dtpDataNascGclientes.Name = "dtpDataNascGclientes";
            dtpDataNascGclientes.Size = new Size(139, 23);
            dtpDataNascGclientes.TabIndex = 2;
            dtpDataNascGclientes.KeyDown += txtBuscaGCliente_KeyDown;
            // 
            // lblLimparFiltro
            // 
            lblLimparFiltro.AutoSize = true;
            lblLimparFiltro.Location = new Point(554, 56);
            lblLimparFiltro.Name = "lblLimparFiltro";
            lblLimparFiltro.Size = new Size(129, 15);
            lblLimparFiltro.TabIndex = 5;
            lblLimparFiltro.Text = "Limpar Filtros de Busca";
            lblLimparFiltro.Click += lblLimparFiltro_Click;
            lblLimparFiltro.MouseEnter += lblLimparFiltro_MouseEnter;
            lblLimparFiltro.MouseLeave += lblLimparFiltro_MouseLeave;
            // 
            // UC_GestaoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblLimparFiltro);
            Controls.Add(dvgClientes);
            Controls.Add(pnlCadastroCliente);
            Controls.Add(btnBuscarGClientes);
            Controls.Add(txtBuscaGCliente);
            Name = "UC_GestaoClientes";
            Padding = new Padding(20);
            Size = new Size(826, 506);
            Load += UC_GestaoClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dvgClientes).EndInit();
            pnlBotoes.ResumeLayout(false);
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlCadastroCliente.ResumeLayout(false);
            pnlCadastroCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscaGCliente;
        private BotaoPadraoMandecas btnBuscarGClientes;
        private DataGridView dvgClientes;
        private Label lbNomeGClientes;
        private Label lbCPFGClientes;
        private TextBox txtNomeGClientes;
        private TextBox txtCPFGClientes;
        private Label lbDtNascimento;
        private Label lbEmail;
        private TextBox txtEmailGClientes;
        private Label lbTelefone;
        private TextBox txtTelefoneGClientes;
        private Panel pnlSeparador2;
        private Panel pnlBotoes;
        private BotaoPadraoMandecas btnSalvarGClientes;
        private Panel pnlSeparador;
        private Panel pnlTitulo;
        private Label lbCadastrarCliente;
        private Panel pnlCadastroCliente;
        private DataGridViewImageColumn btnEditar;
        private DataGridViewImageColumn btnExcluir;
        private DateTimePicker dtpDataNascGclientes;
        private Label lblLimparFiltro;
        private BotaoPadraoDois btnLimparGClientes;
    }
}
