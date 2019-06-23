namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Empresa_Logo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [StringLength(250)]
        public string Ruta { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo_jpg { get; set; }
    }
}
