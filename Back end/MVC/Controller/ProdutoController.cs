using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Model;
using MVC.View;

namespace MVC.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        //metodo controlador para acessar a listagem de produtos

        public void ListarProdutos(){

            //chamada da model trazendo a lista

            List<Produto> produtos = produto.Ler();

            //chamada da view passando a lista 
            produtoView.Listar(produto);
        }
            
        
    }
}