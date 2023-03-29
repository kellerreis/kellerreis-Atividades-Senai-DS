Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine(@$"
--------------------------
| Programa para calcular |
|       seu IMC          |
--------------------------

");
Console.ResetColor();

Console.WriteLine($"Digite o nome do paciente");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo {nome} ;)");

Console.WriteLine($"Informe o peso: ");
float peso = float.Parse(Console.ReadLine());


Console.WriteLine($"informe sua altura: ");
float altura = float.Parse(Console.ReadLine());

float imc = (peso / ((float)Math.Pow(altura,2)));

Console.WriteLine($"o paciente {nome} tem imc igual a : {imc}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"obrigdo por utilizar nosso sistema!");
Console.ResetColor();




