using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoJogo1
{
    public partial class Apresentacao : Form
    {

        int estadoDaJanela = 0;//controla o estagio da janela

        public Apresentacao()
        {
            InitializeComponent();
        }

        private void BtnProApresentacao_Click(object sender, EventArgs e)
        {

            estadoDaJanela++;

            if (estadoDaJanela == 1)
            {

                lblMengsApresentacao.Text = "Este jogo se trata de ensinar como a internet funciona, \ncomo os computadores se conectam.";
                btnAnApresentacao.Visible = true;

            }
            else if(estadoDaJanela == 2)
            {

                lblMengsApresentacao.Text = "Muito bem, vamos ver se você descobre o caminho mais rapido \npara enviar o pacote ao servidor.";

            }else if(estadoDaJanela == 3)
            {

                Hide();

                FormJogo formJogo = new FormJogo();
                formJogo.ShowDialog();

            }

        }

        private void BtnAnApresentacao_Click(object sender, EventArgs e)
        {

            estadoDaJanela--;

            if(estadoDaJanela == 0)
            {

                lblMengsApresentacao.Text = "Bem vindo ao Jogo da NET";
                btnAnApresentacao.Visible = false;

            }else if(estadoDaJanela == 1)
            {

                lblMengsApresentacao.Text = "Este jogo se trata de ensinar como a internet funciona, \ncomo os computadores se conectam.";
                btnAnApresentacao.Visible = true;

            }

        }
    }
}
