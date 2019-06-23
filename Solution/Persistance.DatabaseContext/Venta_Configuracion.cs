namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Venta_Configuracion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public byte? Salida_Automatica { get; set; }

        public byte? Valida_Costo_Referencia { get; set; }

        public int? Dias_Plazo_Factura { get; set; }

        public byte? Aut_Venta_Credito { get; set; }

        public byte? Solo_Prod_Lista { get; set; }

        public byte? Cancelacion_Automatica_Cot { get; set; }

        public byte? Cancel_Fac_Estatus_Cotiza { get; set; }

        public decimal? Diferencia_Mimina_Margen { get; set; }

        public decimal? Peso_Max { get; set; }

        public DateTime? Hora_Max_Entrega { get; set; }

        public DateTime? Hora_Sab_Entrega { get; set; }

        public byte ESTATUS_CFDI_SAT { get; set; }

        public int? Concepto_Contable_NC { get; set; }

        public int? Familia_NC { get; set; }
    }
}
