using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_extra
{
    public class Jogador
    {
        public string nome;
        public string datadenascimento;
        public string nacionalidade;
        public float altura;
        public float peso;

        public string VerDados()
        {
            return nome;
            
        }
    }
}