using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_celular_26_04
{
    public class Celular
    {
        //atributos (caracteristicas) ou propriedades
        public string Cor;
        public string Modelo;
        public string Tamanho;
        
        public bool Ligado;
        
    }

    public string Ligar()
    {
        Ligado = true;
        Console.WriteLine($"O celular esta ligado");
        
    }
}