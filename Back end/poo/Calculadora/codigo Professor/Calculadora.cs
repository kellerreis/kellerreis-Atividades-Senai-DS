using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codigo_Professor
{
    public class Calculadora
    {
     // propriedades
        public float numero1;
        public float numero2;

        // métodos
        public float Somar()
        {
            return  this.numero1 + this.numero2;
        }
        public float Subtrair()
        {
            return  this.numero1 - this.numero2;
        }
        
        public float Multiplicar()
        {
            return  this.numero1 * this.numero2;
        }
        public float Dividir()
        {
            return  this.numero1 / this.numero2;
        }
    }
}