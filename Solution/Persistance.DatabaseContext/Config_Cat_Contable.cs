namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Config_Cat_Contable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int? Numero_Niveles { get; set; }

        public int? Digitos_Nivel1 { get; set; }

        public int? Digitos_Nivel2 { get; set; }

        public int? Digitos_Nivel3 { get; set; }

        public int? Digitos_Nivel4 { get; set; }

        public int? Digitos_Nivel5 { get; set; }

        public int? Digitos_Nivel6 { get; set; }

        public int? Digitos_Nivel7 { get; set; }

        public int? Digitos_Nivel8 { get; set; }

        public int? Digitos_Nivel9 { get; set; }
    }
}
