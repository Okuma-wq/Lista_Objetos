using System;
using System.Collections.Generic;
using ListaObjetos.Classes;

namespace ListaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(5, "Apple Watch", 3522.56f));
            produtos.Add(new Produto(8, "Xiaomi Watch", 1522.56f));
            produtos.Add(new Produto(78, "Zenfone ASUS", 4522.56f));
            produtos.Add(new Produto(2, "Sansung", 4522.56f));
            produtos.Add(new Produto(2, "Motorola G8", 6522.56f));

            Produto iphone = new Produto();
            iphone.Codigo = 67;
            iphone.Nome = "Iphone XII";
            iphone.Preco = 8952.56f;

            produtos.Add(iphone);

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }

            produtos.RemoveAt(3);

            produtos.RemoveAll(x => x.Nome == "Apple Watch");

            Console.WriteLine("\nLista Alterada\n");

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
            

        }
    }
}
