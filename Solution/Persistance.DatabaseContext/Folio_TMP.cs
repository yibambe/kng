namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Folio_TMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Tipo_Docto { get; set; }

        public int? Clas_Moneda { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Folio { get; set; }

        public int? Numero { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Tipo_Docto { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Moneda { get; set; }

        public int? Facturadoras { get; set; }

        public int? Validadoras { get; set; }

        public byte? Docto_Internet { get; set; }

        [StringLength(10)]
        public string Prefijo { get; set; }

        public byte? CRP { get; set; }
    }
}
