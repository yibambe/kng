namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacen_Diferencia
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Numero { get; set; }

        public DateTime Fecha { get; set; }

        public byte Tipo_Diferencia { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Almacen { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_inventario { get; set; }

        public int Concepto_Cont { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Concepto { get; set; }

        [StringLength(4000)]
        public string Indicaciones { get; set; }

        public byte Contabilizada { get; set; }

        public int Familia_Concepto_Cont { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Concepto { get; set; }

        public int? Numero_Entrada_Salida { get; set; }

        public int? Numero_Partida { get; set; }

        public decimal? Costo { get; set; }

        public int? Numero_Reg_Poliza { get; set; }
    }
}
