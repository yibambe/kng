namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class co_Reportes_Contables_Registros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public co_Reportes_Contables_Registros()
        {
            co_Reportes_Contables_Detalle = new HashSet<co_Reportes_Contables_Detalle>();
            co_Reportes_Contables_Importes = new HashSet<co_Reportes_Contables_Importes>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Reporte { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Registro { get; set; }

        public int Tipo_Dato { get; set; }

        public int? Clas_Numero { get; set; }

        public int? Familia_Numero { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        public int? Nivel { get; set; }

        [StringLength(4000)]
        public string Operacion { get; set; }

        public byte? bPeriodo { get; set; }

        public byte? Periodo { get; set; }

        public byte? Acumulativa { get; set; }

        public byte? Tipo_Cuenta { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual co_Reportes_Contables co_Reportes_Contables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Reportes_Contables_Detalle> co_Reportes_Contables_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Reportes_Contables_Importes> co_Reportes_Contables_Importes { get; set; }
    }
}
