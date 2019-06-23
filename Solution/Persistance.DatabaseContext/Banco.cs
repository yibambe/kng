namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bancos")]
    public partial class Banco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Banco()
        {
            Banco_Formato_Impresion = new HashSet<Banco_Formato_Impresion>();
            Bancos_Cuentas_Propias = new HashSet<Bancos_Cuentas_Propias>();
            Caja_Dotacion = new HashSet<Caja_Dotacion>();
            Caja_Dotacion1 = new HashSet<Caja_Dotacion>();
            Bancos_Cuentas_Terceros = new HashSet<Bancos_Cuentas_Terceros>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre_Banco { get; set; }

        [StringLength(100)]
        public string Nombre_Corto_Banco { get; set; }

        public int? Clas_Pais { get; set; }

        public int? Clas_Estado { get; set; }

        public int? Clas_Ciudad { get; set; }

        public int Familia { get; set; }

        [StringLength(4)]
        public string Clave { get; set; }

        [StringLength(15)]
        public string RFC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banco_Formato_Impresion> Banco_Formato_Impresion { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Cuentas_Propias> Bancos_Cuentas_Propias { get; set; }

        public virtual Empresa Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Dotacion> Caja_Dotacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Dotacion> Caja_Dotacion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Cuentas_Terceros> Bancos_Cuentas_Terceros { get; set; }
    }
}
