namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Alamcen_Solicitud
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public DateTime Fecha { get; set; }

        public int Clas_Estatus { get; set; }

        public int Solicitante { get; set; }

        public int Clas_Depto { get; set; }

        public int Clas_Puesto { get; set; }

        public int Clas_Seccion { get; set; }

        public int? Persona_Autoriza { get; set; }

        public int Familia_Estatus { get; set; }

        public int Familia_Depto { get; set; }

        public int Clas_Almacen { get; set; }

        public int Tipo_Solicitud { get; set; }

        public int? Clas_Moneda { get; set; }

        public int Familia_Almacen { get; set; }

        public int? Familia_Moneda { get; set; }

        public byte? Tipo { get; set; }
    }
}
