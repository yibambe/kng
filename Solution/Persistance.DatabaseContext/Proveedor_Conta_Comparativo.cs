namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedor_Conta_Comparativo
    {
        public int? Numero_Empresa { get; set; }

        public int? Numero_Usuario { get; set; }

        public int? Numero_Proveedor { get; set; }

        [StringLength(1000)]
        public string Nombre_Completo { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(100)]
        public string Documento { get; set; }

        [StringLength(50)]
        public string Tipo { get; set; }

        public byte? Contabilizada { get; set; }

        public int? Estatus { get; set; }

        public int? Numero_Poliza { get; set; }

        [StringLength(1000)]
        public string Concepto { get; set; }

        public decimal? Importe { get; set; }

        [StringLength(50)]
        public string Folio_Fiscal { get; set; }

        [Key]
        public int Tipo_M { get; set; }

        public int? Numero_Referencia { get; set; }
    }
}
