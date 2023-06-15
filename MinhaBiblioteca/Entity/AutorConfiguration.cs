using MinhaBiblioteca.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Entity
{
    public class AutorConfiguration : EntityTypeConfiguration<Autor>
    {
        public AutorConfiguration()
        {
            ToTable("Autor")
            .HasKey(x => x.CodigoAutor);
            ToTable("Autor").Property(x => x.NomeAutor).HasColumnName("Nome");
        }
    }
}
