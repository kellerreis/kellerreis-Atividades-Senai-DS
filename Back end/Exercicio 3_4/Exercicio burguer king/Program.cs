//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional

Console.WriteLine(@$"
----------------------------------
|   Selecione sua bebida         |   
|                                |
|   Digite o numero da bebida    |
|                                |
|    (1) Coca cola               |
|    (2) Pepsi                   |
|    (3) Fanta                   |
|    (4) Monster                 |
----------------------------------
");

int bebida = int.Parse(Console.ReadLine());

Console.WriteLine(@$"Gostaria de acrescentar gelo a sua bebida? 

digite o numero da opção desejada:

(1) para SIM
(2) para NÃO

)");
int gelo = int.Parse(Console.ReadLine());

switch (bebida)
{

    case 1:
        Console.WriteLine($"A bebida escolhida é Coca Cola");
        break;
    case 2:
        Console.WriteLine($"A bebida escolhida é Pepsi");
        break;
    case 3:
        Console.WriteLine($"A bebida escolhida é Fanta");
        break;
    case 4:
        Console.WriteLine($"A bebida escolhida é Monster");
        break;

    default:

        Console.WriteLine($"Bebida informada invalida.");
        break;
}

switch (gelo)
{

    case 1:
        Console.WriteLine($"Com gelo");
        break;
    case 2:
        Console.WriteLine($"Sem gelo");
        break;

default:

        Console.WriteLine($"Opção de gelo invalida.");
        break;
         }
