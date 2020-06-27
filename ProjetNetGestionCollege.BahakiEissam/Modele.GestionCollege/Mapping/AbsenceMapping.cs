using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.GestionCollege.Mapping
{
    public class AbsenceMapping : EntityTypeConfiguration<Absence>
    {

        public AbsenceMapping()
        {
            ToTable("Absence");
            HasKey(a => a.AbsenceId);

            Property(a => a.AbsenceId).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(a => a.DateAbsence).IsRequired();
            Property(a => a.Motif).IsRequired().HasMaxLength(255);

            Property(a => a.EleveId).IsRequired();

        }

    }
}
