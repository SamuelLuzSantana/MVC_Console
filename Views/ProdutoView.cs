using System;
using System.Collections.Generic;
using MCV_POO.Models;

namespace MCV_POO.Views{

    public class ProdutoView
        {
            public void Listar (List<Produto> produtos)
            {
                foreach (var item in produtos)
                {
                    Console.WriteLine($"Codigo: {item.Codigo} ");
                    Console.WriteLine($"Produto: {item.Nome} ");
                    Console.WriteLine($"Preço: R${item.Preco} ");
                    
                }
            }

            public Produto CadastrarProduto()
            {

                Produto produto = new Produto();

                Console.WriteLine($"Digite um codigo: ");
                produto.Codigo = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o nome do Produto: ");
                produto.Nome = Console.ReadLine();
                
                Console.WriteLine($"Digite o Valor do Produto R$: ");
                produto.Preco = float.Parse(Console.ReadLine());
                
                return produto;
            }
        }

}