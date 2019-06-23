namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Auxiliar_Bitacora
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int Numero_Empresa { get; set; }

        [Required]
        [StringLength(25)]
        public string Programa { get; set; }

        public double Tabs { get; set; }

        [StringLength(1000)]
        public string Comentario { get; set; }

        [Required]
        [StringLength(100)]
        public string Accion { get; set; }
    }
}
