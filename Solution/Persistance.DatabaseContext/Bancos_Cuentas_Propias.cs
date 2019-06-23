namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bancos_Cuentas_Propias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bancos_Cuentas_Propias()
        {
            Bancos_Contactos = new HashSet<Bancos_Contactos>();
            Bancos_Cuentas_Propias_Facultades = new HashSet<Bancos_Cuentas_Propias_Facultades>();
            Bancos_Registro_Movimiento = new HashSet<Bancos_Registro_Movimiento>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num_Banco { get; set; }

        public int? Num_Sucursal { get; set; }

        [StringLength(100)]
        public string Sucursal { get; set; }

        [Required]
        [StringLength(50)]
        public string Num_Cuenta { get; set; }

        [StringLength(40)]
        public string Digito_Interbancario { get; set; }

        public int? Clas_Moneda { get; set; }

        public DateTime? Fecha_Apertura { get; set; }

        public int? Clas_Estatus { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(20)]
        public string Num_Cheque_Inicial { get; set; }

        public int Cont_Clas_Banco { get; set; }

        public int Familia_Clas_Moneda { get; set; }

        public int Familia_Clas_Estatus { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cont_Clas_Cuenta { get; set; }

        public decimal? Saldo_Inicial { get; set; }

        public short? Cargo_Abono { get; set; }

        public int? Tipo_Cuenta { get; set; }

        public virtual Banco Banco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Contactos> Bancos_Contactos { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Empresa Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Cuentas_Propias_Facultades> Bancos_Cuentas_Propias_Facultades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Registro_Movimiento> Bancos_Registro_Movimiento { get; set; }
    }
}
