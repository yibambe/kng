namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orden_Compras_Factura_Multiple
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Persona_Proveedor { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string Numero_Factura { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Moneda { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal TC { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime Fecha_Vencimiento { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Concepto { get; set; }

        [StringLength(50)]
        public string Referencia { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte Prorrateo { get; set; }

        public int? Tipo { get; set; }

        public int? Clas_Gasto { get; set; }

        [StringLength(50)]
        public string UUID { get; set; }

        public int? CXP { get; set; }

        public byte? Estatus { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        public byte? Contabilizada { get; set; }

        public int? Familia_Moneda { get; set; }
    }
}
