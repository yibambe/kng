namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Banco_Transaccion_Multiempresa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Empresa_Origen { get; set; }

        public int Banco_Origen { get; set; }

        public int Clas_Cuenta_Origen { get; set; }

        public int Empresa_Destino { get; set; }

        public int Banco_Destino { get; set; }

        public int Clas_Cuenta_Destino { get; set; }

        public decimal Importe { get; set; }

        [Required]
        [StringLength(100)]
        public string Folio { get; set; }

        public DateTime Fecha { get; set; }

        public int Usuario { get; set; }

        public int Bancos_Registro_Movimiento_Origen { get; set; }

        public int Bancos_Registro_Movimiento_Destino { get; set; }

        public int Familia { get; set; }

        public int? Num_Cotizacion { get; set; }

        public int? Num_Reg_Factura { get; set; }

        public int? Num_Docto { get; set; }

        public int? Numero_Cuenta_Pagar { get; set; }

        public int? Familia_Documento { get; set; }

        public short Bandera_Prestamo { get; set; }
    }
}
