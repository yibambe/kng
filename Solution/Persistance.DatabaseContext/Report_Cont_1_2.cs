namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Report_Cont_1_2
    {
        public int ID { get; set; }

        public int? Numero_Empresa { get; set; }

        public int? Numero_Reporte { get; set; }

        public int? Tipo { get; set; }

        public int? X_1 { get; set; }

        public int? Y_1 { get; set; }

        public byte? ali_1 { get; set; }

        public byte? tip_1 { get; set; }

        [StringLength(150)]
        public string cam_1 { get; set; }

        public int? X_2 { get; set; }

        public int? Y_2 { get; set; }

        public byte? ali_2 { get; set; }

        public byte? tip_2 { get; set; }

        [StringLength(150)]
        public string cam_2 { get; set; }

        public int? X_3 { get; set; }

        public int? Y_3 { get; set; }

        public byte? ali_3 { get; set; }

        public byte? tip_3 { get; set; }

        [StringLength(150)]
        public string cam_3 { get; set; }

        public int? X_4 { get; set; }

        public int? Y_4 { get; set; }

        public byte? ali_4 { get; set; }

        public byte? tip_4 { get; set; }

        [StringLength(150)]
        public string cam_4 { get; set; }

        public int? X_5 { get; set; }

        public int? Y_5 { get; set; }

        public byte? ali_5 { get; set; }

        public byte? tip_5 { get; set; }

        [StringLength(150)]
        public string cam_5 { get; set; }
    }
}
