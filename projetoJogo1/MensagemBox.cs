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
    public partial class MensagemBox : Form
    {
        public MensagemBox()
        {
            InitializeComponent();
        }

        private void MensagemBox_Load(object sender, EventArgs e)
        {

            lblMensagem.Text = "Clique nos pontos e conecte o servidor ao computador";

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
