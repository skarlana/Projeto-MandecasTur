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
using static QuestPDF.Helpers.Colors;

namespace Login.UseControls
{
    public partial class UC_GestaoViagens : UserControl
    {
        public UC_GestaoViagens()
        {
            InitializeComponent();

            dvgViagens.ReadOnly = false;

            // Estilização Avançada do Grid
            dvgViagens.EnableHeadersVisualStyles = false; // Permite mudar a cor do cabeçalho
            dvgViagens.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
            dvgViagens.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dvgViagens.DefaultCellStyle.Padding = new Padding(15, 10, 15, 10);
            dvgViagens.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 10, 12, 10);
            dvgViagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            dvgViagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgViagens.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);
            dvgViagens.DefaultCellStyle.SelectionForeColor = Color.Black;

            dvgViagens.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);

            // 4. Muda a fonte do conteúdo da Grid também
            dvgViagens.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dvgViagens.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // Altura das linhas para dar "respiro" ao design
            dvgViagens.RowTemplate.Height = 35;

        }

        private void MudarCoresRecursivo(Control container, bool dark)
        {
            foreach (Control c in container.Controls)
            {

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
                pnlCadastrarViagens.BackColor = Color.FromArgb(150, 20, 35, 30);
                lbCadastraViagem.ForeColor = Color.Gainsboro;

                foreach (Control c in pnlCadastrarViagens.Controls)
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
                dvgViagens.BackgroundColor = Color.FromArgb(20, 35, 30);
                dvgViagens.DefaultCellStyle.BackColor = Color.FromArgb(25, 45, 35);
                dvgViagens.DefaultCellStyle.ForeColor = Color.Gainsboro;

                dvgViagens.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 40);
                dvgViagens.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 30, 25);
                dvgViagens.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dvgViagens.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 30, 25); // Evita o azul no clique do topo

                //Seleção Fluorescente: Um verde mais vivo (tipo o do botão buscar)
                dvgViagens.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127); // Verde SpringGreen
                dvgViagens.DefaultCellStyle.SelectionForeColor = Color.Black; // Texto preto para dar leitura no verde claro

                dvgViagens.EnableHeadersVisualStyles = false; // Necessário para a cor do cabeçalho pegar
            }
            else // MODO CLARO (Igual à imagem gc5.png)
            {
                this.BackColor = Color.FromArgb(239, 239, 239); // O cinza clarinho de fundo da gc5
                MudarCoresRecursivo(this, false);

                // --- PAINEL DE CADASTRO ---
                pnlTitulo.BackColor = Color.FromArgb(232, 232, 232); // Cinza do cabeçalho de cadastro
                pnlCadastrarViagens.BackColor = Color.White;

                // Força o Negrito no título que a recursividade tirou
                lbCadastraViagem.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lbCadastraViagem.ForeColor = Color.Black;

                // --- DATAGRIDVIEW (Limpeza total do Dark Mode) ---
                dvgViagens.BackgroundColor = Color.White;
                dvgViagens.DefaultCellStyle.BackColor = Color.White;
                dvgViagens.DefaultCellStyle.ForeColor = Color.Black;

                // Remove o fundo verde das linhas alternadas
                dvgViagens.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                // Seleção Fluorescente (Igual à gc5)
                dvgViagens.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);
                dvgViagens.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Cabeçalho - Reset para o cinza original
                dvgViagens.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                dvgViagens.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dvgViagens.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);

            }
        }
        public void AtualizarGrid()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try

            {
                con.Open();
                string sqlMostrar = "SELECT id_viagem, destino, data_viagem, qtdd_vagas, tipo_transporte FROM viagem ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlMostrar, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dvgViagens.DataSource = dt;

                // AJUSTES DOS BOTÕES DE AÇÃO

                // Centralizar
                dvgViagens.Columns["btnIncluir"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dvgViagens.Columns["btnEditar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dvgViagens.Columns["btnExcluir"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Espaçamento interno
                dvgViagens.Columns["btnIncluir"].DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
                dvgViagens.Columns["btnEditar"].DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
                dvgViagens.Columns["btnExcluir"].DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);

                // Largura fixa
                dvgViagens.Columns["btnIncluir"].Width = 40;
                dvgViagens.Columns["btnEditar"].Width = 40;
                dvgViagens.Columns["btnExcluir"].Width = 40;

                // Desativa AutoSize só nessas colunas
                dvgViagens.Columns["btnIncluir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dvgViagens.Columns["btnEditar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dvgViagens.Columns["btnExcluir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // --- ORDENAÇÃO MANUAL DAS COLUNAS (O segredo está aqui) 
                // O DisplayIndex define a posição da esquerda para a direita (0 é a primeira)

                if (dvgViagens.Columns.Contains("id_viagem"))
                {
                    dvgViagens.Columns["id_viagem"].HeaderText = "Código";
                    dvgViagens.Columns["id_viagem"].DisplayIndex = 0;
                }

                // 1. Nome Completo

                if (dvgViagens.Columns.Contains("destino"))
                {
                    dvgViagens.Columns["destino"].HeaderText = "Destino";
                    dvgViagens.Columns["destino"].DisplayIndex = 1;
                }

                // 2. CPF

                if (dvgViagens.Columns.Contains("data_viagem"))
                {
                    dvgViagens.Columns["data_viagem"].HeaderText = "Data";
                    dvgViagens.Columns["data_viagem"].DisplayIndex = 2;
                }

                // 3. Data de Nascimento

                if (dvgViagens.Columns.Contains("qtdd_vagas"))
                {
                    dvgViagens.Columns["qtdd_vagas"].HeaderText = "Vagas";
                    dvgViagens.Columns["qtdd_vagas"].DisplayIndex = 3;
                }

                // 4. Telefone

                if (dvgViagens.Columns.Contains("tipo_transporte"))
                {
                    dvgViagens.Columns["tipo_transporte"].HeaderText = "Transporte";
                    dvgViagens.Columns["tipo_transporte"].DisplayIndex = 4;
                }

                /* if (dvgViagens.Columns.Contains("status"))
                 {
                     dvgViagens.Columns["status"].HeaderText = "Status";
                     dvgViagens.Columns["status"].DisplayIndex = 5;
                 }*/

                // 6 e 7. Ações (Botões sempre por último e colados um no outro)

                if (dvgViagens.Columns.Contains("btnEditar"))
                    dvgViagens.Columns["btnEditar"].DisplayIndex = 6;

                if (dvgViagens.Columns.Contains("btnExcluir"))
                    dvgViagens.Columns["btnExcluir"].DisplayIndex = 7;

                lblLimparFiltro.Visible = false; // Esconde a label

            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
        private void dvgViagens_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // 1. Localiza os índices das colunas
                int col1 = dvgViagens.Columns["btnEditar"].Index;
                int col2 = dvgViagens.Columns["btnIncluir"].Index;
                int col3 = dvgViagens.Columns["btnExcluir"].Index;

                // 2. Obtém a área (retângulo) ocupada pelos cabeçalhos dessas colunas
                Rectangle r1 = dvgViagens.GetCellDisplayRectangle(col1, -1, true);
                Rectangle r2 = dvgViagens.GetCellDisplayRectangle(col2, -1, true);
                Rectangle r3 = dvgViagens.GetCellDisplayRectangle(col3, -1, true);

                // 3. Cria um retângulo único que junta as duas áreas
                // Junta TODAS as colunas

                int xInicio = Math.Min(r1.X, Math.Min(r2.X, r3.X));
                int xFim = Math.Max(r1.Right, Math.Max(r2.Right, r3.Right));

                Rectangle areaAcoes = new Rectangle(
                    xInicio,
                    r1.Y,
                    xFim - xInicio,
                    r1.Height
                );

                // 4. Pinta o fundo do cabeçalho (usando a cor que você já definiu para a grid)
                using (SolidBrush sb = new SolidBrush(dvgViagens.ColumnHeadersDefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(sb, areaAcoes);
                }

                // 5. Desenha o texto "Ações" centralizado nessa nova área

                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                TextRenderer.DrawText(
                    e.Graphics,
                    "Ações",
                    dvgViagens.ColumnHeadersDefaultCellStyle.Font,
                    areaAcoes,
                    dvgViagens.ColumnHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.VerticalCenter
                );
            }
            catch { /* Evita erros caso as colunas ainda não existam no momento da pintura */ }

        }

        private void dvgViagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Ignora se clicar no cabeçalho
            if (e.RowIndex < 0) return;

            Form homeForm = this.ParentForm;

            // --- LÓGICA DO EDITAR ---
            if (dvgViagens.Columns[e.ColumnIndex].Name == "btnEditar")
            {

                if (homeForm is Home home)
                {
                    home.BloquearMenu();
                    Control[] controls = homeForm.Controls.Find("panelContainer", true);
                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        // Pega o ID da viagem da linha clicada
                        int idViagem = Convert.ToInt32(
                            dvgViagens.Rows[e.RowIndex].Cells["id_viagem"].Value
                        );

                        // Abre o UserControl de edição passando o ID
                        UC_EditarViagem editarViagem = new UC_EditarViagem(idViagem);
                        editarViagem.Dock = DockStyle.Fill;

                        // ======================================================================
                        // 🟢 AJUSTADO AQUI: Trocamos o antigo 'Home.IsDarkMode' pela nossa nova classe global
                        // ======================================================================
                        editarViagem.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
                        // ======================================================================

                        pnlPrincipal.Controls.Clear();
                        pnlPrincipal.Controls.Add(editarViagem);
                    }
                }
            }
            // --- LÓGICA DO INCLUIR (Note que agora ele é independente) ---
            else if (dvgViagens.Columns[e.ColumnIndex].Name == "btnIncluir")
            {
                // CORRIGIDO: Tiramos o "Form" daqui para sumir com o erro CS0136
                homeForm = this.ParentForm;

                if (homeForm is Home home)
                {
                    home.BloquearMenu();
                    Control[] controls = homeForm.Controls.Find("panelContainer", true);

                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        // Pega o ID da viagem da linha clicada
                        int idIncluirPassageiro = Convert.ToInt32(
                            dvgViagens.Rows[e.RowIndex].Cells["id_viagem"].Value
                        );

                        pnlPrincipal.Controls.Clear();
                        UC_IncluirPassageiros IncluirPassageiros = new UC_IncluirPassageiros();
                        IncluirPassageiros.Dock = DockStyle.Fill;

                        // Aplica o Green Mode na subtela usando a classe que você acabou de recriar
                        IncluirPassageiros.AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);

                        pnlPrincipal.Controls.Add(IncluirPassageiros);

                        // 4. CHAMA O MÉTODO QUE CARREGA TUDO
                        IncluirPassageiros.CarregarInformacoes(idIncluirPassageiro);
                    }
                }
            }
            // --- LÓGICA DO EXCLUIR ---
            else if (dvgViagens.Columns[e.ColumnIndex].Name == "btnExcluir")
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.Yes)
                {
                    int idSelecionado = Convert.ToInt32(
                    dvgViagens.Rows[e.RowIndex].Cells["id_viagem"].Value
                     );
                    Conexao conexao = new Conexao();
                    using (MySqlConnection con = conexao.Conectar())
                    {
                        try
                        {
                            con.Open();
                            string sqlDelete = "DELETE FROM Viagem WHERE id_viagem = @id_viagem";
                            MySqlCommand cmd = new MySqlCommand(sqlDelete, con);
                            cmd.Parameters.AddWithValue("@id_viagem", idSelecionado);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Viagem excluído com sucesso!");
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
            string textoBusca = txtBuscaGViagens.Text.Trim();
            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();
            try
            {
                // Criamos dois parâmetros diferentes (@nome e @documento)
                string sql = "SELECT id_viagem, destino, data_viagem, qtdd_vagas, tipo_transporte FROM viagem " +
                             "WHERE destino LIKE @valor OR id_viagem LIKE @valor";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                // Parametro 1: Busca pelo nome (com o texto original)
                cmd.Parameters.AddWithValue("@valor", "%" + textoBusca + "%");
                // Parametro 2: Busca pelo documento (com o texto limpo pela função LimparCPF)

                MySqlDataAdapter adt = new MySqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                adt.Fill(dtt);
                dvgViagens.DataSource = dtt;

                if (!string.IsNullOrWhiteSpace(txtBuscaGViagens.Text))
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
        private void txtBuscaGViagens_KeyDown(object sender, KeyEventArgs e)
        {
            //Esse código é para o ENTER funcionar como o clique
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Remove o som do "beep"
                // O 'sender' é o campo que o usuário está usando no momento
                if (sender == txtBuscaGViagens)
                {
                    // Se o campo for o de busca, ele chama a função de buscar
                    RealizarBusca();
                }
                else
                {
                    // Se for qualquer outro campo (Nome, CPF, etc.), ele chama o Salvar
                    btnSalvar.PerformClick();
                }
            }
        }

        private void lblLimparFiltro_Click(object sender, EventArgs e)
        {
            txtBuscaGViagens.Clear();   // Limpa o campo de busca
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

        private void UC_GestaoViagens_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            DTPDataCViagem.Value = DateTime.Now;

            CentralizarBotoes();
        }
        private void btnLimparGViagens_Click(object sender, EventArgs e)
        {
            txtDestinoViagens.Clear(); txtTransporteCViagens.Clear(); txtQTDVagaCViagens.Clear();
            txtCustoTransporteCViagem.Clear(); txtCustoHospedagemCViagem.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscaGViagens.Text))
            {
                MessageBox.Show("Por favor, digite um Destino ou Status para realizar a busca.", "Campo de Busca Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaGViagens.Focus(); // Deixa o cursor pronto para o usuário digitar
                return; // IMPORTANTE: Para o código aqui e não tenta buscar nada no banco
            }
            RealizarBusca();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDestinoViagens.Text) ||
               string.IsNullOrWhiteSpace(txtTransporteCViagens.Text) ||
               string.IsNullOrWhiteSpace(txtQTDVagaCViagens.Text))


            {
                MessageBox.Show("Por favor, preencha todos os campos antes de salvar!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDestinoViagens.Focus();
                return; // Esse 'return' é CRUCIAL. Ele impede que o código abaixo seja executado.
            }

            Conexao conexao = new Conexao();

            MySqlConnection conn = conexao.Conectar();

            try
            {
                conn.Open();
                string sqlInserir = "INSERT INTO Viagem (destino, data_viagem, qtdd_vagas, tipo_transporte, custo_transporte," +
                    " custo_hospedagem) VALUES (@destino, @data_viagem, @qtdd_vagas, @tipo_transporte, @custo_transporte, " +
                    "@custo_hospedagem)";

                if (!decimal.TryParse(txtCustoTransporteCViagem.Text, out decimal custoTransporte) ||
                    !decimal.TryParse(txtCustoHospedagemCViagem.Text, out decimal custoHospedagem))
                {
                    MessageBox.Show("Digite valores numéricos válidos para os custos.");
                    return;
                }

                if (!int.TryParse(txtQTDVagaCViagens.Text, out int vagas))
                {
                    MessageBox.Show("Quantidade de vagas inválida.");
                    return;
                }

                MySqlCommand cmd = new MySqlCommand(sqlInserir, conn);

                cmd.Parameters.AddWithValue("@destino", txtDestinoViagens.Text);
                cmd.Parameters.AddWithValue("@data_viagem", DTPDataCViagem.Value);
                cmd.Parameters.AddWithValue("@qtdd_vagas", vagas);
                cmd.Parameters.AddWithValue("@tipo_transporte", txtTransporteCViagens.Text);
                cmd.Parameters.AddWithValue("@custo_transporte", custoTransporte);
                cmd.Parameters.AddWithValue("@custo_hospedagem", custoHospedagem);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Viagem cadastrada com sucesso!");

                txtDestinoViagens.Clear();
                txtTransporteCViagens.Clear();
                txtQTDVagaCViagens.Clear();

                string sqlMostrar = @"SELECT id_viagem, destino, data_viagem, qtdd_vagas, tipo_transporte, 
                    CASE 
                        WHEN data_viagem >= CURDATE() THEN 'Programada' 
                        ELSE 'Concluída' 
                    END AS status 
                    FROM Viagem";

                //vai adaptar as informações do banco e dados para o DGV.

                MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dvgViagens.DataSource = dt;
                AtualizarGrid();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro no sistema." + ex.ToString());

            }
            finally
            {
                conn.Close();
            }

        }

        private void CentralizarBotoes()
        {
            pnlBotoes.Left = (pnlCadastrarViagens.Width - pnlBotoes.Width) / 2;
        }


        private void pnlCadastrarViagens_Resize(object sender, EventArgs e)
        {
            CentralizarBotoes();
        }

        private void lbCustoTransporteCViagem_Click(object sender, EventArgs e)
        {

        }
    }
}


