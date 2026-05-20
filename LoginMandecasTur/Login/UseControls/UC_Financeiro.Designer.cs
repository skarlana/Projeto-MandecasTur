namespace Login.UseControls
{
    partial class UC_Financeiro
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
            btnAtualizar = new BotaoPadraoMandecas();
            pnlRelatorio = new Panel();
            cboClienteRelatorio = new ComboBox();
            rbCustoViagem = new RadioButton();
            rbReciboCliente = new RadioButton();
            rbListaPassageiros = new RadioButton();
            label8 = new Label();
            botaoPadraoMandecas3 = new BotaoPadraoMandecas();
            cboViagemRelatorio = new ComboBox();
            lbViagemFinanceiro = new Label();
            lbRelatorioFinanceiro = new Label();
            pnlGerar = new Panel();
            lblRelatorio_Titulo = new Label();
            pnlDEBusca = new Panel();
            btnBuscarFinanceiro = new BotaoPadraoMandecas();
            lblLimparFiltro = new Label();
            txtBuscaFinanceiro = new TextBox();
            cboStatus = new ComboBox();
            Panel_Vencidos = new Panel();
            lblVencidos = new Label();
            lblVencido_Titulo = new Label();
            Panel_Pendentes = new Panel();
            lblPendentes = new Label();
            lblPendente_Titulo = new Label();
            Panel_Entrada = new Panel();
            lblEntradas = new Label();
            lblReceita_Titulo = new Label();
            dgv_Financeiro = new DataGridView();
            panel1.SuspendLayout();
            pnlRelatorio.SuspendLayout();
            pnlGerar.SuspendLayout();
            pnlDEBusca.SuspendLayout();
            Panel_Vencidos.SuspendLayout();
            Panel_Pendentes.SuspendLayout();
            Panel_Entrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Financeiro).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnAtualizar);
            panel1.Controls.Add(pnlRelatorio);
            panel1.Controls.Add(pnlDEBusca);
            panel1.Controls.Add(Panel_Vencidos);
            panel1.Controls.Add(Panel_Pendentes);
            panel1.Controls.Add(Panel_Entrada);
            panel1.Controls.Add(dgv_Financeiro);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 577);
            panel1.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(68, 252, 124);
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.Black;
            btnAtualizar.Location = new Point(708, 510);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(92, 33);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // pnlRelatorio
            // 
            pnlRelatorio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlRelatorio.BackColor = SystemColors.ButtonHighlight;
            pnlRelatorio.Controls.Add(cboClienteRelatorio);
            pnlRelatorio.Controls.Add(rbCustoViagem);
            pnlRelatorio.Controls.Add(rbReciboCliente);
            pnlRelatorio.Controls.Add(rbListaPassageiros);
            pnlRelatorio.Controls.Add(label8);
            pnlRelatorio.Controls.Add(botaoPadraoMandecas3);
            pnlRelatorio.Controls.Add(cboViagemRelatorio);
            pnlRelatorio.Controls.Add(lbViagemFinanceiro);
            pnlRelatorio.Controls.Add(lbRelatorioFinanceiro);
            pnlRelatorio.Controls.Add(pnlGerar);
            pnlRelatorio.Location = new Point(822, 80);
            pnlRelatorio.Name = "pnlRelatorio";
            pnlRelatorio.Size = new Size(305, 424);
            pnlRelatorio.TabIndex = 1;
            // 
            // cboClienteRelatorio
            // 
            cboClienteRelatorio.FormattingEnabled = true;
            cboClienteRelatorio.Location = new Point(80, 264);
            cboClienteRelatorio.Name = "cboClienteRelatorio";
            cboClienteRelatorio.Size = new Size(203, 23);
            cboClienteRelatorio.TabIndex = 11;
            // 
            // rbCustoViagem
            // 
            rbCustoViagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbCustoViagem.AutoSize = true;
            rbCustoViagem.Font = new Font("Segoe UI", 10F);
            rbCustoViagem.Location = new Point(32, 123);
            rbCustoViagem.Name = "rbCustoViagem";
            rbCustoViagem.Size = new Size(246, 23);
            rbCustoViagem.TabIndex = 10;
            rbCustoViagem.TabStop = true;
            rbCustoViagem.Text = "Demonstrativo de Custo da Viagem";
            rbCustoViagem.UseVisualStyleBackColor = true;
            rbCustoViagem.CheckedChanged += rbCustoViagem_CheckedChanged;
            // 
            // rbReciboCliente
            // 
            rbReciboCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rbReciboCliente.AutoSize = true;
            rbReciboCliente.Font = new Font("Segoe UI", 10F);
            rbReciboCliente.Location = new Point(32, 181);
            rbReciboCliente.Name = "rbReciboCliente";
            rbReciboCliente.Size = new Size(132, 23);
            rbReciboCliente.TabIndex = 9;
            rbReciboCliente.TabStop = true;
            rbReciboCliente.Text = "Recibo de Cliente";
            rbReciboCliente.UseVisualStyleBackColor = true;
            rbReciboCliente.CheckedChanged += rbReciboCliente_CheckedChanged;
            // 
            // rbListaPassageiros
            // 
            rbListaPassageiros.AutoSize = true;
            rbListaPassageiros.Font = new Font("Segoe UI", 10F);
            rbListaPassageiros.Location = new Point(32, 152);
            rbListaPassageiros.Name = "rbListaPassageiros";
            rbListaPassageiros.Size = new Size(149, 23);
            rbListaPassageiros.TabIndex = 8;
            rbListaPassageiros.TabStop = true;
            rbListaPassageiros.Text = "Lista de Passageiros";
            rbListaPassageiros.UseVisualStyleBackColor = true;
            rbListaPassageiros.CheckedChanged += Lis_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 84);
            label8.Name = "label8";
            label8.Size = new Size(255, 20);
            label8.TabIndex = 7;
            label8.Text = "Selecione um dos tipos de relatórios";
            // 
            // botaoPadraoMandecas3
            // 
            botaoPadraoMandecas3.BackColor = Color.FromArgb(68, 252, 124);
            botaoPadraoMandecas3.FlatAppearance.BorderSize = 0;
            botaoPadraoMandecas3.FlatStyle = FlatStyle.Flat;
            botaoPadraoMandecas3.Font = new Font("Segoe UI Semibold", 11F);
            botaoPadraoMandecas3.ForeColor = Color.Black;
            botaoPadraoMandecas3.Location = new Point(100, 340);
            botaoPadraoMandecas3.Name = "botaoPadraoMandecas3";
            botaoPadraoMandecas3.Size = new Size(113, 28);
            botaoPadraoMandecas3.TabIndex = 6;
            botaoPadraoMandecas3.Text = "Gerar PDF";
            botaoPadraoMandecas3.UseVisualStyleBackColor = false;
            botaoPadraoMandecas3.Click += botaoPadraoMandecas3_Click;
            // 
            // cboViagemRelatorio
            // 
            cboViagemRelatorio.FormattingEnabled = true;
            cboViagemRelatorio.Location = new Point(80, 224);
            cboViagemRelatorio.Name = "cboViagemRelatorio";
            cboViagemRelatorio.Size = new Size(203, 23);
            cboViagemRelatorio.TabIndex = 5;
            cboViagemRelatorio.SelectedIndexChanged += cboViagemRelatorio_SelectedIndexChanged;
            // 
            // lbViagemFinanceiro
            // 
            lbViagemFinanceiro.AutoSize = true;
            lbViagemFinanceiro.Location = new Point(24, 228);
            lbViagemFinanceiro.Name = "lbViagemFinanceiro";
            lbViagemFinanceiro.Size = new Size(50, 15);
            lbViagemFinanceiro.TabIndex = 2;
            lbViagemFinanceiro.Text = "Viagem:";
            // 
            // lbRelatorioFinanceiro
            // 
            lbRelatorioFinanceiro.AutoSize = true;
            lbRelatorioFinanceiro.Location = new Point(24, 267);
            lbRelatorioFinanceiro.Name = "lbRelatorioFinanceiro";
            lbRelatorioFinanceiro.Size = new Size(47, 15);
            lbRelatorioFinanceiro.TabIndex = 1;
            lbRelatorioFinanceiro.Text = "Cliente:";
            // 
            // pnlGerar
            // 
            pnlGerar.BackColor = Color.FromArgb(68, 252, 124);
            pnlGerar.Controls.Add(lblRelatorio_Titulo);
            pnlGerar.Location = new Point(0, 0);
            pnlGerar.Name = "pnlGerar";
            pnlGerar.Size = new Size(319, 51);
            pnlGerar.TabIndex = 0;
            // 
            // lblRelatorio_Titulo
            // 
            lblRelatorio_Titulo.AutoSize = true;
            lblRelatorio_Titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRelatorio_Titulo.Location = new Point(80, 15);
            lblRelatorio_Titulo.Name = "lblRelatorio_Titulo";
            lblRelatorio_Titulo.Size = new Size(156, 25);
            lblRelatorio_Titulo.TabIndex = 0;
            lblRelatorio_Titulo.Text = "Gerar Relatórios";
            // 
            // pnlDEBusca
            // 
            pnlDEBusca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlDEBusca.BackColor = SystemColors.ControlLight;
            pnlDEBusca.Controls.Add(btnBuscarFinanceiro);
            pnlDEBusca.Controls.Add(lblLimparFiltro);
            pnlDEBusca.Controls.Add(txtBuscaFinanceiro);
            pnlDEBusca.Controls.Add(cboStatus);
            pnlDEBusca.Location = new Point(23, 253);
            pnlDEBusca.Name = "pnlDEBusca";
            pnlDEBusca.Size = new Size(778, 59);
            pnlDEBusca.TabIndex = 7;
            // 
            // btnBuscarFinanceiro
            // 
            btnBuscarFinanceiro.BackColor = Color.FromArgb(68, 252, 124);
            btnBuscarFinanceiro.FlatAppearance.BorderSize = 0;
            btnBuscarFinanceiro.FlatStyle = FlatStyle.Flat;
            btnBuscarFinanceiro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarFinanceiro.ForeColor = Color.Black;
            btnBuscarFinanceiro.Location = new Point(502, 20);
            btnBuscarFinanceiro.Name = "btnBuscarFinanceiro";
            btnBuscarFinanceiro.Size = new Size(79, 24);
            btnBuscarFinanceiro.TabIndex = 4;
            btnBuscarFinanceiro.Text = "Buscar";
            btnBuscarFinanceiro.UseVisualStyleBackColor = false;
            btnBuscarFinanceiro.Click += btnBuscarFinanceiro_Click;
            // 
            // lblLimparFiltro
            // 
            lblLimparFiltro.AutoSize = true;
            lblLimparFiltro.Location = new Point(597, 25);
            lblLimparFiltro.Name = "lblLimparFiltro";
            lblLimparFiltro.Size = new Size(129, 15);
            lblLimparFiltro.TabIndex = 3;
            lblLimparFiltro.Text = "Limpar Filtros de Busca";
            lblLimparFiltro.Click += lblLimparFiltro_Click;
            // 
            // txtBuscaFinanceiro
            // 
            txtBuscaFinanceiro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscaFinanceiro.Location = new Point(235, 21);
            txtBuscaFinanceiro.Name = "txtBuscaFinanceiro";
            txtBuscaFinanceiro.PlaceholderText = "Busca por Nome ou Destino";
            txtBuscaFinanceiro.Size = new Size(256, 23);
            txtBuscaFinanceiro.TabIndex = 1;
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Todos", "Pago", "Pendente", "Vencido", "Filtrar por Status", "Pago", "Pendente", "Vencido" });
            cboStatus.Location = new Point(19, 20);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(188, 23);
            cboStatus.TabIndex = 0;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // Panel_Vencidos
            // 
            Panel_Vencidos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel_Vencidos.BackColor = Color.Transparent;
            Panel_Vencidos.Controls.Add(lblVencidos);
            Panel_Vencidos.Controls.Add(lblVencido_Titulo);
            Panel_Vencidos.Location = new Point(566, 80);
            Panel_Vencidos.Name = "Panel_Vencidos";
            Panel_Vencidos.Size = new Size(234, 145);
            Panel_Vencidos.TabIndex = 5;
            Panel_Vencidos.Paint += DesenharCard;
            // 
            // lblVencidos
            // 
            lblVencidos.BackColor = Color.Transparent;
            lblVencidos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVencidos.ForeColor = SystemColors.ButtonHighlight;
            lblVencidos.Location = new Point(3, 65);
            lblVencidos.Name = "lblVencidos";
            lblVencidos.Size = new Size(222, 25);
            lblVencidos.TabIndex = 3;
            lblVencidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVencido_Titulo
            // 
            lblVencido_Titulo.BackColor = Color.Transparent;
            lblVencido_Titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVencido_Titulo.ForeColor = Color.DimGray;
            lblVencido_Titulo.Location = new Point(3, 11);
            lblVencido_Titulo.Name = "lblVencido_Titulo";
            lblVencido_Titulo.Size = new Size(222, 29);
            lblVencido_Titulo.TabIndex = 2;
            lblVencido_Titulo.Text = "Vencidos (Mês)";
            lblVencido_Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel_Pendentes
            // 
            Panel_Pendentes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel_Pendentes.BackColor = Color.Transparent;
            Panel_Pendentes.Controls.Add(lblPendentes);
            Panel_Pendentes.Controls.Add(lblPendente_Titulo);
            Panel_Pendentes.Location = new Point(295, 80);
            Panel_Pendentes.Name = "Panel_Pendentes";
            Panel_Pendentes.Size = new Size(233, 145);
            Panel_Pendentes.TabIndex = 6;
            Panel_Pendentes.Paint += DesenharCard;
            // 
            // lblPendentes
            // 
            lblPendentes.BackColor = Color.Transparent;
            lblPendentes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendentes.ForeColor = SystemColors.ButtonHighlight;
            lblPendentes.Location = new Point(3, 65);
            lblPendentes.Name = "lblPendentes";
            lblPendentes.Size = new Size(222, 25);
            lblPendentes.TabIndex = 2;
            lblPendentes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendente_Titulo
            // 
            lblPendente_Titulo.BackColor = Color.Transparent;
            lblPendente_Titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendente_Titulo.ForeColor = Color.DimGray;
            lblPendente_Titulo.Location = new Point(4, 8);
            lblPendente_Titulo.Name = "lblPendente_Titulo";
            lblPendente_Titulo.Size = new Size(221, 35);
            lblPendente_Titulo.TabIndex = 1;
            lblPendente_Titulo.Text = "Pendentes (Mês)";
            lblPendente_Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel_Entrada
            // 
            Panel_Entrada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel_Entrada.BackColor = Color.Transparent;
            Panel_Entrada.Controls.Add(lblEntradas);
            Panel_Entrada.Controls.Add(lblReceita_Titulo);
            Panel_Entrada.Location = new Point(23, 80);
            Panel_Entrada.Name = "Panel_Entrada";
            Panel_Entrada.Size = new Size(232, 145);
            Panel_Entrada.TabIndex = 4;
            Panel_Entrada.Paint += DesenharCard;
            // 
            // lblEntradas
            // 
            lblEntradas.BackColor = Color.Transparent;
            lblEntradas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntradas.ForeColor = SystemColors.ButtonHighlight;
            lblEntradas.Location = new Point(3, 65);
            lblEntradas.Name = "lblEntradas";
            lblEntradas.Size = new Size(222, 25);
            lblEntradas.TabIndex = 0;
            lblEntradas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReceita_Titulo
            // 
            lblReceita_Titulo.BackColor = Color.Transparent;
            lblReceita_Titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceita_Titulo.ForeColor = Color.DimGray;
            lblReceita_Titulo.Location = new Point(7, 12);
            lblReceita_Titulo.Name = "lblReceita_Titulo";
            lblReceita_Titulo.Size = new Size(218, 27);
            lblReceita_Titulo.TabIndex = 0;
            lblReceita_Titulo.Text = "Entradas (Mês)";
            lblReceita_Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgv_Financeiro
            // 
            dgv_Financeiro.AllowUserToAddRows = false;
            dgv_Financeiro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgv_Financeiro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Financeiro.BackgroundColor = SystemColors.ControlLight;
            dgv_Financeiro.BorderStyle = BorderStyle.None;
            dgv_Financeiro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Financeiro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Financeiro.ColumnHeadersHeight = 40;
            dgv_Financeiro.EnableHeadersVisualStyles = false;
            dgv_Financeiro.Location = new Point(23, 336);
            dgv_Financeiro.Name = "dgv_Financeiro";
            dgv_Financeiro.RowHeadersVisible = false;
            dgv_Financeiro.Size = new Size(778, 168);
            dgv_Financeiro.TabIndex = 8;
            dgv_Financeiro.CellContentClick += dgv_Financeiro_CellContentClick;
            dgv_Financeiro.CellPainting += dgv_Financeiro_CellPainting;
            // 
            // UC_Financeiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_Financeiro";
            Size = new Size(1172, 577);
            Load += UC_Financeiro_Load;
            VisibleChanged += UC_Financeiro_VisibleChanged;
            panel1.ResumeLayout(false);
            pnlRelatorio.ResumeLayout(false);
            pnlRelatorio.PerformLayout();
            pnlGerar.ResumeLayout(false);
            pnlGerar.PerformLayout();
            pnlDEBusca.ResumeLayout(false);
            pnlDEBusca.PerformLayout();
            Panel_Vencidos.ResumeLayout(false);
            Panel_Pendentes.ResumeLayout(false);
            Panel_Entrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Financeiro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlDEBusca;
        private TextBox txtBuscaFinanceiro;
        private ComboBox cboStatus;
        private Panel Panel_Vencidos;
        private Panel Panel_Pendentes;
        private Panel Panel_Entrada;
        private DataGridView dgv_Financeiro;
        private BotaoPadraoMandecas btn_buscar_FN;
        private Label lblVencidos;
        private Label lblVencido_Titulo;
        private Label lblPendentes;
        private Label lblPendente_Titulo;
        private Label lblEntradas;
        private Label lblReceita_Titulo;
        private Panel pnlRelatorio;
        private Panel pnlGerar;
        private Label lblRelatorio_Titulo;
       // private ComboBox comboBox2;
        private Label lbViagemFinanceiro;
        private Label lbRelatorioFinanceiro;
        private BotaoPadraoMandecas botaoPadraoMandecas2;
        private BotaoPadraoMandecas botaoPadraoMandecas1;
        private ComboBox cboViagemRelatorio;
        private Label label8;
        private BotaoPadraoMandecas botaoPadraoMandecas3;
        private RadioButton rbListaPassageiros;
        private RadioButton rbReciboCliente;
        private RadioButton rbCustoViagem;
        private Label lblLimparFiltro;
        private BotaoPadraoMandecas btnBuscarFinanceiro;
        private BotaoPadraoMandecas btnAtualizar;

        private ComboBox cboClienteRelatorio;
 
    }
}
