// See https://aka.ms/new-console-template for more information
using System;
using exercicio_livros;

internal class Program
{
    private static void Main(string[] args)
    {
        LivroDeFantasia livro1 = new LivroDeFantasia("O castelo animado", "Diana Wynne Jones", 1986, 368);
        livro1.Ler();
        //Console.WriteLine("\n", livro1);
    }
}