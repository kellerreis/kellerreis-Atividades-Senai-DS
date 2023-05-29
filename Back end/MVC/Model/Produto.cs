using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //Caminho da pasta e do rquivo csv

        private const string PATH = "Database/Produto.csv";
        public Produto(){
            //criar a logica para gerar a pasta e o arquivo

            //obter o camiho da pasta
            string pasta = PATH.Split("/")[0];

            //verificar se no caminho ja existe uma pasta
            if (!Directory.Exists(pasta)){

                Directory.CreateDirectory(pasta);

            }
            //verificar se no caminho ja existe um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
        {

            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                //separacao de atributos de cada linha
                string[] atributos = item.Split(";");

                //instancia de objeto

                Produto p = new Produto();

                //atribuicao de valores dentro do objeto

                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                //adiciona objeto dentro da lista
                produtos.Add(p);
            }

            //retorna a lista de produtos
            return produtos;
        }

        //metodo para preparar as linhas a aserem inseridas no csv

        public string PrepararLinhasCSV(Produto p)
        {

            return $"{p.Codigo};{p.Nome};{p.Preco}";//1010;coca;6,99
        }

        //metodo para inserir um produto na linha do csv

        public void Inserir(Produto p)
        {
            string[] linhas = {PrepararLinhasCSV(p)};

            File.AppendAllLines(PATH, linhas);

        }

        

    }
}