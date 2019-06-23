namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activo_Fijo_Alta
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Clas_Concepto { get; set; }

        public byte Unidad { get; set; }

        public int Cantidad { get; set; }

        public DateTime Fecha_Adquisicion { get; set; }

        public int Persona_Proveedor { get; set; }

        public int Clas_Moneda { get; set; }

        [Required]
        [StringLength(50)]
        public string Factura { get; set; }

        public decimal Monto { get; set; }

        public byte Depresiacion { get; set; }

        public byte Generacion_Reg { get; set; }

        public decimal Tipo_Cambio { get; set; }

        public DateTime Fecha_Inicio { get; set; }

        public byte Fin_Depresiacion { get; set; }

        public int Familia_Concepto { get; set; }

        public int Familia_Moneda { get; set; }
    }
}
