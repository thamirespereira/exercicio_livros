using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_livros
{
    public abstract class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public int Paginas { get; set; }

        public Livro(string titulo, string autor, int ano, int paginas){
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Paginas = paginas;
        }

        public abstract void Ler();
    }
}