using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_16_05_cadastro_de_produtos
{
    public class Marca
    {
        public int Codigo{get; set;}
        public string NomeMarca{get; set;}
        public DateTime DataCadastro{get; set;}
        List<Marca> listaMarcas = new List<Marca>();
        public Marca Cadastrar(){

            Marca novaMarca = new Marca();

            //receber os dados e cadastrar nesse objeto
            //armazenar o objeto na lista
            //retornar o objeto criado

            return novaMarca;

        }
        public void Listar(){

            

        }
        public void Deletar(int codigo){

        }
    }
}