using System;
using System.Globalization;

namespace ProdutoPS5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("PS5", 6000.00, 10);

            p.SetNome("");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQnt());
        }
    }
}
