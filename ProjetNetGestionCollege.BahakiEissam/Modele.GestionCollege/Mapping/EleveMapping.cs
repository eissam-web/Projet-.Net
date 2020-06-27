using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.GestionCollege.Mapping
{
    public class EleveMapping : EntityTypeConfiguration<Eleve>
    {

        public EleveMapping()
        {
            ToTable("Eleve");
            HasKey(e => e.EleveId);

            Property(e => e.EleveId).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(e => e.Nom).IsRequired().HasMaxLength(255);
            Property(e => e.Prenom).IsRequired().HasMaxLength(255);
            Property(e => e.DateNaissance).IsRequired();
            Property(e => e.ClasseId).IsRequired();

            //HasMany(eleve => eleve.Notes).WithRequired(note => note.EleveNote).HasForeignKey(note => note.EleveId);
            HasMany(eleve => eleve.Absences).WithRequired(absence => absence.EleveAbs).HasForeignKey(absence => absence.EleveId);

        }

    }
}
