namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parametros_Produccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public byte? Almacen_SOP_Automatica { get; set; }

        public byte? Almacen_EOP_Automatica { get; set; }

        public byte? Almacen_SMTransformada { get; set; }

        public byte? Prod_PProduccion { get; set; }

        public byte? Calculo_MP_Prod { get; set; }

        public int? Clas_Padre { get; set; }

        public int? Clas_Materia_Prima { get; set; }

        public int? Fam_Materia_Prima { get; set; }

        [StringLength(80)]
        public string Descripcion { get; set; }

        [StringLength(80)]
        public string Etiqueta { get; set; }

        public byte? VariosProductosOP { get; set; }

        public byte? Plan_Pedidos { get; set; }

        public byte? Plan_Facturas { get; set; }

        public byte? Plan_Back_Order { get; set; }

        public byte? Homologacion { get; set; }

        public byte? Sumar { get; set; }

        public int? Mes_Pronostico { get; set; }

        public int? Meses { get; set; }

        public decimal? Merma { get; set; }

        public int? Redondeo { get; set; }

        public int? Meses_Simular { get; set; }
    }
}
