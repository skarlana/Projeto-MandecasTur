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
    public partial class UC_EditarViagem : UserControl
    {
        int id_EditarViagem;
        public UC_EditarViagem(int idviagem)
        {
            InitializeComponent();
            id_EditarViagem = idviagem;
        }

        private void MudarCoresRecursivo(Control container, bool dark)
        {
            foreach (Control c in container.Controls)
            {
                // Se NÃO for o título (que precisa ser bold), aplica a fonte normal
                if (c.Name != "lbEditarViagem")
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
                    if (c is Label && c.Name != "lbEditarViagem")
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
                panelEditarViagem.BackColor = Color.FromArgb(150, 20, 35, 30);
                lbEditarViagem.ForeColor = Color.Gainsboro;

                foreach (Control c in panelEditarViagem.Controls)
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

                panelEditarViagem.BackColor = Color.White;

                // Força o Negrito no título que a recursividade tirou
                lbEditarViagem.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                lbEditarViagem.ForeColor = Color.Black;

            }
        }

        public void Carregar()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try
            {
                string sql = @"
                SELECT id_viagem, destino, data_viagem, qtdd_vagas, tipo_transporte, custo_transporte, custo_hospedagem, valor_unitario 
                FROM viagem
                WHERE id_viagem = @id_viagem";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id_viagem", id_EditarViagem);

                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtDestino.Text = reader["destino"].ToString();
                    dtpDataViagemEditarViagem.Value = Convert.ToDateTime(reader["data_viagem"].ToString());
                    txtQtdDeViagem.Text = reader["qtdd_vagas"].ToString();
                    txtTransporte.Text = reader["tipo_transporte"].ToString();
                    txtCustoDoTransporte.Text = reader["custo_transporte"].ToString();
                    txtCustoDaHospedagem.Text = reader["custo_hospedagem"].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSalvarEditarViagem_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try
            {
                con.Open();
                string atualizar = "UPDATE viagem SET destino = @destino, data_viagem = @data_viagem, qtdd_vagas = @qtdd_vagas, tipo_transporte = @tipo_transporte, custo_transporte = @custo_transporte, custo_hospedagem = @custo_hospedagem, valor_unitario = @valor_unitario WHERE id_viagem = @id_viagem";
                MySqlCommand cmd = new MySqlCommand(atualizar, con);
                cmd.Parameters.AddWithValue("@destino", txtDestino.Text);
                cmd.Parameters.AddWithValue("@data_viagem", dtpDataViagemEditarViagem.Value);
                cmd.Parameters.AddWithValue("@qtdd_vagas", txtQtdDeViagem.Text);
                cmd.Parameters.AddWithValue("@tipo_transporte", txtTransporte.Text);
                cmd.Parameters.AddWithValue("@custo_transporte", txtCustoDoTransporte.Text);
                cmd.Parameters.AddWithValue("@custo_hospedagem", txtCustoDaHospedagem.Text);
                cmd.Parameters.AddWithValue("@id_viagem", id_EditarViagem);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Viagem atualizada com sucesso!");

                Form homeForm = this.ParentForm;

                if (homeForm is Home home)
                {

                    home.DesbloquearMenu();
                    // Encontra o panelContainer
                    Control[] controls = homeForm.Controls.Find("panelContainer", true);

                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        pnlPrincipal.Controls.Clear();

                        // Volta para o UC_GestaoClientes
                        UC_GestaoViagens EditarViagem = new UC_GestaoViagens();
                        EditarViagem.Dock = DockStyle.Fill;
                        pnlPrincipal.Controls.Add(EditarViagem);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_EditarViagem_Load(object sender, EventArgs e)
        {
            Carregar();

            // 🟢 O ESCUDO AQUI: Assim que a tela carregar, ela força o Green Mode a rodar!
            this.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);

            dtpDataViagemEditarViagem.Value = DateTime.Now;
            lbIDViagem.Text = id_EditarViagem.ToString();
            CentralizarBotoes();
        }

        private void btnVoltarEditarViagem_Click(object sender, EventArgs e)
        {
            Form homeForm = this.ParentForm;

            if (homeForm is Home home)
            {
                home.DesbloquearMenu();
                // Encontra o panelContainer
                Control[] controls = homeForm.Controls.Find("panelContainer", true);

                if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                {
                    pnlPrincipal.Controls.Clear();

                    // Volta para o UC_GestaoViagens
                    UC_GestaoViagens gestaoViagens = new UC_GestaoViagens();
                    gestaoViagens.Dock = DockStyle.Fill;

                    // ======================================================================
                    // 🟢 GREEN MODE AQUI: Garante que ao cancelar a edição, a Gestão de Viagens volte escura
                    // ======================================================================
                    gestaoViagens.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                    // ======================================================================

                    pnlPrincipal.Controls.Add(gestaoViagens);
                }
            }
        }
       

        private void UC_EditarViagem_VisibleChanged(object sender, EventArgs e)
        {
            // Se a tela ficou visível para o usuário, força o Green Mode na hora!
            if (this.Visible)
            {
                this.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
            }
        }

        private void CentralizarBotoes()
        {
            pnlBotoes.Left = (panelEditarViagem.Width - pnlBotoes.Width) / 2;
        }

        private void panelEditarViagem_Resize(object sender, EventArgs e)
        {
            CentralizarBotoes();
        }
    }
}
