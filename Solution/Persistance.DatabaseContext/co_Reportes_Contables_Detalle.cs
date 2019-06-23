namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class co_Reportes_Contables_Detalle
    {
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

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Detalle { get; set; }

        public int Tipo_Dato_Detalle { get; set; }

        public int? Clas_Numero_Detalle { get; set; }

        public int? Familia_Numero_Detalle { get; set; }

        public int X_Detalle { get; set; }

        public int Y_Detalle { get; set; }

        [StringLength(1)]
        public string Operador { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual co_Reportes_Contables co_Reportes_Contables { get; set; }

        public virtual co_Reportes_Contables_Registros co_Reportes_Contables_Registros { get; set; }
    }
}
