using Exercicio_celular_26_04;

Celular novoCelular = new Celular();

Console.WriteLine($"Informe a cor do celular: ");
novoCelular.Cor = Console.ReadLine();

Console.WriteLine($"Informe o modelo do celular: ");
novoCelular.Modelo = Console.ReadLine();

Console.WriteLine($"Informe o tamanho do celular: ");
novoCelular.Tamanho = Console.ReadLine();

Console.WriteLine($"O celular esta ligado? s/n : ");
string resposta = Console.ReadLine().ToLower();

novoCelular.Ligado = resposta == "s" ? true : false;

string opcao;

do
{
    Console.WriteLine($"****Menu****");
    Console.WriteLine(@$"
[1] - Ligar
[2] - Desligar
[3] - Fazer ligacao
[4] - Enviar mensagem
[0] - Sair
");
    opcao = Console.ReadLine();

     switch (opcao)
    {
        case "1":
            novoCelular.Ligar()
            break;
        case "2":
            ;
            break;
        case "0":
            Console.WriteLine($"Fim");
            break;
        default:
            Console.WriteLine($"Opção inválida!");
            break;
    }
} while (opcao != "0");
