namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConceptoTMP")]
    public partial class ConceptoTMP
    {
        public int? Numero_empresa { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int? Numero_programa { get; set; }

        [StringLength(20)]
        public string Etiqueta_Importe1 { get; set; }

        [StringLength(20)]
        public string Etiqueta_Importe2 { get; set; }

        [StringLength(20)]
        public string Etiqueta_Importe3 { get; set; }

        [StringLength(20)]
        public string Etiqueta_Importe4 { get; set; }

        [StringLength(20)]
        public string Etiqueta_Importe5 { get; set; }

        [StringLength(20)]
        public string Etiqueta_Importe6 { get; set; }

        [StringLength(20)]
        public string Etiqueta_Importe7 { get; set; }

        [StringLength(20)]
        public string Etiqueta_Importe8 { get; set; }

        [StringLength(20)]
        public string Etiqueta_Importe9 { get; set; }

        [StringLength(20)]
        public string Etiqueta_Importe10 { get; set; }
    }
}
