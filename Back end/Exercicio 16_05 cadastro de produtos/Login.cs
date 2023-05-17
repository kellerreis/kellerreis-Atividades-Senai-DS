using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_16_05_cadastro_de_produtos
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login()
        {
            Usuario user = new Usuario();
            logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void logar(Usuario usuario)
        {
            Console.WriteLine($"Informe seu e-mail:");
            string emailDigitado = Console.ReadLine();

            Console.WriteLine($"Informe senha:");
            string SenhaDigitado = Console.ReadLine();

            if (emailDigitado == usuario.email && SenhaDigitado == usuario.senha)
            {
                this.Logado = true;
                Console.WriteLine($"logado com sucesso!!!");

            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha no login, email ou senha incorretos");

            }



        }

        public void Deslogar()
        {
            Logado = false;
        }

        public void GerarMenu()
        {

            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

            do
            {
                Console.WriteLine(@$"
            [1] Cadastrar Produto
            [2] Listar Produtos
            [3] Remover produto
            --------------------
            [4] Cadastar Marca
            [5] Listar Marcas
            [6] Remover Marca
            -----------------
            [0] Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar();
                        break;
                    case "2":
                        produto.Listar();
                        break;
                    case "3":
                        Console.WriteLine($"informe codigo a ser excluido:");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(codigoProduto);
                        break;
                    case "4":
                        marca.Cadastrar();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"Informe o codigo a ser removido:");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(codigoMarca);
                        break;
                    case "0":
                        Console.WriteLine($"App encerrado, ate breve");
                        break;
                    default:
                        Console.WriteLine($"Opcao invalida");
                        break;
                        }

                } while (opcao != "0");

            }
        }

    }
