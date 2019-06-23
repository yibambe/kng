namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacen_Transferencias
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }

        public int Usuario { get; set; }

        public int Clas_Consepto { get; set; }

        public int Almacen_Solicitante { get; set; }

        public int Almacen_Requerido { get; set; }

        [StringLength(300)]
        public string Referencia { get; set; }

        [StringLength(500)]
        public string Observaciones { get; set; }

        public int Clas_Estatus { get; set; }

        public int? Moneda { get; set; }

        public int Familia { get; set; }

        public int Familia_Moneda { get; set; }

        public int? Transferencia_Automatica { get; set; }

        public int? Numero_Entrada { get; set; }

        public int? Numero_Salida { get; set; }

        public int? Estatus_Entrada { get; set; }

        public int? Estatus_Salida { get; set; }

        public int? Autoriza { get; set; }
    }
}
