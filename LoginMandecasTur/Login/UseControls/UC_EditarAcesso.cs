using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Login.UseControls
{
    public partial class UC_EditarAcesso : UserControl
    {
        int id_usuario;

        public UC_EditarAcesso(int idfuncionarios)
        {
            InitializeComponent();
            id_usuario = idfuncionarios;
        }

        private void MudarCoresRecursivo(Control container, bool dark)
        {
            foreach (Control c in container.Controls)
            {
                // Se NÃO for o título (que precisa ser bold), aplica a fonte normal
                if (c.Name != "lbDadosAcesso")
                {
                    c.Font = new Font("Segoe UI", 10);
                }

                if (dark)
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
                    // Cor das labels no modo claro
                    if (c is Label && c.Name != "lbDadosAcesso")
                        c.ForeColor = Color.FromArgb(64, 64, 64);
                }

                if (c.HasChildren) MudarCoresRecursivo(c, dark);
            }
        }

        public void AtualizarTema(bool isDark)
        {
            if (isDark)
            {
                // 1. O Fundo da UC deve ser transparente para mostrar a imagem da Home
                this.BackColor = Color.FromArgb(20, 35, 30);
                MudarCoresRecursivo(this, isDark);

                // 2. Painel de Cadastro (Efeito Transparente)
                pnlCadastro.BackColor = Color.FromArgb(150, 20, 35, 30);
                lbDadosAcesso.ForeColor = Color.Gainsboro;

                foreach (Control c in pnlCadastro.Controls)
                {
                    if (c is Label) c.ForeColor = Color.Gainsboro;
                    if (c is TextBox txt)
                    {
                        txt.BackColor = Color.FromArgb(45, 45, 45); // Textbox escura
                        txt.ForeColor = Color.White;
                        txt.BorderStyle = BorderStyle.FixedSingle;
                    }
                }


            }
            else // MODO CLARO
            {
                this.BackColor = Color.FromArgb(239, 239, 239); // O cinza clarinho de fundo da gc5
                MudarCoresRecursivo(this, false);

                // --- PAINEL DE CADASTRO ---

                pnlCadastro.BackColor = Color.White;

                // Força o Negrito no título que a recursividade tirou
                lbDadosAcesso.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                lbDadosAcesso.ForeColor = Color.Black;

            }
        }


        public void carregar()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try
            {
                string sql = "SELECT nome, documento, email, perfil_acesso FROM funcionario WHERE id_funcionario = @id_funcionario";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id_funcionario", id_usuario);

                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtnomeacesso.Text = reader["nome"].ToString();
                    txtcpfacesso.Text = reader["documento"].ToString();
                    txtemailacesso.Text = reader["email"].ToString();
                    cbmperfil.Text = reader["perfil_acesso"].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void UC_EditarAcesso_Load(object sender, EventArgs e)
        {
            carregar();
            CentralizarBotoes();
            lbCodigo.Text = id_usuario.ToString();
        }

        private void btnSalvarEditarAcesso_Click(object sender, EventArgs e)
        {
            // Validação de segurança
            if (string.IsNullOrWhiteSpace(txtnomeacesso.Text) ||
                string.IsNullOrWhiteSpace(txtcpfacesso.Text) ||
                string.IsNullOrWhiteSpace(txtemailacesso.Text) ||
                cbmperfil.SelectedItem == null)
            {
                MessageBox.Show("Os campos não podem ficar vazios durante a edição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string atualizar = "UPDATE funcionario SET nome = @nome, email = @email, documento = @documento, perfil_acesso = @perfil_acesso " +
                                   "WHERE id_funcionario = @id_funcionario";

                MySqlCommand cmd = new MySqlCommand(atualizar, con);
                cmd.Parameters.AddWithValue("@nome", txtnomeacesso.Text);
                cmd.Parameters.AddWithValue("@documento", txtcpfacesso.Text);
                cmd.Parameters.AddWithValue("@email", txtemailacesso.Text);
                cmd.Parameters.AddWithValue("@perfil_acesso", cbmperfil.Text);
                cmd.Parameters.AddWithValue("@id_funcionario", id_usuario); // Usando a variável int

                cmd.ExecuteNonQuery();

                MessageBox.Show("Perfil Atualizado com Sucesso");

                // Lógica para voltar à tela anterior
                VoltarParaListagem();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }
        private void btnVoltarEditarAcesso_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("As alterações não foram salvas. Tem certeza que deseja sair?", "Confirmar Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                VoltarParaListagem();
            }

        }
      
        // Criei este método para você não repetir código no Salvar e no Voltar
        private void VoltarParaListagem()
        {
            Form homeForm = this.ParentForm;
            if (homeForm is Home home)
            {
                home.DesbloquearMenu();
                Control[] controls = homeForm.Controls.Find("panelContainer", true);

                if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                {
                    pnlPrincipal.Controls.Clear();
                    UC_Funcionario atFuncionario = new UC_Funcionario();
                    atFuncionario.Dock = DockStyle.Fill;
                    atFuncionario.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                    pnlPrincipal.Controls.Add(atFuncionario);
                }
            }
        }


        private void CentralizarBotoes()
        {
            pnlBotoes.Left = (pnlCadastro.Width - pnlBotoes.Width) / 2;
        }

        private void pnlCadastro_Resize(object sender, EventArgs e)
        {
            CentralizarBotoes();
        }

       
    }
}