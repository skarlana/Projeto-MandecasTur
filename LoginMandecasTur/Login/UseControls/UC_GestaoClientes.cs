using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Login.UseControls
{


    public partial class UC_GestaoClientes : UserControl
    {
        public UC_GestaoClientes()
        {
            InitializeComponent();

            dvgClientes.ReadOnly = false;

            // Estilização Avançada do Grid
            dvgClientes.EnableHeadersVisualStyles = false; // Permite mudar a cor do cabeçalho
            dvgClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
            dvgClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dvgClientes.DefaultCellStyle.Padding = new Padding(15, 10, 15, 10);
            dvgClientes.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 10, 12, 10);
            dvgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            dvgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dvgClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);
            dvgClientes.DefaultCellStyle.SelectionForeColor = Color.Black;

            dvgClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);

            // 4. Muda a fonte do conteúdo da Grid também
            dvgClientes.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dvgClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // Altura das linhas para dar "respiro" ao design
            dvgClientes.RowTemplate.Height = 35;

        }

        private void MudarCoresRecursivo(Control container, bool dark)
        {
            foreach (Control c in container.Controls)
            {
                // Se NÃO for o título (que precisa ser bold), aplica a fonte normal
                if (c.Name != "lbCadastrarCliente")
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
                    if (c is Label && c.Name != "lbCadastrarCliente")
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
                pnlCadastroCliente.BackColor = Color.FromArgb(150, 20, 35, 30);
                lbCadastrarCliente.ForeColor = Color.Gainsboro;

                foreach (Control c in pnlCadastroCliente.Controls)
                {
                    if (c is Label) c.ForeColor = Color.Gainsboro;
                    if (c is TextBox txt)
                    {
                        txt.BackColor = Color.FromArgb(45, 45, 45); // Textbox escura
                        txt.ForeColor = Color.White;
                        txt.BorderStyle = BorderStyle.FixedSingle;
                    }
                }

                //DataGridView 
                dvgClientes.BackgroundColor = Color.FromArgb(20, 35, 30);
                dvgClientes.DefaultCellStyle.BackColor = Color.FromArgb(25, 45, 35);
                dvgClientes.DefaultCellStyle.ForeColor = Color.Gainsboro;

                dvgClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 40);
                dvgClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 30, 25);
                dvgClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dvgClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 30, 25); // Evita o azul no clique do topo

                //Seleção Fluorescente: Um verde mais vivo (tipo o do botão buscar)
                dvgClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127); // Verde SpringGreen
                dvgClientes.DefaultCellStyle.SelectionForeColor = Color.Black; // Texto preto para dar leitura no verde claro

                dvgClientes.EnableHeadersVisualStyles = false; // Necessário para a cor do cabeçalho pegar
            }
            else // MODO CLARO (Igual à imagem gc5.png)
            {
                this.BackColor = Color.FromArgb(239, 239, 239); // O cinza clarinho de fundo da gc5
                MudarCoresRecursivo(this, false);

                // --- PAINEL DE CADASTRO ---
                pnlTitulo.BackColor = Color.FromArgb(232, 232, 232); // Cinza do cabeçalho de cadastro
                pnlCadastroCliente.BackColor = Color.White;

                // Força o Negrito no título que a recursividade tirou
                lbCadastrarCliente.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lbCadastrarCliente.ForeColor = Color.Black;

                // --- DATAGRIDVIEW (Limpeza total do Dark Mode) ---
                dvgClientes.BackgroundColor = Color.White;
                dvgClientes.DefaultCellStyle.BackColor = Color.White;
                dvgClientes.DefaultCellStyle.ForeColor = Color.Black;

                // Remove o fundo verde das linhas alternadas que apareceu na gc6
                dvgClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                // Seleção Fluorescente (Igual à gc5)
                dvgClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);
                dvgClientes.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Cabeçalho - Reset para o cinza original
                dvgClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                dvgClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dvgClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);

            }
        }



        public void AtualizarGrid()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlMostrar = "SELECT id_cliente, nome, cpf, data_nascimento, telefone, email FROM Cliente";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlMostrar, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dvgClientes.DataSource = dt;

                // --- ORDENAÇÃO MANUAL DAS COLUNAS (O segredo está aqui) ---
                // O DisplayIndex define a posição da esquerda para a direita (0 é a primeira)

                if (dvgClientes.Columns.Contains("id_cliente"))
                {
                    dvgClientes.Columns["id_cliente"].HeaderText = "Código";
                    dvgClientes.Columns["id_cliente"].DisplayIndex = 0;

                }

                // 1. Nome Completo
                if (dvgClientes.Columns.Contains("nome"))
                {
                    dvgClientes.Columns["nome"].HeaderText = "Nome";
                    dvgClientes.Columns["nome"].DisplayIndex = 1;
                }

                // 2. CPF
                if (dvgClientes.Columns.Contains("cpf"))
                {
                    dvgClientes.Columns["cpf"].HeaderText = "CPF";
                    dvgClientes.Columns["cpf"].DisplayIndex = 2;
                }

                // 3. Data de Nascimento
                if (dvgClientes.Columns.Contains("data_nascimento"))
                {
                    dvgClientes.Columns["data_nascimento"].HeaderText = "Data de Nascimento";
                    dvgClientes.Columns["data_nascimento"].DisplayIndex = 3;
                }

                // 4. Telefone
                if (dvgClientes.Columns.Contains("telefone"))
                {
                    dvgClientes.Columns["telefone"].HeaderText = "Telefone";
                    dvgClientes.Columns["telefone"].DisplayIndex = 4;
                }

                // 5. E-mail
                if (dvgClientes.Columns.Contains("email"))
                {
                    dvgClientes.Columns["email"].HeaderText = "E-mail";
                    dvgClientes.Columns["email"].DisplayIndex = 5;
                }

                // 6 e 7. Ações (Botões sempre por último e colados um no outro)
                if (dvgClientes.Columns.Contains("btnEditar"))
                    dvgClientes.Columns["btnEditar"].DisplayIndex = 6;

                if (dvgClientes.Columns.Contains("btnExcluir"))
                    dvgClientes.Columns["btnExcluir"].DisplayIndex = 7;

                lblLimparFiltro.Visible = false; // Esconde a label
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
        private void LimparCampos()
        {
            txtNomeGClientes.Clear();
            txtCPFGClientes.Clear();
            txtTelefoneGClientes.Clear();
            txtEmailGClientes.Clear();
            dtpDataNascGclientes.Value = DateTime.Now;
            txtNomeGClientes.Focus();
        }
        private void UC_GestaoClientes_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            dtpDataNascGclientes.Value = DateTime.Now;

            CentralizarBotoes();
        }

        private void dvgClientes_Paint(object sender, PaintEventArgs e)
        {

            try
            {
                // 1. Localiza os índices das colunas
                int col1 = dvgClientes.Columns["btnEditar"].Index;
                int col2 = dvgClientes.Columns["btnExcluir"].Index;

                // 2. Obtém a área (retângulo) ocupada pelos cabeçalhos dessas colunas
                Rectangle r1 = dvgClientes.GetCellDisplayRectangle(col1, -1, true);
                Rectangle r2 = dvgClientes.GetCellDisplayRectangle(col2, -1, true);

                // 3. Cria um retângulo único que junta as duas áreas
                Rectangle areaAcoes = new Rectangle(r1.X, r1.Y, r1.Width + r2.Width, r1.Height);

                // 4. Pinta o fundo do cabeçalho (usando a cor que você já definiu para a grid)
                using (SolidBrush sb = new SolidBrush(dvgClientes.ColumnHeadersDefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(sb, areaAcoes);
                }

                // 5. Desenha o texto "Ações" centralizado nessa nova área
                TextRenderer.DrawText(e.Graphics, "Ações", dvgClientes.ColumnHeadersDefaultCellStyle.Font,
                    areaAcoes, dvgClientes.ColumnHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }
            catch { /* Evita erros caso as colunas ainda não existam no momento da pintura */ }
        }

        private void dvgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Ignora clique no cabeçalho
            if (e.RowIndex < 0) return;

            //2. Descobre qual coluna foi clicada
            string nomeColuna = dvgClientes.Columns[e.ColumnIndex].Name;

            // --- EDITAR ---
            if (nomeColuna == "btnEditar")
            {
                int idCliente = Convert.ToInt32(
                    dvgClientes.Rows[e.RowIndex].Cells["id_cliente"].Value
                );
                Form homeForm = this.ParentForm;

                if (homeForm is Home home)
                {
                    //BLOQUEIA O MENU
                    home.BloquearMenu();

                    Control[] controls = home.Controls.Find("panelContainer", true);

                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        pnlPrincipal.Controls.Clear();

                        UC_EditarCliente editarCliente = new UC_EditarCliente(idCliente);
                        editarCliente.Dock = DockStyle.Fill;
                        editarCliente.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                        pnlPrincipal.Controls.Add(editarCliente);
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
                        dvgClientes.Rows[e.RowIndex].Cells["id_cliente"].Value
                    );

                    Conexao conexao = new Conexao();
                    using (MySqlConnection con = conexao.Conectar())
                    {
                        try
                        {
                            con.Open();
                            string sqlDelete = "DELETE FROM Cliente WHERE id_cliente = @id_cliente";
                            MySqlCommand cmd = new MySqlCommand(sqlDelete, con);
                            cmd.Parameters.AddWithValue("@id_cliente", idSelecionado);
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

        private void RealizarBusca()
        {

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            string textoBusca = txtBuscaGCliente.Text.Trim();
            string sql;
            try
            {
                // SQL que busca em ambas as colunas ao mesmo tempo
                sql = "SELECT id_cliente, nome,cpf,data_nascimento,telefone, email FROM Cliente WHERE " +
                     " nome LIKE @valor OR cpf LIKE @valor";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                // O uso do % antes e depois permite encontrar resultados que contenham o termo
                // Ex: Se digitar "123", encontra o CPF "000.123.000-00"
                cmd.Parameters.AddWithValue("@valor", "%" + textoBusca + "%");

                MySqlDataAdapter adt = new MySqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                adt.Fill(dtt);

                dvgClientes.DataSource = dtt;

                // Se o campo de busca não estiver vazio, mostra a label
                if (!string.IsNullOrWhiteSpace(txtBuscaGCliente.Text))
                {
                    lblLimparFiltro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }

        }

        private void btnBuscarGClientes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscaGCliente.Text))
            {
                MessageBox.Show("Por favor, digite um Nome ou CPF para realizar a busca.", "Campo de Busca Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBuscaGCliente.Focus(); // Deixa o cursor pronto para o usuário digitar
                return; // IMPORTANTE: Para o código aqui e não tenta buscar nada no banco
            }

            RealizarBusca();
        }

        private void btnSalvarGClientes_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNomeGClientes.Text) ||
                string.IsNullOrWhiteSpace(txtEmailGClientes.Text) ||
                string.IsNullOrWhiteSpace(txtTelefoneGClientes.Text) ||
                string.IsNullOrWhiteSpace(txtCPFGClientes.Text))

            {
                MessageBox.Show("Por favor, preencha todos os campos antes de salvar!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeGClientes.Focus();
                return; // Esse 'return' é CRUCIAL. Ele impede que o código abaixo seja executado.
            }

            if (dtpDataNascGclientes.Value > DateTime.Now)
            {
                MessageBox.Show("A data de nascimento não pode ser uma data futura!", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDataNascGclientes.Focus();
                return; // Impede o cadastro
            }

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlInserir = "INSERT INTO Cliente(nome, cpf, data_nascimento, telefone, email)" +
                    "VALUES(@nome, @cpf, @data_nascimento, @telefone, @email)";
                MySqlCommand cmd = new MySqlCommand(sqlInserir, con);
                cmd.Parameters.AddWithValue("@nome", txtNomeGClientes.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPFGClientes.Text);
                cmd.Parameters.AddWithValue("@data_nascimento", dtpDataNascGclientes.Value);
                cmd.Parameters.AddWithValue("@telefone", txtTelefoneGClientes.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailGClientes.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário Cadastrado com Sucesso!!");

                AtualizarGrid();
                LimparCampos();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lblLimparFiltro_Click(object sender, EventArgs e)
        {
            txtBuscaGCliente.Clear();   // Limpa o campo de busca
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

        private void txtBuscaGCliente_TextChanged(object sender, EventArgs e)
        {
            // Se o usuário apagou tudo no campo, volta a mostrar todos os clientes automaticamente
            if (string.IsNullOrWhiteSpace(txtBuscaGCliente.Text))
            {
                AtualizarGrid();
            }
        }

        private void pnlCadastroCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscaGCliente_KeyDown(object sender, KeyEventArgs e)
        {
            //Esse código é para o ENTER funcionar como o clique
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Remove o som do "beep"

                // O 'sender' é o campo que o usuário está usando no momento
                if (sender == txtBuscaGCliente)
                {
                    // Se o campo for o de busca, ele chama a função de buscar
                    RealizarBusca();
                }
                else
                {
                    // Se for qualquer outro campo (Nome, CPF, etc.), ele chama o Salvar
                    btnSalvarGClientes.PerformClick();
                }
            }
        }

        private void CentralizarBotoes()
        {
            pnlBotoes.Left = (pnlCadastroCliente.Width - pnlBotoes.Width) / 2;
        }


        private void pnlCadastroCliente_Resize(object sender, EventArgs e)
        {
            CentralizarBotoes();
        }


        private void btnLimparGClientes_Click(object sender, EventArgs e)
        {
            txtNomeGClientes.Clear();
            txtEmailGClientes.Clear();
            txtTelefoneGClientes.Clear();
            txtCPFGClientes.Clear();
        }
    }

}