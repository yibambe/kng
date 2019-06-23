namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClasificacionTMP")]
    public partial class ClasificacionTMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia { get; set; }

        [StringLength(15)]
        public string Clave1 { get; set; }

        [StringLength(80)]
        public string Descripcion1 { get; set; }

        [StringLength(15)]
        public string Clave2 { get; set; }

        [StringLength(80)]
        public string Descripcion2 { get; set; }

        [StringLength(15)]
        public string Clave3 { get; set; }

        [StringLength(80)]
        public string Descripcion3 { get; set; }

        [StringLength(15)]
        public string Clave4 { get; set; }

        [StringLength(80)]
        public string Descripcion4 { get; set; }

        [StringLength(15)]
        public string Clave5 { get; set; }

        [StringLength(80)]
        public string Descripcion5 { get; set; }

        [StringLength(15)]
        public string Clave6 { get; set; }

        [StringLength(80)]
        public string Descripcion6 { get; set; }

        [StringLength(15)]
        public string Clave7 { get; set; }

        [StringLength(80)]
        public string Descripcion7 { get; set; }

        [StringLength(15)]
        public string Clave8 { get; set; }

        [StringLength(80)]
        public string Descripcion8 { get; set; }

        [StringLength(15)]
        public string Clave9 { get; set; }

        [StringLength(80)]
        public string Descripcion9 { get; set; }

        [StringLength(135)]
        public string Clave { get; set; }

        [StringLength(120)]
        public string Clave_Padre { get; set; }

        [StringLength(80)]
        public string Descripcion { get; set; }

        public int? Nivel { get; set; }

        public bool? Terminal { get; set; }

        public int? Numero_Padre { get; set; }

        public short? Clave_Edicion { get; set; }
    }
}
