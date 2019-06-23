namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Cobrar_Antiguedad_Cadena
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
        public int Numero_Usuario { get; set; }

        public decimal Saldo { get; set; }

        public int Numero_Cliente { get; set; }

        [StringLength(300)]
        public string Nombre_Cliente { get; set; }

        public int? Tipo_Cliente { get; set; }

        [StringLength(100)]
        public string Nombre_Tipo { get; set; }

        public int? Numero_Cadena { get; set; }

        [StringLength(300)]
        public string Nombre_Cadena { get; set; }

        public int? Numero_Vendedor { get; set; }

        [StringLength(300)]
        public string Nombre_Vendedor { get; set; }

        public int Moneda { get; set; }

        [StringLength(100)]
        public string Nombre_Moneda { get; set; }

        [StringLength(50)]
        public string Documento { get; set; }

        public DateTime Fecha_Aplicacion { get; set; }

        public DateTime Fecha_Vencimiento { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        [StringLength(100)]
        public string Caso { get; set; }
    }
}
