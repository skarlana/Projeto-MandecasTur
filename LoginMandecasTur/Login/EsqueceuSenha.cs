
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.InteropServices; // Necessário para a movimentação

namespace Login
{
    public partial class TelaLogin : Form
    {
        #region Movimentação da Janela
        //Código para arrastar a tela 
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void TelaLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //complemento de arrastar a tela
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        #endregion

        public TelaLogin()
        {
            InitializeComponent();
        }

        #region Ciclo de Vida e Layout
        private void TelaLogin_Load(object sender, EventArgs e)
        {

            CentralizarPainel();
        }

        private void TelaLogin_Resize(object sender, EventArgs e)
        {
            CentralizarPainel();
        }


        // Método para manter o card(panel) sempre no meio
        private void CentralizarPainel()
        {
            pnlLogin.Location = new Point(
                (this.ClientSize.Width - pnlLogin.Width) / 2,
                (this.ClientSize.Height - pnlLogin.Height) / 2
            );
        }
        #endregion

        #region Botões de Controle
        private void lbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbRecolher_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // Garante que vai respeitar a área de trabalho antes de maximizar
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
        }
        #endregion

        #region Custom Drawing (Design do Painel)
        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
            // 1. Criar o GraphicsPath com cantos arredondados (Radius: 25).
            // 2. Preencher com Color.FromArgb(190, 10, 30, 10).
            // 3. Desenhar a borda fina com Color.FromArgb(50, 255, 255, 255).
            // 4. Setar a Region do painel para o path criado.

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Definição do Retângulo e Arredondamento 
            Rectangle rect = new Rectangle(0, 0, pnlLogin.Width - 1, pnlLogin.Height - 1);
            int radius = 26;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();


            // 1. Preenchimento (Verde Escuro Semi-transparente) 
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 10, 30, 10)))
            {
                g.FillPath(brush, path);
            }

            // 2. Borda do Painel (Linha fina branca/clara) 
            using (Pen pen = new Pen(Color.FromArgb(50, 255, 255, 255), 1))
            {
                g.DrawPath(pen, path);
            }

            // Aplica o arredondamento à região do controle para cortar as quinas 
            pnlLogin.Region = new Region(path);
        }
        #endregion

        #region Eventos de Input
        //Efeitos do TextBoxs(Linha Verde)
        private void txtUsuarioLogin_Enter(object sender, EventArgs e)
        {
            pnlLinhaUsuarioLogin.BackColor = Color.FromArgb(68, 252, 124); // Hover 
        }

        private void txtUsuarioLogin_Leave(object sender, EventArgs e)
        {  
            pnlLinhaUsuarioLogin.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void txtSenhaLogin_Enter(object sender, EventArgs e)
        { 
            txtSenhaLogin.PasswordChar = '●'; //Esconder caracteres
            pnlLinhaSenhaLogin.BackColor = Color.FromArgb(68, 252, 124);//hover
        }

        private void txtSenhaLogin_Leave(object sender, EventArgs e)
        {
            pnlLinhaSenhaLogin.BackColor = Color.FromArgb(255, 255, 255); ;
        }
        #endregion

        //Levar para proxima tela
        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioLogin.Text) || string.IsNullOrWhiteSpace(txtSenhaLogin.Text))
            {
                MessageBox.Show("Por favor, informe o e-mail e a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();

            try
            {
                conn.Open();

                // 1. Buscamos os dados do funcionário
                string sql = "SELECT nome, perfil_acesso FROM funcionario WHERE email = @email AND senha = @senha";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", txtUsuarioLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenhaLogin.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // 2. [NOVO] Lê a primeira linha encontrada
                    reader.Read();

                    // 3. [NOVO] Captura o valor da coluna perfil_acesso
                    string perfil = reader["perfil_acesso"].ToString();
                    string nomeUser = reader["nome"].ToString() ;

                    // 4. [ALTERADO] Passa o perfil como argumento para o construtor da Home
                    Home TelaHome = new Home(perfil,nomeUser);
                    TelaHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("E-mail ou senha incorretos!", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenhaLogin.Clear();
                    txtSenhaLogin.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro técnico ao autenticar: " + ex.Message, "Erro no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        
        }
    }
}
