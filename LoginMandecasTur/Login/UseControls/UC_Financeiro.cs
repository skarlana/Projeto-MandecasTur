using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Color = System.Drawing.Color;

namespace Login.UseControls
{
    public partial class UC_Financeiro : UserControl
    {
        public UC_Financeiro()
        {
            InitializeComponent();


            ConfigurarEstiloGrid();

            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[] { "Todos", "Pago", "Pendente", "Vencido" });
            cboStatus.SelectedIndex = 0;

            AtualizarGrid();
            AtualizarCards();

            // Licença do QuestPDF (obrigatória e gratuita)
            QuestPDF.Settings.License = LicenseType.Community;
        }

        #region Configurações de Design e UI

        private void ConfigurarEstiloGrid()
        {

            dgv_Financeiro.ReadOnly = false;

            // Estilização Avançada do Grid
            dgv_Financeiro.EnableHeadersVisualStyles = false; // Permite mudar a cor do cabeçalho
            dgv_Financeiro.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
            dgv_Financeiro.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv_Financeiro.DefaultCellStyle.Padding = new Padding(15, 10, 15, 10);
            dgv_Financeiro.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 10, 12, 10);
            dgv_Financeiro.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            dgv_Financeiro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_Financeiro.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);
            dgv_Financeiro.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv_Financeiro.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);

            // 4. Muda a fonte do conteúdo da Grid também
            dgv_Financeiro.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv_Financeiro.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // Altura das linhas para dar "respiro" ao design
            dgv_Financeiro.RowTemplate.Height = 35;

        }


        private void MudarCoresRecursivo(Control container, bool dark)
        {
            foreach (Control c in container.Controls)
            {
                // Força Segoe UI em tudo, menos nos títulos que vamos tratar depois
                if (c.Name != "lblRelatorio_Titulo")
                    c.Font = new Font("Segoe UI", 10);

                if (dark)
                {
                    if (c is TextBox || c is ComboBox || c is DateTimePicker)
                    {
                        c.BackColor = Color.FromArgb(45, 45, 45);
                        c.ForeColor = Color.White;
                    }
                    // RadioButtons e Labels
                    if (c is Label || c is RadioButton) c.ForeColor = Color.Gainsboro;
                }
                else
                {
                    if (c is TextBox || c is ComboBox || c is DateTimePicker)
                    {
                        c.BackColor = Color.White;
                        c.ForeColor = Color.Black;
                    }
                    if (c is Label || c is RadioButton) c.ForeColor = Color.FromArgb(64, 64, 64);
                }

                if (c.HasChildren) MudarCoresRecursivo(c, dark);
            }
        }

        public void AtualizarTema(bool isDark)
        {
            if (isDark)
            {
                this.BackColor = Color.FromArgb(15, 15, 15); // Fundo bem escuro
                MudarCoresRecursivo(this, true);

                // --- MODO ESCURO: CARDS TRANSPARENTES PARA O DESENHARCARD FUNCIONAR ---
                Panel_Entrada.BackColor = Color.Transparent;
                Panel_Pendentes.BackColor = Color.Transparent;
                Panel_Vencidos.BackColor = Color.Transparent;

                // Estilo Neon (Valores)
                lblEntradas.ForeColor = Color.SpringGreen;
                lblPendentes.ForeColor = Color.Gold;
                lblVencidos.ForeColor = Color.Tomato;

                // Painéis Laterais e Busca
                pnlRelatorio.BackColor = Color.FromArgb(150, 20, 35, 30);
                pnlDEBusca.BackColor = Color.FromArgb(150, 20, 35, 30);
                pnlGerar.BackColor = Color.FromArgb(25, 45, 35); // Verde escuro

                //DataGridView 
                dgv_Financeiro.BackgroundColor = Color.FromArgb(20, 35, 30);
                dgv_Financeiro.DefaultCellStyle.BackColor = Color.FromArgb(25, 45, 35);
                dgv_Financeiro.DefaultCellStyle.ForeColor = Color.Gainsboro;

                dgv_Financeiro.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 40);
                dgv_Financeiro.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 30, 25);
                dgv_Financeiro.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_Financeiro.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 30, 25); // Evita o azul no clique do topo

                //Seleção Fluorescente: Um verde mais vivo (tipo o do botão buscar)
                dgv_Financeiro.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127); // Verde SpringGreen
                dgv_Financeiro.DefaultCellStyle.SelectionForeColor = Color.Black; // Texto preto para dar leitura no verde claro

                dgv_Financeiro.EnableHeadersVisualStyles = false; // Necessário para a cor do cabeçalho pegar

            }
            else
            {
                // --- MODO CLARO: VOLTANDO AO ORIGINAL ---
                this.BackColor = Color.FromArgb(239, 239, 239);
                MudarCoresRecursivo(this, false);

                // CRUCIAL: Cards precisam ser Transparent para mostrar o efeito do DesenharCard
                Panel_Entrada.BackColor = Color.Transparent;
                Panel_Pendentes.BackColor = Color.Transparent;
                Panel_Vencidos.BackColor = Color.Transparent;

                // Cores das Labels (Valores)
                lblEntradas.ForeColor = Color.SeaGreen;
                lblPendentes.ForeColor = Color.DarkGoldenrod;
                lblVencidos.ForeColor = Color.Firebrick;

                // Painel "GERAR RELATÓRIO" volta a ser Verde Fluorescente
                pnlGerar.BackColor = Color.FromArgb(45, 255, 145);
                pnlRelatorio.BackColor = Color.White;
                pnlDEBusca.BackColor = Color.White;

                // --- DATAGRIDVIEW (Limpeza total do Dark Mode) ---
                dgv_Financeiro.BackgroundColor = Color.White;
                dgv_Financeiro.DefaultCellStyle.BackColor = Color.White;
                dgv_Financeiro.DefaultCellStyle.ForeColor = Color.Black;

                // Remove o fundo verde das linhas alternadas que apareceu na gc6
                dgv_Financeiro.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                // Seleção Fluorescente (Igual à gc5)
                dgv_Financeiro.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);
                dgv_Financeiro.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Cabeçalho - Reset para o cinza original
                dgv_Financeiro.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                dgv_Financeiro.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgv_Financeiro.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 127);
            }

            // --- AJUSTE GLOBAL DE FONTES (Para não repetir código) ---
            float fontSizeTitulo = 14F;
            float fontSizeValor = 16F;

            lblReceita_Titulo.Font = new Font("Segoe UI", fontSizeTitulo, FontStyle.Bold);
            lblPendente_Titulo.Font = new Font("Segoe UI", fontSizeTitulo, FontStyle.Bold);
            lblVencido_Titulo.Font = new Font("Segoe UI", fontSizeTitulo, FontStyle.Bold);

            lblEntradas.Font = new Font("Segoe UI", fontSizeValor, FontStyle.Bold);
            lblPendentes.Font = new Font("Segoe UI", fontSizeValor, FontStyle.Bold);
            lblVencidos.Font = new Font("Segoe UI", fontSizeValor, FontStyle.Bold);

            // Força os cards a se redesenharem com as novas configurações
            Panel_Entrada.Invalidate();
            Panel_Pendentes.Invalidate();
            Panel_Vencidos.Invalidate();
        }




        private void dgv_Financeiro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgv_Financeiro.Columns[e.ColumnIndex].Name == "status_pagamento" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                string status = e.Value?.ToString() ?? "";
                Color corPilula = Color.Gray;
                Color corTexto = Color.White;

                if (status == "Pago") corPilula = Color.FromArgb(46, 204, 113);
                else if (status == "Pendente") corPilula = Color.FromArgb(241, 196, 15);
                else if (status == "Vencido") corPilula = Color.FromArgb(231, 76, 60);

                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + 5, e.CellBounds.Width - 20, e.CellBounds.Height - 11);
                using (GraphicsPath path = new GraphicsPath())
                {
                    int r = rect.Height;
                    path.AddArc(rect.X, rect.Y, r, r, 90, 180);
                    path.AddArc(rect.Right - r, rect.Y, r, r, 270, 180);
                    path.CloseFigure();
                    g.FillPath(new SolidBrush(corPilula), path);
                }

                TextRenderer.DrawText(g, status, dgv_Financeiro.Font, rect, corTexto, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                e.Handled = true;
            }
        }

        private void DesenharCard(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color corCard = Color.Gray;
            if (pnl.Name.Contains("Entrada")) corCard = Color.FromArgb(46, 204, 113);
            else if (pnl.Name.Contains("Pendentes")) corCard = Color.FromArgb(241, 196, 15);
            else if (pnl.Name.Contains("Vencidos")) corCard = Color.FromArgb(231, 76, 60);

            int radius = 20;
            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                e.Graphics.FillPath(new SolidBrush(Color.FromArgb(40, corCard)), path);
                e.Graphics.DrawPath(new Pen(corCard, 3), path);
            }
        }

        private void ConfigurarColunas()
        {
            if (dgv_Financeiro.Columns.Contains("id_reserva"))
            {
                dgv_Financeiro.Columns["id_reserva"].HeaderText = "Código";
                dgv_Financeiro.Columns["id_reserva"].DisplayIndex = 0;
            }
            if (dgv_Financeiro.Columns.Contains("nome_cliente"))
            {
                dgv_Financeiro.Columns["nome_cliente"].HeaderText = "Cliente";
                dgv_Financeiro.Columns["nome_cliente"].DisplayIndex = 1;
            }
            if (dgv_Financeiro.Columns.Contains("nome_viagem"))
            {
                dgv_Financeiro.Columns["nome_viagem"].HeaderText = "Viagem";
                dgv_Financeiro.Columns["nome_viagem"].DisplayIndex = 2;
            }
            if (dgv_Financeiro.Columns.Contains("total_pago"))
            {
                dgv_Financeiro.Columns["total_pago"].HeaderText = "Total Pago";
                dgv_Financeiro.Columns["total_pago"].DisplayIndex = 3;
                dgv_Financeiro.Columns["total_pago"].DefaultCellStyle.Format = "C2";
            }
            if (dgv_Financeiro.Columns.Contains("valor_viagem"))
            {
                dgv_Financeiro.Columns["valor_viagem"].HeaderText = "Valor da Viagem";
                dgv_Financeiro.Columns["valor_viagem"].DisplayIndex = 4;
                dgv_Financeiro.Columns["valor_viagem"].DefaultCellStyle.Format = "C2";
            }


            if (dgv_Financeiro.Columns.Contains("data_vencimento"))

            //if (dgv_Financeiro.Columns.Contains("data_inicio_pag"))

            {
                dgv_Financeiro.Columns["data_vencimento"].HeaderText = "Vencimento";
                dgv_Financeiro.Columns["data_vencimento"].DisplayIndex = 5;
            }
            if (dgv_Financeiro.Columns.Contains("status_pagamento"))
            {
                dgv_Financeiro.Columns["status_pagamento"].HeaderText = "Status";
                dgv_Financeiro.Columns["status_pagamento"].DisplayIndex = 6;
            }
        }

        #endregion

        #region Lógica de Dados e Buscas

        public void AtualizarGrid()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                // Unificamos o CASE: Regra padrão para o que aparece na tela
                string sql = @"SELECT 
                    r.id_reserva, 
                    c.nome AS nome_cliente, 
                    v.destino AS nome_viagem,
                    COALESCE(r.valor_unitario, 0) AS valor_viagem,
                    (SELECT COALESCE(SUM(f.valor_parcela), 0) FROM financeiro f WHERE f.id_reserva = r.id_reserva) AS total_pago,
                    r.data_vencimento,
                    CASE 
                        WHEN r.data_vencimento < CURDATE() AND (SELECT COALESCE(SUM(f.valor_parcela), 0) FROM financeiro f WHERE f.id_reserva = r.id_reserva) < r.valor_unitario THEN 'Vencido'
                        WHEN r.status_pagamento = 'Em Dia' THEN 'Pago'
                        ELSE 'Pendente'
                    END AS status_pagamento
                   FROM reserva r
                   LEFT JOIN cliente c ON r.id_cliente = c.id_cliente
                   LEFT JOIN viagem v ON r.id_viagem = v.id_viagem
                   ORDER BY r.id_reserva DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_Financeiro.DataSource = dt;
                ConfigurarColunas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados financeiros: " + ex.Message);
            }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }

        public void AtualizarCards()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                string sqlEntradas = "SELECT SUM(valor_parcela) FROM financeiro";
                MySqlCommand cmd1 = new MySqlCommand(sqlEntradas, con);
                object resultadoEntradas = cmd1.ExecuteScalar();
                decimal entradas = resultadoEntradas != DBNull.Value ? Convert.ToDecimal(resultadoEntradas) : 0;
                lblEntradas.Text = entradas.ToString("C2");
                lblEntradas.ForeColor = Color.SeaGreen;

                string sqlPendentes = @"SELECT (SELECT SUM(COALESCE(valor_unitario, 0)) FROM reserva) - (SELECT SUM(COALESCE(valor_parcela, 0)) FROM financeiro)";
                MySqlCommand cmd2 = new MySqlCommand(sqlPendentes, con);
                object resultadoPendentes = cmd2.ExecuteScalar();
                decimal pendentes = resultadoPendentes != DBNull.Value ? Convert.ToDecimal(resultadoPendentes) : 0;
                lblPendentes.Text = pendentes.ToString("C2");
                lblPendentes.ForeColor = Color.DarkGoldenrod;

                // Ajustado para bater com a regra correta de vencimento do banco
                string sqlVencidos = @"SELECT SUM(COALESCE(valor_unitario, 0)) FROM reserva WHERE status_pagamento != 'Em Dia' AND data_vencimento < CURDATE()";
                MySqlCommand cmd3 = new MySqlCommand(sqlVencidos, con);
                object resultadoVencidos = cmd3.ExecuteScalar();
                decimal vencidos = resultadoVencidos != DBNull.Value ? Convert.ToDecimal(resultadoVencidos) : 0;
                lblVencidos.Text = vencidos.ToString("C2");
                lblVencidos.ForeColor = Color.Firebrick;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro nos cards: " + ex.Message);
            }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }

        public void RealizarBusca()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                // 1. Criamos a query. Note que deixei o CASE exatamente igual ao do seu AtualizarGrid()
                string sqlBusca = @"SELECT 
                        r.id_reserva, 
                        c.nome AS nome_cliente, 
                        v.destino AS nome_viagem,
                        COALESCE(r.valor_unitario, 0) AS valor_viagem,
                        (SELECT COALESCE(SUM(f.valor_parcela), 0) FROM financeiro f WHERE f.id_reserva = r.id_reserva) AS total_pago,
                        r.data_vencimento,
                        CASE 
                            WHEN r.data_vencimento < CURDATE() AND (SELECT COALESCE(SUM(f.valor_parcela), 0) FROM financeiro f WHERE f.id_reserva = r.id_reserva) < r.valor_unitario THEN 'Vencido'
                            WHEN r.status_pagamento = 'Em Dia' THEN 'Pago'
                            ELSE 'Pendente'
                        END AS status_final
                   FROM reserva r
                   LEFT JOIN cliente c ON r.id_cliente = c.id_cliente
                   LEFT JOIN viagem v ON r.id_viagem = v.id_viagem
                   WHERE 1=1";

                // 2. FILTRO DE TEXTO: Se o usuário digitou algo
                bool temBuscaTexto = !string.IsNullOrWhiteSpace(txtBuscaFinanceiro.Text) &&
                                     txtBuscaFinanceiro.Text != "Busca por Nome ou Destino";

                if (temBuscaTexto)
                {
                    sqlBusca += " AND (c.nome LIKE @busca OR v.destino LIKE @busca)";
                }

                // 3. 🟢 O SEGREDO: FILTRO DE COMBOBOX VIA HAVING
                // O HAVING filtra direto no apelido 'status_final' gerado pelo CASE. É tiro certeiro!
                if (cboStatus.SelectedIndex != -1 && cboStatus.Text != "Todos")
                {
                    string statusSelecionado = cboStatus.Text.Trim();

                    if (statusSelecionado == "Pago")
                    {
                        sqlBusca += " HAVING status_final = 'Pago'";
                    }
                    else if (statusSelecionado == "Vencido")
                    {
                        sqlBusca += " HAVING status_final = 'Vencido'";
                    }
                    else if (statusSelecionado == "Pendente")
                    {
                        sqlBusca += " HAVING status_final = 'Pendente'";
                    }
                }

                // 4. Ordenação vem por último
                sqlBusca += " ORDER BY r.id_reserva DESC";

                MySqlCommand cmd = new MySqlCommand(sqlBusca, con);

                if (temBuscaTexto)
                {
                    cmd.Parameters.AddWithValue("@busca", "%" + txtBuscaFinanceiro.Text.Trim() + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Clona a tabela para trocar o nome da coluna para o C# não reclamar no ConfigurarColunas
                if (dt.Columns.Contains("status_final"))
                {
                    dt.Columns["status_final"].ColumnName = "status_pagamento";
                }

                dgv_Financeiro.DataSource = dt;
                ConfigurarColunas(); // Mantém seu visual e cores intactos

                if (temBuscaTexto || (cboStatus.SelectedIndex != -1 && cboStatus.Text != "Todos"))
                {
                    lblLimparFiltro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca: " + ex.Message, "Erro de Busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open) con.Close();
            }
        }

        private void CarregarViagens()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=mandecas;uid=root;pwd=;"))
            {
                conn.Open();
                string sql = "SELECT id_viagem, destino FROM viagem";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboViagemRelatorio.DataSource = dt;
                cboViagemRelatorio.DisplayMember = "destino";
                cboViagemRelatorio.ValueMember = "id_viagem";
                cboViagemRelatorio.SelectedIndex = -1;
            }
        }

        private void CarregarClientes()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=mandecas;uid=root;pwd=;"))
            {
                conn.Open();
                string sql = "SELECT id_cliente, nome FROM cliente";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboClienteRelatorio.DataSource = dt;
                cboClienteRelatorio.DisplayMember = "nome";
                cboClienteRelatorio.ValueMember = "id_cliente";
                cboClienteRelatorio.SelectedIndex = -1;
            }
        }

        #endregion

        #region Eventos da Tela

        private void UC_Financeiro_Load(object sender, EventArgs e)
        {
            cboClienteRelatorio.DataSource = null;
            cboClienteRelatorio.Enabled = false;
            CarregarViagens();
            AtualizarGrid();
            AtualizarCards();
            lblVencidos.ForeColor = Color.Black;

            AtualizarEstadoComboCliente();
        }

        private void lblLimparFiltro_Click(object sender, EventArgs e)
        {
            txtBuscaFinanceiro.Clear();
            cboStatus.SelectedIndex = 0;
            AtualizarGrid();
            lblLimparFiltro.Visible = false;
        }

        private void btnBuscarFinanceiro_Click(object sender, EventArgs e) { RealizarBusca(); }
        private void btnAtualizar_Click(object sender, EventArgs e) { AtualizarGrid(); AtualizarCards(); }
        private void dgv_Financeiro_CellContentClick(object sender, DataGridViewCellEventArgs e) { AtualizarGrid(); }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RealizarBusca();
        }
        private void Lis_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstadoComboCliente();
        }

        private void rbReciboCliente_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstadoComboCliente();
        }

        private void rbCustoViagem_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstadoComboCliente();
        }

        private void botaoPadraoMandecas3_Click(object sender, EventArgs e)
        {
            if (rbListaPassageiros.Checked) GerarListaPassageiros();
            else if (rbReciboCliente.Checked) GerarRecibo();
            else if (rbCustoViagem.Checked) GerarCustos();
            else MessageBox.Show("Selecione um tipo de relatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Geração de Relatórios em PDF (QuestPDF)

        private void GerarListaPassageiros()
        {

            if (cboViagemRelatorio.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Viagem para gerar a lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = $"Lista_Passageiros.pdf" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            string caminhoLogo = @"C:\Users\silas.sbsilva\Downloads\Mídia.jpg";

            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = new Conexao().Conectar())
                {
                    conn.Open();
                    string sql = @"SELECT c.nome, c.cpf, c.telefone, r.status_pagamento 
                                   FROM reserva r 
                                   INNER JOIN cliente c ON r.id_cliente = c.id_cliente 
                                   WHERE r.id_viagem = @id_viagem";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id_viagem", cboViagemRelatorio.SelectedValue);
                    new MySqlDataAdapter(cmd).Fill(dt);
                }

                if (dt.Rows.Count == 0) { MessageBox.Show("Nenhum passageiro encontrado nesta viagem."); return; }

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);

                        // Cabeçalho com Logo Arredondada
                        page.Header().Row(row =>
                        {
                            if (File.Exists(caminhoLogo))
                                row.ConstantItem(60)
                                   .Height(60)
                                   .CornerRadius(30) // Aplica o formato de círculo perfeito
                                   .Image(caminhoLogo, ImageScaling.Resize); // Redimensiona para encaixar no círculo

                            row.RelativeItem().PaddingLeft(15).AlignMiddle()
                               .Text($"Lista de Passageiros - {cboViagemRelatorio.Text}")
                               .FontSize(18).SemiBold().FontColor("#2ecc71");
                        });

                        page.Content().PaddingVertical(1, Unit.Centimetre).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3); columns.RelativeColumn(2);
                                columns.RelativeColumn(2); columns.RelativeColumn(2);
                            });

                            table.Header(header =>
                            {
                                header.Cell().Text("Nome Completo").SemiBold(); header.Cell().Text("Documento").SemiBold();
                                header.Cell().Text("Telefone").SemiBold(); header.Cell().Text("Status").SemiBold();
                            });

                            int rowIndex = 0;
                            foreach (DataRow row in dt.Rows)
                            {
                                string corFundo = (rowIndex % 2 == 0) ? Colors.White : Colors.Grey.Lighten4;

                                table.Cell().Background(corFundo).BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row["nome"].ToString());
                                table.Cell().Background(corFundo).BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row["cpf"].ToString());
                                table.Cell().Background(corFundo).BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row["telefone"].ToString());
                                table.Cell().Background(corFundo).BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row["status_pagamento"].ToString());
                                rowIndex++;
                            }
                        });
                    });
                }).GeneratePdf(sfd.FileName);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = sfd.FileName, UseShellExecute = true });
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void GerarRecibo()
        {
            if (cboClienteRelatorio.SelectedIndex == -1 || cboViagemRelatorio.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Cliente e uma Viagem para gerar o recibo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = $"Recibo_{cboClienteRelatorio.Text}.pdf" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            string caminhoLogo = @"C:\Users\silas.sbsilva\Downloads\Mídia.jpg";

            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = new Conexao().Conectar())
                {
                    conn.Open();
                    string sql = @"SELECT c.nome, r.data_vencimento AS data_inicio, f.valor_parcela, f.num_parcela, f.data_pagamento, r.forma_pagamento 
                                   FROM financeiro f 
                                   INNER JOIN reserva r ON f.id_reserva = r.id_reserva 
                                   INNER JOIN cliente c ON r.id_cliente = c.id_cliente 
                                   WHERE r.id_cliente = @id_cliente AND r.id_viagem = @id_viagem 
                                   ORDER BY f.data_pagamento DESC LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id_cliente", cboClienteRelatorio.SelectedValue);
                    cmd.Parameters.AddWithValue("@id_viagem", cboViagemRelatorio.SelectedValue);
                    new MySqlDataAdapter(cmd).Fill(dt);
                }

                if (dt.Rows.Count == 0) { MessageBox.Show("Nenhum pagamento encontrado para este cliente nesta viagem."); return; }

                DataRow d = dt.Rows[0];

                string nome = d["nome"].ToString();
                string numParcela = d["num_parcela"] != DBNull.Value ? d["num_parcela"].ToString() : "-";
                decimal valorParcela = d["valor_parcela"] != DBNull.Value ? Convert.ToDecimal(d["valor_parcela"]) : 0;

                string dataInicio = d["data_inicio"] != DBNull.Value ? Convert.ToDateTime(d["data_inicio"]).ToString("dd/MM/yyyy") : "Não informada";
                string dataPagamento = d["data_pagamento"] != DBNull.Value ? Convert.ToDateTime(d["data_pagamento"]).ToString("dd/MM/yyyy") : "Não informada";
                string formaPagamento = d["forma_pagamento"] != DBNull.Value ? d["forma_pagamento"].ToString() : "Não informada";

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A5);
                        page.Margin(1, Unit.Centimetre);
                        page.Content().Column(col =>
                        {
                            // Logo centralizada e arredondada no topo do recibo
                            if (File.Exists(caminhoLogo))
                                col.Item().AlignCenter()
                                   .Width(70)
                                   .Height(70)
                                   .CornerRadius(35) // Metade do tamanho para virar círculo
                                   .Image(caminhoLogo, ImageScaling.Resize);

                            col.Item().AlignCenter().PaddingTop(5).Text("MANDECASTUR VIAGENS").FontSize(16).Black().FontColor("#2ecc71");
                            col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                            col.Item().PaddingVertical(15).AlignCenter().Text($"RECIBO DE PAGAMENTO - Parcela {numParcela}").FontSize(14).SemiBold();

                            col.Item().Text(txt => { txt.Span("Recebemos de: ").SemiBold(); txt.Span(nome); });
                            col.Item().Text(txt => { txt.Span("A quantia de: ").SemiBold(); txt.Span(valorParcela.ToString("C2")).FontColor(Colors.Green.Darken2).SemiBold(); });
                            col.Item().Text(txt => { txt.Span("Referente à viagem: ").SemiBold(); txt.Span(cboViagemRelatorio.Text); });

                            col.Item().PaddingTop(10).Text($"Data de início: {dataInicio}");
                            col.Item().Text($"Data do pagamento atual: {dataPagamento}");
                            col.Item().Text($"Forma de Pagamento: {formaPagamento}");

                            col.Item().PaddingTop(40).AlignCenter().Text("_________________________________________");
                            col.Item().AlignCenter().Text("Assinatura Mandecastur").FontSize(10).FontColor(Colors.Grey.Darken1);
                        });
                    });
                }).GeneratePdf(sfd.FileName);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = sfd.FileName, UseShellExecute = true });
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void GerarCustos()
        {
            if (cboViagemRelatorio.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Viagem para ver os custos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = $"Custos_Viagem.pdf" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            string caminhoLogo = @"C:\Users\silas.sbsilva\Downloads\Mídia.jpg";

            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = new Conexao().Conectar())
                {
                    conn.Open();
                    string sql = @"
                    SELECT 
                     v.destino, 
                     v.custo_transporte, 
                     v.custo_hospedagem, 
                     COALESCE(SUM(f.gastos_extras), 0) AS gastos_extras
                     FROM viagem v
                     LEFT JOIN reserva r ON r.id_viagem = v.id_viagem
                     LEFT JOIN financeiro f ON f.id_reserva = r.id_reserva
                     WHERE v.id_viagem = @id
                     GROUP BY v.id_viagem";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", cboViagemRelatorio.SelectedValue);
                    new MySqlDataAdapter(cmd).Fill(dt);
                }

                if (dt.Rows.Count == 0) return;

                DataRow d = dt.Rows[0];

                decimal transporte = d["custo_transporte"] != DBNull.Value ? Convert.ToDecimal(d["custo_transporte"]) : 0;
                decimal hospedagem = d["custo_hospedagem"] != DBNull.Value ? Convert.ToDecimal(d["custo_hospedagem"]) : 0;
                decimal extras = d["gastos_extras"] != DBNull.Value ? Convert.ToDecimal(d["gastos_extras"]) : 0;
                decimal total = transporte + hospedagem + extras;

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);

                        // Cabeçalho com Logo Arredondada
                        page.Header().Row(row =>
                        {
                            if (File.Exists(caminhoLogo))
                                row.ConstantItem(60)
                                   .Height(60)
                                   .CornerRadius(30) // Aplica o formato de círculo perfeito
                                   .Image(caminhoLogo, ImageScaling.Resize); // Redimensiona para encaixar no círculo

                            row.RelativeItem().PaddingLeft(15).AlignMiddle()
                               .Text($"Demonstrativo de Custos: {d["destino"]}")
                               .FontSize(18).SemiBold().FontColor("#2ecc71");
                        });

                        page.Content().PaddingVertical(1, Unit.Centimetre).Column(col =>
                        {
                            col.Item().Text($"Custo de Transporte: {transporte:C2}");
                            col.Item().Text($"Custo de Hospedagem: {hospedagem:C2}");
                            col.Item().Text($"Gastos Extras: {extras:C2}");

                            col.Item().PaddingVertical(10).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                            col.Item().Background(Colors.Grey.Lighten4).Padding(10).Text(txt =>
                            {
                                txt.Span("CUSTO TOTAL DA VIAGEM: ").SemiBold();
                                txt.Span(total.ToString("C2")).SemiBold().FontSize(14).FontColor(Colors.Red.Medium);
                            });

                            col.Item().PaddingTop(20).Text("Observações:").SemiBold();
                            col.Item().Text("Nenhuma observação registrada.");

                        });
                    });
                }).GeneratePdf(sfd.FileName);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = sfd.FileName, UseShellExecute = true });
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        #endregion

        private void UC_Financeiro_VisibleChanged(object sender, EventArgs e)
        {
            // Garante que o tema atualizado (Green Mode ou Claro) seja aplicado sem bugs de renderização
            AtualizarTema(ConfigGreenMode.ModoEscuroAtivo);
        }

        private void cboViagemRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Só faz isso se for recibo
            if (!rbReciboCliente.Checked) return;

            if (cboViagemRelatorio.SelectedIndex != -1)
            {
                CarregarClientesDaViagem(Convert.ToInt32(cboViagemRelatorio.SelectedValue));
            }

        }

        private void CarregarClientesDaViagem(int idViagem)
        {
            using (MySqlConnection conn = new Conexao().Conectar())
            {
                conn.Open();

                string sql = @"
            SELECT c.id_cliente, c.nome 
            FROM reserva r
            INNER JOIN cliente c ON r.id_cliente = c.id_cliente
            WHERE r.id_viagem = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idViagem);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboClienteRelatorio.DataSource = dt;
                cboClienteRelatorio.DisplayMember = "nome";
                cboClienteRelatorio.ValueMember = "id_cliente";
                cboClienteRelatorio.SelectedIndex = -1;
            }
        }

        private void AtualizarEstadoComboCliente()
        {
            if (rbReciboCliente.Checked)
            {
                cboClienteRelatorio.Enabled = true;

                // 🔥 SE JÁ TEM VIAGEM SELECIONADA, CARREGA
                if (cboViagemRelatorio.SelectedIndex != -1)
                {
                    CarregarClientesDaViagem(Convert.ToInt32(cboViagemRelatorio.SelectedValue));
                }
            }
            else
            {
                cboClienteRelatorio.Enabled = false;
                cboClienteRelatorio.SelectedIndex = -1;
                cboClienteRelatorio.DataSource = null;
                cboClienteRelatorio.Items.Clear();
            }
        }


    }
}