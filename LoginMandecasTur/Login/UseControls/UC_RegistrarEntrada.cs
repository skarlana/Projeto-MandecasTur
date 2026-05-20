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
    public partial class UC_RegistrarEntrada : UserControl
    {
        public UC_RegistrarEntrada()
        {
            InitializeComponent();
            CarregarViagens();

        }

        private void MudarCoresRecursivo(Control container, bool dark)
        {
            foreach (Control c in container.Controls)
            {
                // Se NÃO for o título (que precisa ser bold), aplica a fonte normal
                if (c.Name != "lblRE" && c.Name != "lblInformativo")
                {
                    c.Font = new Font("Segoe UI", 10);
                }

                if (dark)
                {
                    if (c is TextBox || c is ComboBox)
                    {
                        c.BackColor = Color.FromArgb(45, 45, 45);
                        c.ForeColor = Color.White;
                    }

                    if (c is DateTimePicker dtp)
                    {
                        dtp.BackColor = Color.FromArgb(45, 45, 45);
                        dtp.ForeColor = Color.White;
                        dtp.CalendarMonthBackground = Color.FromArgb(45, 45, 45);
                        dtp.CalendarForeColor = Color.White;
                        dtp.CalendarTitleBackColor = Color.FromArgb(30, 30, 30);
                        dtp.CalendarTitleForeColor = Color.White;
                    }



                    if (c is Label) c.ForeColor = Color.Gainsboro;
                }
                else
                {
                    if (c is TextBox || c is DateTimePicker || c is ComboBox)
                    {
                        c.BackColor = Color.White;
                        c.ForeColor = Color.Black;
                    }
                    // Cor das labels no modo claro
                    if (c is Label && c.Name != "lblRE" && c.Name != "lblInformativo")
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
                this.BackColor = Color.Transparent;
                MudarCoresRecursivo(this, isDark);

                // 2. Painel de Cadastro (Efeito Transparente)
                panelRE.BackColor = Color.FromArgb(150, 20, 35, 30);
                pnlInformativo.BackColor = Color.FromArgb(150, 20, 35, 30);
                pnlBotoes.BackColor = Color.FromArgb(150, 20, 35, 30);
                lblRE.ForeColor = Color.Gainsboro;
                lblInformativo.ForeColor = Color.Gainsboro;

                foreach (Control c in panelRE.Controls)
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

                panelRE.BackColor = Color.White;
                pnlInformativo.BackColor = Color.White;
                pnlBotoes.BackColor = Color.White;


                // Força o Negrito no título que a recursividade tirou
                lblRE.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                lblRE.ForeColor = Color.Black;

                lblInformativo.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                lblInformativo.ForeColor = Color.Black;

            }
        }






        private void CarregarViagens()
        {
            // 1. Usa a classe de conexão que vocês criaram (igual à img1)
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                // 2. Sua query com o CONCAT para não confundir as datas
                string query = "SELECT id_viagem, CONCAT(destino, ' - ', DATE_FORMAT(data_viagem, '%d/%m/%Y')) AS info_viagem FROM viagem ORDER BY data_viagem ASC";

                // 3. Usa o DataAdapter com a sua conexão 'con'
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // 4. Configura o ComboBox
                cbViagens.DataSource = dt;
                cbViagens.DisplayMember = "info_viagem"; // O que aparece para a Amanda
                cbViagens.ValueMember = "id_viagem";     // O ID que fica escondido

                cbViagens.SelectedIndex = -1; // Deixa o campo em branco ao abrir
                cbPassageiros.DataSource = null; // Garante que a lista de clientes comece vazia
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar viagens: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbViagens_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Verifica se existe um valor selecionado para não dar erro ao carregar a tela
            if (cbViagens.SelectedValue != null && int.TryParse(cbViagens.SelectedValue.ToString(), out int idViagem))
            {
                CarregarClientesDaViagem(idViagem);
            }

            AtualizarInfoParcela();


        }

        private void CarregarClientesDaViagem(int idViagem)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                // SQL que filtra os clientes pela tabela de reserva

                string sql = @"SELECT c.id_cliente, c.nome 
                       FROM cliente c 
                       INNER JOIN reserva r ON c.id_cliente = r.id_cliente 
                       WHERE r.id_viagem = " + idViagem +
                       " ORDER BY c.nome ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbPassageiros.DataSource = dt;
                cbPassageiros.DisplayMember = "nome";      // O que a Amanda vê
                cbPassageiros.ValueMember = "id_cliente";  // O que o código salva

                cbPassageiros.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void AtualizarInfoParcela()
        {

            // Texto padrão 
            string textoPadrao = "Selecione a viagem e o cliente para gerenciar os pagamentos";

            // 1. Se não selecionou a viagem ou o cliente ainda:
            if (cbViagens.SelectedIndex == -1 || cbPassageiros.SelectedIndex == -1)
            {
                lblInformativo.Text = textoPadrao;
                lblInformativo.ForeColor = Color.Black;
                return;
            }

            // Só faz a conta se a viagem e o cliente estiverem selecionados
            if (cbViagens.SelectedValue != null && cbPassageiros.SelectedValue != null)
            {
                Conexao conexao = new Conexao();
                MySqlConnection conn = conexao.Conectar();

                try
                {
                    conn.Open();
                    // 1. Primeiro, pegamos o ID da Reserva e a Qtd Total de Parcelas
                    string sqlReserva = "SELECT id_reserva, qtdd_parcelas FROM reserva WHERE id_viagem = @idV AND id_cliente = @idC";
                    MySqlCommand cmdReserva = new MySqlCommand(sqlReserva, conn);
                    cmdReserva.Parameters.AddWithValue("@idV", cbViagens.SelectedValue);
                    cmdReserva.Parameters.AddWithValue("@idC", cbPassageiros.SelectedValue);

                    MySqlDataReader reader = cmdReserva.ExecuteReader();

                    if (reader.Read())
                    {
                        int idReserva = Convert.ToInt32(reader["id_reserva"]);
                        int totalParcelas = Convert.ToInt32(reader["qtdd_parcelas"]);
                        reader.Close(); // Fecha o reader para fazer a próxima consulta

                        // 2. Agora contamos quantos pagamentos já existem para essa reserva
                        string sqlContagem = "SELECT COUNT(*) FROM financeiro WHERE id_reserva = @idR";
                        MySqlCommand cmdCount = new MySqlCommand(sqlContagem, conn);
                        cmdCount.Parameters.AddWithValue("@idR", idReserva);

                        int jaPagos = Convert.ToInt32(cmdCount.ExecuteScalar());
                        int proximaParcela = jaPagos + 1;

                        // 3. Atualiza a label 
                        lblInformativo.Text = $"Lançando pagamento para: {cbViagens.Text} (Parcela {proximaParcela}/{totalParcelas})";
                        lblInformativo.ForeColor = Color.DarkGreen;
                    }

                    else
                    {
                        lblInformativo.Text = "Nenhuma reserva encontrada para este cliente nesta viagem.";
                        lblInformativo.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao calcular parcelas: " + ex.Message);
                }
                finally { conn.Close(); }
            }

        }

        private void btnRegistrarReservas_Click(object sender, EventArgs e)
        {
            // Validação básica: não deixa registrar sem valor ou sem cliente
            if (cbPassageiros.SelectedValue == null || string.IsNullOrEmpty(txtValorParcela.Text))
            {
                MessageBox.Show("Por favor, selecione um cliente e informe o valor do pagamento.");
                return;
            }

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                // O SQL de inserção
                // id_reserva: pegamos da tabela reserva usando o cliente e viagem selecionados
                // valor_parcela: o que está no txt
                // data_pagamento: a data atual do sistema
                string sql = @"INSERT INTO financeiro (id_reserva, valor_parcela, data_pagamento) 
                       SELECT id_reserva, @valor, @data 
                       FROM reserva 
                       WHERE id_cliente = @idCliente AND id_viagem = @idViagem";

                string sqlUpdateReserva = @"UPDATE reserva 
                        SET data_vencimento = @novaData,
                        status_pagamento = 'Em Dia'
                        WHERE id_cliente = @idCliente AND id_viagem = @idViagem";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@valor", decimal.Parse(txtValorParcela.Text));
                cmd.Parameters.AddWithValue("@data", DateTime.Now);
                cmd.Parameters.AddWithValue("@idCliente", cbPassageiros.SelectedValue);
                cmd.Parameters.AddWithValue("@idViagem", cbViagens.SelectedValue);


                cmd.ExecuteNonQuery();

                // Executa o Update da Reserva(Vencimento)
                MySqlCommand cmdRes = new MySqlCommand(sqlUpdateReserva, con);
                cmdRes.Parameters.AddWithValue("@idCliente", cbPassageiros.SelectedValue);
                cmdRes.Parameters.AddWithValue("@idViagem", cbViagens.SelectedValue);
                cmdRes.Parameters.AddWithValue("@novaData", dtpVencimento.Value);
                cmdRes.ExecuteNonQuery();

                MessageBox.Show("Pagamento registrado e vencimento atualizado");

                // Limpa o campo de valor para o próximo lançamento

                // Limpeza dos campos
                txtValorParcela.Clear();
                if (txtFormaPgto != null) txtFormaPgto.Clear(); // Evita erro se o campo não existir
                cbViagens.SelectedIndex = -1;
                cbPassageiros.SelectedIndex = -1;

                AtualizarInfoParcela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar pagamento: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnLimparReservas_Click(object sender, EventArgs e)
        {
            txtValorParcela.Clear();
            txtFormaPgto.Clear();
            cbViagens.SelectedIndex = -1;
            cbPassageiros.SelectedIndex = -1;

            AtualizarInfoParcela();

        }


        private void cbPassageiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarInfoParcela();
        }

        private void UC_RegistrarEntrada_Load(object sender, EventArgs e)
        {
            dtpVencimento.Value = DateTime.Now.AddMonths(1);
            CentralizarBotoes();
        }

        private void CentralizarBotoes()
        {
            pnlBotoes.Left = (panelRE.Width - pnlBotoes.Width) / 2;
        }

        private void panelRE_Resize(object sender, EventArgs e)
        {
            CentralizarBotoes();
        }
    }
}
