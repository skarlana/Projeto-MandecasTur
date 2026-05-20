using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.UseControls
{
    public partial class UC_EditarCliente : UserControl
    {
        int id_usuario;

        public UC_EditarCliente(int idCliente)
        {
            InitializeComponent();
            id_usuario = idCliente;


        }

        private void MudarCoresRecursivo(Control container, bool dark)
        {
            foreach (Control c in container.Controls)
            {
                // Se NÃO for o título (que precisa ser bold), aplica a fonte normal
                if (c.Name != "lbEditarCliente")
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
                    if (c is Label && c.Name != "lbEditarCliente")
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
                panelEditarCliente.BackColor = Color.FromArgb(150, 20, 35, 30);
                lbEditarCliente.ForeColor = Color.Gainsboro;

                foreach (Control c in panelEditarCliente.Controls)
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

                panelEditarCliente.BackColor = Color.White;

                // Força o Negrito no título que a recursividade tirou
                lbEditarCliente.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                lbEditarCliente.ForeColor = Color.Black;

            }
        }


        public void carregar()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try
            {
                string sqlMostrar = @"
                SELECT nome, cpf, data_nascimento, telefone, email
                FROM Cliente
                WHERE id_cliente = @id_cliente";

                MySqlCommand cmd = new MySqlCommand(sqlMostrar, con);
                cmd.Parameters.AddWithValue("@id_cliente", id_usuario);

                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNomeCompleto.Text = reader["nome"].ToString();
                    txtCPFEditarCliente.Text = reader["cpf"].ToString();
                    dtpDataNascimento.Value = Convert.ToDateTime(reader["data_nascimento"]);
                    txtTelefoneEditarCliente.Text = reader["telefone"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSalvarEditarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text) ||
                string.IsNullOrWhiteSpace(txtCPFEditarCliente.Text) ||
                string.IsNullOrWhiteSpace(txtTelefoneEditarCliente.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text)
                )

            {
                MessageBox.Show("Os campos não podem ficar vazios durante a edição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Bloqueia a execução do UPDATE
            }

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlAtualizar = " UPDATE cliente SET nome = @nome,email = @email,cpf = @cpf,data_nascimento = @data_nascimento," +
                    "telefone = @telefone WHERE id_cliente = @id_cliente";
                MySqlCommand cmd = new MySqlCommand(sqlAtualizar, con);
                cmd.Parameters.AddWithValue("@nome", txtNomeCompleto.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPFEditarCliente.Text);
                cmd.Parameters.AddWithValue("@data_nascimento", dtpDataNascimento.Value);
                cmd.Parameters.AddWithValue("@telefone", txtTelefoneEditarCliente.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@id_cliente", id_usuario);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Cadastro Atualizado com Sucesso");

                // Pega o formulário principal
                Form homeForm = this.ParentForm;

                if (homeForm != null)
                {
                    // Encontra o panelContainer
                    Control[] controls = homeForm.Controls.Find("panelContainer", true);

                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        pnlPrincipal.Controls.Clear();

                        // Volta para o UC_GestaoClientes
                        UC_GestaoClientes gestaoClientes = new UC_GestaoClientes();
                        gestaoClientes.Dock = DockStyle.Fill;
                        pnlPrincipal.Controls.Add(gestaoClientes);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void UC_EditarCliente_Load(object sender, EventArgs e)
        {
            carregar();
            lbIDCliente.Text = id_usuario.ToString(); //Aparece ID

            CentralizarBotoes();
        }

        private void btnVoltarEditarCliente_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("As alterações não foram salvas. Tem certeza que deseja sair?", "Confirmar Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 2. TUDO o que troca a tela deve ficar dentro deste IF
            if (resultado == DialogResult.Yes)
            {
                Form homeForm = this.ParentForm;

                if (homeForm is Home home)
                {

                    home.DesbloquearMenu();
                    // Busca o painel onde as telas são carregadas
                    Control[] controls = homeForm.Controls.Find("panelContainer", true);

                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        pnlPrincipal.Controls.Clear();

                        // Cria a tela de funcionários para voltar
                        UC_GestaoClientes gestaoClientes = new UC_GestaoClientes();
                        gestaoClientes.Dock = DockStyle.Fill;
                        gestaoClientes.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                        pnlPrincipal.Controls.Add(gestaoClientes);
                    }
                }
            }

        }


        private void CentralizarBotoes()
        {
            pnlBotoes.Left = (panelEditarCliente.Width - pnlBotoes.Width) / 2;
        }

        private void panelEditarCliente_Resize(object sender, EventArgs e)
        {
            CentralizarBotoes();
        }
    }

}
