using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.GestionCollege.Mapping
{
    public class ClasseMapping : EntityTypeConfiguration<Classe>
    {

        public ClasseMapping()
        {
            ToTable("Classe");
            HasKey(c => c.ClassId);

            Property(c => c.ClassId).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(c => c.NomEtablissement).IsRequired().HasMaxLength(255);
            Property(c => c.Niveau).IsRequired().HasMaxLength(255);

            HasMany(c => c.Eleves).WithRequired(eleve => eleve.ClasseEleve).HasForeignKey(eleve => eleve.ClasseId);

        }

    }
}
