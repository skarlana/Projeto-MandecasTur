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
    public partial class UC_DashBoard : UserControl
    {

        bool modoEscuroAtivo = false;
        // Esta variável controla qual viagem aparece (1, 2 ou 3)
        int viagemAtiva = 1;

        // Lista para guardar os dados das viagens
        List<ViagemCarrossel> listaViagens = new List<ViagemCarrossel>();

        int direcao = 1; // 1 para frente, -1 para trás
        int velocidade = 13;

        public UC_DashBoard()
        {
            InitializeComponent();

            // ATIVE ISSO PARA PARAR DE PISCAR:
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            AtualizarTema(false);


            CarregarDadosIniciais();

            pnlBase.BackColor = Color.Transparent;

        }

        #region Desenho dos Cards

        // Método único para arredondar qualquer painel com a cor de borda que você quiser
        private void DesenharBordaArredondada(Control ctrl, Graphics g, int raio, Color corBorda, int espessura)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, ctrl.Width - 1, ctrl.Height - 1);

            path.AddArc(rect.X, rect.Y, raio, raio, 180, 90);
            path.AddArc(rect.Right - raio, rect.Y, raio, raio, 270, 90);
            path.AddArc(rect.Right - raio, rect.Bottom - raio, raio, raio, 0, 90);
            path.AddArc(rect.X, rect.Bottom - raio, raio, raio, 90, 90);
            path.CloseFigure();

            ctrl.Region = new Region(path);

            using (Pen pen = new Pen(corBorda, espessura))
            {
                g.DrawPath(pen, path);
            }
        }



        private void pnlCard_Viagens_Paint(object sender, PaintEventArgs e)
        {
            DesenharBordaArredondada(pnlCard_Viagens, e.Graphics, 40, Color.FromArgb(64, 252, 124), 5);
        }

        private void pnlCard_Aniversario_Paint(object sender, PaintEventArgs e)
        {

            // Se for escuro, borda Verde Neon. Se for claro, borda Cinza ou Verde Escuro.
            Color corBorda = modoEscuroAtivo ? Color.FromArgb(64, 252, 124) : Color.Silver;

            DesenharBordaArredondada(sender as Control, e.Graphics, 30, Color.Silver, 4);

        }

        private void pnlCard_Reservas_Paint(object sender, PaintEventArgs e)
        {

            Color corBorda = modoEscuroAtivo ? Color.FromArgb(64, 252, 124) : Color.Silver;
            DesenharBordaArredondada(sender as Control, e.Graphics, 25, Color.Silver, 4);
        }
        #endregion

        #region Botões

        private void EstilizarBolinha(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btn.Width - 1, btn.Height - 1);
            btn.Region = new Region(path);

            // Cor verde neon (mesma da borda) ou cinza se inativo
            Color corAcesa = Color.FromArgb(64, 252, 124);

            // Lógica para saber qual está ativa (baseada na variável viagemAtiva)
            bool ativa = (btn.Name == "btnB1" && viagemAtiva == 1) ||
                         (btn.Name == "btnB2" && viagemAtiva == 2) ||
                         (btn.Name == "btnB3" && viagemAtiva == 3);

            using (SolidBrush brush = new SolidBrush(ativa ? corAcesa : Color.LightGray))
            {
                g.FillPath(brush, path);
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            viagemAtiva = 1;
            AtualizarCard();

            timer1.Stop(); // Para o tempo
            timer1.Start(); // Recomeça a contar os 5 segundos do zero
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            // Se já estiver na viagem 2, não faz nada
            if (viagemAtiva == 2) return;

            // Define qual será a próxima viagem
            viagemAtiva = 2;

            // Reseta o timer de 5s e inicia a animação de deslize
            timer1.Stop();
            timer1.Start();
            timerSlide.Start();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            viagemAtiva = 3;
            AtualizarCard();

            timer1.Stop(); // Para o tempo
            timer1.Start(); // Recomeça a contar os 5 segundos do zero
        }
        #endregion

        private void MudarCoresRecursivo(Control container, bool dark)
        {

        }

        public void AtualizarTema(bool isDark)
        {
            modoEscuroAtivo = isDark;

            // --- CORES DE FUNDO ---
            this.BackColor = isDark ? Color.FromArgb(15, 15, 15) : Color.White;
            this.BackgroundImage = isDark ? Properties.Resources.img_fundo_escuro : Properties.Resources.img_fundo_claro;

            // --- CORES DOS CARDS ---
            Color corFundoCard = isDark ? Color.FromArgb(25, 45, 35) : Color.Gainsboro;
            //pnlCard_Viagens.BackColor = corFundoCard;
            pnlCard_Viagens.BackColor = corFundoCard;
            pnlCard_Aniversario.BackColor = corFundoCard;
            pnlCard_Reservas.BackColor = corFundoCard;



            // --- TEXTOS (Sem mudar o tamanho ou a fonte, só a cor) ---
            Color corTextoPrincipal = isDark ? Color.Gainsboro : Color.FromArgb(64, 64, 64);
            Color corVerdeNeon = Color.FromArgb(64, 252, 124);

            // Labels de Título e Informação (Mantêm a fonte que você já setou no Design)
            lblDestino.ForeColor = isDark ? Color.Gainsboro : Color.Black;
            lblData.ForeColor = corTextoPrincipal;
            lblVagas.ForeColor = corTextoPrincipal; 

            lbl_proximaV.ForeColor = corTextoPrincipal;
            lbl_calendario.ForeColor = corTextoPrincipal;
            lbl_qtdvagas.ForeColor = corTextoPrincipal;
            lbl_proximoAni.ForeColor = corTextoPrincipal;
            lbl_reservaMes.ForeColor = corTextoPrincipal;

            lbl_aniversariante.ForeColor = corTextoPrincipal;
            lbl_reservas.ForeColor = corTextoPrincipal;

            // --- ÍCONES (Se você já tiver as versões brancas no Resources) ---
            if (isDark)
            {
                pic_onibus.Image = Properties.Resources.icone_onibus_claro;
                pic_calendario.Image = Properties.Resources.icone_calendario_claro;
                pic_vagas.Image = Properties.Resources.icone_pessoas_claro;
                pic_viajante.Image = Properties.Resources.icone_viajante_claro;
                pic_bolo.Image = Properties.Resources.icone_bolo_claro;
                pic_reserva.Image = Properties.Resources.icone_ticket_claro;
            }
            else
            {
                pic_onibus.Image = Properties.Resources.icone_onibus_escuro;
                pic_calendario.Image = Properties.Resources.icone_calendario_escuro;
                pic_vagas.Image = Properties.Resources.icone_pessoas_escuro;
                pic_viajante.Image = Properties.Resources.icone_viajante_escuro;
                pic_bolo.Image = Properties.Resources.icone_bolo_escuro;
                pic_reserva.Image = Properties.Resources.icone_ticket_escuro;
            }

            // Isso aqui força o Zoom em qualquer situação:
            pic_onibus.SizeMode = PictureBoxSizeMode.Zoom;
            pic_calendario.SizeMode = PictureBoxSizeMode.Zoom;
            pic_vagas.SizeMode = PictureBoxSizeMode.Zoom;
            pic_viajante.SizeMode = PictureBoxSizeMode.Zoom;
            pic_bolo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_reserva.SizeMode = PictureBoxSizeMode.Zoom;

            // --- FINALIZAÇÃO ---
            this.Invalidate(); // Redesenha a tela toda
            this.Refresh();    // Garante que os PaintEvents rodem agora
        }



        private void CarregarDadosIniciais()
        {
            CarregarViagensDoBanco();
            CarregarProximoAniversariante();
            CarregarTotalReservasMes();

            if (listaViagens.Count > 0)
            {
                viagemAtiva = 1;
                AtualizarCard();
            }
        }



        private void CarregarViagensDoBanco()
        {
            listaViagens.Clear(); // Limpa a lista para não duplicar
            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();

            try
            {
                conn.Open();
                // Buscamos as 3 viagens mais próximas da data de hoje
                string sql = "SELECT id_viagem, destino, data_viagem, qtdd_vagas FROM Viagem " +
                             "WHERE data_viagem >= CURDATE() ORDER BY data_viagem ASC LIMIT 3";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {


                    listaViagens.Add(new ViagemCarrossel
                    {
                        Id = Convert.ToInt32(rdr["id_viagem"]),
                        Destino = rdr["destino"].ToString().ToUpper(),
                        // Formatando a data para ficar bonita na label
                        Data = Convert.ToDateTime(rdr["data_viagem"]).ToString("dd/MM/yyyy"),
                        Vagas = rdr["qtdd_vagas"].ToString()
                    });
                }



                // Dentro de CarregarViagensDoBanco, após o while(rdr.Read())
                btnB1.Visible = (listaViagens.Count >= 1);
                btnB2.Visible = (listaViagens.Count >= 2);
                btnB3.Visible = (listaViagens.Count >= 3);
                timer1.Enabled = (listaViagens.Count > 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar viagens: " + ex.Message);
            }


            finally
            {
                conn.Close();
            }
        }
        private void AtualizarCard()
        {

            // Só faz a conta se a lista tiver pelo menos uma viagem
            if (listaViagens != null && listaViagens.Count > 0)
            {
                // Garante que o índice não saia do limite se você tiver menos de 3 viagens
                int indice = (viagemAtiva - 1) % listaViagens.Count;
                var viagem = listaViagens[indice];

                lblDestino.Text = viagem.Destino;
                lblData.Text = viagem.Data;
                lblVagas.Text = viagem.Vagas;

                // Redesenha a tela (atualiza as cores das bolinhas)
                this.Refresh();
            }
            else
            {
                // Se a lista estiver vazia, você pode deixar um aviso ou os tracinhos
                lblDestino.Text = "NENHUMA VIAGEM PROGRAMADA";
            }
        }

        private void CarregarProximoAniversariante()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                // SQL Ninja: Ordena por quem faz niver hoje ou depois, ignorando o ano
                string sql = @"SELECT nome, data_nascimento 
                       FROM Cliente 
                       ORDER BY 
                         CASE 
                           WHEN DATE_FORMAT(data_nascimento, '%m%d') >= DATE_FORMAT(CURDATE(), '%m%d') THEN 0 
                           ELSE 1 
                         END, 
                         DATE_FORMAT(data_nascimento, '%m%d') ASC 
                       LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    string nome = rdr["nome"].ToString();
                    DateTime dataNasc = Convert.ToDateTime(rdr["data_nascimento"]);

                    // Exemplo: "Amanda - 13/05" (sem o ano para ficar clean)
                    lbl_aniversariante.Text = $"{nome} - {dataNasc.ToString("dd/MM")}";
                }
                else
                {
                    lbl_aniversariante.Text = "Nenhum cliente cadastrado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar aniversariante: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void CarregarTotalReservasMes()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                // Aqui a mágica: unimos a Reserva com a Viagem para saber 
                // quais reservas pertencem a viagens deste mês e ano.
                string sql = @"SELECT COUNT(r.id_reserva) as total 
                       FROM Reserva r
                       INNER JOIN Viagem v ON r.id_viagem = v.id_viagem
                       WHERE MONTH(v.data_viagem) = MONTH(CURDATE()) 
                       AND YEAR(v.data_viagem) = YEAR(CURDATE())";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    lbl_reservas.Text = $"Total: {resultado.ToString()}";
                }
            }
            catch (Exception ex)
            {
                // Se der erro porque a tabela não existe, a gente ajusta o nome!
                lbl_reservas.Text = "Total: 0";
            }
            finally
            {
                con.Close();
            }
        }


        private void timerSlide_Tick(object sender, EventArgs e)
        {
            // Define a velocidade (rápida fora da tela, suave dentro)
            int vAtual = (pnlCard_Viagens.Left > pnlBase.Width || pnlCard_Viagens.Right < 0) ? 60 : 18;

            pnlCard_Viagens.Left -= vAtual;

            // Quando o card sai totalmente pela esquerda
            if (pnlCard_Viagens.Right <= 0)
            {
                // AQUI É O SEGREDO: Só mudamos o número da viagem quando o card está invisível
                viagemAtiva++;

                // Se passar do total de viagens que o banco trouxe, volta para a primeira
                if (viagemAtiva > listaViagens.Count)
                {
                    viagemAtiva = 1;
                }

                // Agora sim, atualiza os textos com a nova viagemAtiva
                AtualizarCard();

                // Reposiciona o card na direita para ele entrar deslizando
                pnlCard_Viagens.Left = pnlBase.Width;
            }

            // Quando o card volta para a posição inicial (estaciona no centro)
            if (pnlCard_Viagens.Left <= 0 && pnlCard_Viagens.Left > -vAtual)
            {
                pnlCard_Viagens.Left = 0;
                timerSlide.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listaViagens.Count > 1) // Só gira se tiver mais de uma
            {
                // A gente não aumenta o viagemAtiva aqui! 
                // Deixamos o TimerSlide cuidar disso quando o card sumir da tela.
                timerSlide.Start();
            }
        }

        public class ViagemCarrossel
        {
            public int Id { get; set; }
            public string Destino { get; set; }
            public string Data { get; set; }
            public string Vagas { get; set; }
        }

        private void lblVagas_Click(object sender, EventArgs e)
        {

        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            // Define o tema padrão (Claro) para a tela não abrir vazia
           // AtualizarTema(false);
        }

        private void UC_DashBoard_Enter(object sender, EventArgs e)
        {
            CarregarDadosIniciais();
        }

        private void UC_DashBoard_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Refresh(); // Força a tela a se "limpar" e desenhar do zero
            }
        }
    }
}
