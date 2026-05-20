using MySql.Data.MySqlClient;
using System.Globalization;
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Login.UseControls
{
    public partial class UC_Funcionario : UserControl
    {
        public UC_Funcionario()
        {
            InitializeComponent();

            dvgFuncionarios.ReadOnly = false;

            // Estilização Avançada do Grid
            dvgFuncionarios.EnableHeadersVisualStyles = false; // Permite mudar a cor do cabeçalho
            dvgFuncionarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
            dvgFuncionarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dvgFuncionarios.DefaultCellStyle.Padding = new Padding(15, 10, 15, 10);
            dvgFuncionarios.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 10, 12, 10);
            dvgFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            dvgFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgFuncionarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);
            dvgFuncionarios.DefaultCellStyle.SelectionForeColor = Color.Black;

            dvgFuncionarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);

            // 4. Muda a fonte do conteúdo da Grid também
            dvgFuncionarios.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dvgFuncionarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // Altura das linhas para dar "respiro" ao design
            dvgFuncionarios.RowTemplate.Height = 35;

        }

        private void MudarCoresRecursivo(Control container, bool dark)
        {
            foreach (Control c in container.Controls)
            {

                if (dark)
                {
                    if (c is System.Windows.Forms.TextBox txt)
                    {
                        c.BackColor = Color.FromArgb(45, 45, 45);
                        c.ForeColor = Color.White;
                    }
                    if (c is Label) c.ForeColor = Color.Gainsboro;
                }
                else
                {
                    if (c is System.Windows.Forms.TextBox txt || c is DateTimePicker)
                    {
                        c.BackColor = Color.White;
                        c.ForeColor = Color.Black;
                    }
                    // Cor das labels no modo claro
                    if (c is Label)
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
                pnlTitulo.BackColor = Color.FromArgb(25, 45, 35);
                pnlCadastraAcesso.BackColor = Color.FromArgb(150, 20, 35, 30);
                lbCadastraAcesso.ForeColor = Color.Gainsboro;

                foreach (Control c in pnlCadastraAcesso.Controls)
                {
                    if (c is Label) c.ForeColor = Color.Gainsboro;

                    if (c is System.Windows.Forms.TextBox txt)
                    {
                        txt.BackColor = Color.FromArgb(45, 45, 45); // Textbox escura
                        txt.ForeColor = Color.White;
                        txt.BorderStyle = BorderStyle.FixedSingle;
                    }
                }

                //DataGridView 
                dvgFuncionarios.BackgroundColor = Color.FromArgb(20, 35, 30);
                dvgFuncionarios.DefaultCellStyle.BackColor = Color.FromArgb(25, 45, 35);
                dvgFuncionarios.DefaultCellStyle.ForeColor = Color.Gainsboro;

                dvgFuncionarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 40);
                dvgFuncionarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 30, 25);
                dvgFuncionarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dvgFuncionarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 30, 25); // Evita o azul no clique do topo

                //Seleção Fluorescente: Um verde mais vivo (tipo o do botão buscar)
                dvgFuncionarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127); // Verde SpringGreen
                dvgFuncionarios.DefaultCellStyle.SelectionForeColor = Color.Black; // Texto preto para dar leitura no verde claro

                dvgFuncionarios.EnableHeadersVisualStyles = false; // Necessário para a cor do cabeçalho pegar
            }
            else // MODO CLARO (Igual à imagem gc5.png)
            {
                this.BackColor = Color.FromArgb(239, 239, 239); // O cinza clarinho de fundo da gc5
                MudarCoresRecursivo(this, false);

                // --- PAINEL DE CADASTRO ---
                pnlTitulo.BackColor = Color.FromArgb(232, 232, 232); // Cinza do cabeçalho de cadastro
                pnlCadastraAcesso.BackColor = Color.White;

                // Força o Negrito no título que a recursividade tirou
                lbCadastraAcesso.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lbCadastraAcesso.ForeColor = Color.Black;

                // --- DATAGRIDVIEW (Limpeza total do Dark Mode) ---
                dvgFuncionarios.BackgroundColor = Color.White;
                dvgFuncionarios.DefaultCellStyle.BackColor = Color.White;
                dvgFuncionarios.DefaultCellStyle.ForeColor = Color.Black;

                // Remove o fundo verde das linhas alternadas que apareceu na gc6
                dvgFuncionarios.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                // Seleção Fluorescente (Igual à gc5)
                dvgFuncionarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);
                dvgFuncionarios.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Cabeçalho - Reset para o cinza original
                dvgFuncionarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                dvgFuncionarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dvgFuncionarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);

            }
        }




        public void AtualizarGrid()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlMostrar = "SELECT id_funcionario, nome, documento, email, perfil_acesso FROM funcionario";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlMostrar, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dvgFuncionarios.DataSource = dt;

                if (dvgFuncionarios.Columns.Contains("id_funcionario"))
                {
                    dvgFuncionarios.Columns["id_funcionario"].HeaderText = "Código";
                    dvgFuncionarios.Columns["id_funcionario"].DisplayIndex = 0;

                }

                if (dvgFuncionarios.Columns.Contains("nome"))
                {
                    dvgFuncionarios.Columns["nome"].HeaderText = "Nome Completo";
                    dvgFuncionarios.Columns["nome"].DisplayIndex = 1;
                }

                if (dvgFuncionarios.Columns.Contains("documento"))
                {
                    dvgFuncionarios.Columns["documento"].HeaderText = "CPF";
                    dvgFuncionarios.Columns["documento"].DisplayIndex = 2;
                }

                if (dvgFuncionarios.Columns.Contains("email"))
                {
                    dvgFuncionarios.Columns["email"].HeaderText = "Email";
                    dvgFuncionarios.Columns["email"].DisplayIndex = 3;
                }

                if (dvgFuncionarios.Columns.Contains("perfil_acesso"))
                {
                    dvgFuncionarios.Columns["perfil_acesso"].HeaderText = "Perfil de Acesso";
                    dvgFuncionarios.Columns["perfil_acesso"].DisplayIndex = 4;
                }

                if (dvgFuncionarios.Columns.Contains("btnEditar"))
                    dvgFuncionarios.Columns["btnEditar"].DisplayIndex = 5;

                if (dvgFuncionarios.Columns.Contains("btnExcluir"))
                    dvgFuncionarios.Columns["btnExcluir"].DisplayIndex = 6;

                lblLimparFiltro.Visible = false; // Esconde a label
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no sistema.");
            }


        }



        private void dvgFuncionarios_Paint(object sender, PaintEventArgs e)
        {

            try
            {
                // 1. Localiza os índices das colunas
                int col1 = dvgFuncionarios.Columns["btnEditar"].Index;
                int col2 = dvgFuncionarios.Columns["btnExcluir"].Index;

                // 2. Obtém a área (retângulo) ocupada pelos cabeçalhos dessas colunas
                Rectangle r1 = dvgFuncionarios.GetCellDisplayRectangle(col1, -1, true);
                Rectangle r2 = dvgFuncionarios.GetCellDisplayRectangle(col2, -1, true);

                // 3. Cria um retângulo único que junta as duas áreas
                Rectangle areaAcoes = new Rectangle(r1.X, r1.Y, r1.Width + r2.Width, r1.Height);

                // 4. Pinta o fundo do cabeçalho (usando a cor que você já definiu para a grid)
                using (SolidBrush sb = new SolidBrush(dvgFuncionarios.ColumnHeadersDefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(sb, areaAcoes);
                }

                // 5. Desenha o texto "Ações" centralizado nessa nova área
                TextRenderer.DrawText(e.Graphics, "Ações", dvgFuncionarios.ColumnHeadersDefaultCellStyle.Font,
                    areaAcoes, dvgFuncionarios.ColumnHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }
            catch { /* Evita erros caso as colunas ainda não existam no momento da pintura */ }
        }

        private void dvgFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ✅ 1. Ignora clique no cabeçalho
            if (e.RowIndex < 0) return;

            // ✅ 2. Descobre qual coluna foi clicada
            string nomeColuna = dvgFuncionarios.Columns[e.ColumnIndex].Name;

            // --- EDITAR ---
            if (nomeColuna == "btnEditar")
            {
                int idfuncionarios = Convert.ToInt32(
                    dvgFuncionarios.Rows[e.RowIndex].Cells["id_funcionario"].Value
                );

                Form homeForm = this.ParentForm;

                if (homeForm is Home home)
                {

                    home.BloquearMenu();
                    Control[] controls = homeForm.Controls.Find("panelContainer", true);

                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        pnlPrincipal.Controls.Clear();

                        UC_EditarAcesso editarFuncionario = new UC_EditarAcesso(idfuncionarios);
                        editarFuncionario.Dock = DockStyle.Fill;
                        editarFuncionario.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                        pnlPrincipal.Controls.Add(editarFuncionario);
                    }
                }
            }
            // --- EXCLUIR ---
            else if (nomeColuna == "btnExcluir")
            {
                var confirmacao = MessageBox.Show(
                    "Tem certeza que deseja excluir?",
                    "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacao == DialogResult.Yes)
                {
                    int idSelecionado = Convert.ToInt32(
                        dvgFuncionarios.Rows[e.RowIndex].Cells["id_funcionario"].Value
                    );

                    Conexao conexao = new Conexao();
                    using (MySqlConnection con = conexao.Conectar())
                    {
                        try
                        {
                            con.Open();
                            string sqlDelete = "DELETE FROM funcionario WHERE id_funcionario = @id_funcionario";
                            MySqlCommand cmd = new MySqlCommand(sqlDelete, con);
                            cmd.Parameters.AddWithValue("@id_funcionario", idSelecionado);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Cliente excluído com sucesso!");
                            AtualizarGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void UC_Funcionario_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();

            CBPerfilAcesso.Items.Clear();
            CBPerfilAcesso.Items.Add("Administrador");
            CBPerfilAcesso.Items.Add("Padrão");
            CBPerfilAcesso.SelectedIndex = 1; // Deixa "Padrão" selecionado por padrão

            string sqlMostrar = "SELECT * FROM funcionario";

            //vai adaptar as informações do banco e dados para o DGV.
            MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, conn);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            dvgFuncionarios.DataSource = dt;

            AtualizarGrid();

            CentralizarBotoes();

        }


        private void btnSalvarCAcesso_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNomeCAcesso.Text) ||
                string.IsNullOrWhiteSpace(txtEmailCAcesso.Text) ||
                string.IsNullOrWhiteSpace(txtSenhaCAcesso.Text) ||
                string.IsNullOrWhiteSpace(txtCPFCAcesso.Text) ||
                CBPerfilAcesso.SelectedItem == null)

            {
                MessageBox.Show("Por favor, preencha todos os campos antes de salvar!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeCAcesso.Focus();
                return; // Esse 'return' é CRUCIAL. Ele impede que o código abaixo seja executado.
            }

            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();

            try
            {
                conn.Open();

                string sqlInserir = "INSERT INTO funcionario (nome, email, senha, documento, perfil_acesso) VALUES (@nome, @email, @senha, @cpf, @perfil_acesso)";

                MySqlCommand cmd = new MySqlCommand(sqlInserir, conn);

                cmd.Parameters.AddWithValue("@nome", txtNomeCAcesso.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailCAcesso.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenhaCAcesso.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPFCAcesso.Text);
                cmd.Parameters.AddWithValue("@perfil_acesso", CBPerfilAcesso.SelectedItem.ToString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                txtNomeCAcesso.Clear();
                txtEmailCAcesso.Clear();
                txtSenhaCAcesso.Clear();
                txtCPFCAcesso.Clear();
                txtNomeCAcesso.Focus();

                string sqlMostrar = "SELECT * FROM funcionario";

                //vai adaptar as informações do banco e dados para o DGV.
                MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, conn);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                dvgFuncionarios.DataSource = dt;

                AtualizarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no sistema.");
            }
            finally
            {
                conn.Close();
            }

        }

        private string LimparCPF(string cpf)
        {
            // Remove pontos, traços e espaços (caso tenha ficado algum) para podermos fazer a Busca.
            return cpf.Replace(".", "").Replace("-", "").Replace(" ", "");
        }

        private void RealizarBusca()
        {
            string textoBusca = txtBuscaFuncionario.Text.Trim();
            string cpfLimpo = LimparCPF(textoBusca);

            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();

            try
            {
                // Criamos dois parâmetros diferentes (@nome e @documento)
                string sql = "SELECT id_funcionario, nome, documento, email, perfil_acesso FROM funcionario " +
                             "WHERE nome LIKE @nome OR documento LIKE @documento";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                // Parametro 1: Busca pelo nome (com o texto original)
                cmd.Parameters.AddWithValue("@nome", "%" + textoBusca + "%");

                // Parametro 2: Busca pelo documento (com o texto limpo pela função LimparCPF)
                cmd.Parameters.AddWithValue("@documento", "%" + cpfLimpo + "%");

                MySqlDataAdapter adt = new MySqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                adt.Fill(dtt);

                dvgFuncionarios.DataSource = dtt;

                if (!string.IsNullOrWhiteSpace(txtBuscaFuncionario.Text))
                {
                    lblLimparFiltro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no sistema: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscaFuncionario.Text))
            {
                MessageBox.Show("Por favor, digite um Nome ou CPF para realizar a busca.", "Campo de Busca Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBuscaFuncionario.Focus(); // Deixa o cursor pronto para o usuário digitar
                return; // IMPORTANTE: Para o código aqui e não tenta buscar nada no banco
            }

            RealizarBusca();
        }



        private void txtBuscaFuncionario_TextChanged(object sender, EventArgs e)
        {
            // 1. Remove tudo que não for número para processar a máscara
            string textoLimpo = System.Text.RegularExpressions.Regex.Replace(txtBuscaFuncionario.Text, @"[^0-9]", "");
            string resultado = "";

            if (textoLimpo.Length > 3 && textoLimpo.Length <= 11)
            {
                if (textoLimpo.Length <= 3) resultado = textoLimpo;
                else if (textoLimpo.Length <= 6) resultado = textoLimpo.Insert(3, ".");
                else if (textoLimpo.Length <= 9) resultado = textoLimpo.Insert(3, ".").Insert(7, ".");
                else resultado = textoLimpo.Insert(3, ".").Insert(7, ".").Insert(11, "-");

                // 3. Atualiza o texto sem causar um loop infinito de eventos
                txtBuscaFuncionario.Text = resultado;

                // 4. Joga o cursor para o final do texto (se não ele volta pro começo!)
                txtBuscaFuncionario.SelectionStart = txtBuscaFuncionario.Text.Length;

                if (string.IsNullOrWhiteSpace(txtBuscaFuncionario.Text))
                {
                    AtualizarGrid();
                }
            }
        }


        private void btnCancelarCAcesso_Click(object sender, EventArgs e)
        {
            txtNomeCAcesso.Clear();
            txtCPFCAcesso.Clear();
            txtSenhaCAcesso.Clear();
            txtEmailCAcesso.Clear();


        }

        private void lblLimparFiltro_Click(object sender, EventArgs e)
        {
            txtBuscaFuncionario.Clear();   // Limpa o campo de busca
            AtualizarGrid();   // Chama sua função que dá o SELECT sem WHERE
            lblLimparFiltro.Visible = false; // Esconde a label novamente
        }

        private void lblLimparFiltro_MouseEnter(object sender, EventArgs e)
        {
            lblLimparFiltro.Font = new Font(lblLimparFiltro.Font, FontStyle.Underline); // Adiciona sublinhado
        }

        private void lblLimparFiltro_MouseLeave(object sender, EventArgs e)
        {
            lblLimparFiltro.Font = new Font(lblLimparFiltro.Font, FontStyle.Regular);   // Remove sublinhado
        }

        private void txtNomeCAcesso_KeyDown(object sender, KeyEventArgs e)
        {
            //Esse código é para o ENTER funcionar como o clique
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Remove o som do "beep"

                // O 'sender' é o campo que o usuário está usando no momento
                if (sender == txtBuscaFuncionario)
                {
                    // Se o campo for o de busca, ele chama a função de buscar
                    RealizarBusca();
                }
                else
                {
                    // Se for qualquer outro campo (Nome, CPF, etc.), ele chama o Salvar
                    btnSalvarCAcesso.PerformClick();
                }
            }

        }


        private void CentralizarBotoes()
        {
            pnlBotoesCAcesso.Left = (pnlCadastraAcesso.Width - pnlBotoesCAcesso.Width) / 2;
        }

        private void pnlCadastraAcesso_Resize(object sender, EventArgs e)
        {
            CentralizarBotoes();
        }
    }
}
