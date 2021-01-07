using System;
using MCV_POO.Controllers;
using MCV_POO.Models;

namespace MCV_POO
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController prod = new ProdutoController();

            prod.Cadastrar();
            prod.ListarProdutos();
        }
    }
}
