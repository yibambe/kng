namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sucursal")]
    public partial class Sucursal
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Sucursal { get; set; }

        public int Num_Domicilio { get; set; }

        public int? Clas_Tipo_Cliente { get; set; }

        public int? Forma_Pago { get; set; }

        public decimal? Comision { get; set; }

        public int? Lista_Precio { get; set; }

        public int? Persona_Contacto { get; set; }

        public int Familia_Sucursal { get; set; }

        public int Familia_Pais { get; set; }

        public int Familia_TCliente { get; set; }

        public int? Clas_Zona { get; set; }

        public int? Factura_Concepto { get; set; }

        public byte? Expedido_DF { get; set; }

        public int? Clas_Almacen_Sucursal { get; set; }

        public int? Familia_Almacen { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Domicilio Domicilio { get; set; }
    }
}
