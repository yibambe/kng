namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Venta_Caja_Apertura
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Clas_Sucursal { get; set; }

        public int Clas_Caja { get; set; }

        public int Numero_Cajero { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }

        public byte Estatus { get; set; }

        public int? Usuario_Cancela { get; set; }

        [StringLength(250)]
        public string Causa { get; set; }

        public int? Cerrada { get; set; }

        public int Familia_Sucursal { get; set; }

        public int Familia_Caja { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
