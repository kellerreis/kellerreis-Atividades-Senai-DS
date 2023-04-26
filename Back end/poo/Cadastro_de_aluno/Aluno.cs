using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_de_aluno
{
    public class Aluno
    {
        public string Nome;
        public string Curso;
        public int Idade; 
        public string Rg;
        public bool Bolsa;
        public float Media;
        public float Mensalidde;

        public float VerMediaFinal()
        {
            return Media;
        }

        public float VerMensalidade()
        {
            return Mensalidde;
        }



    }
}