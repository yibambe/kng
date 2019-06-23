namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Viaticos_Justificacion_Rpt
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Viatico_Adeudo { get; set; }

        public int? Clas_Concepto { get; set; }

        [StringLength(50)]
        public string Comprobante { get; set; }

        public DateTime? Fecha_Liquidacion { get; set; }

        public decimal? Importe_Liquidacion { get; set; }

        [StringLength(100)]
        public string Descripcion_Liquidacion { get; set; }

        public int? Num_Banco { get; set; }

        public int? Num_Cuenta { get; set; }

        [StringLength(50)]
        public string Folio { get; set; }

        public int? Concepto_Devolucion { get; set; }

        public decimal? Importe_Devolucion { get; set; }

        public DateTime? Fecha_Devolucion { get; set; }

        [StringLength(100)]
        public string Descripcion_Devolucion { get; set; }

        public short? liquidacion_Devolucion { get; set; }

        public int? Familia { get; set; }
    }
}
