using MinhaBiblioteca.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Entity
{
    public class EditoraConfiguration : EntityTypeConfiguration<Editora>
    {
        public EditoraConfiguration()
        {
            ToTable("Editora")
            .HasKey(x => x.CodigoEditora);
            ToTable("Editora").Property(x => x.NomeEditora).HasColumnName("Nome");
        }
    }
}
