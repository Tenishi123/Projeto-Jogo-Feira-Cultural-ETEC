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
        Usuario usuario = new Usuario();

        public FormJogo()
        {
            InitializeComponent();
        }

        /***
        * minhas funções
         ***/

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

        }

        private void LoadFase()
        {

            if(usuario.setFase() == 1)
            {

                pctUsuario.Visible = true;
                pctUsuario1.Visible = false;
                pctServidorPrincipal.Visible = true;
                pctServidorPrincipal1.Visible = false;
                pctServidorSecundario.Visible = false;

                reset();

            }
            else if(usuario.setFase() == 2)
            {

                pctUsuario.Visible = true;
                pctUsuario1.Visible = false;
                pctServidorPrincipal.Visible = false;
                pctServidorPrincipal1.Visible = true;
                pctServidorSecundario.Visible = true;

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
                    MessageBox.Show("Faça o caminho correto");
                    Score -= 10;
                }
            }

        }

        private void FormJogo_Load(object sender, EventArgs e)
        {

            pctFundo.Height = this.Height;
            pctFundo.Width = this.Width;//Ajuste de tamanho da imagem com a tela

            usuario.getFase(1);//passa a primeira fase

            reset();
            
        }

        private void PctSaoPaulo_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                saoPaulo.mudarPonto();
                Score += 10;
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
                    MessageBox.Show("Faça o caminho correto");
                    Score -= 10;
                }

            }else if(usuario.setFase() == 2)
            {



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
                    MessageBox.Show("Faça o caminho correto");
                    Score -= 10;
                }
            }

        }

        private void Pct_USA_Oeste_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (usa_leste.setCondicao())
                {
                    usa_oeste.mudarPonto();
                    Score += 10;
                }
                else
                {
                    MessageBox.Show("Faça o caminho correto");
                    Score -= 10;
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
                    MessageBox.Show("Faça o caminho correto");
                    Score -= 10;
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
                    MessageBox.Show("Faça o caminho correto");
                    Score -= 10;
                }
            }

        }

        private void PctTailandia_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                if (china.setCondicao())
                {
                    tailandia.mudarPonto();
                    Score += 10;
                }
                else
                {
                    MessageBox.Show("Faça o caminho correto");
                    Score -= 10;
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
                    MessageBox.Show("Sua pontuação é: " + Score);
                    usuario.getScore(Score);
                    usuario.getFase(2);

                    /*
                    Apresentacao2 apresentacao2 = new Apresentacao2();
                    apresentacao2.ShowDialog();
                    */

                    LoadFase();

                }
                else
                {
                    MessageBox.Show("Caminho errado");
                    Score -= 10;
                }
            }

        }

        private void PctAfricaSul_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                MessageBox.Show("Caminho errado");
                Score -= 10;
            }
        }

        private void PctAfricaCenter_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                MessageBox.Show("Caminho errado");
                Score -= 10;
            }
        }

        private void PctEuropaOeste_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {

                MessageBox.Show("Caminho errado");
                Score -= 10;

            }else if(usuario.setFase() == 2)
            {

                if (unitedKingdom.setCondicao())
                {

                    unitedKingdom.mudarPonto();
                    Score += 10;

                }
                else
                {

                    MessageBox.Show("Ache o caminho certo");

                }

            }
        }

        private void PctEuropaLeste_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                MessageBox.Show("Caminho errado");
                Score -= 10;
            }
        }

        private void Pct_UnitedKingdom_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                MessageBox.Show("Caminho errado");
                Score -= 10;

            }else if (usuario.setFase() == 2)
            {

                unitedKingdom.mudarPonto();
                Score += 10;

            }
        }

        private void PctIndia_Click(object sender, EventArgs e)
        {
            if (usuario.setFase() == 1)
            {
                MessageBox.Show("Caminho errado");
                Score -= 10;
            }
        }

    }
}
