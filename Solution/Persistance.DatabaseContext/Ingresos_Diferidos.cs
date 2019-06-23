namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingresos_Diferidos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Numero_Cliente { get; set; }

        public int? Numero_Factura { get; set; }

        [StringLength(30)]
        public string Documento { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Numero_Referencia { get; set; }

        public short? Numero_Pago { get; set; }

        public int? Moneda { get; set; }

        public decimal? Monto { get; set; }

        public decimal? Cargo { get; set; }

        public decimal? Abono { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        [StringLength(250)]
        public string Caracteristicas { get; set; }

        [StringLength(30)]
        public string Num_Contrato { get; set; }

        public short? Meses { get; set; }

        public DateTime? Fecha_Inicio { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        [StringLength(30)]
        public string Num_Serie { get; set; }

        [StringLength(30)]
        public string Site_ID { get; set; }

        public int? Clas_Ingresos1 { get; set; }

        public int? Clas_Ingresos2 { get; set; }

        public int? Poliza_Meses_Ant { get; set; }

        public byte? Poliza_Cierre_Mes { get; set; }

        public int? Usuario { get; set; }

        public DateTime? Fecha_Alta { get; set; }

        public DateTime? Fecha_Modifica { get; set; }

        public byte? Estatus { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        public byte? Familia { get; set; }

        public byte? Familia_Moneda { get; set; }
    }
}
