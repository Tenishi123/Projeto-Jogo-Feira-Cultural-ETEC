using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetoJogo1.Properties;

namespace projetoJogo1
{
    public partial class FormJogo : Form
    {
        int Score = 0;
        SaoPaulo saoPaulo = new SaoPaulo();
        Bahia bahia = new Bahia();
        Caribe caribe = new Caribe();
        USA_Leste usa_leste = new USA_Leste();
        USA_Oeste usa_oeste = new USA_Oeste();
        Japao japao = new Japao();
        China china = new China();
        Tailandia tailandia = new Tailandia();
        Australia australia = new Australia();
        UnitedKingdom unitedKingdom = new UnitedKingdom();
        AfricaCentral africaCentral = new AfricaCentral();
        AfricaSul africaSul = new AfricaSul();
        India india = new India();
        EuropaOeste europaOeste = new EuropaOeste();
        EuropaLeste europaLeste = new EuropaLeste();
        Usuario usuario = new Usuario();
        Random rand = new Random();
        int erros = 0;


        public FormJogo()
        {
            InitializeComponent();
        }

        /***
        * minhas funções
         ***/

        private void caminhoErrado()
        {

            int numRand = rand.Next(1,4);

            if (numRand == 1) {

                MessageBox.Show("Caminho errado");
                Score -= 10;
            
            }else if(numRand == 2)
            {

                MessageBox.Show("Escolha o caminho certo !!!");
                Score -= 10;

            }else if (numRand == 3)
            {

                MessageBox.Show("Escolha outro caminho");

            }
            else
            {

                MessageBox.Show("Error");

            }

            erros++;

            if(erros == 4 || erros == 7)
            {

                if(usuario.setFase() == 1)
                {

                    MessageBox.Show("Clique nos pontos até chegar no computador");

                }else if(usuario.setFase() == 2)
                {

                    MessageBox.Show("Clique nos pontos até chegar no servidor 2 e depois para o computador");

                }

            }else if(erros == 10)
            {

                MessageBox.Show("Game over");
                Application.Exit();

            }

        }

        private void reset()// reseta todos os pontos para proxima fase
        {

            saoPaulo = new SaoPaulo();
            bahia = new Bahia();
            caribe = new Caribe();
            usa_leste = new USA_Leste();
            usa_oeste = new USA_Oeste();
            japao = new Japao();
            china = new China();
            tailandia = new Tailandia();
            australia = new Australia();
            unitedKingdom = new UnitedKingdom();
            africaCentral = new AfricaCentral();
            africaSul = new AfricaSul();
            india = new India();

            saoPaulo.getCondicao(true);
            bahia.getCondicao(true);
            caribe.getCondicao(true);
            usa_leste.getCondicao(true);
            usa_oeste.getCondicao(true);
            japao.getCondicao(true);
            china.getCondicao(true);
            tailandia.getCondicao(true);
            australia.getCondicao(true);
            unitedKingdom.getCondicao(true);
            africaCentral.getCondicao(true);
            africaSul.getCondicao(true);
            india.getCondicao(true);
            europaLeste.getCondicao(true);
            europaOeste.getCondicao(true);

            saoPaulo.get_pct(pctSaoPaulo);
            bahia.get_pct(pctBahia);
            caribe.get_pct(pctCaribe);
            usa_leste.get_pct(pct_USA_Leste);
            usa_oeste.get_pct(pct_USA_Oeste);
            japao.get_pct(pctJapao);
            china.get_pct(pctChina);
            tailandia.get_pct(pctTailandia);
            australia.get_pct(pctAustralia);
            unitedKingdom.get_pct(pct_UnitedKingdom);
            africaCentral.get_pct(pctAfricaCenter);
            africaSul.get_pct(pctAfricaSul);
            india.get_pct(pctIndia);
            europaLeste.get_pct(pctEuropaLeste);
            europaOeste.get_pct(pctEuropaOeste);

            saoPaulo.mudarPonto();
            bahia.mudarPonto();
            caribe.mudarPonto();
            usa_leste.mudarPonto();
            usa_oeste.mudarPonto();
            japao.mudarPonto();
            china.mudarPonto();
            tailandia.mudarPonto();
            australia.mudarPonto();
            unitedKingdom.mudarPonto();
            africaCentral.mudarPonto();
            africaSul.mudarPonto();
            india.mudarPonto();
            europaOeste.mudarPonto();
            europaLeste.mudarPonto();

        }

