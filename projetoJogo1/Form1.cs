﻿using System;
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
    public partial class Form_Principal : Form
    {
        int Tempo = 0;

        public Form_Principal()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if(Tempo <= 100)
            {

                Opacity += 0.02;//efeito na tela inicial

            }
            else if(Tempo == 101)
            {

                Apresentacao apresentacao = new Apresentacao();
                Tempo++;
                apresentacao.ShowDialog();
                Hide();

            }
            else
            {

                ControleInicio.Enabled = false;

            }

            Tempo++;

        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
