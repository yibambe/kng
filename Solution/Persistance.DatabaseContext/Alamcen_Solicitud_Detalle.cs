namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Alamcen_Solicitud_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Solicitud { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Partida { get; set; }

        public short Estatus { get; set; }

        public int Clas_TCompra { get; set; }

        public int Clas_Compra { get; set; }

        public int Clas_TConcepto { get; set; }

        public int Clas_Concepto { get; set; }

        public int Clas_Unidad_Medida { get; set; }

        public decimal Cantidad { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero_Parte { get; set; }

        [StringLength(500)]
        public string Caracteristicas { get; set; }

        [StringLength(500)]
        public string Observaciones { get; set; }

        public byte Tipo_Conceptos { get; set; }

        public int Familia_Conceptos { get; set; }

        public int Familia_Unidad_medida { get; set; }
    }
}
