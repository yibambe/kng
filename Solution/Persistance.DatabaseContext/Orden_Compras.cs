namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orden_Compras
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
        public byte Tipo1 { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Estatus { get; set; }

        public int? Numero_SC { get; set; }

        public int? Forma_Pago { get; set; }

        public int? Moneda { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Comision { get; set; }

        public int? IVA { get; set; }

        [StringLength(4000)]
        public string Observaciones { get; set; }

        public DateTime? Fecha_Entrega { get; set; }

        public DateTime? Hora_De { get; set; }

        public DateTime? Hora_Hasta { get; set; }

        public int? Domicilio { get; set; }

        public int? Persona { get; set; }

        [StringLength(64)]
        public string Telefono { get; set; }

        public int? Cant_Forma_Pago { get; set; }

        public int? Numero_Proveedor { get; set; }

        [StringLength(250)]
        public string Contacto { get; set; }

        public int? Responsable { get; set; }

        public int? Persona_Autoriza { get; set; }

        public int? Clas_Almacen { get; set; }

        public int? Persona_Rechaza { get; set; }

        [StringLength(250)]
        public string Causa { get; set; }

        public int? TerminosEntrega { get; set; }

        public short? Familia { get; set; }

        public short? Familia_Moneda { get; set; }

        public short? Familia_IVA { get; set; }

        public short? Familia_Almacen { get; set; }

        public int? Estatus_Inventario { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public decimal? Otros_Impuestos { get; set; }

        public decimal? Subtotal { get; set; }

        public decimal? Total { get; set; }
    }
}
