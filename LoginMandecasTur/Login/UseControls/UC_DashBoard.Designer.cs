namespace Login.UseControls
{
    partial class UC_DashBoard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DashBoard));
            pnlCard_Viagens = new Panel();
            pic_viajante = new PictureBox();
            panel4 = new Panel();
            lblVagas = new Label();
            lbl_qtdvagas = new Label();
            lblData = new Label();
            lbl_calendario = new Label();
            pic_vagas = new PictureBox();
            pic_calendario = new PictureBox();
            pic_onibus = new PictureBox();
            lblDestino = new Label();
            lbl_proximaV = new Label();
            btnB3 = new Button();
            btnB2 = new Button();
            btnB1 = new Button();
            pnlCard_Aniversario = new Panel();
            lbl_aniversariante = new Label();
            lbl_proximoAni = new Label();
            pic_bolo = new PictureBox();
            pnlCard_Reservas = new Panel();
            lbl_reservas = new Label();
            lbl_reservaMes = new Label();
            pic_reserva = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlBase = new Panel();
            timerSlide = new System.Windows.Forms.Timer(components);
            pnlCard_Viagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_viajante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_vagas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_calendario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_onibus).BeginInit();
            pnlCard_Aniversario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_bolo).BeginInit();
            pnlCard_Reservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_reserva).BeginInit();
            pnlBase.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard_Viagens
            // 
            pnlCard_Viagens.BackColor = Color.Gainsboro;
            pnlCard_Viagens.Controls.Add(pic_viajante);
            pnlCard_Viagens.Controls.Add(panel4);
            pnlCard_Viagens.Controls.Add(lblVagas);
            pnlCard_Viagens.Controls.Add(lbl_qtdvagas);
            pnlCard_Viagens.Controls.Add(lblData);
            pnlCard_Viagens.Controls.Add(lbl_calendario);
            pnlCard_Viagens.Controls.Add(pic_vagas);
            pnlCard_Viagens.Controls.Add(pic_calendario);
            pnlCard_Viagens.Controls.Add(pic_onibus);
            pnlCard_Viagens.Controls.Add(lblDestino);
            pnlCard_Viagens.Controls.Add(lbl_proximaV);
            pnlCard_Viagens.Location = new Point(0, 0);
            pnlCard_Viagens.Name = "pnlCard_Viagens";
            pnlCard_Viagens.Size = new Size(645, 279);
            pnlCard_Viagens.TabIndex = 0;
            pnlCard_Viagens.Paint += pnlCard_Viagens_Paint;
            // 
            // pic_viajante
            // 
            pic_viajante.BackgroundImageLayout = ImageLayout.Zoom;
            pic_viajante.Location = new Point(497, 109);
            pic_viajante.Name = "pic_viajante";
            pic_viajante.Size = new Size(89, 74);
            pic_viajante.TabIndex = 10;
            pic_viajante.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(451, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 116);
            panel4.TabIndex = 9;
            // 
            // lblVagas
            // 
            lblVagas.AutoSize = true;
            lblVagas.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVagas.Location = new Point(314, 188);
            lblVagas.Name = "lblVagas";
            lblVagas.Size = new Size(16, 21);
            lblVagas.TabIndex = 8;
            lblVagas.Text = "-";
            lblVagas.Click += lblVagas_Click;
            // 
            // lbl_qtdvagas
            // 
            lbl_qtdvagas.AutoSize = true;
            lbl_qtdvagas.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_qtdvagas.Location = new Point(314, 167);
            lbl_qtdvagas.Name = "lbl_qtdvagas";
            lbl_qtdvagas.Size = new Size(52, 19);
            lbl_qtdvagas.TabIndex = 7;
            lbl_qtdvagas.Text = "Vagas:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(314, 109);
            lblData.Name = "lblData";
            lblData.Size = new Size(16, 21);
            lblData.TabIndex = 6;
            lblData.Text = "-";
            // 
            // lbl_calendario
            // 
            lbl_calendario.AutoSize = true;
            lbl_calendario.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_calendario.Location = new Point(314, 88);
            lbl_calendario.Name = "lbl_calendario";
            lbl_calendario.Size = new Size(44, 19);
            lbl_calendario.TabIndex = 5;
            lbl_calendario.Text = "Data:";
            // 
            // pic_vagas
            // 
            pic_vagas.BackgroundImageLayout = ImageLayout.Zoom;
            pic_vagas.Location = new Point(263, 167);
            pic_vagas.Name = "pic_vagas";
            pic_vagas.Size = new Size(45, 42);
            pic_vagas.TabIndex = 4;
            pic_vagas.TabStop = false;
            // 
            // pic_calendario
            // 
            pic_calendario.BackgroundImageLayout = ImageLayout.Zoom;
            pic_calendario.Location = new Point(263, 88);
            pic_calendario.Name = "pic_calendario";
            pic_calendario.Size = new Size(45, 42);
            pic_calendario.TabIndex = 3;
            pic_calendario.TabStop = false;
            // 
            // pic_onibus
            // 
            pic_onibus.BackgroundImageLayout = ImageLayout.Zoom;
            pic_onibus.Location = new Point(29, 88);
            pic_onibus.Name = "pic_onibus";
            pic_onibus.Size = new Size(206, 135);
            pic_onibus.TabIndex = 2;
            pic_onibus.TabStop = false;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(18, 39);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(24, 31);
            lblDestino.TabIndex = 1;
            lblDestino.Text = "-";
            // 
            // lbl_proximaV
            // 
            lbl_proximaV.AutoSize = true;
            lbl_proximaV.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_proximaV.Location = new Point(18, 18);
            lbl_proximaV.Name = "lbl_proximaV";
            lbl_proximaV.Size = new Size(127, 21);
            lbl_proximaV.TabIndex = 0;
            lbl_proximaV.Text = "Próxima Viagem:";
            // 
            // btnB3
            // 
            btnB3.Location = new Point(592, 379);
            btnB3.Name = "btnB3";
            btnB3.Size = new Size(10, 11);
            btnB3.TabIndex = 13;
            btnB3.UseVisualStyleBackColor = true;
            btnB3.Click += btnB3_Click;
            btnB3.Paint += EstilizarBolinha;
            // 
            // btnB2
            // 
            btnB2.Location = new Point(568, 379);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(10, 11);
            btnB2.TabIndex = 12;
            btnB2.UseVisualStyleBackColor = true;
            btnB2.Click += btnB2_Click;
            btnB2.Paint += EstilizarBolinha;
            // 
            // btnB1
            // 
            btnB1.Location = new Point(542, 379);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(10, 11);
            btnB1.TabIndex = 11;
            btnB1.UseVisualStyleBackColor = true;
            btnB1.Click += btnB1_Click;
            btnB1.Paint += EstilizarBolinha;
            // 
            // pnlCard_Aniversario
            // 
            pnlCard_Aniversario.BackColor = Color.Gainsboro;
            pnlCard_Aniversario.Controls.Add(lbl_aniversariante);
            pnlCard_Aniversario.Controls.Add(lbl_proximoAni);
            pnlCard_Aniversario.Controls.Add(pic_bolo);
            pnlCard_Aniversario.Location = new Point(179, 407);
            pnlCard_Aniversario.Name = "pnlCard_Aniversario";
            pnlCard_Aniversario.Size = new Size(384, 85);
            pnlCard_Aniversario.TabIndex = 1;
            pnlCard_Aniversario.Paint += pnlCard_Aniversario_Paint;
            // 
            // lbl_aniversariante
            // 
            lbl_aniversariante.AutoSize = true;
            lbl_aniversariante.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_aniversariante.Location = new Point(99, 48);
            lbl_aniversariante.Name = "lbl_aniversariante";
            lbl_aniversariante.Size = new Size(15, 19);
            lbl_aniversariante.TabIndex = 2;
            lbl_aniversariante.Text = "-";
            // 
            // lbl_proximoAni
            // 
            lbl_proximoAni.AutoSize = true;
            lbl_proximoAni.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_proximoAni.Location = new Point(99, 14);
            lbl_proximoAni.Name = "lbl_proximoAni";
            lbl_proximoAni.Size = new Size(165, 19);
            lbl_proximoAni.TabIndex = 1;
            lbl_proximoAni.Text = "Próximo Aniversariante:";
            // 
            // pic_bolo
            // 
            pic_bolo.BackgroundImageLayout = ImageLayout.Zoom;
            pic_bolo.Location = new Point(15, 3);
            pic_bolo.Name = "pic_bolo";
            pic_bolo.Size = new Size(78, 79);
            pic_bolo.TabIndex = 0;
            pic_bolo.TabStop = false;
            // 
            // pnlCard_Reservas
            // 
            pnlCard_Reservas.BackColor = Color.Gainsboro;
            pnlCard_Reservas.Controls.Add(lbl_reservas);
            pnlCard_Reservas.Controls.Add(lbl_reservaMes);
            pnlCard_Reservas.Controls.Add(pic_reserva);
            pnlCard_Reservas.Location = new Point(595, 407);
            pnlCard_Reservas.Name = "pnlCard_Reservas";
            pnlCard_Reservas.Size = new Size(384, 85);
            pnlCard_Reservas.TabIndex = 2;
            pnlCard_Reservas.Paint += pnlCard_Reservas_Paint;
            // 
            // lbl_reservas
            // 
            lbl_reservas.AutoSize = true;
            lbl_reservas.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_reservas.Location = new Point(134, 48);
            lbl_reservas.Name = "lbl_reservas";
            lbl_reservas.Size = new Size(16, 21);
            lbl_reservas.TabIndex = 3;
            lbl_reservas.Text = "-";
            // 
            // lbl_reservaMes
            // 
            lbl_reservaMes.AutoSize = true;
            lbl_reservaMes.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_reservaMes.Location = new Point(134, 14);
            lbl_reservaMes.Name = "lbl_reservaMes";
            lbl_reservaMes.Size = new Size(122, 19);
            lbl_reservaMes.TabIndex = 2;
            lbl_reservaMes.Text = "Reservas do mês:";
            // 
            // pic_reserva
            // 
            pic_reserva.BackgroundImageLayout = ImageLayout.Zoom;
            pic_reserva.Location = new Point(20, 3);
            pic_reserva.Name = "pic_reserva";
            pic_reserva.Size = new Size(97, 79);
            pic_reserva.TabIndex = 1;
            pic_reserva.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(pnlCard_Viagens);
            pnlBase.Location = new Point(254, 83);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(645, 279);
            pnlBase.TabIndex = 3;
            // 
            // timerSlide
            // 
            timerSlide.Interval = 5;
            timerSlide.Tick += timerSlide_Tick;
            // 
            // UC_DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnB3);
            Controls.Add(pnlBase);
            Controls.Add(btnB2);
            Controls.Add(btnB1);
            Controls.Add(pnlCard_Reservas);
            Controls.Add(pnlCard_Aniversario);
            DoubleBuffered = true;
            Name = "UC_DashBoard";
            Size = new Size(1218, 788);
            VisibleChanged += UC_DashBoard_VisibleChanged;
            Enter += UC_DashBoard_Enter;
            pnlCard_Viagens.ResumeLayout(false);
            pnlCard_Viagens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_viajante).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_vagas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_calendario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_onibus).EndInit();
            pnlCard_Aniversario.ResumeLayout(false);
            pnlCard_Aniversario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_bolo).EndInit();
            pnlCard_Reservas.ResumeLayout(false);
            pnlCard_Reservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_reserva).EndInit();
            pnlBase.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard_Viagens;
        private Panel pnlCard_Aniversario;
        private PictureBox pic_onibus;
        private Label lblDestino;
        private Label lbl_proximaV;
        private Panel pnlCard_Reservas;
        private PictureBox pic_viajante;
        private Panel panel4;
        private Label lblVagas;
        private Label lbl_qtdvagas;
        private Label lblData;
        private Label lbl_calendario;
        private PictureBox pic_vagas;
        private PictureBox pic_calendario;
        private Label lbl_aniversariante;
        private Label lbl_proximoAni;
        private PictureBox pic_bolo;
        private Label lbl_reservaMes;
        private PictureBox pic_reserva;
        private Label lbl_reservas;
        private Button btnB1;
        private Button btnB3;
        private Button btnB2;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlBase;
        private System.Windows.Forms.Timer timerSlide;
    }
}
