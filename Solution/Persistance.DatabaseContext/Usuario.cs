namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Almacen_Usuario = new HashSet<Almacen_Usuario>();
            Caja_Arqueo = new HashSet<Caja_Arqueo>();
            Caja_Chica_Comprobacion = new HashSet<Caja_Chica_Comprobacion>();
            Caja_Chica_Dotacion = new HashSet<Caja_Chica_Dotacion>();
            Caja_Chica_Solicitud_Reembolso = new HashSet<Caja_Chica_Solicitud_Reembolso>();
            Caja_Comprobacion = new HashSet<Caja_Comprobacion>();
            Caja_Dotacion = new HashSet<Caja_Dotacion>();
            Caja_Solicitud_Reembolso = new HashSet<Caja_Solicitud_Reembolso>();
            Facultades_extraordinarias = new HashSet<Facultades_extraordinarias>();
            Metodo_Costeo_Rangos = new HashSet<Metodo_Costeo_Rangos>();
            Perfil_usuario = new HashSet<Perfil_usuario>();
            Persona_Concepto = new HashSet<Persona_Concepto>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_persona { get; set; }

        [StringLength(8)]
        public string Contraseña { get; set; }

        public int? Estatus { get; set; }

        public short? Intentos_fallidos { get; set; }

        public int? Ultima_transaccion { get; set; }

        public DateTime? Hora_Entrada { get; set; }

        public DateTime? Hora_Salida { get; set; }

        public int? EnLinea { get; set; }

        public byte? Idioma { get; set; }

        public int? Clas_Sucursal { get; set; }

        public int? Familia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Usuario> Almacen_Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Arqueo> Caja_Arqueo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Chica_Comprobacion> Caja_Chica_Comprobacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Chica_Dotacion> Caja_Chica_Dotacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Chica_Solicitud_Reembolso> Caja_Chica_Solicitud_Reembolso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Comprobacion> Caja_Comprobacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Dotacion> Caja_Dotacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Solicitud_Reembolso> Caja_Solicitud_Reembolso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facultades_extraordinarias> Facultades_extraordinarias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Metodo_Costeo_Rangos> Metodo_Costeo_Rangos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perfil_usuario> Perfil_usuario { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona_Concepto> Persona_Concepto { get; set; }
    }
}
