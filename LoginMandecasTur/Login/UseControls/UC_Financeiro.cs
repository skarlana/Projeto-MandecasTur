using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login.UseControls
{
    public partial class UC_Financeiro : UserControl
    {
        public UC_Financeiro()
        {
            InitializeComponent();
            ConfigurarEstiloGrid();

            AtualizarGrid();
            AtualizarCards();

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






            /*dgv_Financeiro.ReadOnly = true;
            dgv_Financeiro.RowHeadersVisible = false; // Tira o espaço cinza antes do Código

            // --- CORES MODO CLARO ---
            Color verdeClaroZebrado = Color.FromArgb(235, 247, 240);
            Color verdeMandecas = Color.FromArgb(46, 204, 113);
            Color cinzaCabecalho = Color.FromArgb(230, 230, 235);

            dgv_Financeiro.BackgroundColor = Color.White;
            dgv_Financeiro.BorderStyle = BorderStyle.None;
            dgv_Financeiro.AllowUserToAddRows = false;
            dgv_Financeiro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Financeiro.Font = new Font("Segoe UI", 9);

            dgv_Financeiro.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_Financeiro.AlternatingRowsDefaultCellStyle.BackColor = verdeClaroZebrado;
            dgv_Financeiro.RowsDefaultCellStyle.SelectionBackColor = verdeMandecas;
            dgv_Financeiro.RowsDefaultCellStyle.SelectionForeColor = Color.White;


            // Cabeçalho
            dgv_Financeiro.EnableHeadersVisualStyles = false;
            dgv_Financeiro.ColumnHeadersVisible = true;
            dgv_Financeiro.ColumnHeadersDefaultCellStyle.BackColor = cinzaCabecalho;
            dgv_Financeiro.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv_Financeiro.ColumnHeadersHeight = 35;
            dgv_Financeiro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Financeiro.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;*/


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
            // Verifica se é a coluna de status 
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

                // Desenha a pílula
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
            // Use Contains para evitar erro se o nome tiver espaços ou prefixos
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

        #endregion

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

        #region Lógica de Dados da DataGrid

        public void AtualizarGrid()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                // SQL com os apelidos configurados para bater com os IFs abaixo
                string sql = @"SELECT 
                                    r.id_reserva, 
                                    c.nome AS nome_cliente, 
                                    v.destino AS nome_viagem,
                                    COALESCE(r.valor_unitario, 0) AS valor_viagem,
                                    (SELECT COALESCE(SUM(f.valor_parcela), 0) FROM financeiro f WHERE f.id_reserva = r.id_reserva) AS total_pago,
                                    r.data_vencimento,
                                    CASE 
                                        WHEN r.status_pagamento = 'Pago' THEN 'Em Dia'
                                        WHEN r.data_vencimento < CURDATE() AND r.data_vencimento != 'Pago' THEN 'Vencido'
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

                // Alerta se estiver vazio
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhuma reserva encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados financeiros: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
        #endregion

        #region Lógica de dados dos Cards
        public void AtualizarCards()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                // 1. Receita Realizada (Tudo o que já foi pago no financeiro)
                string sqlEntradas = "SELECT SUM(valor_parcela) FROM financeiro";
                MySqlCommand cmd1 = new MySqlCommand(sqlEntradas, con);
                object resultadoEntradas = cmd1.ExecuteScalar();
                decimal entradas = resultadoEntradas != DBNull.Value ? Convert.ToDecimal(resultadoEntradas) : 0;
                lblEntradas.Text = entradas.ToString("C2");
                lblEntradas.ForeColor = Color.SeaGreen;

                // 2. Contas Pendentes (Valor das viagens - Valor pago)
                // Usamos uma subconsulta para pegar a diferença
                string sqlPendentes = @"SELECT 
                        (SELECT SUM(COALESCE(valor_unitario, 0)) FROM reserva) - 
                        (SELECT SUM(COALESCE(valor_parcela, 0)) FROM financeiro)";
                MySqlCommand cmd2 = new MySqlCommand(sqlPendentes, con);
                object resultadoPendentes = cmd2.ExecuteScalar();
                decimal pendentes = resultadoPendentes != DBNull.Value ? Convert.ToDecimal(resultadoPendentes) : 0;
                lblPendentes.Text = pendentes.ToString("C2");
                lblPendentes.ForeColor = Color.DarkGoldenrod;

                // 3. Vencidos (Soma o valor total das reservas que estão com data atrasada e não foram pagas)
                string sqlVencidos = @"SELECT SUM(COALESCE(valor_unitario, 0)) 
                       FROM reserva 
                       WHERE status_pagamento != 'Pago' 
                       AND data_vencimento < CURDATE()";
                MySqlCommand cmd3 = new MySqlCommand(sqlVencidos, con);
                object resultadoVencidos = cmd3.ExecuteScalar();
                decimal vencidos = resultadoVencidos != DBNull.Value ? Convert.ToDecimal(resultadoVencidos) : 0;
                lblVencidos.Text = vencidos.ToString("C2");
                lblVencidos.ForeColor = Color.Firebrick;

            }
            catch (Exception ex)
            {
                // Silencioso ou um aviso simples para não atrapalhar
                Console.WriteLine("Erro nos cards: " + ex.Message);
            }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }
        #endregion

        #region Lógica de Busca

        public void RealizarBusca()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                string sqlBusca = @"SELECT 
                                r.id_reserva, 
                                c.nome AS nome_cliente, 
                                v.destino AS nome_viagem, 
                                r.valor_entrada, 
                                r.data_vencimento, 
                                r.status_pagamento 
                              FROM reserva r
                              INNER JOIN cliente c ON r.id_cliente = c.id_cliente
                              INNER JOIN viagem v ON r.id_viagem = v.id_viagem
                              WHERE 1=1"; // Esse '1=1' é um truque para facilitar a adição de filtros

                // Filtro 1: Status (ComboBox)
                if (cboStatus.SelectedIndex != -1 && cboStatus.Text != "Todos")
                {
                    sqlBusca += " AND r.status_pagamento = @status";
                }

                // Filtro 2: Nome do Cliente ou Viagem (TextBox)
                if (!string.IsNullOrWhiteSpace(txtBuscaFinanceiro.Text))
                {
                    sqlBusca += " AND (c.nome LIKE @busca OR v.destino LIKE @busca)";
                }

                MySqlCommand cmd = new MySqlCommand(sqlBusca, con);

                // Passando os parâmetros com segurança
                cmd.Parameters.AddWithValue("@status", cboStatus.Text);
                cmd.Parameters.AddWithValue("@busca", "%" + txtBuscaFinanceiro.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv_Financeiro.DataSource = dt;

                // Se o campo de busca NÃO estiver vazio OU o combo de status NÃO estiver em "Todos"
                if (!string.IsNullOrWhiteSpace(txtBuscaFinanceiro.Text) || (cboStatus.SelectedIndex != -1 && cboStatus.Text != "Todos"))
                {
                    lblLimparFiltro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open) con.Close();
            }
        }
        #endregion



        private void UC_Financeiro_Load(object sender, EventArgs e)
        {

            CarregarClientes();
            CarregarViagens();

            AtualizarGrid();
            AtualizarCards();
            lblVencidos.ForeColor = Color.Black;


 
        }

        private void lblLimparFiltro_Click(object sender, EventArgs e)
        {
            txtBuscaFinanceiro.Clear();               // Limpa o texto
            cboStatus.SelectedIndex = 0;              // Volta para a primeira opção, que é o "Todos"
            AtualizarGrid();                          // Mostra tudo de novo
            lblLimparFiltro.Visible = false;          // Esconde a label
        }

        private void btnBuscarFinanceiro_Click(object sender, EventArgs e)
        {
            RealizarBusca();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            AtualizarCards();

        }


        private void botaoPadraoMandecas3_Click(object sender, EventArgs e)
        {

            if (rbListaPassageiros.Checked)
            {
                GerarListaPassageiros();
            }
            else if (rbReciboCliente.Checked)
            {
                GerarRecibo();
            }
            else if (rbCustoViagem.Checked)
            {
                GerarCustos();
            }
            else
            {
                MessageBox.Show("Selecione uma opção!");
            }

            if (rbListaPassageiros.Checked)
    {
                GerarListaPassageiros();
            }

        }




        private void Lis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Financeiro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           AtualizarGrid();
        }
        private void GerarCustos()
        {

        }
        private void GerarRecibo()
        {

        }
        private void GerarListaPassageiros()
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=mandecas;uid=root;pwd=;"))
                {
                    conn.Open();

                    string sql = @"
                SELECT 
                    c.nome AS Cliente,
                    c.telefone AS Telefone,
                    v.destino AS Destino,
                    v.data_viagem AS Data
                FROM reserva r
                INNER JOIN cliente c ON r.id_cliente = c.id_cliente
                INNER JOIN viagem v ON r.id_viagem = v.id_viagem
                WHERE
                    (@id_cliente IS NULL OR r.id_cliente = @id_cliente)
                AND (@id_viagem IS NULL OR r.id_viagem = @id_viagem)";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    // ✅ CLIENTE
                    if (cboClienteRelatorio.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@id_cliente", cboClienteRelatorio.SelectedValue);
                    else
                        cmd.Parameters.AddWithValue("@id_cliente", DBNull.Value);

                    // ✅ VIAGEM
                    if (cboViagemRelatorio.SelectedIndex != -1)
                        cmd.Parameters.AddWithValue("@id_viagem", cboViagemRelatorio.SelectedValue);
                    else
                        cmd.Parameters.AddWithValue("@id_viagem", DBNull.Value);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_Financeiro.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            }     }
            



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



        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }









}






    













