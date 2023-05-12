using Projeto_produto_interface;

Carrinho carrinho = new Carrinho();

Produto p1 = new Produto(1, "gta", 25.6f );
Produto p2 = new Produto(2, "fifa", 50.3f );
Produto p3 = new Produto(3, "Forza", 100f );


carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

Console.WriteLine($"Apos a remocao de um item");
carrinho.Remover(p2);
carrinho.Remover(p3);


carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"Agora vamos atualizar um ojeto");


//criar um objeto com os dados atualizados

Produto _novoProduto = new Produto();
_novoProduto.Nome = "Fifa2023";
_novoProduto.Preco = 300f;

carrinho.Atualizar(1,_novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();
