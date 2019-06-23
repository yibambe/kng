namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Datos_Embarque
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Embarque { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Numero_Cliente { get; set; }

        public DateTime Fecha_Embarque { get; set; }

        public bool Tipo_Envio { get; set; }

        public int? Lugar_Destino { get; set; }

        public decimal? Cantidad_Piezas { get; set; }

        public decimal? Cantidad_Cajas { get; set; }

        public decimal? Cantidad_Paquetes { get; set; }

        public decimal? Peso_Total { get; set; }

        public int? Num_Transportista { get; set; }

        public int? Num_Contenido { get; set; }

        [StringLength(50)]
        public string No_Guia_Talon { get; set; }

        [StringLength(100)]
        public string Observaciones { get; set; }

        public int? Familia { get; set; }

        public bool Estatus { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        [StringLength(250)]
        public string Causa_Cancelacion { get; set; }

        public int? Usuario_Cancela { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
