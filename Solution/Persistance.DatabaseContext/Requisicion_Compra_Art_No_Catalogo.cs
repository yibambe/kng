namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Requisicion_Compra_Art_No_Catalogo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_RC { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte Tipo1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Articulo { get; set; }

        [StringLength(250)]
        public string Des_Articulo { get; set; }

        public byte? Tipo { get; set; }

        public int? U_Medida { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? Precio_1 { get; set; }

        public decimal? Precio_2 { get; set; }

        public byte? Existe_Solicitud { get; set; }

        [StringLength(4000)]
        public string Caracteristicas { get; set; }

        [StringLength(80)]
        public string Parte { get; set; }

        public short? Familia { get; set; }
    }
}
