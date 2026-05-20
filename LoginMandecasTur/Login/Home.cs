using Login.UseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO; // <-- ADICIONADO PARA LER AS IMAGENS DO PC
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Login

{

    #region Movimentação de Tela

    public partial class Home : Form

    {
     
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }
     
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void pnlNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        // Variável para armazenar o perfil do usuário logado
        private string perfilUsuarioLogado;

        string userName;

        // [ALTERADO] O construtor agora recebe o perfil
        public Home(string perfil, string nomeUser)
        {

            InitializeComponent();
            this.perfilUsuarioLogado = perfil; // Salva o perfil recebido
            userName = nomeUser;

            //Mostra nome do Usuario
            ExibirNomeUser();

            MoverLinhaNav(btnHome);
            UC_DashBoard uc = new UC_DashBoard();
            addUserControl(uc);

            // [INCLUÍDO] Chama a verificação de acesso
            VerificarAcesso();


            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.UpdateStyles();



        }


        //METODO DE PUXAR NOME USUARIO
        private void ExibirNomeUser()
        {
            lbUserName.Text = userName;
        }
        // [NOVO] Método que esconde ou bloqueia o botão
        private void VerificarAcesso()
        {
            if (perfilUsuarioLogado == "Padrão")
            {
                // Opção 1: Deixar invisível (Mais limpo)
                btnFuncionario.Visible = false;

                // Opção 2: Apenas desabilitar (Aparece mas não clica)
                // btnFuncionario.Enabled = false;
            }
        }


        // Variável global para o sistema saber qual tema usar

        public static bool IsDarkMode = false;

        public void AplicarTemaHome()

        {

            if (ConfigGreenMode.ModoEscuroAtivo)
            {
                // MODO ESCURO
                this.BackgroundImage = Properties.Resources.img_fundo_escuro;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                pnlNavBar.BackColor = Color.FromArgb(10, 25, 20);
                imgLogoHome.Image = Properties.Resources.logo_vazado_branco;
                darkModeToolStripMenuItem.ForeColor = Color.Gainsboro;
                pnlMenu.BackColor = Color.FromArgb(15, 40, 30);
            }
            else
            {
                // MODO CLARO
                this.BackgroundImage = null; // Ou sua imagem de fundo clara
                this.BackColor = SystemColors.Control;
                pnlNavBar.BackColor = Color.FromArgb(0, 255, 127); // Cor verde vibrante da sua print
                imgLogoHome.Image = Properties.Resources.logo_vazado_branco; // Logo colorida
                darkModeToolStripMenuItem.ForeColor = Color.Black;
                pnlMenu.BackColor = Color.Gainsboro; // Cor de fundo do menu no claro
            }

            // Agora percorremos os botões FORA daqueles ifs aninhados
            foreach (Control c in pnlMenu.Controls)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    if (ConfigGreenMode.ModoEscuroAtivo)
                    {
                        btn.ForeColor = Color.Gainsboro;
                        btn.BackColor = Color.Transparent;
                        // Verde elegante para o modo escuro
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 80, 60);
                        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 40, 30);
                    }
                    else
                    {
                        btn.ForeColor = Color.Black;
                        btn.BackColor = Color.Transparent; // Deixa o fundo do painel aparecer
                                                           // Cinza claro que você quer (estilo erro2.png)
                        btn.FlatAppearance.MouseOverBackColor = Color.LightGray;
                        btn.FlatAppearance.MouseDownBackColor = Color.DarkGray; // O mousedown que faltava!
                    }
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            panelContainer.GetType()
            .GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.Instance |
             System.Reflection.BindingFlags.NonPublic)
            .SetValue(panelContainer, true, null);

            typeof(Panel).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.SetProperty |
            System.Reflection.BindingFlags.Instance |
             System.Reflection.BindingFlags.NonPublic,
            null, panelContainer, new object[] { true });

        }



        #region Botões Ciclo de Vida - Tela

        private void lbFechar_Click_1(object sender, EventArgs e)

        {

            Application.Exit();

        }



        private void lbMinimizar_Click(object sender, EventArgs e)

        {

            if (this.WindowState == FormWindowState.Maximized)

            {

                this.WindowState = FormWindowState.Normal;

            }

            else

            {

                // Re-atualiza a área de trabalho caso você tenha movido de monitor

                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

                this.WindowState = FormWindowState.Maximized;

            }

        }



        private void lbRecolher_Click(object sender, EventArgs e)

        {

            this.WindowState = FormWindowState.Minimized;

        }

        #endregion



        #region Design do Painel /Layout

        private void ArredondarPainel(Panel panel, int raio)

        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(panel.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, panel.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }



        private void pnlUserName_Paint(object sender, PaintEventArgs e)
        {
            ArredondarPainel((Panel)sender, 20); // Ajuste o raio conforme desejado
        }
        #endregion



        #region Botões de Controle - Navegação - Menu


        public void BloquearMenu()
        {
            btnHome.Enabled = false;
            btnGestaoClientes.Enabled = false;
            btnGestaoViagens.Enabled = false;
            btnFinanceiro.Enabled = false;
            btnReservas.Enabled = false;
            btnFuncionario.Enabled = false;

        }



        public void DesbloquearMenu()

        {
            btnHome.Enabled = true;
            btnGestaoClientes.Enabled = true;
            btnGestaoViagens.Enabled = true;
            btnFinanceiro.Enabled = true;
            btnReservas.Enabled = true;
            btnFuncionario.Enabled = true;

        }



        private void MoverLinhaNav(Control btn)
        {
            // Ajusta a largura da linha para ser igual à do botão clicado
            pnlNav.Width = btn.Width;
            // Move a posição da linha para alinhar com o botão
            pnlNav.Left = btn.Left;
            // Garante que a linha fique visível (caso esteja escondida)
            pnlNav.Visible = true;
        }



        private void addUserControl(UserControl userControl)
        {
        
            panelContainer.SuspendLayout(); // 🔥 trava o layout

            // remove só se existir
            if (panelContainer.Controls.Count > 0)
            {
                Control oldControl = panelContainer.Controls[0];
                panelContainer.Controls.Remove(oldControl);
                oldControl.Dispose();
            }

            userControl.Dock = DockStyle.Fill;
            userControl.BackColor = panelContainer.BackColor; // 🔥 evita branco

            panelContainer.Controls.Add(userControl);

            panelContainer.ResumeLayout(); // 🔥 libera layout
        
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
         

            MoverLinhaNav((Control)sender); // A mágica acontece aqui
            UC_DashBoard Dash = new UC_DashBoard();
            addUserControl(Dash);
            Dash.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
        }

        private void btnGestaoClientes_Click(object sender, EventArgs e)
        {

            MoverLinhaNav((Control)sender); // A mágica acontece aqui
            UC_GestaoClientes Home = new UC_GestaoClientes();
            addUserControl(Home);
            Home.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
        }



        private void btnGestaoViagens_Click(object sender, EventArgs e)

        {
            MoverLinhaNav((Control)sender); // A mágica acontece aqui
            UC_GestaoViagens Viagem = new UC_GestaoViagens();
            addUserControl(Viagem);
            Viagem.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
        }



        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            MoverLinhaNav((Control)sender); // A mágica acontece aqui
            UC_Financeiro Financeiro = new UC_Financeiro();
            addUserControl(Financeiro);
            Financeiro.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
        }



        private void btnReservas_Click(object sender, EventArgs e)
        {
            MoverLinhaNav((Control)sender); // A mágica acontece aqui
            UC_RegistrarEntrada Reservar = new UC_RegistrarEntrada();
            addUserControl(Reservar);
            Reservar.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
            

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            MoverLinhaNav((Control)sender); // A mágica acontece aqui
            UC_Funcionario Funcionario = new UC_Funcionario();
            addUserControl(Funcionario);
            Funcionario.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
        }

        #endregion


    


        // Método auxiliar para avisar as telas do centro que a cor mudou
        private void AtualizarTelasInternas()
        {
            if (panelContainer.Controls.Count > 0)

            {
                var ucAberta = panelContainer.Controls[0];

                if (ucAberta is UC_DashBoard ucDash) ucDash.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                else if (ucAberta is UC_GestaoClientes ucCli) ucCli.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                else if (ucAberta is UC_EditarCliente ucEC) ucEC.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                else if (ucAberta is UC_GestaoViagens ucGV) ucGV.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                else if (ucAberta is UC_EditarViagem ucEV) ucEV.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                else if (ucAberta is UC_IncluirPassageiros ucIncluir) ucIncluir.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                else if (ucAberta is UC_RegistrarEntrada ucRE) ucRE.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                else if (ucAberta is UC_Financeiro ucFin) ucFin.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                else if (ucAberta is UC_Funcionario ucFun) ucFun.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                else if (ucAberta is UC_EditarAcesso ucEA) ucEA.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);



            }
        }

        private void imgLogoHome_Click(object sender, EventArgs e)
        {
            UC_DashBoard Dash = new UC_DashBoard();
            addUserControl(Dash);
            Dash.AtualizarTema(IsDarkMode);
        }

        private void imgNomeLogoHome_Click(object sender, EventArgs e)
        {
            UC_DashBoard Dash = new UC_DashBoard();
            addUserControl(Dash);
            Dash.AtualizarTema(IsDarkMode);
        }

        private void imgConfigurar_MouseClick(object sender, MouseEventArgs e)
        {
            cmsConfigurarMenu.Show(imgConfigurar, e.Location);
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigGreenMode.ModoEscuroAtivo = !ConfigGreenMode.ModoEscuroAtivo;

            AplicarTemaHome();        // Pinta a Home
            AtualizarTelasInternas();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaLogin Login = new TelaLogin();
            this.Close();
            Login.Show();
            
        }
    }
}


