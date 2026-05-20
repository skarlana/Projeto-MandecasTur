namespace Login.UseControls
{
    partial class UC_IncluirPassageiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_IncluirPassageiros));
            lbUCIncluirPassageiros = new Label();
            pnlSeparador1 = new Panel();
            label = new Label();
            pnlIncluir = new Panel();
            pnlBotoes = new Panel();
            btnVoltarIncluirPassageiros = new BotaoPadraoDois();
            btnIncluirPassageiro = new BotaoPadraoMandecas();
            txtValorPacote = new TextBox();
            label2 = new Label();
            txtClienteIncluirPassageiros = new TextBox();
            panel1 = new Panel();
            txtNumeroDeParcelasIncluirPassageiros = new TextBox();
            txtValorDaEntradaIncluirPassageiros = new TextBox();
            txtFormaDePagamentoIncluirPassageiros = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblLista = new Label();
            panel3 = new Panel();
            lbIDViagemIncluirPassageiros = new Label();
            dgvListaDePassageiros = new DataGridView();
            btnExcluir = new DataGridViewImageColumn();
            label1 = new Label();
            lblTituloVagasRestantes = new Label();
            pnlIncluir.SuspendLayout();
            pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaDePassageiros).BeginInit();
            SuspendLayout();
            // 
            // lbUCIncluirPassageiros
            // 
            lbUCIncluirPassageiros.AutoSize = true;
            lbUCIncluirPassageiros.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUCIncluirPassageiros.Location = new Point(35, 59);
            lbUCIncluirPassageiros.Name = "lbUCIncluirPassageiros";
            lbUCIncluirPassageiros.Size = new Size(228, 32);
            lbUCIncluirPassageiros.TabIndex = 0;
            lbUCIncluirPassageiros.Text = "Incluir Passageiros";
            // 
            // pnlSeparador1
            // 
            pnlSeparador1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSeparador1.BackColor = Color.FromArgb(68, 252, 124);
            pnlSeparador1.Location = new Point(35, 94);
            pnlSeparador1.Name = "pnlSeparador1";
            pnlSeparador1.Size = new Size(749, 2);
            pnlSeparador1.TabIndex = 1;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(627, 100);
            label.Name = "label";
            label.Size = new Size(106, 17);
            label.TabIndex = 2;
            label.Text = "Vagas Restantes:";
            // 
            // pnlIncluir
            // 
            pnlIncluir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlIncluir.BackColor = Color.White;
            pnlIncluir.Controls.Add(pnlBotoes);
            pnlIncluir.Controls.Add(txtValorPacote);
            pnlIncluir.Controls.Add(label2);
            pnlIncluir.Controls.Add(txtClienteIncluirPassageiros);
            pnlIncluir.Controls.Add(panel1);
            pnlIncluir.Controls.Add(txtNumeroDeParcelasIncluirPassageiros);
            pnlIncluir.Controls.Add(txtValorDaEntradaIncluirPassageiros);
            pnlIncluir.Controls.Add(txtFormaDePagamentoIncluirPassageiros);
            pnlIncluir.Controls.Add(label6);
            pnlIncluir.Controls.Add(label5);
            pnlIncluir.Controls.Add(label4);
            pnlIncluir.Controls.Add(label3);
            pnlIncluir.Location = new Point(60, 129);
            pnlIncluir.Name = "pnlIncluir";
            pnlIncluir.Size = new Size(673, 249);
            pnlIncluir.TabIndex = 3;
            pnlIncluir.Resize += pnlIncluir_Resize;
            // 
            // pnlBotoes
            // 
            pnlBotoes.Controls.Add(btnVoltarIncluirPassageiros);
            pnlBotoes.Controls.Add(btnIncluirPassageiro);
            pnlBotoes.Location = new Point(236, 202);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(271, 42);
            pnlBotoes.TabIndex = 14;
            // 
            // btnVoltarIncluirPassageiros
            // 
            btnVoltarIncluirPassageiros.BackColor = Color.FromArgb(194, 194, 194);
            btnVoltarIncluirPassageiros.FlatAppearance.BorderSize = 0;
            btnVoltarIncluirPassageiros.FlatStyle = FlatStyle.Flat;
            btnVoltarIncluirPassageiros.Font = new Font("Segoe UI Semibold", 10F);
            btnVoltarIncluirPassageiros.ForeColor = Color.Black;
            btnVoltarIncluirPassageiros.Location = new Point(52, 8);
            btnVoltarIncluirPassageiros.Name = "btnVoltarIncluirPassageiros";
            btnVoltarIncluirPassageiros.Size = new Size(82, 26);
            btnVoltarIncluirPassageiros.TabIndex = 10;
            btnVoltarIncluirPassageiros.Text = "Voltar";
            btnVoltarIncluirPassageiros.UseVisualStyleBackColor = false;
            btnVoltarIncluirPassageiros.Click += btnVoltarIncluirPassageiros_Click_1;
            // 
            // btnIncluirPassageiro
            // 
            btnIncluirPassageiro.BackColor = Color.FromArgb(68, 252, 124);
            btnIncluirPassageiro.FlatAppearance.BorderSize = 0;
            btnIncluirPassageiro.FlatStyle = FlatStyle.Flat;
            btnIncluirPassageiro.Font = new Font("Segoe UI Semibold", 11F);
            btnIncluirPassageiro.ForeColor = Color.Black;
            btnIncluirPassageiro.Location = new Point(144, 8);
            btnIncluirPassageiro.Name = "btnIncluirPassageiro";
            btnIncluirPassageiro.Size = new Size(82, 26);
            btnIncluirPassageiro.TabIndex = 9;
            btnIncluirPassageiro.Text = "Incluir";
            btnIncluirPassageiro.UseVisualStyleBackColor = false;
            btnIncluirPassageiro.Click += btnIncluirPassageiro_Click;
            // 
            // txtValorPacote
            // 
            txtValorPacote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValorPacote.Location = new Point(189, 151);
            txtValorPacote.Name = "txtValorPacote";
            txtValorPacote.Size = new Size(454, 23);
            txtValorPacote.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 154);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 12;
            label2.Text = "Valor do Pacote:";
            // 
            // txtClienteIncluirPassageiros
            // 
            txtClienteIncluirPassageiros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClienteIncluirPassageiros.Location = new Point(189, 15);
            txtClienteIncluirPassageiros.Name = "txtClienteIncluirPassageiros";
            txtClienteIncluirPassageiros.Size = new Size(454, 23);
            txtClienteIncluirPassageiros.TabIndex = 11;
            txtClienteIncluirPassageiros.KeyDown += txtClienteIncluirPassageiros_KeyDown_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(232, 232, 232);
            panel1.Location = new Point(0, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 2);
            panel1.TabIndex = 8;
            // 
            // txtNumeroDeParcelasIncluirPassageiros
            // 
            txtNumeroDeParcelasIncluirPassageiros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNumeroDeParcelasIncluirPassageiros.Location = new Point(189, 118);
            txtNumeroDeParcelasIncluirPassageiros.Name = "txtNumeroDeParcelasIncluirPassageiros";
            txtNumeroDeParcelasIncluirPassageiros.Size = new Size(454, 23);
            txtNumeroDeParcelasIncluirPassageiros.TabIndex = 7;
            // 
            // txtValorDaEntradaIncluirPassageiros
            // 
            txtValorDaEntradaIncluirPassageiros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValorDaEntradaIncluirPassageiros.Location = new Point(189, 85);
            txtValorDaEntradaIncluirPassageiros.Name = "txtValorDaEntradaIncluirPassageiros";
            txtValorDaEntradaIncluirPassageiros.Size = new Size(454, 23);
            txtValorDaEntradaIncluirPassageiros.TabIndex = 6;
            // 
            // txtFormaDePagamentoIncluirPassageiros
            // 
            txtFormaDePagamentoIncluirPassageiros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFormaDePagamentoIncluirPassageiros.Location = new Point(189, 48);
            txtFormaDePagamentoIncluirPassageiros.Name = "txtFormaDePagamentoIncluirPassageiros";
            txtFormaDePagamentoIncluirPassageiros.Size = new Size(454, 23);
            txtFormaDePagamentoIncluirPassageiros.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 121);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 3;
            label6.Text = "Número de Parcelas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 85);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 2;
            label5.Text = "Valor da Entrada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 51);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 1;
            label4.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 18);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Cliente:";
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLista.Location = new Point(35, 406);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(241, 32);
            lblLista.TabIndex = 5;
            lblLista.Text = "Lista de Passageiros";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(68, 252, 124);
            panel3.Location = new Point(35, 441);
            panel3.Name = "panel3";
            panel3.Size = new Size(749, 2);
            panel3.TabIndex = 2;
            // 
            // lbIDViagemIncluirPassageiros
            // 
            lbIDViagemIncluirPassageiros.AutoSize = true;
            lbIDViagemIncluirPassageiros.Location = new Point(159, 100);
            lbIDViagemIncluirPassageiros.Name = "lbIDViagemIncluirPassageiros";
            lbIDViagemIncluirPassageiros.Size = new Size(38, 15);
            lbIDViagemIncluirPassageiros.TabIndex = 8;
            lbIDViagemIncluirPassageiros.Text = "label1";
            // 
            // dgvListaDePassageiros
            // 
            dgvListaDePassageiros.AllowUserToAddRows = false;
            dgvListaDePassageiros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaDePassageiros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaDePassageiros.BackgroundColor = Color.White;
            dgvListaDePassageiros.BorderStyle = BorderStyle.None;
            dgvListaDePassageiros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListaDePassageiros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaDePassageiros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaDePassageiros.ColumnHeadersHeight = 40;
            dgvListaDePassageiros.Columns.AddRange(new DataGridViewColumn[] { btnExcluir });
            dgvListaDePassageiros.EnableHeadersVisualStyles = false;
            dgvListaDePassageiros.Location = new Point(44, 467);
            dgvListaDePassageiros.Name = "dgvListaDePassageiros";
            dgvListaDePassageiros.RowHeadersVisible = false;
            dgvListaDePassageiros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaDePassageiros.Size = new Size(724, 134);
            dgvListaDePassageiros.TabIndex = 9;
            dgvListaDePassageiros.CellClick += dgvListaDePassageiros_CellClick_1;
            dgvListaDePassageiros.Paint += dgvListaDePassageiros_Paint_1;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.Padding = new Padding(8);
            btnExcluir.DefaultCellStyle = dataGridViewCellStyle2;
            btnExcluir.HeaderText = "";
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Width = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 100);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 10;
            label1.Text = "Código da Viagem:";
            // 
            // lblTituloVagasRestantes
            // 
            lblTituloVagasRestantes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTituloVagasRestantes.AutoSize = true;
            lblTituloVagasRestantes.Location = new Point(739, 99);
            lblTituloVagasRestantes.Name = "lblTituloVagasRestantes";
            lblTituloVagasRestantes.Size = new Size(38, 15);
            lblTituloVagasRestantes.TabIndex = 11;
            lblTituloVagasRestantes.Text = "label8";
            // 
            // UC_IncluirPassageiros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTituloVagasRestantes);
            Controls.Add(label1);
            Controls.Add(dgvListaDePassageiros);
            Controls.Add(lbIDViagemIncluirPassageiros);
            Controls.Add(panel3);
            Controls.Add(lblLista);
            Controls.Add(pnlIncluir);
            Controls.Add(label);
            Controls.Add(pnlSeparador1);
            Controls.Add(lbUCIncluirPassageiros);
            Name = "UC_IncluirPassageiros";
            Size = new Size(826, 633);
            Load += UC_IncluirPassageiros_Load;
            VisibleChanged += UC_IncluirPassageiros_VisibleChanged;
            pnlIncluir.ResumeLayout(false);
            pnlIncluir.PerformLayout();
            pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaDePassageiros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUCIncluirPassageiros;
        private Panel pnlSeparador1;
        private Label label;
        private Panel pnlIncluir;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNumeroDeParcelasIncluirPassageiros;
        private TextBox txtValorDaEntradaIncluirPassageiros;
        private TextBox txtFormaDePagamentoIncluirPassageiros;
        private Label lblLista;
        private Panel panel1;
        private Panel panel3;
        private BotaoPadraoMandecas btnIncluirPassageiro;
        private Label lbIDViagemIncluirPassageiros;
        private DataGridView dgvListaDePassageiros;
        private DataGridViewImageColumn btnExcluir;
        private Label label1;
        private TextBox txtClienteIncluirPassageiros;
        private TextBox txtValorPacote;
        private Label label2;
        private Label lblTituloVagasRestantes;
        private Panel pnlBotoes;
        private BotaoPadraoDois btnVoltarIncluirPassageiros;
    }
}
