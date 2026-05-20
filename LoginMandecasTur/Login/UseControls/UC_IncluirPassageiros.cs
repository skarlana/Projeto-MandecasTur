using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;

namespace Login.UseControls
{
    public partial class UC_IncluirPassageiros : UserControl
    {
        
        public int IdViagemSelecionada { get; set; }
        public UC_IncluirPassageiros()
        {
            InitializeComponent();
           

            dgvListaDePassageiros.ReadOnly = false;

            // Estilização Avançada do Grid
            dgvListaDePassageiros.EnableHeadersVisualStyles = false; // Permite mudar a cor do cabeçalho
            dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
            dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvListaDePassageiros.DefaultCellStyle.Padding = new Padding(15, 10, 15, 10);
            dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 10, 12, 10);
            dgvListaDePassageiros.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            dgvListaDePassageiros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvListaDePassageiros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);
            dgvListaDePassageiros.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);

            // 4. Muda a fonte do conteúdo da Grid também
            dgvListaDePassageiros.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);


            // Altura das linhas para dar "respiro" ao design
            dgvListaDePassageiros.RowTemplate.Height = 35;

        }

        private void MudarCoresRecursivo(Control container, bool dark)
        {
            foreach (Control c in container.Controls)
            {
                // Se NÃO for o título (que precisa ser bold), aplica a fonte normal
                if (c.Name != "lbUCIncluirPassageiros" && c.Name != "lblLista")
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
                    if (c is Label && c.Name != "lbUCIncluirPassageiros" && c.Name != "lblLista")
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
                pnlIncluir.BackColor = Color.FromArgb(25, 45, 35);
                lbUCIncluirPassageiros.ForeColor = Color.Gainsboro;
                lblLista.ForeColor = Color.Gainsboro;

                foreach (Control c in pnlIncluir.Controls)
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
                dgvListaDePassageiros.BackgroundColor = Color.FromArgb(20, 35, 30);
                dgvListaDePassageiros.DefaultCellStyle.BackColor = Color.FromArgb(25, 45, 35);
                dgvListaDePassageiros.DefaultCellStyle.ForeColor = Color.Gainsboro;

                dgvListaDePassageiros.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 40);
                dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 30, 25);
                dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 30, 25); // Evita o azul no clique do topo

                //Seleção Fluorescente: Um verde mais vivo (tipo o do botão buscar)
                dgvListaDePassageiros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127); // Verde SpringGreen
                dgvListaDePassageiros.DefaultCellStyle.SelectionForeColor = Color.Black; // Texto preto para dar leitura no verde claro

                dgvListaDePassageiros.EnableHeadersVisualStyles = false; // Necessário para a cor do cabeçalho pegar
            }
            else // MODO CLARO (Igual à imagem gc5.png)
            {
                this.BackColor = Color.FromArgb(239, 239, 239); // O cinza clarinho de fundo da gc5
                MudarCoresRecursivo(this, false);

                // --- PAINEL DE CADASTRO ---
                pnlIncluir.BackColor = Color.FromArgb(255, 255, 255); // Cinza do cabeçalho de cadastro

                // Força o Negrito no título que a recursividade tirou
                lbUCIncluirPassageiros.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                lbUCIncluirPassageiros.ForeColor = Color.Black;

                lblLista.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                lblLista.ForeColor = Color.Black;

                // --- DATAGRIDVIEW (Limpeza total do Dark Mode) ---
                dgvListaDePassageiros.BackgroundColor = Color.White;
                dgvListaDePassageiros.DefaultCellStyle.BackColor = Color.White;
                dgvListaDePassageiros.DefaultCellStyle.ForeColor = Color.Black;

                // Remove o fundo verde das linhas alternadas que apareceu na gc6
                dgvListaDePassageiros.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                // Seleção Fluorescente (Igual à gc5)
                dgvListaDePassageiros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);
                dgvListaDePassageiros.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Cabeçalho - Reset para o cinza original
                dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);

            }
        }

        public void CarregarInformacoes(int id)
        {
            this.IdViagemSelecionada = id;


           // MOSTRAR O ID NA TELA
            lbIDViagemIncluirPassageiros.Text = id.ToString();


            // Agora executamos as buscas com o ID garantido
            CarregarSugestoesClientes();
            CalcularVagas();
            AtualizarGrid();
        }


        public void AtualizarGrid()
        {

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try
            {
                con.Open();
                string sqlPassageiros = @"SELECT 
                            r.id_reserva AS id_reserva, 
                            c.nome AS nome_cliente, 
                            r.forma_pagamento AS forma_pagamento, 
                            r.valor_entrada AS valor_entrada, 
                            r.qtdd_parcelas AS qtdd_parcelas, 
                            r.valor_unitario AS valor_unitario
                          FROM reserva r
                          INNER JOIN cliente c ON r.id_cliente = c.id_cliente
                          WHERE r.id_viagem = @idViagem";

                MySqlCommand cmd = new MySqlCommand(sqlPassageiros, con);
                cmd.Parameters.AddWithValue("@idViagem", IdViagemSelecionada); // Usa a propriedade que veio da Gestão

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvListaDePassageiros.DataSource = dt;

                OrganizarColunasPassageiros();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }


        private void OrganizarColunasPassageiros()
        {
            // Configuração das colunas para a Lista de Passageiros
            if (dgvListaDePassageiros.Columns.Contains("id_reserva"))
            {
                dgvListaDePassageiros.Columns["id_reserva"].HeaderText = "Código";
                dgvListaDePassageiros.Columns["id_reserva"].DisplayIndex = 0;
            }

            if (dgvListaDePassageiros.Columns.Contains("nome_cliente"))
            {
                dgvListaDePassageiros.Columns["nome_cliente"].HeaderText = "Nome";
                dgvListaDePassageiros.Columns["nome_cliente"].DisplayIndex = 1;
            }

            if (dgvListaDePassageiros.Columns.Contains("forma_pagamento"))
            {
                dgvListaDePassageiros.Columns["forma_pagamento"].HeaderText = "Forma de Pagamento";
                dgvListaDePassageiros.Columns["forma_pagamento"].DisplayIndex = 2;
            }

            if (dgvListaDePassageiros.Columns.Contains("valor_entrada"))
            {
                dgvListaDePassageiros.Columns["valor_entrada"].HeaderText = "Entrada";
                dgvListaDePassageiros.Columns["valor_entrada"].DisplayIndex = 3;
            }

            if (dgvListaDePassageiros.Columns.Contains("qtdd_parcelas"))
            {
                dgvListaDePassageiros.Columns["qtdd_parcelas"].HeaderText = "Parcelas";
                dgvListaDePassageiros.Columns["qtdd_parcelas"].DisplayIndex = 4;
            }

            if (dgvListaDePassageiros.Columns.Contains("valor_unitario"))
            {
                dgvListaDePassageiros.Columns["valor_unitario"].HeaderText = "Valor do Pacote:";
                dgvListaDePassageiros.Columns["valor_unitario"].DisplayIndex = 5;
            }

            if (dgvListaDePassageiros.Columns.Contains("btnExcluir"))
            {
                dgvListaDePassageiros.Columns["btnExcluir"].DisplayIndex = 6;
            }
        }

        private void dgvListaDePassageiros_Paint_1(object sender, PaintEventArgs e)
        {
            try
            {
                // 1. Localiza apenas a coluna da lixeira
                int colExcluir = dgvListaDePassageiros.Columns["btnExcluir"].Index;

                // 2. Obtém a área do cabeçalho dessa coluna específica
                Rectangle areaAcoes = dgvListaDePassageiros.GetCellDisplayRectangle(colExcluir, -1, true);

                // 3. Pinta o fundo do cabeçalho
                using (SolidBrush sb = new SolidBrush(dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(sb, areaAcoes);
                }

                // 4. Desenha o texto "Ações" centralizado
                TextRenderer.DrawText(e.Graphics, "Ações", dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.Font,
                    areaAcoes, dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }
            catch { /* Evita erros se a coluna ainda não existir */ }

        }


        private void dgvListaDePassageiros_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Ignora se clicar no cabeçalho
            if (e.RowIndex < 0) return;

            Form homeForm = this.ParentForm;

            if (dgvListaDePassageiros.Columns[e.ColumnIndex].Name == "btnExcluir")
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.Yes)
                {
                    // Pega o ID da RESERVA (que é a chave primária que vincula o cliente àquela viagem)
                    int idReserva = Convert.ToInt32(dgvListaDePassageiros.Rows[e.RowIndex].Cells["id_reserva"].Value);

                    DeletarPassageiro(idReserva);
                }
            }
        }

        private void DeletarPassageiro(int idReserva)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                // 1. PRIMEIRO: Apaga todos os pagamentos dessa reserva no financeiro
                // Isso evita o erro de Foreign Key que você viu
                string sqlFinanceiro = "DELETE FROM financeiro WHERE id_reserva = @id";
                MySqlCommand cmdFin = new MySqlCommand(sqlFinanceiro, con);
                cmdFin.Parameters.AddWithValue("@id", idReserva);
                cmdFin.ExecuteNonQuery();

                // 2. SEGUNDO: Agora sim, apaga a reserva (o passageiro)
                string sqlReserva = "DELETE FROM reserva WHERE id_reserva = @id";
                MySqlCommand cmdRes = new MySqlCommand(sqlReserva, con);
                cmdRes.Parameters.AddWithValue("@id", idReserva);
                cmdRes.ExecuteNonQuery();

                MessageBox.Show("Passageiro e histórico de pagamentos removidos com sucesso!");


                AtualizarGrid();
                CalcularVagas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }


        public void CalcularVagas()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                string sql = @"SELECT 
                (v.qtdd_vagas - 
                (SELECT COUNT(*) FROM reserva r WHERE r.id_viagem = v.id_viagem)) AS disponiveis
              FROM viagem v
              WHERE v.id_viagem = @idViagem";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idViagem", IdViagemSelecionada);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    lblTituloVagasRestantes.Text = resultado.ToString();

                    int vagas = Convert.ToInt32(resultado);
                    lblTituloVagasRestantes.ForeColor = (vagas <= 0) ? Color.Red : Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular vagas: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        
        }


        private int BuscarIdPorNome(string nome)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            int idEncontrado = 0;

            try
            {
                con.Open();
                string sql = "SELECT id_cliente FROM cliente WHERE nome = @nome LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", nome);

                object resultado = cmd.ExecuteScalar(); // O Scalar é ótimo para pegar um único valor

                if (resultado != null)
                {
                    idEncontrado = Convert.ToInt32(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar cliente: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return idEncontrado;

        }

        // MÉTODO que prepara as sugestões (AutoComplete)
        public void CarregarSugestoesClientes()
        {
            AutoCompleteStringCollection listaNomes = new AutoCompleteStringCollection();

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try
            {
                con.Open();
                string sql = "SELECT nome FROM cliente";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaNomes.Add(reader["nome"].ToString());
                }
                // Aplica a lista ao seu TextBox
                txtClienteIncluirPassageiros.AutoCompleteCustomSource = listaNomes;
            }
            catch (Exception ex) { MessageBox.Show("Erro ao carregar sugestões: " + ex.Message); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void UC_IncluirPassageiros_Load(object sender, EventArgs e)
        {
            // 🟢 O ESCUDO AQUI: Assim que a tela carregar, ela força o Green Mode a rodar!
            this.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);

            txtClienteIncluirPassageiros.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtClienteIncluirPassageiros.AutoCompleteSource = AutoCompleteSource.CustomSource;

            CentralizarBotoes();

            /* CarregarSugestoesClientes();
             CalcularVagas();
             AtualizarGrid();*/
        }

        private void btnIncluirPassageiro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClienteIncluirPassageiros.Text) ||
                string.IsNullOrWhiteSpace(txtFormaDePagamentoIncluirPassageiros.Text) ||
                string.IsNullOrWhiteSpace(txtValorDaEntradaIncluirPassageiros.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroDeParcelasIncluirPassageiros.Text) ||
                string.IsNullOrWhiteSpace(txtValorPacote.Text))

            {
                MessageBox.Show("Por favor, preencha todos os campos antes de salvar!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtClienteIncluirPassageiros.Focus();
                return; // Esse 'return' é CRUCIAL. Ele impede que o código abaixo seja executado.
            }

            // Verifica se o nome existe no Banco
            int idClienteEncontrado = BuscarIdPorNome(txtClienteIncluirPassageiros.Text);

            if (idClienteEncontrado == 0) // Se não encontrou nada
            {
                MessageBox.Show("Este cliente ainda não está cadastrado! Vá até a aba 'Gestão de Clientes' primeiro.",
                                "Cliente Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Para o código aqui e não deixa cadastrar
            }

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                // O INSERT na tabela reserva (que é o que vincula tudo)
                string sqlInsert = @"INSERT INTO reserva 
                            (id_cliente, id_viagem, forma_pagamento, valor_entrada, qtdd_parcelas, status_pagamento, data_inicio_pag, valor_unitario) 
                            VALUES 
                            (@idCliente, @idViagem, @formaPagto, @valorEntrada, @parcelas, 'Pendente', @dataPgto, @valorUnitario)";

                MySqlCommand cmd = new MySqlCommand(sqlInsert, con);

                // Aqui você pega os dados dos campos da sua tela
                cmd.Parameters.AddWithValue("@idCliente", idClienteEncontrado); // ID que você buscou
                cmd.Parameters.AddWithValue("@idViagem", IdViagemSelecionada); // ID da viagem que veio da tela anterior
                cmd.Parameters.AddWithValue("@formaPagto", txtFormaDePagamentoIncluirPassageiros.Text);
                cmd.Parameters.AddWithValue("@parcelas", txtNumeroDeParcelasIncluirPassageiros.Text);
                cmd.Parameters.AddWithValue("@dataPgto", DateTime.Now); // Data de hoje como início

                decimal valor = decimal.Parse(txtValorPacote.Text.Replace("R$", "").Trim());
                cmd.Parameters.AddWithValue("@valorUnitario", valor);

                decimal valorEntrada = decimal.Parse(txtValorDaEntradaIncluirPassageiros.Text.Replace("R$", "").Trim());
                cmd.Parameters.AddWithValue("@valorEntrada", valorEntrada);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Passageiro incluído com sucesso!");

                CalcularVagas();
                AtualizarGrid(); // Atualiza a lista embaixo
                txtClienteIncluirPassageiros.Clear();
                txtFormaDePagamentoIncluirPassageiros.Clear();
                txtValorDaEntradaIncluirPassageiros.Clear();
                txtNumeroDeParcelasIncluirPassageiros.Clear();
                txtValorPacote.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open) con.Close();
            }
        }

        private void btnVoltarIncluirPassageiros_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair?", "Confirmar Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

                        // Cria a tela de Gestão de Viagens para voltar
                        UC_GestaoViagens gestaoViagens = new UC_GestaoViagens();
                        gestaoViagens.Dock = DockStyle.Fill;

                        // ======================================================================
                        // 🟢 AQUI: Força a Gestão de Viagens a voltar respeitando o Green Mode
                        // ======================================================================
                        gestaoViagens.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                        // ======================================================================

                        pnlPrincipal.Controls.Add(gestaoViagens);
                    }
                }
            }

        }


        private void txtClienteIncluirPassageiros_KeyDown_1(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada foi o Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Impede o "beep" do Windows
                e.SuppressKeyPress = true;

                // Chama o clique do seu botão de Incluir
                btnIncluirPassageiro.PerformClick();
            }

        }

        private void UC_IncluirPassageiros_VisibleChanged(object sender, EventArgs e)
        {
            // Se a tela ficou visível para o usuário, força o Green Mode na hora!
            if (this.Visible)
            {
                this.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
            }
        }

        private void CentralizarBotoes()
        {
            pnlBotoes.Left = (pnlIncluir.Width - pnlBotoes.Width) / 2;
        }

        private void pnlIncluir_Resize(object sender, EventArgs e)
        {
            CentralizarBotoes();
        }
    }
}
