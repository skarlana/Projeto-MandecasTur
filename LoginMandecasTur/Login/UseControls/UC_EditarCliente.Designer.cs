namespace Login.UseControls
{
    partial class UC_EditarCliente
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
            lbEditarCliente = new Label();
            panelSeparador1 = new Panel();
            panelEditarCliente = new Panel();
            pnlBotoes = new Panel();
            btnVoltarEditarCliente = new BotaoPadraoDois();
            btnSalvarEditarCliente = new BotaoPadraoMandecas();
            dtpDataNascimento = new DateTimePicker();
            panelSeparador2 = new Panel();
            txtEmail = new TextBox();
            txtCPFEditarCliente = new TextBox();
            lbCPFEditarCliente = new Label();
            lbDataNascEditarCliente = new Label();
            lbNomeCompletoEditarCliente = new Label();
            lbTelefoneEditarCliente = new Label();
            lbEmailEditarCliente = new Label();
            txtNomeCompleto = new TextBox();
            txtTelefoneEditarCliente = new TextBox();
            label1 = new Label();
            lbIDCliente = new Label();
            panelEditarCliente.SuspendLayout();
            pnlBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // lbEditarCliente
            // 
            lbEditarCliente.AutoSize = true;
            lbEditarCliente.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEditarCliente.Location = new Point(36, 61);
            lbEditarCliente.Name = "lbEditarCliente";
            lbEditarCliente.Size = new Size(190, 37);
            lbEditarCliente.TabIndex = 12;
            lbEditarCliente.Text = "Editar Cliente";
            // 
            // panelSeparador1
            // 
            panelSeparador1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSeparador1.BackColor = Color.FromArgb(68, 252, 124);
            panelSeparador1.Location = new Point(36, 101);
            panelSeparador1.Name = "panelSeparador1";
            panelSeparador1.Size = new Size(749, 2);
            panelSeparador1.TabIndex = 11;
            // 
            // panelEditarCliente
            // 
            panelEditarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelEditarCliente.BackColor = Color.White;
            panelEditarCliente.Controls.Add(pnlBotoes);
            panelEditarCliente.Controls.Add(dtpDataNascimento);
            panelEditarCliente.Controls.Add(panelSeparador2);
            panelEditarCliente.Controls.Add(txtEmail);
            panelEditarCliente.Controls.Add(txtCPFEditarCliente);
            panelEditarCliente.Controls.Add(lbCPFEditarCliente);
            panelEditarCliente.Controls.Add(lbDataNascEditarCliente);
            panelEditarCliente.Controls.Add(lbNomeCompletoEditarCliente);
            panelEditarCliente.Controls.Add(lbTelefoneEditarCliente);
            panelEditarCliente.Controls.Add(lbEmailEditarCliente);
            panelEditarCliente.Controls.Add(txtNomeCompleto);
            panelEditarCliente.Controls.Add(txtTelefoneEditarCliente);
            panelEditarCliente.Location = new Point(74, 133);
            panelEditarCliente.Name = "panelEditarCliente";
            panelEditarCliente.Size = new Size(673, 288);
            panelEditarCliente.TabIndex = 21;
            panelEditarCliente.Resize += panelEditarCliente_Resize;
            // 
            // pnlBotoes
            // 
            pnlBotoes.Controls.Add(btnVoltarEditarCliente);
            pnlBotoes.Controls.Add(btnSalvarEditarCliente);
            pnlBotoes.Location = new Point(229, 238);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(208, 43);
            pnlBotoes.TabIndex = 18;
            // 
            // btnVoltarEditarCliente
            // 
            btnVoltarEditarCliente.BackColor = Color.FromArgb(194, 194, 194);
            btnVoltarEditarCliente.FlatAppearance.BorderSize = 0;
            btnVoltarEditarCliente.FlatStyle = FlatStyle.Flat;
            btnVoltarEditarCliente.Font = new Font("Segoe UI Semibold", 10F);
            btnVoltarEditarCliente.ForeColor = Color.Black;
            btnVoltarEditarCliente.Location = new Point(20, 9);
            btnVoltarEditarCliente.Name = "btnVoltarEditarCliente";
            btnVoltarEditarCliente.Size = new Size(82, 26);
            btnVoltarEditarCliente.TabIndex = 2;
            btnVoltarEditarCliente.Text = "Voltar";
            btnVoltarEditarCliente.UseVisualStyleBackColor = false;
            btnVoltarEditarCliente.Click += btnVoltarEditarCliente_Click;
            // 
            // btnSalvarEditarCliente
            // 
            btnSalvarEditarCliente.BackColor = Color.FromArgb(68, 252, 124);
            btnSalvarEditarCliente.FlatAppearance.BorderSize = 0;
            btnSalvarEditarCliente.FlatStyle = FlatStyle.Flat;
            btnSalvarEditarCliente.Font = new Font("Segoe UI Semibold", 11F);
            btnSalvarEditarCliente.ForeColor = Color.Black;
            btnSalvarEditarCliente.Location = new Point(111, 9);
            btnSalvarEditarCliente.Name = "btnSalvarEditarCliente";
            btnSalvarEditarCliente.Size = new Size(82, 26);
            btnSalvarEditarCliente.TabIndex = 1;
            btnSalvarEditarCliente.Text = "Salvar";
            btnSalvarEditarCliente.UseVisualStyleBackColor = false;
            btnSalvarEditarCliente.Click += btnSalvarEditarCliente_Click;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(215, 96);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(405, 23);
            dtpDataNascimento.TabIndex = 17;
            // 
            // panelSeparador2
            // 
            panelSeparador2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSeparador2.BackColor = Color.FromArgb(232, 232, 232);
            panelSeparador2.Location = new Point(1, 219);
            panelSeparador2.Name = "panelSeparador2";
            panelSeparador2.Size = new Size(673, 2);
            panelSeparador2.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(215, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(405, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtCPFEditarCliente
            // 
            txtCPFEditarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCPFEditarCliente.Location = new Point(215, 60);
            txtCPFEditarCliente.Name = "txtCPFEditarCliente";
            txtCPFEditarCliente.Size = new Size(405, 23);
            txtCPFEditarCliente.TabIndex = 14;
            // 
            // lbCPFEditarCliente
            // 
            lbCPFEditarCliente.AutoSize = true;
            lbCPFEditarCliente.Location = new Point(65, 68);
            lbCPFEditarCliente.Name = "lbCPFEditarCliente";
            lbCPFEditarCliente.Size = new Size(31, 15);
            lbCPFEditarCliente.TabIndex = 4;
            lbCPFEditarCliente.Text = "CPF:";
            // 
            // lbDataNascEditarCliente
            // 
            lbDataNascEditarCliente.AutoSize = true;
            lbDataNascEditarCliente.Location = new Point(65, 102);
            lbDataNascEditarCliente.Name = "lbDataNascEditarCliente";
            lbDataNascEditarCliente.Size = new Size(117, 15);
            lbDataNascEditarCliente.TabIndex = 5;
            lbDataNascEditarCliente.Text = "Data de Nascimento:";
            // 
            // lbNomeCompletoEditarCliente
            // 
            lbNomeCompletoEditarCliente.AutoSize = true;
            lbNomeCompletoEditarCliente.Location = new Point(65, 31);
            lbNomeCompletoEditarCliente.Name = "lbNomeCompletoEditarCliente";
            lbNomeCompletoEditarCliente.Size = new Size(99, 15);
            lbNomeCompletoEditarCliente.TabIndex = 3;
            lbNomeCompletoEditarCliente.Text = "Nome Completo:";
            // 
            // lbTelefoneEditarCliente
            // 
            lbTelefoneEditarCliente.AutoSize = true;
            lbTelefoneEditarCliente.Location = new Point(65, 141);
            lbTelefoneEditarCliente.Name = "lbTelefoneEditarCliente";
            lbTelefoneEditarCliente.Size = new Size(54, 15);
            lbTelefoneEditarCliente.TabIndex = 6;
            lbTelefoneEditarCliente.Text = "Telefone:";
            // 
            // lbEmailEditarCliente
            // 
            lbEmailEditarCliente.AutoSize = true;
            lbEmailEditarCliente.Location = new Point(65, 178);
            lbEmailEditarCliente.Name = "lbEmailEditarCliente";
            lbEmailEditarCliente.Size = new Size(39, 15);
            lbEmailEditarCliente.TabIndex = 7;
            lbEmailEditarCliente.Text = "Email:";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeCompleto.Location = new Point(215, 23);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(405, 23);
            txtNomeCompleto.TabIndex = 11;
            // 
            // txtTelefoneEditarCliente
            // 
            txtTelefoneEditarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefoneEditarCliente.Location = new Point(215, 133);
            txtTelefoneEditarCliente.Name = "txtTelefoneEditarCliente";
            txtTelefoneEditarCliente.Size = new Size(405, 23);
            txtTelefoneEditarCliente.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 106);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 22;
            label1.Text = "Código do Cliente:";
            // 
            // lbIDCliente
            // 
            lbIDCliente.AutoSize = true;
            lbIDCliente.Location = new Point(155, 106);
            lbIDCliente.Name = "lbIDCliente";
            lbIDCliente.Size = new Size(38, 15);
            lbIDCliente.TabIndex = 23;
            lbIDCliente.Text = "label2";
            // 
            // UC_EditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lbIDCliente);
            Controls.Add(label1);
            Controls.Add(panelEditarCliente);
            Controls.Add(lbEditarCliente);
            Controls.Add(panelSeparador1);
            Name = "UC_EditarCliente";
            Size = new Size(826, 506);
            Load += UC_EditarCliente_Load;
            panelEditarCliente.ResumeLayout(false);
            panelEditarCliente.PerformLayout();
            pnlBotoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbEditarCliente;
        private Panel panelSeparador1;
        private Panel panelEditarCliente;
        private Panel panelSeparador2;
        private BotaoPadraoMandecas btnSalvarEditarCliente;
        private TextBox txtEmail;
        private TextBox txtCPFEditarCliente;
        private Label lbCPFEditarCliente;
        private Label lbDataNascEditarCliente;
        private Label lbNomeCompletoEditarCliente;
        private Label lbTelefoneEditarCliente;
        private Label lbEmailEditarCliente;
        private TextBox txtNomeCompleto;
        private TextBox txtTelefoneEditarCliente;
        private DateTimePicker dtpDataNascimento;
        private Label label1;
        private Panel pnlBotoes;
        private BotaoPadraoDois btnVoltarEditarCliente;
        private Label lbIDCliente;
    }
}
