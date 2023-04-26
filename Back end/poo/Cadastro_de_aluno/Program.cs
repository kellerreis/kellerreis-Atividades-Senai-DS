// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos,
//  em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.
 
// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer 
// visualizar a média ou o valor da mensalidade.
using Cadastro_de_aluno;

Aluno aluno = new Aluno();

Console.WriteLine($"Digite o nome do aluno:");
string Nome = Console.ReadLine();

Console.WriteLine($"Digite o curso do aluno:");
string Curso = Console.ReadLine();

Console.WriteLine($"Digite a idade do aluno:");
int Idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o RG do aluno:");
string Rg = Console.ReadLine();

Console.WriteLine($"O aluno e bolsista? (s/n):");
bool Bolsa = bool.Parse(Console.ReadLine());

Console.WriteLine($"Digite a media do aluno:");
float Media = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a mensalidade do aluno:");
float Mensalidade = float.Parse(Console.ReadLine());


Console.WriteLine(@$"Digite a opcao desejada

1 - Ver media final

2 - Ver mensalidade");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:

    ;
    
        break;

    case 2:

    Console.WriteLine($"Text");
        
    default:
        break;
}

