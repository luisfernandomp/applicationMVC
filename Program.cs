using System;
using aulaMVC.Controllers;

namespace aulaMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();
            produto.Filtrar("34,6");
        }
    }
}
