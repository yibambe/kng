namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reporte_Orden_Embarque
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Embarque { get; set; }

        [StringLength(200)]
        public string Nombre_Empresa { get; set; }

        [StringLength(150)]
        public string Domicilio_Empresa { get; set; }

        [StringLength(20)]
        public string Telefono_Empresa { get; set; }

        [StringLength(13)]
        public string RFC_Empresa { get; set; }

        [StringLength(50)]
        public string Correo_Empresa { get; set; }

        public int Numero_Cliente { get; set; }

        [StringLength(100)]
        public string Nombre_Cliente { get; set; }

        public int Transportista { get; set; }

        [StringLength(100)]
        public string Nombre_Transporte { get; set; }

        [StringLength(50)]
        public string Facturas { get; set; }

        [StringLength(50)]
        public string Pedidos { get; set; }

        public DateTime Fecha_Embarque { get; set; }

        [StringLength(200)]
        public string Consignatario { get; set; }

        [StringLength(150)]
        public string Domicilio_Tario { get; set; }

        [StringLength(150)]
        public string RFC_Consignatario { get; set; }

        [StringLength(200)]
        public string Consignacion { get; set; }

        [StringLength(150)]
        public string Domicilio_Cion { get; set; }

        [StringLength(150)]
        public string Ocurre { get; set; }

        public int Cajas { get; set; }

        [StringLength(150)]
        public string Contenido { get; set; }

        public decimal Peso { get; set; }

        public decimal Valor { get; set; }

        public int Pagina { get; set; }
    }
}
