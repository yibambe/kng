namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cotizacion_Detalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cotizacion_Detalle()
        {
            Cotizacion_Detalle_Almacen = new HashSet<Cotizacion_Detalle_Almacen>();
            Cotizacion_Detalle_Impuesto = new HashSet<Cotizacion_Detalle_Impuesto>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cotiza { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Producto { get; set; }

        public int Tipo_Concepto { get; set; }

        public int Concepto { get; set; }

        public decimal? Alto { get; set; }

        public decimal? Ancho { get; set; }

        public decimal Cantidad { get; set; }

        public decimal? Precio { get; set; }

        public decimal? Hasta { get; set; }

        public decimal? Importe { get; set; }

        [StringLength(100)]
        public string Seccion { get; set; }

        public bool Aceptado { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Orden { get; set; }

        public short? Activo { get; set; }

        public int? Estatus_Orden { get; set; }

        public DateTime? Fecha { get; set; }

        public short? Familia_Producto_Tipo_Concepto_Concepto { get; set; }

        public short? Familia_Estatus_Orden { get; set; }

        public int? Unidad_Medida { get; set; }

        public decimal? Cantidad_Unidad_Medida { get; set; }

        public int? Familia_Unidad_Medida { get; set; }

        public decimal? Cantidad_Entregada { get; set; }

        [StringLength(4000)]
        public string Caracteristicas { get; set; }

        public DateTime? Fecha_Entrega_Partida { get; set; }

        public decimal? Cantidad_Facturada { get; set; }

        public int? Clas_Zona { get; set; }

        public decimal? Costo_Referencia { get; set; }

        public decimal? Costo_Proveedor { get; set; }

        public decimal? Precio_Lista_Costo { get; set; }

        public decimal? Peso { get; set; }

        public decimal? Precio_Lista { get; set; }

        public byte? Factura_Libre { get; set; }

        public decimal? Precio_Estilo { get; set; }

        public virtual Cotizacion Cotizacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Detalle_Almacen> Cotizacion_Detalle_Almacen { get; set; }

        public virtual Empresa Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Detalle_Impuesto> Cotizacion_Detalle_Impuesto { get; set; }
    }
}
