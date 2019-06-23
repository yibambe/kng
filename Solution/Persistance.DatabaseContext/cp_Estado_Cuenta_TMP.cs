namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cp_Estado_Cuenta_TMP
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
        public int Numero_Orden { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Proveedor { get; set; }

        [StringLength(250)]
        public string Nombre_Proveedor { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tipo_Persona { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Moneda { get; set; }

        [StringLength(50)]
        public string Des_Moneda { get; set; }

        public DateTime? Fecha_Aplicacion { get; set; }

        public DateTime? Fecha_Vencimiento { get; set; }

        public int? Numero_Concepto { get; set; }

        [StringLength(250)]
        public string Des_Concepto { get; set; }

        [StringLength(50)]
        public string Documento { get; set; }

        public decimal? Saldo_Inicial { get; set; }

        [StringLength(250)]
        public string Numero_Factura_Abono { get; set; }

        [StringLength(250)]
        public string Referencia_Texto { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public int? Moneda_Origen { get; set; }

        [StringLength(50)]
        public string Des_Moneda_Origen { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public decimal? Abono_Origen { get; set; }

        public decimal? Cargo { get; set; }

        public decimal? Abono { get; set; }

        public decimal? Saldo { get; set; }

        public decimal? Saldo_Reg { get; set; }
    }
}
