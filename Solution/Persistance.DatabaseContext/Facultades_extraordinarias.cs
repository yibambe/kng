namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Facultades_extraordinarias
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_persona { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_programa { get; set; }

        [StringLength(1)]
        public string Signo { get; set; }

        [StringLength(1)]
        public string Alta { get; set; }

        [StringLength(1)]
        public string Modificacion { get; set; }

        [StringLength(1)]
        public string Baja { get; set; }

        public short? Facultad_Extra { get; set; }

        [StringLength(1)]
        public string Autoriza { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Programa Programa { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
