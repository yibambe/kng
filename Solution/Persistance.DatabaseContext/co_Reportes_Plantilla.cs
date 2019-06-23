namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class co_Reportes_Plantilla
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Persona { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Reporte { get; set; }

        public byte? ali_1 { get; set; }

        public byte? tip_1 { get; set; }

        [StringLength(150)]
        public string cam_1 { get; set; }

        public byte? ali_2 { get; set; }

        public byte? tip_2 { get; set; }

        [StringLength(150)]
        public string cam_2 { get; set; }

        public byte? ali_3 { get; set; }

        public byte? tip_3 { get; set; }

        [StringLength(150)]
        public string cam_3 { get; set; }

        public byte? ali_4 { get; set; }

        public byte? tip_4 { get; set; }

        [StringLength(150)]
        public string cam_4 { get; set; }

        public byte? ali_5 { get; set; }

        public byte? tip_5 { get; set; }

        [StringLength(150)]
        public string cam_5 { get; set; }

        public byte? ali_6 { get; set; }

        public byte? tip_6 { get; set; }

        [StringLength(150)]
        public string cam_6 { get; set; }

        public byte? ali_7 { get; set; }

        public byte? tip_7 { get; set; }

        [StringLength(150)]
        public string cam_7 { get; set; }

        public byte? ali_8 { get; set; }

        public byte? tip_8 { get; set; }

        [StringLength(150)]
        public string cam_8 { get; set; }

        public byte? ali_9 { get; set; }

        public byte? tip_9 { get; set; }

        [StringLength(150)]
        public string cam_9 { get; set; }

        public byte? ali_10 { get; set; }

        public byte? tip_10 { get; set; }

        [StringLength(150)]
        public string cam_10 { get; set; }
    }
}
