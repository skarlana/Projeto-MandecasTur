namespace Login.UseControls
{
    partial class UC_GestaoViagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GestaoViagens));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtBuscaGViagens = new TextBox();
            dvgViagens = new DataGridView();
            btnEditar = new DataGridViewImageColumn();
            btnIncluir = new DataGridViewImageColumn();
            btnExcluir = new DataGridViewImageColumn();
            pnlCadastrarViagens = new Panel();
            pnlBotoes = new Panel();
            btnSalvar = new BotaoPadraoMandecas();
            btnLimparGViagens = new BotaoPadraoDois();
            btnCancelarGClientes = new BotaoPadraoMandecas();
            btnSalvarGClientes = new BotaoPadraoMandecas();
            txtCustoHospedagemCViagem = new TextBox();
            txtQTDVagaCViagens = new TextBox();
            lbQTDVagaCViagem = new Label();
            DTPDataCViagem = new DateTimePicker();
            pnlTitulo = new Panel();
            lbCadastraViagem = new Label();
            pnlSeparador = new Panel();
            pnlSeparador2 = new Panel();
            txtTransporteCViagens = new TextBox();
            lbTransporteGViagens = new Label();
            txtCustoTransporteCViagem = new TextBox();
            lbCustoTransporteCViagem = new Label();
            lblbCustoHospedagemCViagem = new Label();
            txtDestinoViagens = new TextBox();
            lbDataGViagens = new Label();
            lbDestinoGViagens = new Label();
            lblLimparFiltro = new Label();
            btnBuscar = new BotaoPadraoMandecas();
            ((System.ComponentModel.ISupportInitialize)dvgViagens).BeginInit();
            pnlCadastrarViagens.SuspendLayout();
            pnlBotoes.SuspendLayout();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscaGViagens
            // 
            txtBuscaGViagens.Location = new Point(49, 50);
            txtBuscaGViagens.Name = "txtBuscaGViagens";
            txtBuscaGViagens.PlaceholderText = "  Buscar por Destino ou Status";
            txtBuscaGViagens.Size = new Size(415, 23);
            txtBuscaGViagens.TabIndex = 4;
            txtBuscaGViagens.KeyDown += txtBuscaGViagens_KeyDown;
            // 
            // dvgViagens
            // 
            dvgViagens.AllowUserToAddRows = false;
            dvgViagens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgViagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgViagens.BackgroundColor = Color.White;
            dvgViagens.BorderStyle = BorderStyle.None;
            dvgViagens.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvgViagens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgViagens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgViagens.ColumnHeadersHeight = 40;
            dvgViagens.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnIncluir, btnExcluir });
            dvgViagens.EnableHeadersVisualStyles = false;
            dvgViagens.Location = new Point(47, 101);
            dvgViagens.Name = "dvgViagens";
            dvgViagens.RowHeadersVisible = false;
            dvgViagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgViagens.Size = new Size(723, 129);
            dvgViagens.TabIndex = 6;
            dvgViagens.CellClick += dvgViagens_CellClick;
            dvgViagens.Paint += dvgViagens_Paint;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.Padding = new Padding(6);
            btnEditar.DefaultCellStyle = dataGridViewCellStyle2;
            btnEditar.HeaderText = "";
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnEditar.Name = "btnEditar";
            btnEditar.Width = 50;
            // 
            // btnIncluir
            // 
            btnIncluir.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            dataGridViewCellStyle3.Padding = new Padding(8);
            btnIncluir.DefaultCellStyle = dataGridViewCellStyle3;
            btnIncluir.HeaderText = "";
            btnIncluir.Image = (Image)resources.GetObject("btnIncluir.Image");
            btnIncluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnIncluir.Name = "btnIncluir";
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = resources.GetObject("dataGridViewCellStyle4.NullValue");
            dataGridViewCellStyle4.Padding = new Padding(8);
            btnExcluir.DefaultCellStyle = dataGridViewCellStyle4;
            btnExcluir.HeaderText = "";
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Width = 50;
            // 
            // pnlCadastrarViagens
            // 
            pnlCadastrarViagens.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastrarViagens.BackColor = Color.White;
            pnlCadastrarViagens.BorderStyle = BorderStyle.FixedSingle;
            pnlCadastrarViagens.Controls.Add(pnlBotoes);
            pnlCadastrarViagens.Controls.Add(txtCustoHospedagemCViagem);
            pnlCadastrarViagens.Controls.Add(txtQTDVagaCViagens);
            pnlCadastrarViagens.Controls.Add(lbQTDVagaCViagem);
            pnlCadastrarViagens.Controls.Add(DTPDataCViagem);
            pnlCadastrarViagens.Controls.Add(pnlTitulo);
            pnlCadastrarViagens.Controls.Add(pnlSeparador);
            pnlCadastrarViagens.Controls.Add(pnlSeparador2);
            pnlCadastrarViagens.Controls.Add(txtTransporteCViagens);
            pnlCadastrarViagens.Controls.Add(lbTransporteGViagens);
            pnlCadastrarViagens.Controls.Add(txtCustoTransporteCViagem);
            pnlCadastrarViagens.Controls.Add(lbCustoTransporteCViagem);
            pnlCadastrarViagens.Controls.Add(lblbCustoHospedagemCViagem);
            pnlCadastrarViagens.Controls.Add(txtDestinoViagens);
            pnlCadastrarViagens.Controls.Add(lbDataGViagens);
            pnlCadastrarViagens.Controls.Add(lbDestinoGViagens);
            pnlCadastrarViagens.Location = new Point(47, 258);
            pnlCadastrarViagens.Name = "pnlCadastrarViagens";
            pnlCadastrarViagens.Size = new Size(724, 199);
            pnlCadastrarViagens.TabIndex = 7;
            pnlCadastrarViagens.Resize += pnlCadastrarViagens_Resize;
            // 
            // pnlBotoes
            // 
            pnlBotoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlBotoes.Controls.Add(btnSalvar);
            pnlBotoes.Controls.Add(btnLimparGViagens);
            pnlBotoes.Controls.Add(btnCancelarGClientes);
            pnlBotoes.Controls.Add(btnSalvarGClientes);
            pnlBotoes.Location = new Point(258, 149);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(219, 47);
            pnlBotoes.TabIndex = 16;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.FromArgb(68, 252, 124);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(119, 12);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 26);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimparGViagens
            // 
            btnLimparGViagens.BackColor = Color.FromArgb(194, 194, 194);
            btnLimparGViagens.FlatAppearance.BorderSize = 0;
            btnLimparGViagens.FlatStyle = FlatStyle.Flat;
            btnLimparGViagens.Font = new Font("Segoe UI Semibold", 10F);
            btnLimparGViagens.ForeColor = Color.Black;
            btnLimparGViagens.Location = new Point(28, 12);
            btnLimparGViagens.Name = "btnLimparGViagens";
            btnLimparGViagens.Size = new Size(82, 26);
            btnLimparGViagens.TabIndex = 17;
            btnLimparGViagens.Text = "Limpar";
            btnLimparGViagens.UseVisualStyleBackColor = false;
            btnLimparGViagens.Click += btnLimparGViagens_Click;
            // 
            // btnCancelarGClientes
            // 
            btnCancelarGClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarGClientes.BackColor = Color.FromArgb(194, 194, 194);
            btnCancelarGClientes.FlatAppearance.BorderSize = 0;
            btnCancelarGClientes.FlatStyle = FlatStyle.Flat;
            btnCancelarGClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarGClientes.ForeColor = Color.Black;
            btnCancelarGClientes.Location = new Point(32, -42);
            btnCancelarGClientes.Name = "btnCancelarGClientes";
            btnCancelarGClientes.Size = new Size(82, 26);
            btnCancelarGClientes.TabIndex = 13;
            btnCancelarGClientes.Text = "Cancelar";
            btnCancelarGClientes.UseVisualStyleBackColor = false;
            // 
            // btnSalvarGClientes
            // 
            btnSalvarGClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvarGClientes.BackColor = Color.FromArgb(68, 252, 124);
            btnSalvarGClientes.FlatAppearance.BorderSize = 0;
            btnSalvarGClientes.FlatStyle = FlatStyle.Flat;
            btnSalvarGClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarGClientes.ForeColor = Color.Black;
            btnSalvarGClientes.Location = new Point(123, -42);
            btnSalvarGClientes.Name = "btnSalvarGClientes";
            btnSalvarGClientes.Size = new Size(82, 26);
            btnSalvarGClientes.TabIndex = 14;
            btnSalvarGClientes.Text = "Salvar";
            btnSalvarGClientes.UseVisualStyleBackColor = false;
            // 
            // txtCustoHospedagemCViagem
            // 
            txtCustoHospedagemCViagem.Anchor = AnchorStyles.Right;
            txtCustoHospedagemCViagem.Location = new Point(596, 111);
            txtCustoHospedagemCViagem.Name = "txtCustoHospedagemCViagem";
            txtCustoHospedagemCViagem.Size = new Size(106, 23);
            txtCustoHospedagemCViagem.TabIndex = 4;
            txtCustoHospedagemCViagem.TextAlign = HorizontalAlignment.Center;
            txtCustoHospedagemCViagem.KeyDown += txtBuscaGViagens_KeyDown;
            // 
            // txtQTDVagaCViagens
            // 
            txtQTDVagaCViagens.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtQTDVagaCViagens.Location = new Point(101, 111);
            txtQTDVagaCViagens.Name = "txtQTDVagaCViagens";
            txtQTDVagaCViagens.Size = new Size(88, 23);
            txtQTDVagaCViagens.TabIndex = 2;
            txtQTDVagaCViagens.KeyDown += txtBuscaGViagens_KeyDown;
            // 
            // lbQTDVagaCViagem
            // 
            lbQTDVagaCViagem.Anchor = AnchorStyles.Left;
            lbQTDVagaCViagem.AutoSize = true;
            lbQTDVagaCViagem.Location = new Point(11, 114);
            lbQTDVagaCViagem.Name = "lbQTDVagaCViagem";
            lbQTDVagaCViagem.Size = new Size(77, 15);
            lbQTDVagaCViagem.TabIndex = 13;
            lbQTDVagaCViagem.Text = "Qtd. de Vaga:";
            // 
            // DTPDataCViagem
            // 
            DTPDataCViagem.Anchor = AnchorStyles.Right;
            DTPDataCViagem.Format = DateTimePickerFormat.Short;
            DTPDataCViagem.Location = new Point(359, 67);
            DTPDataCViagem.Name = "DTPDataCViagem";
            DTPDataCViagem.Size = new Size(118, 23);
            DTPDataCViagem.TabIndex = 12;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(232, 232, 232);
            pnlTitulo.Controls.Add(lbCadastraViagem);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(722, 53);
            pnlTitulo.TabIndex = 0;
            // 
            // lbCadastraViagem
            // 
            lbCadastraViagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCadastraViagem.AutoSize = true;
            lbCadastraViagem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastraViagem.Location = new Point(18, 19);
            lbCadastraViagem.Name = "lbCadastraViagem";
            lbCadastraViagem.Size = new Size(117, 17);
            lbCadastraViagem.TabIndex = 0;
            lbCadastraViagem.Text = "Cadastrar Viagem";
            // 
            // pnlSeparador
            // 
            pnlSeparador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSeparador.BackColor = Color.FromArgb(232, 232, 232);
            pnlSeparador.Location = new Point(0, 99);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(724, 1);
            pnlSeparador.TabIndex = 5;
            // 
            // pnlSeparador2
            // 
            pnlSeparador2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSeparador2.BackColor = Color.FromArgb(232, 232, 232);
            pnlSeparador2.Location = new Point(0, 146);
            pnlSeparador2.Name = "pnlSeparador2";
            pnlSeparador2.Size = new Size(724, 1);
            pnlSeparador2.TabIndex = 11;
            // 
            // txtTransporteCViagens
            // 
            txtTransporteCViagens.Anchor = AnchorStyles.Right;
            txtTransporteCViagens.Location = new Point(592, 67);
            txtTransporteCViagens.Name = "txtTransporteCViagens";
            txtTransporteCViagens.Size = new Size(110, 23);
            txtTransporteCViagens.TabIndex = 1;
            txtTransporteCViagens.KeyDown += txtBuscaGViagens_KeyDown;
            // 
            // lbTransporteGViagens
            // 
            lbTransporteGViagens.Anchor = AnchorStyles.Right;
            lbTransporteGViagens.AutoSize = true;
            lbTransporteGViagens.Location = new Point(520, 72);
            lbTransporteGViagens.Name = "lbTransporteGViagens";
            lbTransporteGViagens.Size = new Size(65, 15);
            lbTransporteGViagens.TabIndex = 9;
            lbTransporteGViagens.Text = "Transporte:";
            // 
            // txtCustoTransporteCViagem
            // 
            txtCustoTransporteCViagem.Anchor = AnchorStyles.Right;
            txtCustoTransporteCViagem.Location = new Point(320, 112);
            txtCustoTransporteCViagem.Name = "txtCustoTransporteCViagem";
            txtCustoTransporteCViagem.Size = new Size(116, 23);
            txtCustoTransporteCViagem.TabIndex = 3;
            
            txtCustoTransporteCViagem.KeyDown += txtBuscaGViagens_KeyDown;
            // 
            // lbCustoTransporteCViagem
            // 
            lbCustoTransporteCViagem.Anchor = AnchorStyles.Right;
            lbCustoTransporteCViagem.AutoSize = true;
            lbCustoTransporteCViagem.Location = new Point(202, 116);
            lbCustoTransporteCViagem.Name = "lbCustoTransporteCViagem";
            lbCustoTransporteCViagem.Size = new Size(116, 15);
            lbCustoTransporteCViagem.TabIndex = 6;
            lbCustoTransporteCViagem.Text = "Custo do Transporte:";
            lbCustoTransporteCViagem.Click += lbCustoTransporteCViagem_Click;
            // 
            // lblbCustoHospedagemCViagem
            // 
            lblbCustoHospedagemCViagem.Anchor = AnchorStyles.Right;
            lblbCustoHospedagemCViagem.AutoSize = true;
            lblbCustoHospedagemCViagem.Location = new Point(459, 116);
            lblbCustoHospedagemCViagem.Name = "lblbCustoHospedagemCViagem";
            lblbCustoHospedagemCViagem.Size = new Size(131, 15);
            lblbCustoHospedagemCViagem.TabIndex = 5;
            lblbCustoHospedagemCViagem.Text = "Custo da Hospedagem:";
            // 
            // txtDestinoViagens
            // 
            txtDestinoViagens.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDestinoViagens.Location = new Point(70, 67);
            txtDestinoViagens.Name = "txtDestinoViagens";
            txtDestinoViagens.Size = new Size(219, 23);
            txtDestinoViagens.TabIndex = 0;
            txtDestinoViagens.KeyDown += txtBuscaGViagens_KeyDown;
            // 
            // lbDataGViagens
            // 
            lbDataGViagens.Anchor = AnchorStyles.Right;
            lbDataGViagens.AutoSize = true;
            lbDataGViagens.Location = new Point(319, 72);
            lbDataGViagens.Name = "lbDataGViagens";
            lbDataGViagens.Size = new Size(34, 15);
            lbDataGViagens.TabIndex = 2;
            lbDataGViagens.Text = "Data:";
            // 
            // lbDestinoGViagens
            // 
            lbDestinoGViagens.Anchor = AnchorStyles.Left;
            lbDestinoGViagens.AutoSize = true;
            lbDestinoGViagens.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDestinoGViagens.Location = new Point(11, 72);
            lbDestinoGViagens.Name = "lbDestinoGViagens";
            lbDestinoGViagens.Size = new Size(50, 15);
            lbDestinoGViagens.TabIndex = 1;
            lbDestinoGViagens.Text = "Destino:";
            // 
            // lblLimparFiltro
            // 
            lblLimparFiltro.AutoSize = true;
            lblLimparFiltro.Location = new Point(555, 57);
            lblLimparFiltro.Name = "lblLimparFiltro";
            lblLimparFiltro.Size = new Size(129, 15);
            lblLimparFiltro.TabIndex = 8;
            lblLimparFiltro.Text = "Limpar Filtros de Busca";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(68, 252, 124);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(470, 49);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 27);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // UC_GestaoViagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnBuscar);
            Controls.Add(lblLimparFiltro);
            Controls.Add(pnlCadastrarViagens);
            Controls.Add(dvgViagens);
            Controls.Add(txtBuscaGViagens);
            Name = "UC_GestaoViagens";
            Size = new Size(826, 501);
            Load += UC_GestaoViagens_Load;
            ((System.ComponentModel.ISupportInitialize)dvgViagens).EndInit();
            pnlCadastrarViagens.ResumeLayout(false);
            pnlCadastrarViagens.PerformLayout();
            pnlBotoes.ResumeLayout(false);
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BotaoPadraoMandecas btnBuscarGViagens;
        private TextBox txtBuscaGViagens;
        private DataGridView dvgViagens;
        private Panel pnlCadastrarViagens;
        private Panel pnlTitulo;
        private Label lbCadastraViagem;
        private Panel pnlSeparador;
        private Panel pnlSeparador2;
        private TextBox txtTransporteCViagens;
        private Label lbTransporteGViagens;
        private TextBox txtCustoTransporteCViagem;
        private Label lbCustoTransporteCViagem;
        private Label lblbCustoHospedagemCViagem;
        private TextBox txtDestinoViagens;
        private Label lbDataGViagens;
        private Label lbDestinoGViagens;
        private BotaoPadraoMandecas btnCancelarCViagem;
        private BotaoPadraoMandecas btnSalvarCViagem;
        private DateTimePicker DTPDataCViagem;
        private TextBox txtQTDVagaCViagens;
        private Label lbQTDVagaCViagem;
        private TextBox txtCustoHospedagemCViagem;
        private Label lblLimparFiltro;
        private DataGridViewImageColumn btnEditar;
        private DataGridViewImageColumn btnIncluir;
        private DataGridViewImageColumn btnExcluir;
        private Panel pnlBotoes;
        private BotaoPadraoMandecas btnCancelarGClientes;
        private BotaoPadraoMandecas btnSalvarGClientes;
        
        private BotaoPadraoMandecas btnSalvar;
        private BotaoPadraoMandecas btnBuscar;
        private BotaoPadraoDois btnLimparGViagens;
    }
}
