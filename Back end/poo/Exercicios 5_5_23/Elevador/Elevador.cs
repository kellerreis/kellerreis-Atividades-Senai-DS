using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elevador
{
    public class Elevador
    {
        public int TotalDeAndares {get; set;}
        public int Capacidade{get; set;}
        public int Posicao {get; set;}

        public void Inicializa(int Capacidade, int TotalDeAndares)
        {
            Console.WriteLine($"A capacidade do elevador e de {Capacidade} pessoas e ele atende {TotalDeAndares}andares do predio");
                    }
        public void entrar(){

        }   
        public void sair()
        {

        }   
        public void subir(){

        }   
        public void descer()
        {
            
        }   


    }
}