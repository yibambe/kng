namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Gastos_Solicitud
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Persona_Solicitante { get; set; }

        public int Motivo { get; set; }

        public int Destino { get; set; }

        public DateTime Fecha_Solicitud { get; set; }

        public DateTime Fecha_Inicio_Viaje { get; set; }

        public DateTime Fecha_Fin_Viaje { get; set; }

        public DateTime Fecha_Comprobacion { get; set; }

        public decimal Importe { get; set; }

        public int? Persona_Autoriza { get; set; }

        public short Factura { get; set; }

        public int? Persona_Factura { get; set; }

        public short? Autorizada { get; set; }

        public int Familia { get; set; }

        [StringLength(2500)]
        public string Observaciones { get; set; }

        public int? Estatus { get; set; }

        public int? Moneda { get; set; }

        public int? Familia_Moneda { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        [StringLength(1024)]
        public string Causa { get; set; }

        public int? Usuario_Cancela { get; set; }
    }
}
