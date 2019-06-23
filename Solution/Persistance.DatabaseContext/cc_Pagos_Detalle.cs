namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cc_Pagos_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Pago { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_CC { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        public decimal Importe { get; set; }

        public int? Registro_Factura { get; set; }

        public virtual cc_Pagos cc_Pagos { get; set; }

        public virtual Cuentas_Cobrar Cuentas_Cobrar { get; set; }
    }
}
