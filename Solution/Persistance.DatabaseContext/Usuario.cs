namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_persona { get; set; }

        [StringLength(8)]
        public string Contraseña { get; set; }

        public int? Estatus { get; set; }

        public short? Intentos_fallidos { get; set; }

        public int? Ultima_transaccion { get; set; }

        public DateTime? Hora_Entrada { get; set; }

        public DateTime? Hora_Salida { get; set; }

        public int? EnLinea { get; set; }

        public byte? Idioma { get; set; }

        public int? Clas_Sucursal { get; set; }

        public int? Familia { get; set; }
    }
}
