namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Viaticos_Asignacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Numero_Viatico_Solicitud { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Persona_Solicitud { get; set; }

        public short Forma_Dotacion { get; set; }

        public decimal Importe { get; set; }

        public int? Numero_Caja { get; set; }

        public int? Numero_Banco { get; set; }

        public int? Numero_Cuenta { get; set; }

        public int? Documento { get; set; }

        public int? Clas_Concepto { get; set; }

        public int? Cont_Clas_Asignado { get; set; }

        public int Usuario { get; set; }

        public int? Numero_Registro_Externo { get; set; }

        public int Liquidado { get; set; }

        public int Familia { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(80)]
        public string Comentario { get; set; }

        public int? Estatus { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        [StringLength(1024)]
        public string Causa { get; set; }

        public int? Usuario_Cancela { get; set; }
    }
}
