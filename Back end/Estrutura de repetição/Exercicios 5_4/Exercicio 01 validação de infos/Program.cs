//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a));

Console.WriteLine($"Digite seu nome");
string nome = Console.ReadLine();

while (nome == "")
{
    Console.WriteLine($"Digite seu nome novamente:");
    nome = Console.ReadLine();
}

Console.WriteLine($"Digite sua idade");
int idade = int.Parse(Console.ReadLine());

while ((idade <0) || (idade>100))
{
    Console.WriteLine($"Digite sua idade novamente: (o valor deve estar entre 0 e 100)");
    idade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Digite seu salario");
float salario = float.Parse(Console.ReadLine());

while (salario <=0)
{
    Console.WriteLine($"Digite seu salario novamente (o valor deve ser positivo e maior que zero)");
    salario = float.Parse(Console.ReadLine());
}

Console.WriteLine(@$"Digite a letra do seu estado civil conforme legenda abaixo:

's' (solteiro(a)),
'c' (casado(a)), 
'v' (viúvo(a)), 
'd' (divorciado(a))


");
string estado = Console.ReadLine();

while ((estado != "s") && (estado != "c") && (estado != "v") && (estado != "d"))
{
    Console.WriteLine($"Digite seu estado civil novamente (o valor deve ser de acordo com a legenda)");
    estado = (Console.ReadLine());
}


Console.WriteLine($"Dados válidos");