        private void LoadFase()
        {

            if(usuario.setFase() == 1)
            {

                pctUsuario.Visible = true;
                pctUsuario1.Visible = false;
                pctServidorPrincipal.Visible = true;
                pctServidorPrincipal1.Visible = false;
                pctServidorPrincipal.Visible = false;
                pctServidorSecundario_1.Visible = false;

                reset();

            }
            else if(usuario.setFase() == 2)
            {

                pctUsuario.Visible = true;
                pctUsuario1.Visible = false;
                pctServidorPrincipal.Visible = false;
                pctServidorPrincipal1.Visible = true;
                pctServidorSecundario_1.Visible = true;

                reset();

            }

        }

        /***
        * minhas funções
        ***/
        private void PctBahia_Click(object sender, EventArgs e)
        {

            if (usuario.setFase() == 1)
            {
                if (saoPaulo.setCondicao())
                {
                    bahia.mudarPonto();
                    Score += 10;
                }
                else
                {
                    caminhoErrado();
                }
            }else if(usuario.setFase() == 2)
            {

                caminhoErrado();

            }

        }

        private void FormJogo_Load(object sender, EventArgs e)
        {

            pctFundo.Height = this.Height;
            pctFundo.Width = this.Width;//Ajuste de tamanho da imagem com a tela

            usuario.getFase(1);//passa a primeira fase

            reset();

            MensagemBox mb = new MensagemBox();
            mb.ShowDialog();
            
        }

