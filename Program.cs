// See https://aka.ms/new-console-template for more information
using EstudoRecord;
using System.Runtime.CompilerServices;

var id = Guid.NewGuid();
var produto1 = new ProdutoDto(id, "Pilsen Urquell", "A1B2");
Console.WriteLine("Exemplo Produto 1");
Console.WriteLine(produto1.ToString());


var (idd, descricao, localizacao) = produto1;
Console.WriteLine($"Exemplo de desconstrução {idd} {descricao} {localizacao}");


var produto2 = new ProdutoDto(id, "Pilsen Urquell", "A1B2");
Console.WriteLine($"Exemplo de igualdade {produto1 == produto2}");


var produtos = new List<ProdutoDto>() { produto1, produto2 };
Console.WriteLine($"Exemplo de agrupamento, devemos ter apenas 1 ({produtos.Distinct().Count()})");


var novoProdutoWith = produto1 with { Localizacao = "YYZ"};
Console.WriteLine("Exemplo de modificação com with");
Console.WriteLine(novoProdutoWith.ToString()); 

