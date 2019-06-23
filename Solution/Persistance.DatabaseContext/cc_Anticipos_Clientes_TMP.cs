namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cc_Anticipos_Clientes_TMP
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
        public int Numero { get; set; }

        public int? Numero_Referencia { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cliente { get; set; }

        [StringLength(250)]
        public string Nombre_Completo { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Moneda { get; set; }

        [StringLength(50)]
        public string Des_Moneda { get; set; }

        public DateTime? Fecha_Registro { get; set; }

        [StringLength(50)]
        public string Documento { get; set; }

        public decimal? Monto { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Iva { get; set; }

        [StringLength(50)]
        public string Des_Iva { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        public DateTime? Fecha_Aplicacion { get; set; }

        public decimal? Abono { get; set; }

        public decimal? Saldo { get; set; }
    }
}
