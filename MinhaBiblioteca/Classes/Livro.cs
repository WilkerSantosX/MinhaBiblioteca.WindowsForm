using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Classes
{
    public class Livro
    {
        public int CodigoLivro { get; set; }

        public string Titulo { get; set; }

        public int CodigoAutor { get; set; }

        public int CodigoEditora { get; set; }

        public int Ano { get; set; }

        public bool JaLido { get; set; }

        public int? Avaliacao { get; set; }

        [ForeignKey("CodigoEditora")]
        public virtual Editora Editora { get; set; }

        [ForeignKey("CodigoAutor")]
        public virtual Autor Autor { get; set; }
    }
}
