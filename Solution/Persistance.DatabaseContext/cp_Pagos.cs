namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cp_Pagos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cp_Pagos()
        {
            cp_Pagos_Detalle = new HashSet<cp_Pagos_Detalle>();
            cp_Pagos_Poliza = new HashSet<cp_Pagos_Poliza>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Pago { get; set; }

        public int Clas_Pantalla { get; set; }

        public DateTime Fecha_Pago { get; set; }

        public int? Numero_Anticipo { get; set; }

        public int? Numero_Mov_Banco { get; set; }

        public int? Numero_Mov_Caja { get; set; }

        public int Numero_Usuario { get; set; }

        public int? Tipo_Pago { get; set; }

        public int? Numero_CP_Acreedor { get; set; }

        public int? Numero_Deudor { get; set; }

        public int? Moneda_Pago { get; set; }

        public decimal? Tipo_Cambio_Pago { get; set; }

        public int? Familia_Moneda { get; set; }

        public virtual Cuentas_Pagar_Anticipos Cuentas_Pagar_Anticipos { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Pagos_Detalle> cp_Pagos_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Pagos_Poliza> cp_Pagos_Poliza { get; set; }
    }
}
