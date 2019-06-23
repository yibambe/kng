namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Condiciones_Financieras
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cliente_Persona { get; set; }

        public int? Clasificacion_Cliente { get; set; }

        public int? Numero_Persona_Vendedor { get; set; }

        public int? Dias_Plazo { get; set; }

        public int? Clasificacion_Frecuencia { get; set; }

        public decimal? Limite_Credito { get; set; }

        public int? Tasa_Interes { get; set; }

        public int? Tasa_Interes_Moratorio { get; set; }

        public int? Domicilio_Entrega { get; set; }

        public int? Forma_Pago_Clasificacion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
