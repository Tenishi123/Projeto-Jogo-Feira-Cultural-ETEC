using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoJogo1
{
    public class pontos
    {

        bool condicao = false, bloquedo = false;
        PictureBox pct;

        public void getCondicao(bool parCondicao)
        {
            if (!bloquedo)
            {
                condicao = parCondicao;
            }
        }

        public void get_pct(PictureBox par_pct)
        {

            pct = par_pct;

        }

        public bool setCondicao()
        {
            return condicao;
        }

        public void getBloquedo(bool parBloqueado)
        {

            bloquedo = parBloqueado;

        }

        public bool setBloqueado()
        {

            return bloquedo;

        }

        public void mudarPonto()
        {
            if (!bloquedo)
            {
                if (condicao)
                {

                    condicao = false;
                    Image SprintPonto = Properties.Resources.pontoNetIcone2;
                    pct.Image = SprintPonto;

                }
                else
                {

                    condicao = true;
                    Image SprintPonto = Properties.Resources.pontoNetIcone;
                    pct.Image = SprintPonto;

                }
            }
        }

    }
}
