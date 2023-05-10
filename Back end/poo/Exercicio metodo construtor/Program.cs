using Exercicio_metodo_construtor;

List<Carro> carros = new List<Carro>();

for (var i = 0; i < 2; i++)
{
    Carro carro = new Carro();

    Console.WriteLine($"informe a marca");
    carro.Marca = Console.ReadLine();

    Console.WriteLine($"informe a cor");
    carro.Cor = Console.ReadLine();

    carros.Add(carro);    
}

foreach (var item in carros)
{
    Console.WriteLine($"MArca: {item.Marca}, Cor {item.Cor}");
    
}

// Console.WriteLine($"insira a marca do carro");
// carros.Add(new Carro(, "camiseta lacoste", 19.99f))

