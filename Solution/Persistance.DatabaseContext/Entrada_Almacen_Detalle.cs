namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entrada_Almacen_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Entrada { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Almacen { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Partida { get; set; }

        public int Clas_TProducto { get; set; }

        public int Clas_Producto { get; set; }

        public int Clas_TConcepto { get; set; }

        public int Concepto { get; set; }

        public decimal Cantidad_Recibida { get; set; }

        public int Unidad_Recibida { get; set; }

        public int Clas_Ubicacion { get; set; }

        public int Clas_Tipo_Inventario { get; set; }

        public int Familia { get; set; }

        [StringLength(100)]
        public string Lote { get; set; }

        public decimal? Cantidad_Entregada { get; set; }

        public decimal? Cantidad_Facturada { get; set; }

        public decimal? Costo { get; set; }

        public int Familia_Inventario { get; set; }

        public int Familia_UM { get; set; }

        public int Clas_moneda { get; set; }

        public decimal Tipo_Cambio { get; set; }

        public int Familia_Moneda { get; set; }

        public byte? Estatus { get; set; }

        [StringLength(50)]
        public string Parte { get; set; }

        public byte? Detallado { get; set; }

        public decimal? Cantidad_Apartada { get; set; }

        [StringLength(4000)]
        public string Referencia { get; set; }

        [StringLength(250)]
        public string Des_Articulo_Nuevo { get; set; }

        public DateTime? Fecha_Caducidad { get; set; }

        public int? Completado { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Secuencia { get; set; }

        public decimal? Cantidad_Recibida_Base { get; set; }

        public decimal? Cantidad_Entregada_Base { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Clasificacion Clasificacion3 { get; set; }

        public virtual Clasificacion Clasificacion4 { get; set; }

        public virtual Clasificacion Clasificacion5 { get; set; }
    }
}