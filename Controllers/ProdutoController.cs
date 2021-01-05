using MCV_POO.Models;
using MCV_POO.Views;

namespace MCV_POO.Controllers
{
    public class ProdutoController
    {
        //Models
        Produto produto = new Produto();

        //Views
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {

            produtoView.Listar(produto.Ler());
        }
    }
}