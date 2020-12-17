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

            Produto p1 = new Produto();
            p1.Codigo = 67;
            p1.Nome = "Iphone XII";
            p1.Preco = 8952.56f;

            produtos.Add(p1);

            foreach (Produto item in produtos)
            {
                Console.WriteLine(item.Nome);
            }

            produtos.RemoveAt(3);

            Console.WriteLine("\nRemoção Feita\n");

            foreach (Produto item in produtos)
            {
                Console.WriteLine(item.Nome);
            }
            

        }
    }
}
