using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Classes
{
    public class LivroModel
    {
        public int IDLivro { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public int Ano { get; set; }

        public bool JaLido { get; set; }

        public int? Avaliacao { get; set; }
    }
}
