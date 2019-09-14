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

        int codPonto = 0, codUltimoPonto = 0;
        bool SaoPaulo = false /*01*/, Bahia = false /*02*/;

        public FormJogo()
        {
            InitializeComponent();
        }

        private void mudarPonto(PictureBox pctPonto, bool codCondicao)
        {

            if (codCondicao)
            {

                SaoPaulo = false;
                Image SprintPonto = Properties.Resources.pontoNetIcone;
                pctPonto.Image = SprintPonto;

            }
            else
            {

                SaoPaulo = true;
                Image SprintPonto = Properties.Resources.pontoNetIcone2;
                pctPonto.Image = SprintPonto;

            }

        }

        private void gerenciarCaminho(int codCaminho)
        {

            if (codUltimoPonto == 0)
            {

                codUltimoPonto = codCaminho;

            }
            else
            {

                if(codUltimoPonto == 1 && codCaminho == 2)// conexão São paulo - Bahia
                {

                    

                }
                else
                {

                    

                }

            }
            codPonto = 0;

        }

        private void PctBahia_Click(object sender, EventArgs e)
        {



        }

        private void FormJogo_Load(object sender, EventArgs e)
        {

            pctFundo.Height = this.Height;
            pctFundo.Width = this.Width;//Ajuste de tamanho da imagem com a tela

        }

        private void PctSaoPaulo_Click(object sender, EventArgs e)
        {

            codPonto = 1;
            gerenciarCaminho(codPonto);
            mudarPonto(pctSaoPaulo, SaoPaulo);

        }
    }
}
