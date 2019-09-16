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
        Usuario usuario = new Usuario();

        public FormJogo()
        {
            InitializeComponent();
        }

        private void PctBahia_Click(object sender, EventArgs e)
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

        private void FormJogo_Load(object sender, EventArgs e)
        {

            pctFundo.Height = this.Height;
            pctFundo.Width = this.Width;//Ajuste de tamanho da imagem com a tela
            
            saoPaulo.get_pct(pctSaoPaulo);
            bahia.get_pct(pctBahia);
            caribe.get_pct(pctCaribe);
            usa_leste.get_pct(pct_USA_Leste);
            usa_oeste.get_pct(pct_USA_Oeste);
            japao.get_pct(pctJapao);
            china.get_pct(pctChina);
            tailandia.get_pct(pctTailandia);
            australia.get_pct(pctAustralia);
            
            
        }

        private void PctSaoPaulo_Click(object sender, EventArgs e)
        {

            saoPaulo.mudarPonto();
            Score += 10;

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PctCaribe_Click(object sender, EventArgs e)
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

        }

        private void Pct_USA_Leste_Click(object sender, EventArgs e)
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

        private void Pct_USA_Oeste_Click(object sender, EventArgs e)
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

        private void PctJapao_Click(object sender, EventArgs e)
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

        private void PctChina_Click(object sender, EventArgs e)
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

        private void PctTailandia_Click(object sender, EventArgs e)
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

        private void PctAustralia_Click(object sender, EventArgs e)
        {

            if (tailandia.setCondicao())
            {

                australia.mudarPonto();
                Score += 20;
                MessageBox.Show("Parabéns !!!! \nVocê ganhou a primeira fase");
                MessageBox.Show("Sua pontuação é: " + Score);
                usuario.getScore(Score);

                Hide();

                Apresentacao2 apresentacao2 = new Apresentacao2();
                apresentacao2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Caminho errado");
                Score -= 10;
            }

        }

        private void PctAfricaSul_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Caminho errado");
            Score -= 10;

        }

        private void PctAfricaCenter_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Caminho errado");
            Score -= 10;

        }

        private void PctEuropaOeste_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Caminho errado");
            Score -= 10;

        }

        private void PctEuropaLeste_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Caminho errado");
            Score -= 10;

        }

        private void Pct_UnitedKingdom_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Caminho errado");
            Score -= 10;

        }

        private void PctIndia_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Caminho errado");
            Score -= 10;

        }

        private void FormJogo_KeyPress(object sender, KeyPressEventArgs e)
        {


        }
    }
}
