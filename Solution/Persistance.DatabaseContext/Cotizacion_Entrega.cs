namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cotizacion_Entrega
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cotizacion { get; set; }

        public int? Clas_Prioridad { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Fecha_Entrega { get; set; }

        public int? Numero_Domicilio { get; set; }

        public DateTime? Hora_Entrega_Ini { get; set; }

        public DateTime? Hora_Entrega_Fin { get; set; }

        public int? Persona_Contacto { get; set; }

        [StringLength(2500)]
        public string Observaciones { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Prioridad { get; set; }

        public DateTime? Fecha_Devolucion { get; set; }

        public int? Ocurre { get; set; }

        public int? Numero_Transportista { get; set; }

        [StringLength(50)]
        public string Num_Guia { get; set; }

        [StringLength(200)]
        public string Destino { get; set; }

        [StringLength(50)]
        public string Peso { get; set; }

        [StringLength(100)]
        public string Medida { get; set; }
    }
}
