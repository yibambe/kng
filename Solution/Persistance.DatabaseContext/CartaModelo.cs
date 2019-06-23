namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CartaModelo")]
    public partial class CartaModelo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tipo { get; set; }

        [StringLength(128)]
        public string Nombre { get; set; }

        [StringLength(8000)]
        public string Seccion1 { get; set; }

        [StringLength(8000)]
        public string Seccion2 { get; set; }

        [StringLength(8000)]
        public string Seccion3 { get; set; }
    }
}
