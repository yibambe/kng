namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CartaModeloTMP")]
    public partial class CartaModeloTMP
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

        [Column(TypeName = "text")]
        public string Seccion1 { get; set; }

        [Column(TypeName = "text")]
        public string Seccion2 { get; set; }

        [Column(TypeName = "text")]
        public string Seccion3 { get; set; }
    }
}
