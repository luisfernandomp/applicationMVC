using aulaMVC.Models;
using aulaMVC.Views;

namespace aulaMVC.Controllers
{
    public class ProdutoController{
        Produto produtoModel = new Produto();
        ProdutoView produtoView  = new ProdutoView();

        public void Listar(){
            produtoView.MostrarConsole( produtoModel.Ler() );
        }
    }
}