        private void PctSaoPaulo_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                saoPaulo.mudarPonto();
                Score += 10;
            }
            else if (usuario.setFase() == 2)
            {

                caminhoErrado();

            }

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PctCaribe_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (bahia.setCondicao())
                {

                    caribe.mudarPonto();
                    Score += 10;

                }
                else
                {
                    caminhoErrado();
                }

            }
            else if (usuario.setFase() == 2)
            {

                caminhoErrado();

            }
        }

        private void Pct_USA_Leste_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (caribe.setCondicao())
                {
                    usa_leste.mudarPonto();
                    Score += 10;
                }
                else
                {
                    caminhoErrado();
                }
            }else if(usuario.setFase() == 2)
            {

                if (europaOeste.setCondicao() && !africaSul.setCondicao())
                {

                    usa_leste.mudarPonto();
                    Score += 10;

                }
                else
                {

                    caminhoErrado();

                }

            }

        }

        private void Pct_USA_Oeste_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (usa_leste.setCondicao() && !africaCentral.setCondicao())
                {
                    usa_oeste.mudarPonto();
                    Score += 10;
                }
                else
                {
                    caminhoErrado();
                }
            }else if(usuario.setFase() == 2)
            {

                if (usa_leste.setCondicao())
                {
                    usa_oeste.mudarPonto();
                    Score += 10;
                }
                else
                {
                    caminhoErrado();
                }

            }

        }

        private void PctJapao_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (usa_oeste.setCondicao())
                {
                    japao.mudarPonto();
                    Score += 10;
                }
                else
                {
                    caminhoErrado();
                }
            }else if(usuario.setFase() == 2)
            {

                if (usa_oeste.setCondicao())
                {
                    japao.mudarPonto();
                    Score += 10;
                }
                else
                {
                    caminhoErrado();
                }

            }

        }

        private void PctChina_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (japao.setCondicao())
                {
                    china.mudarPonto();
                    Score += 10;
                }
                else
                {
                    caminhoErrado();
                }

            }else if( usuario.setFase() == 2)
            {

                if (india.setCondicao() || japao.setCondicao())
                {
                    MessageBox.Show("Agora envie para o usuario agora");
                    reset();
                    china.mudarPonto();

                }else
                {

                    caminhoErrado();

                }

            }

        }

        private void PctTailandia_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (china.setCondicao() || india.setCondicao())
                {
                    tailandia.mudarPonto();
                    Score += 10;
                }
                else
                {
                    caminhoErrado();
                }

            }else if(usuario.setFase() == 2)
            {

                if (china.setCondicao())
                {

                    tailandia.mudarPonto();
                    Score += 10;

                }else
                {

                    caminhoErrado();

                }

            }

        }

        private void PctAustralia_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (tailandia.setCondicao() || saoPaulo.setCondicao())//atalho da fase - desativar quando pronto
                {

                    australia.mudarPonto();
                    Score += 20;
                    MessageBox.Show("Parabéns !!!! \nVocê ganhou a primeira fase");
                    usuario.getFase(2);

                    /*
                    Apresentacao2 apresentacao2 = new Apresentacao2();
                    apresentacao2.ShowDialog();
                    */

                    LoadFase();

                }
                else
                {
                    caminhoErrado();
                }

            }else if(usuario.setFase() == 2)
            {

                if (tailandia.setCondicao())
                {

                    australia.mudarPonto();
                    Score += 10;
                    MessageBox.Show("Parabéns !!!! \nVocê ganhou a segunda fase");

                    usuario.getScore(Score);

                    MessageBox.Show("Sua pontuação foi " + usuario.setScore());

                }
                else
                {

                     caminhoErrado();

                }

            }

        }

        private void PctAfricaSul_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (africaCentral.setCondicao())
                {

                    africaSul.mudarPonto();
                    Score += 10;

                }
                else
                {

                    caminhoErrado();

                }

            }
            else if(usuario.setFase() == 2)
            {

                if (africaCentral.setCondicao() && !usa_leste.setCondicao())
                {

                    africaSul.mudarPonto();
                    Score += 10;

                }
                else
                {

                    caminhoErrado();

                }

            }
        }

        private void PctAfricaCenter_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (europaOeste.setCondicao())
                {

                    africaCentral.mudarPonto();
                    Score += 10;

                }
                else
                {

                    caminhoErrado();

                }

            }
            else if (usuario.setFase() == 2)
            {
                if (europaOeste.setCondicao())
                {

                    africaCentral.mudarPonto();
                    Score += 10;

                }
                else
                {

                    caminhoErrado();

                }
            }
        }

        private void PctEuropaOeste_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {

                if(usa_leste.setCondicao() && !usa_oeste.setCondicao())
                {

                    europaOeste.mudarPonto();
                    Score += 10;

                }
                else
                {

                    caminhoErrado();

                }

            }else if(usuario.setFase() == 2)
            {

                if (unitedKingdom.setCondicao())
                {

                    europaOeste.mudarPonto();
                    Score += 10;

                }
                else
                {

                    caminhoErrado();

                }

            }
        }

        private void PctEuropaLeste_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                caminhoErrado();
            }
            else if (usuario.setFase() == 2)
            {

                caminhoErrado();

            }
        }

        private void Pct_UnitedKingdom_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                caminhoErrado();

            }
            else if (usuario.setFase() == 2)
            {

                unitedKingdom.mudarPonto();
                Score += 10;

            }
        }

        private void PctIndia_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (africaSul.setCondicao())
                {

                    india.mudarPonto();
                    Score += 10;

                }
                else
                {

                    caminhoErrado();

                }

            }
            else if(usuario.setFase() == 2)
            {

                if (africaSul.setCondicao())
                {

                    india.mudarPonto();

                }
                else
                {

                    caminhoErrado();

                }

            }
        }

    }
}
