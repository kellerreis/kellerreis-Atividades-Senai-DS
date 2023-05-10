using metodo_construtor;

Produto p = new Produto();

Console.WriteLine($"informe o codigo de barras");
p.Codigo = Console.ReadLine();

Console.WriteLine($"informe o nome");
p.Nome = Console.ReadLine();

Console.WriteLine($"informe o preco");
p.Preco = float.Parse(Console.ReadLine());

