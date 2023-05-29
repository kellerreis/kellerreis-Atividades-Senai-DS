using MVC.Model;

namespace MVC.View
{
    public class NewBaseType
    {

    //metodo para exibir os dados da lista no console
    public void Listar(List<Produto> produto)

     {
            foreach (var item in produto)
            {
            Console.WriteLine($"Codigo: {item.Codigo}");
            Console.WriteLine($"Nome: {item.Nome}");
            Console.WriteLine($"Preco: {item.Preco:C}");

             }

            public Produto Cadastrar()
            {

            Produto novoProduto = new Produto();

            Console.WriteLine($"Infotmr o codigo:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Infotmr o nome:");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Infotmr o codigo:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;

            }
     }
    }



}