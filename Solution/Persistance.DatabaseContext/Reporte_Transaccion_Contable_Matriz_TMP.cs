namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reporte_Transaccion_Contable_Matriz_TMP
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
        public int Numero { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Programa { get; set; }

        [StringLength(100)]
        public string Nombre_Programa { get; set; }

        [StringLength(100)]
        public string Desc_Programa { get; set; }

        [StringLength(100)]
        public string Modulo { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tipo_Poliza { get; set; }

        [StringLength(100)]
        public string Nombre_Tipo_Poliza { get; set; }

        [StringLength(250)]
        public string Concepto_Contable { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Producto { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tipo_Producto { get; set; }

        [StringLength(100)]
        public string Cve_Tipo_Producto { get; set; }

        [StringLength(100)]
        public string Nombre_Tipo_Producto { get; set; }

        public int? Producto { get; set; }

        [StringLength(100)]
        public string Cve_Producto { get; set; }

        [StringLength(100)]
        public string Nombre_Producto { get; set; }

        public int? Tipo_Concepto { get; set; }

        [StringLength(100)]
        public string Cve_Tipo_Concepto { get; set; }

        [StringLength(100)]
        public string Nombre_Tipo_Concepto { get; set; }

        public int? Concepto { get; set; }

        [StringLength(100)]
        public string Cve_Concepto { get; set; }

        [StringLength(100)]
        public string Nombre_Concepto { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Detalle { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Tipo { get; set; }

        [StringLength(100)]
        public string Nombre_Tipo { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cuenta { get; set; }

        [StringLength(100)]
        public string Clave_Cuenta { get; set; }

        [StringLength(100)]
        public string Nombre_Cuenta { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool Acumulativa_Detalle { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cargo_Abono { get; set; }

        public int? Auxiliar { get; set; }

        [StringLength(100)]
        public string Nombre_Auxiliar { get; set; }
    }
}
