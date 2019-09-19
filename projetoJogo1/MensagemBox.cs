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
    public partial class MensagemBox : Form
    {

        Ponto1DEMO ponto1 = new Ponto1DEMO();
        Ponto2DEMO ponto2 = new Ponto2DEMO();
        public MensagemBox()
        {
            InitializeComponent();
        }

        private void MensagemBox_Load(object sender, EventArgs e)
        {

            lblMensagem.Text = "Clique nos pontos e conecte o servidor ao computador";
            btnJogar.Visible = false;
            ponto1.get_pct(pctPonto1);
            ponto2.get_pct(pctPonto2);
            ponto1.getCondicao(true);
            ponto2.getCondicao(true);
            ponto1.mudarPonto();
            ponto2.mudarPonto();


        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void PctPonto1_Click(object sender, EventArgs e)
        {

            ponto1.mudarPonto();
            ponto1.getBloquedo(true);

        }

        private void PctPonto2_Click(object sender, EventArgs e)
        {

            if (ponto1.setCondicao())
            {

                ponto2.mudarPonto();
                btnJogar.Visible = true;

            }
            else
            {

                MessageBox.Show("Escolha o caminho certo");

            }

        }

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PctUsuario1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
