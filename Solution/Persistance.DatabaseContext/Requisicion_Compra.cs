namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Requisicion_Compra
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Estatus { get; set; }

        public int? Numero_Persona { get; set; }

        public int? Departamento { get; set; }

        public int? Seccion { get; set; }

        public int? Puesto { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte Tipo1 { get; set; }

        public int? Centro_Costo { get; set; }

        public int? Responsable { get; set; }

        public int? Persona_Autoriza { get; set; }

        public int? Persona_Rechaza { get; set; }

        [StringLength(250)]
        public string Causa { get; set; }

        [StringLength(150)]
        public string Entrega_Requerida { get; set; }

        [StringLength(500)]
        public string Observaciones { get; set; }

        public short? Familia { get; set; }

        public short? Familia_Depto_Seccion { get; set; }

        public short? Familia_CC { get; set; }

        public int? Clasificacion { get; set; }

        public DateTime? Fecha_Entrega { get; set; }

        public int? Clas_Sucursal { get; set; }

        public int? Familia_Sucursal { get; set; }

        public int? Clas_Zona { get; set; }
    }
}
