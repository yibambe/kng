namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bancos_Cuentas_Terceros
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Numero_Banco { get; set; }

        public int ClasMoneda { get; set; }

        public int Tipo { get; set; }

        public int Terceros { get; set; }

        [Required]
        [StringLength(40)]
        public string Cuenta { get; set; }

        [StringLength(40)]
        public string Digito_Interbancario { get; set; }

        [StringLength(200)]
        public string Tutular_Cuenta { get; set; }

        public int Tipo_Deposito { get; set; }

        public int Proveedor { get; set; }

        public int Clas_Pais { get; set; }

        public int Clas_Estado { get; set; }

        public int Clas_Ciudad { get; set; }

        public short Familia_Tipo_Terceros_Tipo_Deposito { get; set; }

        public short Familia_Moneda { get; set; }

        public byte? Cancelado { get; set; }

        [StringLength(5)]
        public string Num_Sucursal { get; set; }

        public virtual Banco Banco { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
