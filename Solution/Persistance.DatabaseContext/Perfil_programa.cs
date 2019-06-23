namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Perfil_programa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_perfil { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_programa { get; set; }

        [StringLength(1)]
        public string Alta { get; set; }

        [StringLength(1)]
        public string Modificacion { get; set; }

        [StringLength(1)]
        public string Baja { get; set; }

        [StringLength(1)]
        public string Autoriza { get; set; }

        public virtual Perfil Perfil { get; set; }

        public virtual Programa Programa { get; set; }
    }
}
