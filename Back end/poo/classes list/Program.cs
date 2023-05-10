using classes_list;

List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto(2563,"camiseta Quicksilver",199.90f)
);
    produtos.Add(
        new Produto (1111, "tenis naike", 50f)
    );
    Produto calcaDiesel = new Produto(1526,"calca diesel", 15f);
    produtos.Add(calcaDiesel);

    foreach (var item in produtos){
         Console.WriteLine($"Codigo: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:C} {produtos.IndexOf(item)}");
    }

    Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563);

    // Console.WriteLine($"{produtoBuscado.Codigo} {produtoBuscado.Nome} {produtoBuscado.Preco}");

    int index = produtos.IndexOf(produtoBuscado);

    produtoBuscado.Preco = 299.9f;

    produtos.RemoveAt(index);

    produtos.Insert(index, produtoBuscado);

    Console.WriteLine($"lista atualizada");
    Console.WriteLine($"****************");

    foreach (var item in produtos)
    {

        Console.WriteLine($"Codigo: {item.Codigo} Nome: {item.Nome} Preco: {item.Preco:c} {produtos.IndexOf(item)}");
        
    }
    
    
    

   
    
    