Console.WriteLine(@$"


Vamos calcular sua idade em anos e em semanas
");

// Console.WriteLine($"digite sua idade:");
// int ano = int.Parse(Console.ReadLine());

// Console.WriteLine($"digite seu mes de nascimento");
// int mes = int.Parse(Console.ReadLine());

// Console.WriteLine($"digite seu dia de nascimento");
// int dia = int.Parse(Console.ReadLine());

// DateTime data = DateTime.Now;

// int Meses = ((data.Year - ano)*12);
// Console.WriteLine($"sua idade em meses é igual a: {Meses} meses");

Console.Write($"Digite seu ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine()!);

int anoAtual = DateTime.Now.Year;

int idade = anoAtual - anoNascimento;
int idadeSemanas = idade * 52; 
Console.WriteLine(@$"Você tem {idade} anos ou {idadeSemanas} semanas
");





