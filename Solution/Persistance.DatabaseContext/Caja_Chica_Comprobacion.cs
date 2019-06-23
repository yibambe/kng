namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Chica_Comprobacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Egreso { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(100)]
        public string Folio { get; set; }

        [StringLength(500)]
        public string Proveedor { get; set; }

        public int? Num_Proveedor { get; set; }

        public decimal Importe { get; set; }

        public int Clas_Iva { get; set; }

        public decimal Iva { get; set; }

        public int Clas_Estatus { get; set; }

        public int Contabilizado { get; set; }

        public int Num_Concepto { get; set; }

        public int Clas_Concepto { get; set; }

        public int Usuario { get; set; }

        public int Familia_Iva { get; set; }

        public int Padre_Iva { get; set; }

        public int Familia_Estatus { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Usuario Usuario1 { get; set; }
    }
}
