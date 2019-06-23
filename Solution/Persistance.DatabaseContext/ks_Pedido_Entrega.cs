namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ks_Pedido_Entrega
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cotiza { get; set; }

        [StringLength(50)]
        public string Orden_Compra { get; set; }

        [StringLength(50)]
        public string Numero_Proveedor { get; set; }

        public int? Numero_Departamento { get; set; }

        public int? Clas_Forma_Envio { get; set; }

        public int? Familia_Forma_Envio { get; set; }

        [StringLength(100)]
        public string Des_Ocurre { get; set; }

        public byte? Consignacion { get; set; }

        public int? Numero_Domicilio_Consig { get; set; }

        public int? Numero_Persona_Consig { get; set; }

        public byte? chkSoloFacturar { get; set; }

        public byte? chkRecoger { get; set; }

        public byte? chkEntregaKaiser { get; set; }

        public byte? chkRefacturacion { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Domicilio Domicilio { get; set; }

        public virtual ks_Pedido ks_Pedido { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
