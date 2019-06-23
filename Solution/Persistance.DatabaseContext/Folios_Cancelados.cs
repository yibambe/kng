namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Folios_Cancelados
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Clas_Tipo_Documento { get; set; }

        [Required]
        [StringLength(10)]
        public string Tipo_Factura_Relacion { get; set; }

        public int Numero_Documento_Anterior { get; set; }

        public int? Numero_Documento_Actual { get; set; }

        public int? Tipo_Tabla { get; set; }

        public int Usuario { get; set; }

        [Required]
        [StringLength(3000)]
        public string Comentario { get; set; }

        public DateTime Fecha { get; set; }

        public int Familia { get; set; }
    }
}
