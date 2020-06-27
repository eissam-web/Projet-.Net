using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.GestionCollege.Mapping
{
    public class NoteMapping : EntityTypeConfiguration<Note>
    {

        public NoteMapping()
        {
            ToTable("Note");
            HasKey( n => n.NoteId);

            Property(n => n.NoteId).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(n => n.Matiere).IsRequired().HasMaxLength(255);
            Property(n => n.DateNote).IsRequired();
            Property(n => n.Appreciation).IsRequired().HasMaxLength(255);
            Property(n => n.NoteObt).IsRequired();

            Property(n => n.EleveId).IsRequired();
            HasRequired(n => n.EleveNote).WithMany(e => e.Notes).HasForeignKey(n => n.EleveId);

        }

    }
}
