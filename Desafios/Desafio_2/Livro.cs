using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    public class Livro
    { 
        public string Titulo { get; private set; }
        public string Autor { get; set; }
        public string ISBN { get; private set; }
        public int AnoPublicacao { get; set; }
        public string EstiloLiterario { get; set; }
        public int NumeroPaginas { get; set; }
        public string PaisPublicacao { get; set; }

        public Livro(string isbn, string titulo)
        {
            this.ISBN = isbn;
            this.Titulo = titulo;
        }

    }


}