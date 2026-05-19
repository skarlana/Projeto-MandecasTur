namespace Login
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            pnlLogin = new Panel();
            lbRodape = new Label();
            imgOnibusLogin = new PictureBox();
            imgNavioLogin = new PictureBox();
            imgAviaoLogin = new PictureBox();
            pnlSeparador = new Panel();
            btnEntrarLogin = new BotaoMandecas();
            imgLockLogin = new PictureBox();
            imgUserLogin = new PictureBox();
            pnlLinhaSenhaLogin = new Panel();
            pnlLinhaUsuarioLogin = new Panel();
            txtSenhaLogin = new TextBox();
            txtUsuarioLogin = new TextBox();
            lbSloganLogin = new Label();
            imgLogoLogin = new PictureBox();
            pnlFecharMinimizarTela = new Panel();
            lbRecolher = new Label();
            lbMinimizar = new Label();
            lbFechar = new Label();
            imgLogoCodsis = new PictureBox();
            lbCodsis = new Label();
            pnlCodsis = new Panel();
            label1 = new Label();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgOnibusLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgNavioLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgAviaoLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLockLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUserLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoLogin).BeginInit();
            pnlFecharMinimizarTela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogoCodsis).BeginInit();
            pnlCodsis.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.None;
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(lbRodape);
            pnlLogin.Controls.Add(imgOnibusLogin);
            pnlLogin.Controls.Add(imgNavioLogin);
            pnlLogin.Controls.Add(imgAviaoLogin);
            pnlLogin.Controls.Add(pnlSeparador);
            pnlLogin.Controls.Add(btnEntrarLogin);
            pnlLogin.Controls.Add(imgLockLogin);
            pnlLogin.Controls.Add(imgUserLogin);
            pnlLogin.Controls.Add(pnlLinhaSenhaLogin);
            pnlLogin.Controls.Add(pnlLinhaUsuarioLogin);
            pnlLogin.Controls.Add(txtSenhaLogin);
            pnlLogin.Controls.Add(txtUsuarioLogin);
            pnlLogin.Controls.Add(lbSloganLogin);
            pnlLogin.Controls.Add(imgLogoLogin);
            pnlLogin.Location = new Point(447, 152);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(300, 450);
            pnlLogin.TabIndex = 1;
            pnlLogin.Paint += pnlLogin_Paint;
            // 
            // lbRodape
            // 
            lbRodape.AutoSize = true;
            lbRodape.BackColor = Color.Transparent;
            lbRodape.ForeColor = Color.Gainsboro;
            lbRodape.Location = new Point(45, 414);
            lbRodape.Name = "lbRodape";
            lbRodape.Size = new Size(210, 15);
            lbRodape.TabIndex = 13;
            lbRodape.Text = "Viagens Terrestres • Aéreas • Marítimas";
            // 
            // imgOnibusLogin
            // 
            imgOnibusLogin.BackColor = Color.Transparent;
            imgOnibusLogin.Image = (Image)resources.GetObject("imgOnibusLogin.Image");
            imgOnibusLogin.Location = new Point(171, 373);
            imgOnibusLogin.Name = "imgOnibusLogin";
            imgOnibusLogin.Size = new Size(30, 30);
            imgOnibusLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgOnibusLogin.TabIndex = 12;
            imgOnibusLogin.TabStop = false;
            // 
            // imgNavioLogin
            // 
            imgNavioLogin.BackColor = Color.Transparent;
            imgNavioLogin.Image = (Image)resources.GetObject("imgNavioLogin.Image");
            imgNavioLogin.Location = new Point(135, 373);
            imgNavioLogin.Name = "imgNavioLogin";
            imgNavioLogin.Size = new Size(30, 30);
            imgNavioLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgNavioLogin.TabIndex = 11;
            imgNavioLogin.TabStop = false;
            // 
            // imgAviaoLogin
            // 
            imgAviaoLogin.BackColor = Color.Transparent;
            imgAviaoLogin.Image = (Image)resources.GetObject("imgAviaoLogin.Image");
            imgAviaoLogin.Location = new Point(100, 373);
            imgAviaoLogin.Name = "imgAviaoLogin";
            imgAviaoLogin.Size = new Size(30, 30);
            imgAviaoLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgAviaoLogin.TabIndex = 10;
            imgAviaoLogin.TabStop = false;
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = Color.FromArgb(68, 252, 124);
            pnlSeparador.Location = new Point(75, 365);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(150, 2);
            pnlSeparador.TabIndex = 9;
            // 
            // btnEntrarLogin
            // 
            btnEntrarLogin.Anchor = AnchorStyles.None;
            btnEntrarLogin.BackColor = Color.FromArgb(0, 102, 51);
            btnEntrarLogin.FlatAppearance.BorderSize = 0;
            btnEntrarLogin.FlatStyle = FlatStyle.Flat;
            btnEntrarLogin.Font = new Font("Segoe UI Semibold", 11F);
            btnEntrarLogin.ForeColor = Color.Black;
            btnEntrarLogin.Location = new Point(51, 264);
            btnEntrarLogin.Name = "btnEntrarLogin";
            btnEntrarLogin.Size = new Size(200, 40);
            btnEntrarLogin.TabIndex = 8;
            btnEntrarLogin.Text = "Entrar";
            btnEntrarLogin.UseVisualStyleBackColor = false;
            btnEntrarLogin.Click += btnEntrarLogin_Click;
            // 
            // imgLockLogin
            // 
            imgLockLogin.BackColor = Color.Transparent;
            imgLockLogin.Image = (Image)resources.GetObject("imgLockLogin.Image");
            imgLockLogin.Location = new Point(58, 217);
            imgLockLogin.Name = "imgLockLogin";
            imgLockLogin.Size = new Size(21, 19);
            imgLockLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgLockLogin.TabIndex = 7;
            imgLockLogin.TabStop = false;
            // 
            // imgUserLogin
            // 
            imgUserLogin.BackColor = Color.Transparent;
            imgUserLogin.Image = Properties.Resources.user;
            imgUserLogin.Location = new Point(58, 174);
            imgUserLogin.Name = "imgUserLogin";
            imgUserLogin.Size = new Size(21, 19);
            imgUserLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgUserLogin.TabIndex = 6;
            imgUserLogin.TabStop = false;
            // 
            // pnlLinhaSenhaLogin
            // 
            pnlLinhaSenhaLogin.BackColor = Color.Linen;
            pnlLinhaSenhaLogin.Location = new Point(50, 240);
            pnlLinhaSenhaLogin.Name = "pnlLinhaSenhaLogin";
            pnlLinhaSenhaLogin.Size = new Size(200, 2);
            pnlLinhaSenhaLogin.TabIndex = 5;
            // 
            // pnlLinhaUsuarioLogin
            // 
            pnlLinhaUsuarioLogin.BackColor = Color.GhostWhite;
            pnlLinhaUsuarioLogin.Location = new Point(51, 196);
            pnlLinhaUsuarioLogin.Name = "pnlLinhaUsuarioLogin";
            pnlLinhaUsuarioLogin.Size = new Size(200, 2);
            pnlLinhaUsuarioLogin.TabIndex = 4;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BackColor = Color.FromArgb(10, 30, 10);
            txtSenhaLogin.BorderStyle = BorderStyle.None;
            txtSenhaLogin.ForeColor = Color.White;
            txtSenhaLogin.Location = new Point(84, 219);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.PlaceholderText = "Senha";
            txtSenhaLogin.Size = new Size(157, 16);
            txtSenhaLogin.TabIndex = 3;
            txtSenhaLogin.Enter += txtSenhaLogin_Enter;
            txtSenhaLogin.Leave += txtSenhaLogin_Leave;
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.BackColor = Color.FromArgb(10, 30, 10);
            txtUsuarioLogin.BorderStyle = BorderStyle.None;
            txtUsuarioLogin.ForeColor = Color.White;
            txtUsuarioLogin.Location = new Point(84, 177);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.PlaceholderText = "Usuário";
            txtUsuarioLogin.Size = new Size(157, 16);
            txtUsuarioLogin.TabIndex = 2;
            txtUsuarioLogin.Enter += txtUsuarioLogin_Enter;
            txtUsuarioLogin.Leave += txtUsuarioLogin_Leave;
            // 
            // lbSloganLogin
            // 
            lbSloganLogin.AutoSize = true;
            lbSloganLogin.BackColor = Color.Transparent;
            lbSloganLogin.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSloganLogin.ForeColor = Color.Gainsboro;
            lbSloganLogin.Location = new Point(65, 138);
            lbSloganLogin.Name = "lbSloganLogin";
            lbSloganLogin.Size = new Size(176, 17);
            lbSloganLogin.TabIndex = 1;
            lbSloganLogin.Text = "Conectando Pessoas e Lugares";
            lbSloganLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgLogoLogin
            // 
            imgLogoLogin.BackColor = Color.Transparent;
            imgLogoLogin.Image = (Image)resources.GetObject("imgLogoLogin.Image");
            imgLogoLogin.Location = new Point(104, 22);
            imgLogoLogin.Name = "imgLogoLogin";
            imgLogoLogin.Size = new Size(94, 93);
            imgLogoLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogoLogin.TabIndex = 0;
            imgLogoLogin.TabStop = false;
            // 
            // pnlFecharMinimizarTela
            // 
            pnlFecharMinimizarTela.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlFecharMinimizarTela.BackColor = Color.Transparent;
            pnlFecharMinimizarTela.Controls.Add(lbRecolher);
            pnlFecharMinimizarTela.Controls.Add(lbMinimizar);
            pnlFecharMinimizarTela.Controls.Add(lbFechar);
            pnlFecharMinimizarTela.Location = new Point(1108, 12);
            pnlFecharMinimizarTela.Name = "pnlFecharMinimizarTela";
            pnlFecharMinimizarTela.Size = new Size(88, 36);
            pnlFecharMinimizarTela.TabIndex = 5;
            // 
            // lbRecolher
            // 
            lbRecolher.AutoSize = true;
            lbRecolher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRecolher.ForeColor = SystemColors.ButtonFace;
            lbRecolher.Location = new Point(9, 6);
            lbRecolher.Name = "lbRecolher";
            lbRecolher.Size = new Size(16, 21);
            lbRecolher.TabIndex = 6;
            lbRecolher.Text = "-";
            lbRecolher.Click += lbRecolher_Click;
            // 
            // lbMinimizar
            // 
            lbMinimizar.AutoSize = true;
            lbMinimizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMinimizar.ForeColor = SystemColors.ButtonFace;
            lbMinimizar.Location = new Point(30, 7);
            lbMinimizar.Name = "lbMinimizar";
            lbMinimizar.Size = new Size(22, 20);
            lbMinimizar.TabIndex = 5;
            lbMinimizar.Text = "❐";
            lbMinimizar.Click += lbMinimizar_Click;
            // 
            // lbFechar
            // 
            lbFechar.AutoSize = true;
            lbFechar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFechar.ForeColor = SystemColors.ButtonFace;
            lbFechar.Location = new Point(57, 6);
            lbFechar.Name = "lbFechar";
            lbFechar.Size = new Size(18, 20);
            lbFechar.TabIndex = 4;
            lbFechar.Text = "X";
            lbFechar.Click += lbFechar_Click;
            // 
            // imgLogoCodsis
            // 
            imgLogoCodsis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imgLogoCodsis.BackColor = Color.Transparent;
            imgLogoCodsis.Image = (Image)resources.GetObject("imgLogoCodsis.Image");
            imgLogoCodsis.Location = new Point(27, 20);
            imgLogoCodsis.Name = "imgLogoCodsis";
            imgLogoCodsis.Size = new Size(1167, 34);
            imgLogoCodsis.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogoCodsis.TabIndex = 6;
            imgLogoCodsis.TabStop = false;
            // 
            // lbCodsis
            // 
            lbCodsis.Anchor = AnchorStyles.Bottom;
            lbCodsis.AutoSize = true;
            lbCodsis.BackColor = Color.Transparent;
            lbCodsis.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCodsis.ForeColor = Color.White;
            lbCodsis.Location = new Point(601, 6);
            lbCodsis.Name = "lbCodsis";
            lbCodsis.Size = new Size(18, 13);
            lbCodsis.TabIndex = 7;
            lbCodsis.Text = "By";
            lbCodsis.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlCodsis
            // 
            pnlCodsis.BackColor = Color.Transparent;
            pnlCodsis.Controls.Add(imgLogoCodsis);
            pnlCodsis.Controls.Add(lbCodsis);
            pnlCodsis.Dock = DockStyle.Bottom;
            pnlCodsis.Location = new Point(0, 744);
            pnlCodsis.Name = "pnlCodsis";
            pnlCodsis.Size = new Size(1218, 61);
            pnlCodsis.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(102, 318);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 14;
            label1.Text = "Esqueci a senha";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1218, 805);
            Controls.Add(pnlCodsis);
            Controls.Add(pnlFecharMinimizarTela);
            Controls.Add(pnlLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += TelaLogin_Load;
            MouseDown += TelaLogin_MouseDown;
            Resize += TelaLogin_Resize;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgOnibusLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgNavioLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgAviaoLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLockLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUserLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoLogin).EndInit();
            pnlFecharMinimizarTela.ResumeLayout(false);
            pnlFecharMinimizarTela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogoCodsis).EndInit();
            pnlCodsis.ResumeLayout(false);
            pnlCodsis.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlLogin;
        private PictureBox imgLogoLogin;
        private TextBox txtSenhaLogin;
        private TextBox txtUsuarioLogin;
        private Label lbSloganLogin;
        private Panel pnlLinhaUsuarioLogin;
        private Panel pnlLinhaSenhaLogin;
        private PictureBox imgLockLogin;
        private PictureBox imgUserLogin;
        private BotaoMandecas btnEntrarLogin;
        private PictureBox imgOnibusLogin;
        private PictureBox imgNavioLogin;
        private PictureBox imgAviaoLogin;
        private Panel pnlSeparador;
        private Label lbRodape;
        private Panel pnlFecharMinimizarTela;
        private Label lbRecolher;
        private Label lbMinimizar;
        private Label lbFechar;
        private PictureBox imgLogoCodsis;
        private Label lbCodsis;
        private Panel pnlCodsis;
        private Label label1;
    }
}
