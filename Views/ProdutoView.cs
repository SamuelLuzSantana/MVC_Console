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
        }

}