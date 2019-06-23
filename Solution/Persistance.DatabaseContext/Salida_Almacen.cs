namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Salida_Almacen
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Almacen { get; set; }

        public DateTime Fecha_Salida { get; set; }

        public DateTime Hora_Salida { get; set; }

        public int Usuario { get; set; }

        public int Tipo_Entrada { get; set; }

        public int Numero_Tipo_Entrada { get; set; }

        public int? Prioridad { get; set; }

        public int? Tipo_Docto_Entrada { get; set; }

        [StringLength(50)]
        public string Numero_Docto_Entrada { get; set; }

        public DateTime? Fecha_Docto_Entrada { get; set; }

        [StringLength(150)]
        public string Anexo { get; set; }

        [StringLength(2500)]
        public string Observaciones { get; set; }

        public int Familia_Tipo_Docto_Almacen { get; set; }

        public int Familia_Prioridad { get; set; }

        public int Clas_Moneda { get; set; }

        public decimal Tipo_Cambio { get; set; }

        public int Familia_Moneda { get; set; }

        public int Contabilizado { get; set; }

        public int Estatus { get; set; }

        public int? Proveedor { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        [StringLength(250)]
        public string Causa { get; set; }

        public int? Externo { get; set; }

        public int? Facturada { get; set; }

        public int? Numero_Factura { get; set; }

        public int? Clas_Pantalla { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
