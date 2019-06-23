namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cotizacion_Simple
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Estatus { get; set; }

        public DateTime? Fecha { get; set; }

        public int Numero_Cliente { get; set; }

        public int? Numero_Usuario { get; set; }

        public int? Numero_Responsable { get; set; }

        [StringLength(100)]
        public string Nombre_Proyecto { get; set; }

        public int Moneda { get; set; }

        public DateTime? Fecha_Entrega { get; set; }

        public int? Numero_Contacto { get; set; }

        [StringLength(4000)]
        public string Observaciones { get; set; }

        public int Numero_Pago { get; set; }

        public int Clas_Periodo_Pago { get; set; }

        public short Comision_Calculada { get; set; }

        public int? Tipo_Documento { get; set; }

        public DateTime Fecha_Vencimiento { get; set; }

        public int Clas_IVA { get; set; }

        public short? Familia_Estatus { get; set; }

        public short? Familia_Moneda { get; set; }

        public short? Familia_Clas_Periodo_Pago { get; set; }

        public short? Familia_Tipo_Documento { get; set; }

        public int? Relacion_Tipo_Documento { get; set; }

        public int? Moneda_Factura { get; set; }

        [StringLength(4000)]
        public string Observaciones2 { get; set; }

        public int? Autoriza { get; set; }

        public int? Concepto_Apartado { get; set; }

        public int? Num_Concepto { get; set; }

        [StringLength(30)]
        public string Num_Referencia { get; set; }

        public int? Numero_Domicilio { get; set; }

        public int? Clas_Almacen { get; set; }

        public byte? Credito { get; set; }

        public int? Ciclo_Facturacion { get; set; }

        public int? Clas_Sucursal { get; set; }

        public int? Familia_Sucursal { get; set; }

        public byte? chkContado { get; set; }

        public byte? Entrega_Directa { get; set; }

        public int? Lista_Precio { get; set; }

        public int? Lista_Precio_Real { get; set; }

        public int? Clas_Dato_Pago { get; set; }

        [StringLength(20)]
        public string Dato_Pago { get; set; }

        public int? Familia_Clas_Dato_Pago { get; set; }

        public byte? chkTransporte { get; set; }

        public byte? Total_Transporte { get; set; }

        public int? FolioSucursal { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Persona Persona1 { get; set; }

        public virtual Persona Persona2 { get; set; }
    }
}
