using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class TelaRecuperarSenha : Form
    {

        #region Movimentação da Janela
        //Código para arrastar a tela 
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void TelaRecuperarSenha_MouseDown(object sender, MouseEventArgs e)
        {
            //complemento de arrastar a tela
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }

        }

        #endregion

        public TelaRecuperarSenha()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;


            // REMOVE PISCADA DO PANEL
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, pnlRecuperarSenha, new object[] { true });

        }

        #region Ciclo de Vida e Layout
        private void TelaRecuperarSenha_Load(object sender, EventArgs e)
        {
            CentralizarPainel();
            AplicarBordaArredondada();
        }
        private void TelaRecuperarSenha_Resize(object sender, EventArgs e)
        {
            CentralizarPainel();
        }

        // Método para manter o card(panel) sempre no meio
        private void CentralizarPainel()
        {
            pnlRecuperarSenha.Location = new Point(
                (this.ClientSize.Width - pnlRecuperarSenha.Width) / 2,
                (this.ClientSize.Height - pnlRecuperarSenha.Height) / 2
            );
        }
        #endregion

        #region Botões de Controle


        private void lbRecolher_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbMinimizar_Click_1(object sender, EventArgs e)
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

        private void lbFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Custom Drawing (Design do Painel)

        private void AplicarBordaArredondada()
        {
            Rectangle rect = new Rectangle(0, 0, pnlRecuperarSenha.Width, pnlRecuperarSenha.Height);
            int radius = 26;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            pnlRecuperarSenha.Region = new Region(path);
        }



        private void pnlRecuperarSenha_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, pnlRecuperarSenha.Width - 1, pnlRecuperarSenha.Height - 1);
            int radius = 26;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 10, 30, 10)))
            {
                g.FillPath(brush, path);
            }

            using (Pen pen = new Pen(Color.FromArgb(50, 255, 255, 255), 1))
            {
                g.DrawPath(pen, path);
            }

        }
        #endregion

        #region Eventos de Input
        //Efeitos do TextBoxs(Linha Verde)

        private void txtEmailRecuperarSenha_MouseEnter(object sender, EventArgs e)
        {
            pnlLinhaEmailRecuperarSenha.BackColor = Color.FromArgb(68, 252, 124); // Hover 
        }

        private void txtEmailRecuperarSenha_MouseLeave(object sender, EventArgs e)
        {
            pnlLinhaEmailRecuperarSenha.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void txtNovaSenha_MouseEnter(object sender, EventArgs e)
        {
            txtNovaSenha.PasswordChar = '●'; //Esconder caracteres
            pnlLinhaNovaSenha.BackColor = Color.FromArgb(68, 252, 124);//hover
        }

        private void txtNovaSenha_MouseLeave(object sender, EventArgs e)
        {
            pnlLinhaNovaSenha.BackColor = Color.FromArgb(255, 255, 255); ;
        }

        private void txtConfirmarSenha_MouseEnter(object sender, EventArgs e)
        {
            txtConfirmarSenha.PasswordChar = '●'; //Esconder caracteres
            pnlConfirmarSenha.BackColor = Color.FromArgb(68, 252, 124);//hover
        }

        private void txtConfirmarSenha_MouseLeave(object sender, EventArgs e)
        {
            pnlConfirmarSenha.BackColor = Color.FromArgb(255, 255, 255); ;
        }

        #endregion

        //Levar para proxima tela

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            // Validação básica
            if (string.IsNullOrWhiteSpace(txtEmailRecuperarSenha.Text) ||
                string.IsNullOrWhiteSpace(txtNovaSenha.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se as senhas batem
            if (txtNovaSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();

            try
            {
                conn.Open();

                // Atualizar senha no banco
                string sql = "UPDATE funcionario SET senha = @senha WHERE email = @email";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@senha", txtNovaSenha.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailRecuperarSenha.Text);

                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Senha alterada com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fecha e volta pro login (opcional)
                    this.Close();
                }
                else
                {
                    MessageBox.Show("E-mail não encontrado!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                txtNovaSenha.Clear();
                txtConfirmarSenha.Clear();
                txtNovaSenha.Focus();


                TelaLogin login = new TelaLogin();
                login.Show();
                this.Hide();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar senha: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }

        private void lbVoltarLogin_Click(object sender, EventArgs e)
        {
            TelaLogin Login = new TelaLogin();
            Login.Show();
            this.Hide();

        }

        bool senhaVisivel1 = false;
        bool senhaVisivel2 = false;


        private void picMostraAlterarSenha_Click(object sender, EventArgs e)
        {

            if(senhaVisivel1)
            {
                txtNovaSenha.PasswordChar = '●';
                picMostraAlterarSenha.Image = Image.FromFile(@"..\..\..\Resources\eye.png");
                senhaVisivel1 = false;
            }
            else
            {
                txtNovaSenha.PasswordChar = '\0';
                picMostraAlterarSenha.Image = Image.FromFile(@"..\..\..\Resources\hidden.png");
                senhaVisivel1 = true;
            }

        }

        private void picMostraAlterarSenha2_Click(object sender, EventArgs e)
        {

            if (senhaVisivel2)
            {
                txtConfirmarSenha.PasswordChar = '●';
                picMostraAlterarSenha.Image = Image.FromFile(@"..\..\..\Resources\eye.png");
                senhaVisivel2 = false;
            }
            else
            {
                txtConfirmarSenha.PasswordChar = '\0';
                picMostraAlterarSenha.Image = Image.FromFile(@"..\..\..\Resources\hidden.png");
                senhaVisivel2 = true;
            }

        }
    }
}







