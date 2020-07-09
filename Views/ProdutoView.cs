using System;
using System.Collections.Generic;
using aulaMVC.Models;

namespace aulaMVC.Views
{
    public class ProdutoView{

        public void MostrarConsole(List<Produto> prod){
            foreach (var item in prod)
            {
                Console.WriteLine($"Preco: {item.Preco} - Nome: {item.Nome}");
            }
        }
    }
}
