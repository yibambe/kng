namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Folio_Relacion_Docto_FE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLas_Tipo_Docto { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Serie { get; set; }

        [Required]
        [StringLength(2500)]
        public string Ruta_Key { get; set; }

        [Required]
        [StringLength(50)]
        public string Contraseña_Key { get; set; }

        [Required]
        [StringLength(2500)]
        public string Ruta_Cer { get; set; }

        public int? Año_Aprobacion { get; set; }

        [StringLength(50)]
        public string Num_Aprobacion { get; set; }

        [StringLength(250)]
        public string Ruta_Logo { get; set; }

        [StringLength(250)]
        public string Ruta_Almacenamiento { get; set; }

        public int? Folio_Fin { get; set; }

        public DateTime? fecha_hasta { get; set; }
    }
}
