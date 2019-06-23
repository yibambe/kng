namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cotizacion_MatRecibido
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cotizacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Tipo { get; set; }

        [StringLength(10)]
        public string Cantidad { get; set; }

        [StringLength(250)]
        public string Comentarios { get; set; }

        public int? Muestra { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(250)]
        public string Programa { get; set; }

        [StringLength(250)]
        public string Version { get; set; }

        public int? Tipo { get; set; }

        public int? Numero_Orden { get; set; }

        public short? Familia_Clas_Tipo_Tipo { get; set; }

        public virtual Cotizacion Cotizacion { get; set; }
    }
}
