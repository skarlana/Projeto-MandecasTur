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



        public Home()

        {

            InitializeComponent();

            MoverLinhaNav(btnHome);


            UC_DashBoard uc = new UC_DashBoard();

            addUserControl(uc);

        }



        // Variável global para o sistema saber qual tema usar

        public static bool IsDarkMode = false;



        public void AplicarTemaHome()

        {

            if (IsDarkMode)
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

                    if (IsDarkMode)
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

            // Primeiro define o limite

            // this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Depois define o estado

            // this.WindowState = FormWindowState.Maximized;

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

        private void CentralizarConteudo(Control conteudo)

        {

            int x = (panelContainer.Width - conteudo.Width) / 2;

            int y = (panelContainer.Height - conteudo.Height) / 2;



            // Math.Max(0, ...) garante que se a tela for pequena, o conteúdo não "fuja" para fora do topo

            conteudo.Location = new Point(Math.Max(0, x), Math.Max(0, y));

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

            panelContainer.Controls.Clear();



            if (panelContainer.Controls.Count > 0)

            {

                // Limpa e libera memória do controle anterior

                Control oldControl = panelContainer.Controls[0];

                panelContainer.Controls.Remove(oldControl);

                oldControl.Dispose();

            }



            // Altere de None para Fill para o User Control ocupar todo o painel cinza

            userControl.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(userControl);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MoverLinhaNav((Control)sender); // A mágica acontece aqui

            UC_DashBoard Dash = new UC_DashBoard();

            addUserControl(Dash);

            Dash.AtualizarTema(IsDarkMode);
        }

        private void btnGestaoClientes_Click(object sender, EventArgs e)

        {

            MoverLinhaNav((Control)sender); // A mágica acontece aqui

            UC_GestaoClientes Home = new UC_GestaoClientes();

            addUserControl(Home);

            Home.AtualizarTema(IsDarkMode);
        }



        private void btnGestaoViagens_Click(object sender, EventArgs e)

        {

            MoverLinhaNav((Control)sender); // A mágica acontece aqui

            UC_GestaoViagens Viagem = new UC_GestaoViagens();

            addUserControl(Viagem);

            Viagem.AtualizarTema(IsDarkMode);
        }



        private void btnFinanceiro_Click(object sender, EventArgs e)

        {

            MoverLinhaNav((Control)sender); // A mágica acontece aqui

            UC_Financeiro Financeiro = new UC_Financeiro();

            addUserControl(Financeiro);
            Financeiro.AtualizarTema(IsDarkMode);
        }



        private void btnReservas_Click(object sender, EventArgs e)

        {

            MoverLinhaNav((Control)sender); // A mágica acontece aqui

            UC_RegistrarEntrada Reservar = new UC_RegistrarEntrada();

            addUserControl(Reservar);
            Reservar.AtualizarTema(IsDarkMode);
            Reservar.AtualizarTema(IsDarkMode);

        }



        private void btnFuncionario_Click(object sender, EventArgs e)

        {

            MoverLinhaNav((Control)sender); // A mágica acontece aqui

            UC_Funcionario Funcionario = new UC_Funcionario();

            addUserControl(Funcionario);
            Funcionario.AtualizarTema(IsDarkMode);
        }



        #endregion



        private void panelContainer_Paint(object sender, PaintEventArgs e)

        {



        }



        // =========================================================================

        // AQUI COMEÇA A NOVA LÓGICA DO MENU FLUTUANTE QUE SUBSTITUIU A ANTIGA

        // =========================================================================

        private void imgConfigurar_Click(object sender, EventArgs e)

        {

            // Substituímos o painel cortado por esse menu nativo do Windows!

            MostrarMenuPerfil(sender, e);

        }



        #region Novo Menu de Perfil Flutuante

        private void MostrarMenuPerfil(object sender, EventArgs e)

        {

            ContextMenuStrip menuPerfil = new ContextMenuStrip();

            menuPerfil.BackColor = Color.White;

            menuPerfil.ShowImageMargin = true; // Espaço para as imagens

            menuPerfil.Font = new Font("Segoe UI", 10);

            menuPerfil.Cursor = Cursors.Hand;



            // 1. OPÇÃO ÚNICA DE TEMA (Alterna entre Claro e Escuro)

            ToolStripMenuItem menuTema = new ToolStripMenuItem();



            /*// Configura os caminhos (tentando PNG e JPG caso o Windows tenha escondido a extensão)

            string caminhoSolPNG = @"C:\Users\silas.sbsilva\Downloads\sol.png";

            string caminhoSolJPG = @"C:\Users\silas.sbsilva\Downloads\sol.jpg";

            string caminhoLuaPNG = @"C:\Users\silas.sbsilva\Downloads\lua.png";

            string caminhoLuaJPG = @"C:\Users\silas.sbsilva\Downloads\lua.jpg";



            if (IsDarkMode)

            {

                // Se estiver escuro, a opção é ir para o Claro (Mostra o Sol)

                menuTema.Text = "Modo Claro";

                if (File.Exists(caminhoSolPNG)) menuTema.Image = Image.FromFile(caminhoSolPNG);

                else if (File.Exists(caminhoSolJPG)) menuTema.Image = Image.FromFile(caminhoSolJPG);

            }

            else

            {

                // Se estiver claro, a opção é ir para o Escuro (Mostra a Lua)

                menuTema.Text = "Modo Escuro";

                if (File.Exists(caminhoLuaPNG)) menuTema.Image = Image.FromFile(caminhoLuaPNG);

                else if (File.Exists(caminhoLuaJPG)) menuTema.Image = Image.FromFile(caminhoLuaJPG);

            }*/



            // O que acontece ao clicar nesse botão único:

            menuTema.Click += (s, args) =>

            {

                IsDarkMode = !IsDarkMode; // Inverte a variável global (se for true vira false, e vice-versa)

                AplicarTemaHome();        // Pinta a Home

                AtualizarTelasInternas(); // Pinta os painéis do meio

            };



            ToolStripSeparator linha = new ToolStripSeparator();



            // 2. OPÇÃO SAIR (Porta de saída)

            ToolStripMenuItem menuSair = new ToolStripMenuItem("Sair do Sistema");



            // Tenta ler como PNG ou JPG

            string caminhoPortaPNG = @"C:\Users\silas.sbsilva\Downloads\portadesaida.png";

            string caminhoPortaJPG = @"C:\Users\silas.sbsilva\Downloads\portadesaida.jpg";



            if (File.Exists(caminhoPortaPNG)) menuSair.Image = Image.FromFile(caminhoPortaPNG);

            else if (File.Exists(caminhoPortaJPG)) menuSair.Image = Image.FromFile(caminhoPortaJPG);



            menuSair.ForeColor = Color.Red;

            menuSair.Click += (s, args) => Application.Exit();



            // Adiciona as opções ao menu

            menuPerfil.Items.Add(menuTema);

            menuPerfil.Items.Add(linha);

            menuPerfil.Items.Add(menuSair);



            // =========================================================================

            // A MÁGICA QUE RESOLVE O MENU CORTADO:

            // O comando "ToolStripDropDownDirection.BelowLeft" força o menu a abrir

            // para a ESQUERDA do ícone, mantendo ele 100% dentro da tela!

            // =========================================================================

            Control controleClicado = (Control)sender;

            menuPerfil.Show(controleClicado, new Point(controleClicado.Width, controleClicado.Height), ToolStripDropDownDirection.BelowLeft);

        }

        #endregion

        // Método auxiliar para avisar as telas do centro que a cor mudou

        private void AtualizarTelasInternas()

        {

            if (panelContainer.Controls.Count > 0)

            {

                var ucAberta = panelContainer.Controls[0];



                if (ucAberta is UC_DashBoard ucDash) ucDash.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_GestaoClientes ucCli) ucCli.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_EditarCliente ucEC) ucEC.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_GestaoViagens ucGV) ucGV.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_EditarViagem ucEV) ucEV.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_IncluirPassageiros ucIncluir) ucIncluir.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_RegistrarEntrada ucRE) ucRE.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_Financeiro ucFin) ucFin.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_Funcionario ucFun) ucFun.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_EditarAcesso ucEA) ucEA.AtualizarTema(IsDarkMode);



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
    }
}


