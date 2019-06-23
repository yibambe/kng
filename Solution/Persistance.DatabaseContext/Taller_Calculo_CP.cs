namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Taller_Calculo_CP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Taller_Calculo_CP()
        {
            Taller_Calculo_CP_Detalle = new HashSet<Taller_Calculo_CP_Detalle>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Secuencia_Valor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Valor { get; set; }

        public int Familia { get; set; }

        public int Calculado { get; set; }

        public int? chk_Real { get; set; }

        public int? Numero_Usuario { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taller_Calculo_CP_Detalle> Taller_Calculo_CP_Detalle { get; set; }
    }
}
