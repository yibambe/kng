namespace Persistance.DatabaseContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KonexusModel : DbContext
    {
        public KonexusModel()
            : base("name=KonexusModel")
        {
        }

        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .Property(e => e.Nombre_Completo)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Paterno)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Materno)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Nombre_Corto)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Radiolocalizador)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.correo_electronico)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Personalidad_juridica)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Numero_Confia)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .HasOptional(e => e.Usuario)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Contraseña)
                .IsUnicode(false);
        }
    }
}
