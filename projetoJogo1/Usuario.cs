using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoJogo1
{
    class Usuario
    {

        protected String nome;
        protected int Score;
        protected int fase;

        public String setNome()
        {
            return nome;
        }

        public void getNome(String parNome)
        {

            nome = parNome;   

        }

        public int setScore()
        {
            return Score;
        }

        public void getScore(int parScore)
        {

            Score = parScore;

            Score *= fase;

        }

        public int setFase()
        {
            return fase;
        }

        public void getFase(int parFase)
        {

            fase = parFase;

        }



    }
}
