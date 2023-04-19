// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

static bool Login(string senha)
{
    if (senha == "9999")
    {
        return true;
    }
    else
    {
        Console.WriteLine($"Senha inválida!");
        return false;
    }
}

string[] nome = new string[10];
float[] preco = new float[10];
bool[] promo = new bool[10];

bool senhaok;

do
{
    Console.WriteLine($"Informe a sua senha: ");
    string senha = Console.ReadLine();

    senhaok = Login(senha);

} while (senhaok != true);

string opcao;

do
{
    
    Console.WriteLine($"Menu de opções");

    Console.WriteLine(@$"
Selecione uma das opções abaixo:

[1] - Cadastrar Produtos
[2] - Listar produtos cadastrados
[0] - Sair
");

    opcao = Console.ReadLine();

    string resposta;
    string resppromo;

    switch (opcao)
    {
        case "1":
            do
            {
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Informe o nome do produto: ");
                    nome[i] = Console.ReadLine();

                    Console.WriteLine($"Informe o preço do produto: ");
                    preco[i] = float.Parse(Console.ReadLine());

                    do 
                    {Console.WriteLine(@$"O produto está na promoção?
                    (Digite S para sim ou N para não)
                    ");

                    resppromo = (Console.ReadLine());

                  if (resppromo == "s")
                    {
                        promo[i] = true;
                        
                    }
                    else if (resppromo == "n")
                    {
                       promo[i] = false; 
                    }
                    else
                    {Console.WriteLine($"Opção inválida");}
                    }

                    while (resppromo != "s" && resppromo != "n");
                    

                }

                Console.WriteLine($"Quer cadastrar mais produtos: s/n");
                resposta = Console.ReadLine().ToLower();

            } while (resposta == "s");
            break;
        case "2":
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(@$"
                -----------------------------------------------
                | Produto cadastrado:
                | Nome: {nome[i]}
                | Preço: {preco[i]} ");
                if (promo [i] == true){
                    Console.WriteLine($"                | Preço promocional: Sim");
                                      
                }
                else {

                    Console.WriteLine($"                | Preço promocional: Não");
                    
                }
            }
            break;
        case "0":
            Console.WriteLine($"Fim do programa");
            break;
        default:
            Console.WriteLine($"Opção inválida!");
            break;
    }
} while (opcao != "0");