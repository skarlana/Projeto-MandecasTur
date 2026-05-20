namespace Login.UseControls
{
    partial class UC_RegistrarEntrada
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
            panel1 = new Panel();
            lblRE = new Label();
            pnlInformativo = new Panel();
            lblInformativo = new Label();
            panelRE = new Panel();
            dtpVencimento = new DateTimePicker();
            lbDtVencimentoRegistrarEntrada = new Label();
            pnlBotoes = new Panel();
            btnRegistrarReservas = new BotaoPadraoMandecas();
            btnLimparReservas = new BotaoPadraoDois();
            panel5 = new Panel();
            cbPassageiros = new ComboBox();
            cbViagens = new ComboBox();
            label12 = new Label();
            txtValorParcela = new TextBox();
            txtFormaPgto = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            pnlInformativo.SuspendLayout();
            panelRE.SuspendLayout();
            pnlBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(68, 252, 124);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(59, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 2);
            panel1.TabIndex = 0;
            // 
            // lblRE
            // 
            lblRE.AutoSize = true;
            lblRE.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRE.Location = new Point(59, 20);
            lblRE.Name = "lblRE";
            lblRE.Size = new Size(212, 32);
            lblRE.TabIndex = 1;
            lblRE.Text = "Registrar Entrada";
            // 
            // pnlInformativo
            // 
            pnlInformativo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformativo.BackColor = Color.White;
            pnlInformativo.Controls.Add(lblInformativo);
            pnlInformativo.Location = new Point(59, 78);
            pnlInformativo.Name = "pnlInformativo";
            pnlInformativo.Size = new Size(707, 88);
            pnlInformativo.TabIndex = 2;
            // 
            // lblInformativo
            // 
            lblInformativo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInformativo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformativo.Location = new Point(0, 22);
            lblInformativo.Name = "lblInformativo";
            lblInformativo.Size = new Size(707, 45);
            lblInformativo.TabIndex = 0;
            lblInformativo.Text = "Selecione a viagem e o cliente para iniciar:";
            lblInformativo.TextAlign = ContentAlignment.MiddleCenter;
            lblInformativo.Click += label2_Click;
            // 
            // panelRE
            // 
            panelRE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelRE.BackColor = Color.White;
            panelRE.Controls.Add(dtpVencimento);
            panelRE.Controls.Add(lbDtVencimentoRegistrarEntrada);
            panelRE.Controls.Add(pnlBotoes);
            panelRE.Controls.Add(panel5);
            panelRE.Controls.Add(cbPassageiros);
            panelRE.Controls.Add(cbViagens);
            panelRE.Controls.Add(label12);
            panelRE.Controls.Add(txtValorParcela);
            panelRE.Controls.Add(txtFormaPgto);
            panelRE.Controls.Add(label15);
            panelRE.Controls.Add(label16);
            panelRE.Controls.Add(label17);
            panelRE.Location = new Point(59, 195);
            panelRE.Name = "panelRE";
            panelRE.Size = new Size(707, 279);
            panelRE.TabIndex = 3;
            panelRE.Resize += panelRE_Resize;
            // 
            // dtpVencimento
            // 
            dtpVencimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpVencimento.Location = new Point(292, 170);
            dtpVencimento.Name = "dtpVencimento";
            dtpVencimento.Size = new Size(285, 23);
            dtpVencimento.TabIndex = 11;
            // 
            // lbDtVencimentoRegistrarEntrada
            // 
            lbDtVencimentoRegistrarEntrada.AutoSize = true;
            lbDtVencimentoRegistrarEntrada.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDtVencimentoRegistrarEntrada.Location = new Point(98, 173);
            lbDtVencimentoRegistrarEntrada.Name = "lbDtVencimentoRegistrarEntrada";
            lbDtVencimentoRegistrarEntrada.Size = new Size(151, 20);
            lbDtVencimentoRegistrarEntrada.TabIndex = 10;
            lbDtVencimentoRegistrarEntrada.Text = "Data de Vencimento:";
            // 
            // pnlBotoes
            // 
            pnlBotoes.BackColor = Color.White;
            pnlBotoes.Controls.Add(btnRegistrarReservas);
            pnlBotoes.Controls.Add(btnLimparReservas);
            pnlBotoes.Location = new Point(223, 222);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(309, 50);
            pnlBotoes.TabIndex = 4;
            // 
            // btnRegistrarReservas
            // 
            btnRegistrarReservas.BackColor = Color.FromArgb(68, 252, 124);
            btnRegistrarReservas.FlatAppearance.BorderSize = 0;
            btnRegistrarReservas.FlatStyle = FlatStyle.Flat;
            btnRegistrarReservas.Font = new Font("Segoe UI Semibold", 11F);
            btnRegistrarReservas.ForeColor = Color.Black;
            btnRegistrarReservas.Location = new Point(124, 13);
            btnRegistrarReservas.Name = "btnRegistrarReservas";
            btnRegistrarReservas.Size = new Size(165, 26);
            btnRegistrarReservas.TabIndex = 13;
            btnRegistrarReservas.Text = "Registrar Pagamento";
            btnRegistrarReservas.UseVisualStyleBackColor = false;
            btnRegistrarReservas.Click += btnRegistrarReservas_Click;
            // 
            // btnLimparReservas
            // 
            btnLimparReservas.BackColor = Color.FromArgb(194, 194, 194);
            btnLimparReservas.FlatAppearance.BorderSize = 0;
            btnLimparReservas.FlatStyle = FlatStyle.Flat;
            btnLimparReservas.Font = new Font("Segoe UI Semibold", 10F);
            btnLimparReservas.ForeColor = Color.Black;
            btnLimparReservas.Location = new Point(36, 13);
            btnLimparReservas.Name = "btnLimparReservas";
            btnLimparReservas.Size = new Size(82, 26);
            btnLimparReservas.TabIndex = 12;
            btnLimparReservas.Text = "Limpar";
            btnLimparReservas.UseVisualStyleBackColor = false;
            btnLimparReservas.Click += btnLimparReservas_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(232, 232, 232);
            panel5.Location = new Point(1, 215);
            panel5.Name = "panel5";
            panel5.Size = new Size(704, 2);
            panel5.TabIndex = 9;
            // 
            // cbPassageiros
            // 
            cbPassageiros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbPassageiros.FormattingEnabled = true;
            cbPassageiros.Location = new Point(292, 61);
            cbPassageiros.Name = "cbPassageiros";
            cbPassageiros.Size = new Size(285, 23);
            cbPassageiros.TabIndex = 8;
            cbPassageiros.SelectedIndexChanged += cbPassageiros_SelectedIndexChanged;
            // 
            // cbViagens
            // 
            cbViagens.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbViagens.FormattingEnabled = true;
            cbViagens.Location = new Point(292, 22);
            cbViagens.Name = "cbViagens";
            cbViagens.Size = new Size(285, 23);
            cbViagens.TabIndex = 7;
            cbViagens.SelectedIndexChanged += cbViagens_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(98, 25);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 6;
            label12.Text = "Viagem:";
            // 
            // txtValorParcela
            // 
            txtValorParcela.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValorParcela.Location = new Point(292, 132);
            txtValorParcela.Name = "txtValorParcela";
            txtValorParcela.Size = new Size(285, 23);
            txtValorParcela.TabIndex = 5;
            // 
            // txtFormaPgto
            // 
            txtFormaPgto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFormaPgto.Location = new Point(292, 97);
            txtFormaPgto.Name = "txtFormaPgto";
            txtFormaPgto.Size = new Size(285, 23);
            txtFormaPgto.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(98, 135);
            label15.Name = "label15";
            label15.Size = new Size(124, 20);
            label15.TabIndex = 2;
            label15.Text = "Valor da Parcela:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(98, 96);
            label16.Name = "label16";
            label16.Size = new Size(160, 20);
            label16.TabIndex = 1;
            label16.Text = "Forma de Pagamento:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(98, 60);
            label17.Name = "label17";
            label17.Size = new Size(60, 20);
            label17.TabIndex = 0;
            label17.Text = "Cliente:";
            // 
            // UC_RegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelRE);
            Controls.Add(pnlInformativo);
            Controls.Add(lblRE);
            Controls.Add(panel1);
            Name = "UC_RegistrarEntrada";
            Size = new Size(826, 648);
            Load += UC_RegistrarEntrada_Load;
            pnlInformativo.ResumeLayout(false);
            panelRE.ResumeLayout(false);
            panelRE.PerformLayout();
            pnlBotoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblRE;
        private Panel pnlInformativo;
        private Label lblInformativo;
        private Panel panelRE;
        private TextBox txtValorParcela;
        private TextBox txtFormaPgto;
        private Label label15;
        private Label label16;
        private Label label17;
        private Panel pnlBotoes;
        private Label label12;
        private ComboBox cbPassageiros;
        private ComboBox cbViagens;
        private Panel panel5;
        private Label lbDtVencimentoRegistrarEntrada;
        private DateTimePicker dtpVencimento;
        private BotaoPadraoDois btnLimparReservas;
        private BotaoPadraoMandecas btnRegistrarReservas;
    }
}
