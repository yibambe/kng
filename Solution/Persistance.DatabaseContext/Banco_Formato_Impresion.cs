namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Banco_Formato_Impresion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Numero_Banco { get; set; }

        [Required]
        [StringLength(200)]
        public string Campo { get; set; }

        public int Linea { get; set; }

        public int Columna { get; set; }

        public int Longitud { get; set; }

        public virtual Banco Banco { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
