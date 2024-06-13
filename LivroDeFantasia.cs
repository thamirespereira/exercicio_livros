using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_livros
{
    public class LivroDeFantasia : Livro
    {
        public LivroDeFantasia(string titulo, string autor, int ano, int paginas)
            :base(titulo, autor, ano, paginas){

            }
        public override void Ler()
        {
            Console.WriteLine("Lendo o livro " + Titulo + " de " + Autor + " publicado em " + Ano + " com " + Paginas + " páginas.");
        }
    }
}