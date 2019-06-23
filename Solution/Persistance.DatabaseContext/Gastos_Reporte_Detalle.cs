namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Gastos_Reporte_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Gastos_Reporte { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public byte Tipo { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(25)]
        public string Folio { get; set; }

        [Required]
        [StringLength(1024)]
        public string Proveedor { get; set; }

        public int Clas_Concepto { get; set; }

        public decimal Importe { get; set; }

        public decimal? IVA { get; set; }

        public decimal? Propina { get; set; }

        public decimal? Hospedaje { get; set; }

        public int Familia_Concepto { get; set; }
    }
}
