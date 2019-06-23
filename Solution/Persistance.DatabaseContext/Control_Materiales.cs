namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Control_Materiales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Control_Materiales()
        {
            Control_Materiales_Recibe = new HashSet<Control_Materiales_Recibe>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Control { get; set; }

        public int Numero_Producto { get; set; }

        public int Familia_Producto { get; set; }

        public int Numero_Receta { get; set; }

        public int Numero_Proceso { get; set; }

        public int Familia_Proceso { get; set; }

        public int? Numero_Entrega { get; set; }

        public int? Familia_Entrega { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Receta Receta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control_Materiales_Recibe> Control_Materiales_Recibe { get; set; }
    }
}
