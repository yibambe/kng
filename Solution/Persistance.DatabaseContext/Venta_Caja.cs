namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Venta_Caja
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

        public int Estatus { get; set; }

        public int? Numero_Cliente { get; set; }

        public int Moneda { get; set; }

        [StringLength(2000)]
        public string Observaciones { get; set; }

        public int? Numero_Contacto { get; set; }

        public int Clas_IVA { get; set; }

        public int? Usuario_Cancela { get; set; }

        [StringLength(250)]
        public string Causa { get; set; }

        public int? Apertura { get; set; }

        public int? Cierre { get; set; }

        public int? Numero_Factura { get; set; }

        public int Familia_Sucursal { get; set; }

        public int Familia { get; set; }

        public int? Familia_Moneda { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Clasificacion Clasificacion3 { get; set; }

        public virtual Clasificacion Clasificacion4 { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Persona Persona1 { get; set; }

        public virtual Persona Persona2 { get; set; }

        public virtual Persona Persona3 { get; set; }
    }
}
