using System.Collections.Generic;
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
        public void Filtrar(string _preco){
            List<Produto> lista = produtoModel.Ler();
            lista = lista.FindAll(x => x.Preco == float.Parse(_preco));
            produtoView.MostrarConsole(lista);
        }
    }
}
