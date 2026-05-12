using Login.UseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            MoverLinhaNav(btnGestaoClientes);
            UC_GestaoClientes uc = new UC_GestaoClientes();
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
                darkModeToolStripMenuItem.Text = "Modo Claro";
            }
            else
            {
                // MODO CLARO
                this.BackgroundImage = null;
                this.BackColor = SystemColors.Control;
                pnlNavBar.BackColor = Color.FromArgb(0, 255, 127);
                imgLogoHome.Image = Properties.Resources.logo_vazado_branco;
                darkModeToolStripMenuItem.ForeColor = Color.Black;
                pnlMenu.BackColor = Color.White;
                darkModeToolStripMenuItem.Text = "Modo Escuro";

                // Resetando cores dos textos dos botões no modo claro
                btnGestaoClientes.ForeColor = Color.Black;
                btnGestaoViagens.ForeColor = Color.Black;
                btnReservas.ForeColor = Color.Black;
                btnFinanceiro.ForeColor = Color.Black;
                btnFuncionario.ForeColor = Color.Black;
            }

            // --- ESSE BLOCO ABAIXO FOI MOVIDO PARA FORA DOS IFS ---
            // Assim ele atualiza os botões SEMPRE, não importa o tema
            foreach (Control c in pnlMenu.Controls)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;

                    if (IsDarkMode)
                    {
                        btn.ForeColor = Color.Gainsboro;
                        btn.BackColor = Color.Transparent;
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 80, 60);
                        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 40, 30);
                        btn.FlatAppearance.BorderSize = 0;
                    }
                    else
                    {
                        btn.ForeColor = Color.Black;
                        btn.BackColor = Color.Transparent; // Deixa o branco do painel aparecer
                        btn.FlatAppearance.MouseOverBackColor = Color.LightGray; // O cinza claro de erro2.png
                        btn.FlatAppearance.MouseDownBackColor = Color.DarkGray;  // Adicionei o mousedown aqui!
                        btn.FlatAppearance.BorderSize = 0; // Se preferir sem borda igual no escuro
                    }
                }
            }

            // Atualização de fontes e outros controles (TextBox, etc)
            foreach (Control c in this.Controls)
            {
                c.Font = new Font("Segoe UI", 9, FontStyle.Regular);

                if (IsDarkMode)
                {
                    if (c is TextBox || c is DateTimePicker)
                    {
                        c.BackColor = Color.FromArgb(45, 45, 45);
                        c.ForeColor = Color.White;
                    }
                    if (c is Label) c.ForeColor = Color.Gainsboro;
                }
                else
                {
                    if (c is TextBox || c is DateTimePicker)
                    {
                        c.BackColor = Color.White;
                        c.ForeColor = Color.Black;
                    }
                    if (c is Label) c.ForeColor = Color.Black;
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
            btnGestaoClientes.Enabled = false;
            btnGestaoViagens.Enabled = false;
            btnFinanceiro.Enabled = false;
            btnReservas.Enabled = false;
            btnFuncionario.Enabled = false;
        }

        public void DesbloquearMenu()
        {
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

        private void imgConfigurar_Click(object sender, EventArgs e)
        {
            cmsConfigurarMenu.Show(imgConfigurar, 0, imgConfigurar.Height);
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsDarkMode = !IsDarkMode; // Inverte o tema
            AplicarTemaHome();        // Executa a troca de cores/imagens na Home

            // Verifica qual UC está aparecendo agora e avisa ela
            if (panelContainer.Controls.Count > 0)
            {
                var ucAberta = panelContainer.Controls[0];

                if (ucAberta is UC_GestaoClientes ucCli) ucCli.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_EditarCliente ucEC) ucEC.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_GestaoViagens ucViagem) ucViagem.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_EditarViagem ucEV) ucEV.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_RegistrarEntrada ucRE) ucRE.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_IncluirPassageiros ucIncluir) ucIncluir.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_Funcionario ucFunc) ucFunc.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_Financeiro ucFin) ucFin.AtualizarTema(IsDarkMode);

            }
        }
    }
}
