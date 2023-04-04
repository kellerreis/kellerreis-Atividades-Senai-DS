// Exemplo de estrutura com switch case


Console.WriteLine($"Digite o numero correspondente ao dia da semana");
int diadasemana = int.Parse(Console.ReadLine());

switch (diadasemana)
{
    case 1:
    Console.WriteLine($"Hoje é domingo!");
    break;
    case 2:
    Console.WriteLine($"Hoje é segunda!");
    break;
    case 3:
    Console.WriteLine($"Hoje é terça!");
    break;
    case 4:
    Console.WriteLine($"Hoje é quarta!");
    break;
    case 5:
    Console.WriteLine($"Hoje é quinta!");
    break;
    case 6:
    Console.WriteLine($"Hoje é sexta!");
    break;
    case 7:
    Console.WriteLine($"Hoje é sabado!");
    break;
    
    
    default:

    Console.WriteLine($"Dia informado invalido.");
    break;
}
