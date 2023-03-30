Console.WriteLine($"informe seu salario");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"informe seu gasto");
float gasto = float.Parse(Console.ReadLine());

float saldo = salario - gasto;

if (saldo>=0)
{
    Console.WriteLine($"Gastos dentro do orçamento, ainda lhe sobrou R${saldo} para investir");
    
}
else {
    Console.WriteLine($"orçamento estourado, seu saldo é de R${saldo} ");
}