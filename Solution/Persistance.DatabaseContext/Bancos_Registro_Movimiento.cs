namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bancos_Registro_Movimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bancos_Registro_Movimiento()
        {
            Caja_Chica_Dotacion = new HashSet<Caja_Chica_Dotacion>();
            Caja_Dotacion = new HashSet<Caja_Dotacion>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Banco { get; set; }

        [Required]
        [StringLength(50)]
        public string Cuenta { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(60)]
        public string Folio { get; set; }

        public decimal? Efectivo { get; set; }

        public decimal? Documentos { get; set; }

        public int? Clas_Concepto { get; set; }

        public int? Beneficiario { get; set; }

        [StringLength(2048)]
        public string Comentario { get; set; }

        public int Tipo { get; set; }

        public int? Familia { get; set; }

        public decimal? Saldo_Inicial { get; set; }

        public decimal? Saldo_Final { get; set; }

        public int Clas_Cuenta { get; set; }

        public int? Clas_Facultad { get; set; }

        public int? Usuario { get; set; }

        [StringLength(250)]
        public string Nombre_Beneficiario { get; set; }

        public short? Retiro_Cheque_Transafer { get; set; }

        public short? Reutilizacion_Folio { get; set; }

        public short? Estatus { get; set; }

        public short? Registro_Externo { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public decimal? TC_Mes { get; set; }

        public int? Conciliado { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        [StringLength(300)]
        public string Causa { get; set; }

        public virtual Bancos_Cuentas_Propias Bancos_Cuentas_Propias { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Empresa Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Chica_Dotacion> Caja_Chica_Dotacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Dotacion> Caja_Dotacion { get; set; }
    }
}
