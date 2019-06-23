namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Salida_Entrada_XLS_TMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(50)]
        public string Numero_Produccion { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Almacen { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Hora { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num_Usuario { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Tipo_Docto { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Num_Docto { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime Fecha_Docto { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Partida { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Producto { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Concepto { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal Cantidad { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_UM { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Almacen { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num_Persona { get; set; }

        [Key]
        [Column(Order = 17)]
        public byte Tipo { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal Costo { get; set; }

        [StringLength(50)]
        public string Lote { get; set; }

        public DateTime? Fecha_Caducidad { get; set; }

        [StringLength(2500)]
        public string Observaciones { get; set; }

        [StringLength(50)]
        public string Anexo { get; set; }

        [StringLength(50)]
        public string Pedimento { get; set; }

        [StringLength(50)]
        public string Causa_Cancelacion { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        public decimal? TC { get; set; }
    }
}
