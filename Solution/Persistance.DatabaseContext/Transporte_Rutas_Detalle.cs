namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transporte_Rutas_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Transporte_Rutas { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Partida { get; set; }

        public int Numero_Cotiza { get; set; }

        public int Numero_Factura { get; set; }

        public int Partida_Factura { get; set; }

        public int Clas_Almacen { get; set; }

        public decimal Cantidad { get; set; }

        public int Numero_Horario { get; set; }

        public decimal? Cantidad_Entregada { get; set; }

        public int Familia_Almacen { get; set; }

        public virtual Empresa_Horarios Empresa_Horarios { get; set; }

        public virtual Transporte_Rutas Transporte_Rutas { get; set; }
    }
}
