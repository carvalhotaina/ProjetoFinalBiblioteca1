using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nome:Taína Carvalho 3 fase

namespace ProjetoFinalBiblioteca
{
    public class Livro : Exemplar
    {
        public int Paginas { get; set; }
        public string TipoCapa { get; set; }
        public string Isbn { get; set; }
        public Livro()
        {
        }
        public Livro(string titulo, string autor, int anoPublicacao, int paginas, string tipoCapa, string isbn)
        {
            Paginas = paginas;
            TipoCapa = tipoCapa;
            Isbn = isbn;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
