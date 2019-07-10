namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Persona")]
    public partial class Persona
    {
        public int? Numero_Empresa { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(300)]
        public string Nombre_Completo { get; set; }

        [StringLength(100)]
        public string Paterno { get; set; }

        [StringLength(100)]
        public string Materno { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(25)]
        public string Nombre_Corto { get; set; }

        [StringLength(18)]
        public string RFC { get; set; }

        [StringLength(18)]
        public string CURP { get; set; }

        [StringLength(64)]
        public string Telefono { get; set; }

        [StringLength(64)]
        public string Fax { get; set; }

        [StringLength(64)]
        public string Celular { get; set; }

        [StringLength(64)]
        public string Radiolocalizador { get; set; }

        [StringLength(50)]
        public string correo_electronico { get; set; }

        [StringLength(1)]
        public string Personalidad_juridica { get; set; }

        public DateTime? Fecha_Nacimiento { get; set; }

        public DateTime? Fecha_Alta { get; set; }

        public DateTime? Fecha_Cambio { get; set; }

        [StringLength(100)]
        public string Numero_Confia { get; set; }

        public byte? General { get; set; }

        public byte? Transportista { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
