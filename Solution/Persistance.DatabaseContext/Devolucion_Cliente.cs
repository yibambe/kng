namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Devolucion_Cliente
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha { get; set; }

        public int Estatus { get; set; }

        public int Numero_Cliente { get; set; }

        public int Clas_Concepto { get; set; }

        public int Numero_Almacen { get; set; }

        public int? Clas_Causa { get; set; }

        public int Clas_Moneda { get; set; }

        public int? Numero_Factura { get; set; }

        public int? Folio { get; set; }

        public int Clas_Iva { get; set; }

        public decimal Tipo_Cambio { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Iva { get; set; }

        public decimal Total { get; set; }

        public int Tipo_Devolucion { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        public int Numero_Usuario { get; set; }

        public int Familia_Concepto_Causa { get; set; }

        public int Familia_Almacen { get; set; }

        public int Familia_Moneda { get; set; }

        public int Familia_Iva { get; set; }

        public int? Tipo_Docto_Entrada { get; set; }

        public int? Nota_Credito { get; set; }

        public int? Movimiento_Bancario { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Cancelacion { get; set; }

        [StringLength(250)]
        public string Causa_Cancelacion { get; set; }

        public byte? Relacion_Factura { get; set; }

        public int? Clas_Sucursal { get; set; }

        public int? Tipo_Compensacion { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Clasificacion Clasificacion3 { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Factura Factura { get; set; }

        public virtual Persona Persona1 { get; set; }
    }
}
