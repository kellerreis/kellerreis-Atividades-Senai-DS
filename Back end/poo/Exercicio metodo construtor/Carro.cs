using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_metodo_construtor
{
    public class Carro
    {
        public string Marca {get; set;}
        public string Cor {get; set;}


        public Carro(){}

        public Carro(string marca, string cor){
            Marca = marca;
            Cor = cor;
        }

        // public Carro(Carro p){

        // }
    }
}