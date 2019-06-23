namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clasificacion")]
    public partial class Clasificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clasificacion()
        {
            Activo_Fijo = new HashSet<Activo_Fijo>();
            Administracion_Recursos = new HashSet<Administracion_Recursos>();
            Administracion_Recursos_Detalle = new HashSet<Administracion_Recursos_Detalle>();
            Administracion_Recursos_Detalle1 = new HashSet<Administracion_Recursos_Detalle>();
            Almacen_Sol_Prod_Detalle = new HashSet<Almacen_Sol_Prod_Detalle>();
            Almacen_Sol_Prod_Empaques = new HashSet<Almacen_Sol_Prod_Empaques>();
            Almacen_Sol_Prod_Empaques1 = new HashSet<Almacen_Sol_Prod_Empaques>();
            Almacen_Sol_Prod_Empaques2 = new HashSet<Almacen_Sol_Prod_Empaques>();
            Almacen_Sol_Produccion = new HashSet<Almacen_Sol_Produccion>();
            Almacen_Sol_Produccion1 = new HashSet<Almacen_Sol_Produccion>();
            Almacen_UM_Equivalencia = new HashSet<Almacen_UM_Equivalencia>();
            Almacen_UM_Equivalencia1 = new HashSet<Almacen_UM_Equivalencia>();
            Articulo_Transformada = new HashSet<Articulo_Transformada>();
            Articulo_Transformada1 = new HashSet<Articulo_Transformada>();
            Articulo_Transformada_Detalle = new HashSet<Articulo_Transformada_Detalle>();
            Articulo_Transformada_Detalle1 = new HashSet<Articulo_Transformada_Detalle>();
            Bancos = new HashSet<Banco>();
            Bancos1 = new HashSet<Banco>();
            Bancos2 = new HashSet<Banco>();
            Bancos_Cuentas_Propias = new HashSet<Bancos_Cuentas_Propias>();
            Bancos_Cuentas_Propias1 = new HashSet<Bancos_Cuentas_Propias>();
            Bancos_Cuentas_Propias2 = new HashSet<Bancos_Cuentas_Propias>();
            Bancos_Cuentas_Propias_Facultades = new HashSet<Bancos_Cuentas_Propias_Facultades>();
            Bancos_Registro_Movimiento = new HashSet<Bancos_Registro_Movimiento>();
            Bancos_Registro_Movimiento1 = new HashSet<Bancos_Registro_Movimiento>();
            Cajas = new HashSet<Caja>();
            Cajas1 = new HashSet<Caja>();
            Cajas2 = new HashSet<Caja>();
            Caja_Arqueo_Efectivo = new HashSet<Caja_Arqueo_Efectivo>();
            Caja_Chica = new HashSet<Caja_Chica>();
            Caja_Chica1 = new HashSet<Caja_Chica>();
            Caja_Chica2 = new HashSet<Caja_Chica>();
            Caja_Chica_Comprobacion = new HashSet<Caja_Chica_Comprobacion>();
            Caja_Comprobacion = new HashSet<Caja_Comprobacion>();
            Caja_Comprobacion1 = new HashSet<Caja_Comprobacion>();
            Caja_Comprobacion2 = new HashSet<Caja_Comprobacion>();
            Caja_Comprobacion3 = new HashSet<Caja_Comprobacion>();
            Caja_Concepto = new HashSet<Caja_Concepto>();
            Caja_Detalle = new HashSet<Caja_Detalle>();
            Caja_Detalle1 = new HashSet<Caja_Detalle>();
            Cierre_Inventario = new HashSet<Cierre_Inventario>();
            Cierre_Inventario1 = new HashSet<Cierre_Inventario>();
            Apertura_Inventario = new HashSet<Apertura_Inventario>();
            Apertura_Inventario1 = new HashSet<Apertura_Inventario>();
            Apertura_Inventario2 = new HashSet<Apertura_Inventario>();
            Apertura_Inventario3 = new HashSet<Apertura_Inventario>();
            Articuloes = new HashSet<Articulo>();
            Articuloes1 = new HashSet<Articulo>();
            Articulo_Concepto = new HashSet<Articulo_Concepto>();
            Articulo_Concepto1 = new HashSet<Articulo_Concepto>();
            cc_Proceso_Pago = new HashSet<cc_Proceso_Pago>();
            cc_Proceso_Pago1 = new HashSet<cc_Proceso_Pago>();
            Cierre_Inventario_Detalle = new HashSet<Cierre_Inventario_Detalle>();
            Cierre_Inventario_Detalle1 = new HashSet<Cierre_Inventario_Detalle>();
            Cierre_Inventario_Detalle2 = new HashSet<Cierre_Inventario_Detalle>();
            Cierre_Inventario_Detalle3 = new HashSet<Cierre_Inventario_Detalle>();
            co_Contabilidad_Polizas_Fecha = new HashSet<co_Contabilidad_Polizas_Fecha>();
            co_Contabilidad_Polizas_Periodo = new HashSet<co_Contabilidad_Polizas_Periodo>();
            co_Parametros_Reporteador = new HashSet<co_Parametros_Reporteador>();
            co_Parametros_Reporteador1 = new HashSet<co_Parametros_Reporteador>();
            co_Parametros_Reporteador2 = new HashSet<co_Parametros_Reporteador>();
            co_Parametros_Reporteador3 = new HashSet<co_Parametros_Reporteador>();
            co_Parametros_Reporteador4 = new HashSet<co_Parametros_Reporteador>();
            co_Parametros_Reporteador5 = new HashSet<co_Parametros_Reporteador>();
            co_Reportes_Contables_Detalle = new HashSet<co_Reportes_Contables_Detalle>();
            co_Reportes_Contables_Registros = new HashSet<co_Reportes_Contables_Registros>();
            Conceptos_Devolucion_Cliente = new HashSet<Conceptos_Devolucion_Cliente>();
            Contabilidad_Polizas = new HashSet<Contabilidad_Polizas>();
            Contabilidad_Relacion_TipoCuenta = new HashSet<Contabilidad_Relacion_TipoCuenta>();
            Control_Materiales = new HashSet<Control_Materiales>();
            Control_Materiales1 = new HashSet<Control_Materiales>();
            Control_Materiales2 = new HashSet<Control_Materiales>();
            Control_Materiales_Recibe = new HashSet<Control_Materiales_Recibe>();
            Control_Procesos = new HashSet<Control_Procesos>();
            Control_Procesos1 = new HashSet<Control_Procesos>();
            cp_Pagos_Poliza = new HashSet<cp_Pagos_Poliza>();
            cp_Pagos_Poliza1 = new HashSet<cp_Pagos_Poliza>();
            cp_Proceso_Contabilidad = new HashSet<cp_Proceso_Contabilidad>();
            cp_Proceso_Contabilidad1 = new HashSet<cp_Proceso_Contabilidad>();
            cp_Proceso_Pago = new HashSet<cp_Proceso_Pago>();
            cp_Proceso_Pago1 = new HashSet<cp_Proceso_Pago>();
            Datos_Conceptos_Plan_Maestro = new HashSet<Datos_Conceptos_Plan_Maestro>();
            Datos_Conceptos_Plan_Maestro1 = new HashSet<Datos_Conceptos_Plan_Maestro>();
            Datos_Conceptos_Plan_Maestro2 = new HashSet<Datos_Conceptos_Plan_Maestro>();
            Datos_Conceptos_Plan_Maestro3 = new HashSet<Datos_Conceptos_Plan_Maestro>();
            Datos_Conceptos_Plan_Maestro4 = new HashSet<Datos_Conceptos_Plan_Maestro>();
            Datos_Embarque = new HashSet<Datos_Embarque>();
            Datos_Embarque1 = new HashSet<Datos_Embarque>();
            Devolucion_Cliente = new HashSet<Devolucion_Cliente>();
            Devolucion_Cliente1 = new HashSet<Devolucion_Cliente>();
            Devolucion_Cliente2 = new HashSet<Devolucion_Cliente>();
            Devolucion_Cliente3 = new HashSet<Devolucion_Cliente>();
            Devolucion_Cliente_Detalle = new HashSet<Devolucion_Cliente_Detalle>();
            Devolucion_Cliente_Detalle1 = new HashSet<Devolucion_Cliente_Detalle>();
            Entrada_Almacen_Detalle = new HashSet<Entrada_Almacen_Detalle>();
            Entrada_Almacen_Detalle1 = new HashSet<Entrada_Almacen_Detalle>();
            Entrada_Almacen_Detalle2 = new HashSet<Entrada_Almacen_Detalle>();
            Entrada_Almacen_Detalle3 = new HashSet<Entrada_Almacen_Detalle>();
            Entrada_Almacen_Detalle4 = new HashSet<Entrada_Almacen_Detalle>();
            Entrada_Almacen_Detalle5 = new HashSet<Entrada_Almacen_Detalle>();
            Entrada_Almacen_Producto_Total = new HashSet<Entrada_Almacen_Producto_Total>();
            Entrada_Almacen_Producto_Total1 = new HashSet<Entrada_Almacen_Producto_Total>();
            Entrada_Almacen_Producto_Total2 = new HashSet<Entrada_Almacen_Producto_Total>();
            Entrada_Almacen_Producto_Total3 = new HashSet<Entrada_Almacen_Producto_Total>();
            Entrada_Almacen_Producto_Total4 = new HashSet<Entrada_Almacen_Producto_Total>();
            Entrada_Almacen_Producto_Total5 = new HashSet<Entrada_Almacen_Producto_Total>();
            Entrega_Almacen_Prod_Detalle = new HashSet<Entrega_Almacen_Prod_Detalle>();
            Entrega_Almacen_Prod_Detalle1 = new HashSet<Entrega_Almacen_Prod_Detalle>();
            Entrega_Almacen_Prod_Motivos = new HashSet<Entrega_Almacen_Prod_Motivos>();
            Equivalencia_Detalle = new HashSet<Equivalencia_Detalle>();
            Equivalencia_Detalle1 = new HashSet<Equivalencia_Detalle>();
            Estadisticos_Compras_Articulo_TMP = new HashSet<Estadisticos_Compras_Articulo_TMP>();
            Estadisticos_Compras_Articulo_TMP1 = new HashSet<Estadisticos_Compras_Articulo_TMP>();
            Estadisticos_Compras_Articulo_TMP2 = new HashSet<Estadisticos_Compras_Articulo_TMP>();
            Estadisticos_Compras_Articulo_TMP3 = new HashSet<Estadisticos_Compras_Articulo_TMP>();
            Estadisticos_Compras_Articulo_TMP4 = new HashSet<Estadisticos_Compras_Articulo_TMP>();
            Estadisticos_Ventas_Articulo_TMP = new HashSet<Estadisticos_Ventas_Articulo_TMP>();
            Estadisticos_Ventas_Articulo_TMP1 = new HashSet<Estadisticos_Ventas_Articulo_TMP>();
            Estadisticos_Ventas_Articulo_TMP2 = new HashSet<Estadisticos_Ventas_Articulo_TMP>();
            Estadisticos_Ventas_Articulo_TMP3 = new HashSet<Estadisticos_Ventas_Articulo_TMP>();
            Estadisticos_Ventas_Articulo_TMP4 = new HashSet<Estadisticos_Ventas_Articulo_TMP>();
            Factura_Comisionistas = new HashSet<Factura_Comisionistas>();
            Historico_Prod_Detalle = new HashSet<Historico_Prod_Detalle>();
            Historico_Prod_Detalle1 = new HashSet<Historico_Prod_Detalle>();
            Historico_Prod_Detalle2 = new HashSet<Historico_Prod_Detalle>();
            Historico_Produccion = new HashSet<Historico_Produccion>();
            Historico_Produccion1 = new HashSet<Historico_Produccion>();
            ks_Pedido_Entrega = new HashSet<ks_Pedido_Entrega>();
            Lista_Precios_Detalle = new HashSet<Lista_Precios_Detalle>();
            Lista_Precios_Detalle_TMP = new HashSet<Lista_Precios_Detalle_TMP>();
            Lista_Precios_Detalle1 = new HashSet<Lista_Precios_Detalle>();
            Lista_Precios_Detalle_TMP1 = new HashSet<Lista_Precios_Detalle_TMP>();
            Lista_Precios_Detalle2 = new HashSet<Lista_Precios_Detalle>();
            Lista_Precios_Detalle_TMP2 = new HashSet<Lista_Precios_Detalle_TMP>();
            Lista_Precios = new HashSet<Lista_Precios>();
            Material_Procesos = new HashSet<Material_Procesos>();
            Material_Procesos1 = new HashSet<Material_Procesos>();
            Material_Procesos2 = new HashSet<Material_Procesos>();
            Modelo_Detalle = new HashSet<Modelo_Detalle>();
            Modelo_Detalle1 = new HashSet<Modelo_Detalle>();
            Modelo_Producto_Det = new HashSet<Modelo_Producto_Det>();
            Modelo_Producto_Det1 = new HashSet<Modelo_Producto_Det>();
            Modelo_Producto_Prod = new HashSet<Modelo_Producto_Prod>();
            Modelo_Producto_Prod1 = new HashSet<Modelo_Producto_Prod>();
            Modelo_Producto_Prod2 = new HashSet<Modelo_Producto_Prod>();
            Modelo_Producto_Prod3 = new HashSet<Modelo_Producto_Prod>();
            MTransformada_MPrima = new HashSet<MTransformada_MPrima>();
            MTransformada_MPrima1 = new HashSet<MTransformada_MPrima>();
            Orden_Produccion = new HashSet<Orden_Produccion>();
            Orden_Produccion1 = new HashSet<Orden_Produccion>();
            Orden_Produccion2 = new HashSet<Orden_Produccion>();
            Orden_Produccion3 = new HashSet<Orden_Produccion>();
            Orden_Produccion4 = new HashSet<Orden_Produccion>();
            Orden_Produccion5 = new HashSet<Orden_Produccion>();
            Periodos_Siguientes_Sel = new HashSet<Periodos_Siguientes_Sel>();
            Periodos_Siguientes_Sel1 = new HashSet<Periodos_Siguientes_Sel>();
            Periodos_Siguientes_Sel2 = new HashSet<Periodos_Siguientes_Sel>();
            Plan_Prod_Detalle_Masivo = new HashSet<Plan_Prod_Detalle_Masivo>();
            Plan_Prod_Detalle_Masivo1 = new HashSet<Plan_Prod_Detalle_Masivo>();
            Plan_Prod_Detalle_Masivo2 = new HashSet<Plan_Prod_Detalle_Masivo>();
            Plan_Prod_Detalle_Masivo3 = new HashSet<Plan_Prod_Detalle_Masivo>();
            Plan_Prod_Detalle_Masivo4 = new HashSet<Plan_Prod_Detalle_Masivo>();
            Plan_Prod_Fechas = new HashSet<Plan_Prod_Fechas>();
            Plan_Prod_Fechas1 = new HashSet<Plan_Prod_Fechas>();
            Plan_Prod_Fechas2 = new HashSet<Plan_Prod_Fechas>();
            Plan_Prod_Fechas3 = new HashSet<Plan_Prod_Fechas>();
            Productoes = new HashSet<Producto>();
            Productoes1 = new HashSet<Producto>();
            Productoes2 = new HashSet<Producto>();
            Productoes3 = new HashSet<Producto>();
            Productoes4 = new HashSet<Producto>();
            Productos_Conceptos_Adicionales = new HashSet<Productos_Conceptos_Adicionales>();
            Productos_Conceptos_Adicionales1 = new HashSet<Productos_Conceptos_Adicionales>();
            Productos_Conceptos_Caducidad = new HashSet<Productos_Conceptos_Caducidad>();
            Productos_Conceptos_Caducidad1 = new HashSet<Productos_Conceptos_Caducidad>();
            Productos_Conceptos_Caducidad2 = new HashSet<Productos_Conceptos_Caducidad>();
            Productos_Conceptos_Caducidad3 = new HashSet<Productos_Conceptos_Caducidad>();
            Productos_Conceptos = new HashSet<Productos_Conceptos>();
            Productos_Conceptos1 = new HashSet<Productos_Conceptos>();
            Productos_Conceptos2 = new HashSet<Productos_Conceptos>();
            Productos_Conceptos_Cliente = new HashSet<Productos_Conceptos_Cliente>();
            Productos_Conceptos_Cliente1 = new HashSet<Productos_Conceptos_Cliente>();
            Receta_Detalle = new HashSet<Receta_Detalle>();
            Receta_Detalle1 = new HashSet<Receta_Detalle>();
            Receta_Detalle2 = new HashSet<Receta_Detalle>();
            Receta_Proceso = new HashSet<Receta_Proceso>();
            Registro_Venta_Salida = new HashSet<Registro_Venta_Salida>();
            Rel_Homologacion_Articulos = new HashSet<Rel_Homologacion_Articulos>();
            Rel_Homologacion_Articulos1 = new HashSet<Rel_Homologacion_Articulos>();
            Relacion_Cajero_Almacen = new HashSet<Relacion_Cajero_Almacen>();
            Relacion_Depto_CC = new HashSet<Relacion_Depto_CC>();
            Relacion_Depto_CC1 = new HashSet<Relacion_Depto_CC>();
            Relacion_Depto_CC2 = new HashSet<Relacion_Depto_CC>();
            Relacion_Sucursal_Caja = new HashSet<Relacion_Sucursal_Caja>();
            Relacion_Sucursal_Caja1 = new HashSet<Relacion_Sucursal_Caja>();
            Relacion_Sucursal_Caja_Detalle = new HashSet<Relacion_Sucursal_Caja_Detalle>();
            Relacion_Sucursal_IVA = new HashSet<Relacion_Sucursal_IVA>();
            Relacion_Sucursal_IVA1 = new HashSet<Relacion_Sucursal_IVA>();
            Relacion_Sucursal_IVA2 = new HashSet<Relacion_Sucursal_IVA>();
            Revision_Calidad = new HashSet<Revision_Calidad>();
            Revision_Calidad1 = new HashSet<Revision_Calidad>();
            Salida_Almacen = new HashSet<Salida_Almacen>();
            Salida_Almacen1 = new HashSet<Salida_Almacen>();
            Salida_Almacen_Detalle = new HashSet<Salida_Almacen_Detalle>();
            Salida_Almacen_Detalle1 = new HashSet<Salida_Almacen_Detalle>();
            Salida_Almacen_Detalle2 = new HashSet<Salida_Almacen_Detalle>();
            Salida_Almacen_Detalle3 = new HashSet<Salida_Almacen_Detalle>();
            Salida_Almacen_Detalle4 = new HashSet<Salida_Almacen_Detalle>();
            Salida_Almacen_Detalle5 = new HashSet<Salida_Almacen_Detalle>();
            Salida_Almacen_Detalle6 = new HashSet<Salida_Almacen_Detalle>();
            Sol_Prod_Detalle_Transformada = new HashSet<Sol_Prod_Detalle_Transformada>();
            Sol_Prod_Detalle_Transformada1 = new HashSet<Sol_Prod_Detalle_Transformada>();
            Sol_Prod_Detalle_Transformada2 = new HashSet<Sol_Prod_Detalle_Transformada>();
            Sol_Prod_Detalle_Transformada3 = new HashSet<Sol_Prod_Detalle_Transformada>();
            Sol_Prod_Detalle_Transformada4 = new HashSet<Sol_Prod_Detalle_Transformada>();
            Sucursal_Almacen_virtual = new HashSet<Sucursal_Almacen_virtual>();
            Sucursal_Almacen_virtual1 = new HashSet<Sucursal_Almacen_virtual>();
            Sucursals = new HashSet<Sucursal>();
            Sucursal_Docto_Folio = new HashSet<Sucursal_Docto_Folio>();
            Sucursal_Docto_Folio1 = new HashSet<Sucursal_Docto_Folio>();
            Taller_Calculo_CP = new HashSet<Taller_Calculo_CP>();
            Taller_Calculo_CP_Detalle = new HashSet<Taller_Calculo_CP_Detalle>();
            Taller_Calculo_CP_Detalle1 = new HashSet<Taller_Calculo_CP_Detalle>();
            Taller_Productos = new HashSet<Taller_Productos>();
            Taller_Productos1 = new HashSet<Taller_Productos>();
            Taller_Productos2 = new HashSet<Taller_Productos>();
            Transacciones_Contables = new HashSet<Transacciones_Contables>();
            Transporte_Vehiculo = new HashSet<Transporte_Vehiculo>();
            Venta_Caja = new HashSet<Venta_Caja>();
            Venta_Caja1 = new HashSet<Venta_Caja>();
            Venta_Caja2 = new HashSet<Venta_Caja>();
            Venta_Caja3 = new HashSet<Venta_Caja>();
            Venta_Caja4 = new HashSet<Venta_Caja>();
            Venta_Caja_Almacen = new HashSet<Venta_Caja_Almacen>();
            Venta_Caja_Almacen1 = new HashSet<Venta_Caja_Almacen>();
            Venta_Caja_Apertura = new HashSet<Venta_Caja_Apertura>();
            Venta_Caja_Apertura1 = new HashSet<Venta_Caja_Apertura>();
            Venta_Caja_Apertura_Detalle = new HashSet<Venta_Caja_Apertura_Detalle>();
            Venta_Caja_Cierre = new HashSet<Venta_Caja_Cierre>();
            Venta_Caja_Cierre1 = new HashSet<Venta_Caja_Cierre>();
            Venta_Caja_Cierre2 = new HashSet<Venta_Caja_Cierre>();
            Venta_Caja_Cierre_Pagos = new HashSet<Venta_Caja_Cierre_Pagos>();
            Venta_Caja_Detalle = new HashSet<Venta_Caja_Detalle>();
            Venta_Caja_Detalle1 = new HashSet<Venta_Caja_Detalle>();
            Venta_Caja_Detalle2 = new HashSet<Venta_Caja_Detalle>();
            Venta_Caja_Pagos = new HashSet<Venta_Caja_Pagos>();
            Venta_Caja_Pagos1 = new HashSet<Venta_Caja_Pagos>();
            Venta_Salida = new HashSet<Venta_Salida>();
            Venta_Salida1 = new HashSet<Venta_Salida>();
            Venta_Salida2 = new HashSet<Venta_Salida>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia { get; set; }

        [StringLength(15)]
        public string Clave1 { get; set; }

        [StringLength(80)]
        public string Descripcion1 { get; set; }

        [StringLength(15)]
        public string Clave2 { get; set; }

        [StringLength(80)]
        public string Descripcion2 { get; set; }

        [StringLength(15)]
        public string Clave3 { get; set; }

        [StringLength(80)]
        public string Descripcion3 { get; set; }

        [StringLength(15)]
        public string Clave4 { get; set; }

        [StringLength(80)]
        public string Descripcion4 { get; set; }

        [StringLength(15)]
        public string Clave5 { get; set; }

        [StringLength(80)]
        public string Descripcion5 { get; set; }

        [StringLength(15)]
        public string Clave6 { get; set; }

        [StringLength(80)]
        public string Descripcion6 { get; set; }

        [StringLength(15)]
        public string Clave7 { get; set; }

        [StringLength(80)]
        public string Descripcion7 { get; set; }

        [StringLength(15)]
        public string Clave8 { get; set; }

        [StringLength(80)]
        public string Descripcion8 { get; set; }

        [StringLength(15)]
        public string Clave9 { get; set; }

        [StringLength(80)]
        public string Descripcion9 { get; set; }

        [StringLength(135)]
        public string Clave { get; set; }

        [StringLength(120)]
        public string Clave_Padre { get; set; }

        [StringLength(80)]
        public string Descripcion { get; set; }

        public int? Nivel { get; set; }

        public bool? Terminal { get; set; }

        public int? Numero_Padre { get; set; }

        public short Clave_Edicion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activo_Fijo> Activo_Fijo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Administracion_Recursos> Administracion_Recursos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Administracion_Recursos_Detalle> Administracion_Recursos_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Administracion_Recursos_Detalle> Administracion_Recursos_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Sol_Prod_Detalle> Almacen_Sol_Prod_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Sol_Prod_Empaques> Almacen_Sol_Prod_Empaques { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Sol_Prod_Empaques> Almacen_Sol_Prod_Empaques1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Sol_Prod_Empaques> Almacen_Sol_Prod_Empaques2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Sol_Produccion> Almacen_Sol_Produccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Sol_Produccion> Almacen_Sol_Produccion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_UM_Equivalencia> Almacen_UM_Equivalencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_UM_Equivalencia> Almacen_UM_Equivalencia1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo_Transformada> Articulo_Transformada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo_Transformada> Articulo_Transformada1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo_Transformada_Detalle> Articulo_Transformada_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo_Transformada_Detalle> Articulo_Transformada_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banco> Bancos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banco> Bancos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banco> Bancos2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Cuentas_Propias> Bancos_Cuentas_Propias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Cuentas_Propias> Bancos_Cuentas_Propias1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Cuentas_Propias> Bancos_Cuentas_Propias2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Cuentas_Propias_Facultades> Bancos_Cuentas_Propias_Facultades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Registro_Movimiento> Bancos_Registro_Movimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Registro_Movimiento> Bancos_Registro_Movimiento1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja> Cajas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja> Cajas1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja> Cajas2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Arqueo_Efectivo> Caja_Arqueo_Efectivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Chica> Caja_Chica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Chica> Caja_Chica1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Chica> Caja_Chica2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Chica_Comprobacion> Caja_Chica_Comprobacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Comprobacion> Caja_Comprobacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Comprobacion> Caja_Comprobacion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Comprobacion> Caja_Comprobacion2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Comprobacion> Caja_Comprobacion3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Concepto> Caja_Concepto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Detalle> Caja_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Detalle> Caja_Detalle1 { get; set; }

        public virtual Cierre_Contable_Auxiliar Cierre_Contable_Auxiliar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cierre_Inventario> Cierre_Inventario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cierre_Inventario> Cierre_Inventario1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apertura_Inventario> Apertura_Inventario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apertura_Inventario> Apertura_Inventario1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apertura_Inventario> Apertura_Inventario2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apertura_Inventario> Apertura_Inventario3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo> Articuloes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo> Articuloes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo_Concepto> Articulo_Concepto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo_Concepto> Articulo_Concepto1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cc_Proceso_Pago> cc_Proceso_Pago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cc_Proceso_Pago> cc_Proceso_Pago1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cierre_Inventario_Detalle> Cierre_Inventario_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cierre_Inventario_Detalle> Cierre_Inventario_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cierre_Inventario_Detalle> Cierre_Inventario_Detalle2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cierre_Inventario_Detalle> Cierre_Inventario_Detalle3 { get; set; }

        public virtual Empresa Empresa1 { get; set; }

        public virtual Familia Familia1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Contabilidad_Polizas_Fecha> co_Contabilidad_Polizas_Fecha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Contabilidad_Polizas_Periodo> co_Contabilidad_Polizas_Periodo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Parametros_Reporteador> co_Parametros_Reporteador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Parametros_Reporteador> co_Parametros_Reporteador1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Parametros_Reporteador> co_Parametros_Reporteador2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Parametros_Reporteador> co_Parametros_Reporteador3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Parametros_Reporteador> co_Parametros_Reporteador4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Parametros_Reporteador> co_Parametros_Reporteador5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Reportes_Contables_Detalle> co_Reportes_Contables_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Reportes_Contables_Registros> co_Reportes_Contables_Registros { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conceptos_Devolucion_Cliente> Conceptos_Devolucion_Cliente { get; set; }

        public virtual Contabilidad_Cuentas_Inhabilitadas Contabilidad_Cuentas_Inhabilitadas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contabilidad_Polizas> Contabilidad_Polizas { get; set; }

        public virtual Contabilidad_Relacion_TC Contabilidad_Relacion_TC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contabilidad_Relacion_TipoCuenta> Contabilidad_Relacion_TipoCuenta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control_Materiales> Control_Materiales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control_Materiales> Control_Materiales1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control_Materiales> Control_Materiales2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control_Materiales_Recibe> Control_Materiales_Recibe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control_Procesos> Control_Procesos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control_Procesos> Control_Procesos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Pagos_Poliza> cp_Pagos_Poliza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Pagos_Poliza> cp_Pagos_Poliza1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Proceso_Contabilidad> cp_Proceso_Contabilidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Proceso_Contabilidad> cp_Proceso_Contabilidad1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Proceso_Pago> cp_Proceso_Pago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Proceso_Pago> cp_Proceso_Pago1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_Conceptos_Plan_Maestro> Datos_Conceptos_Plan_Maestro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_Conceptos_Plan_Maestro> Datos_Conceptos_Plan_Maestro1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_Conceptos_Plan_Maestro> Datos_Conceptos_Plan_Maestro2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_Conceptos_Plan_Maestro> Datos_Conceptos_Plan_Maestro3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_Conceptos_Plan_Maestro> Datos_Conceptos_Plan_Maestro4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_Embarque> Datos_Embarque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_Embarque> Datos_Embarque1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devolucion_Cliente> Devolucion_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devolucion_Cliente> Devolucion_Cliente1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devolucion_Cliente> Devolucion_Cliente2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devolucion_Cliente> Devolucion_Cliente3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devolucion_Cliente_Detalle> Devolucion_Cliente_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devolucion_Cliente_Detalle> Devolucion_Cliente_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Detalle> Entrada_Almacen_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Detalle> Entrada_Almacen_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Detalle> Entrada_Almacen_Detalle2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Detalle> Entrada_Almacen_Detalle3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Detalle> Entrada_Almacen_Detalle4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Detalle> Entrada_Almacen_Detalle5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Producto_Total> Entrada_Almacen_Producto_Total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Producto_Total> Entrada_Almacen_Producto_Total1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Producto_Total> Entrada_Almacen_Producto_Total2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Producto_Total> Entrada_Almacen_Producto_Total3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Producto_Total> Entrada_Almacen_Producto_Total4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen_Producto_Total> Entrada_Almacen_Producto_Total5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrega_Almacen_Prod_Detalle> Entrega_Almacen_Prod_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrega_Almacen_Prod_Detalle> Entrega_Almacen_Prod_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrega_Almacen_Prod_Motivos> Entrega_Almacen_Prod_Motivos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equivalencia_Detalle> Equivalencia_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equivalencia_Detalle> Equivalencia_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Compras_Articulo_TMP> Estadisticos_Compras_Articulo_TMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Compras_Articulo_TMP> Estadisticos_Compras_Articulo_TMP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Compras_Articulo_TMP> Estadisticos_Compras_Articulo_TMP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Compras_Articulo_TMP> Estadisticos_Compras_Articulo_TMP3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Compras_Articulo_TMP> Estadisticos_Compras_Articulo_TMP4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Ventas_Articulo_TMP> Estadisticos_Ventas_Articulo_TMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Ventas_Articulo_TMP> Estadisticos_Ventas_Articulo_TMP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Ventas_Articulo_TMP> Estadisticos_Ventas_Articulo_TMP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Ventas_Articulo_TMP> Estadisticos_Ventas_Articulo_TMP3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Ventas_Articulo_TMP> Estadisticos_Ventas_Articulo_TMP4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura_Comisionistas> Factura_Comisionistas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico_Prod_Detalle> Historico_Prod_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico_Prod_Detalle> Historico_Prod_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico_Prod_Detalle> Historico_Prod_Detalle2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico_Produccion> Historico_Produccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico_Produccion> Historico_Produccion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ks_Pedido_Entrega> ks_Pedido_Entrega { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lista_Precios_Detalle> Lista_Precios_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lista_Precios_Detalle_TMP> Lista_Precios_Detalle_TMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lista_Precios_Detalle> Lista_Precios_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lista_Precios_Detalle_TMP> Lista_Precios_Detalle_TMP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lista_Precios_Detalle> Lista_Precios_Detalle2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lista_Precios_Detalle_TMP> Lista_Precios_Detalle_TMP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lista_Precios> Lista_Precios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material_Procesos> Material_Procesos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material_Procesos> Material_Procesos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material_Procesos> Material_Procesos2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modelo_Detalle> Modelo_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modelo_Detalle> Modelo_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modelo_Producto_Det> Modelo_Producto_Det { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modelo_Producto_Det> Modelo_Producto_Det1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modelo_Producto_Prod> Modelo_Producto_Prod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modelo_Producto_Prod> Modelo_Producto_Prod1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modelo_Producto_Prod> Modelo_Producto_Prod2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modelo_Producto_Prod> Modelo_Producto_Prod3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MTransformada_MPrima> MTransformada_MPrima { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MTransformada_MPrima> MTransformada_MPrima1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden_Produccion> Orden_Produccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden_Produccion> Orden_Produccion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden_Produccion> Orden_Produccion2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden_Produccion> Orden_Produccion3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden_Produccion> Orden_Produccion4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden_Produccion> Orden_Produccion5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Periodos_Siguientes_Sel> Periodos_Siguientes_Sel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Periodos_Siguientes_Sel> Periodos_Siguientes_Sel1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Periodos_Siguientes_Sel> Periodos_Siguientes_Sel2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Detalle_Masivo> Plan_Prod_Detalle_Masivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Detalle_Masivo> Plan_Prod_Detalle_Masivo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Detalle_Masivo> Plan_Prod_Detalle_Masivo2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Detalle_Masivo> Plan_Prod_Detalle_Masivo3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Detalle_Masivo> Plan_Prod_Detalle_Masivo4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Fechas> Plan_Prod_Fechas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Fechas> Plan_Prod_Fechas1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Fechas> Plan_Prod_Fechas2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Fechas> Plan_Prod_Fechas3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Productoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Productoes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Productoes2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Productoes3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Productoes4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos_Adicionales> Productos_Conceptos_Adicionales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos_Adicionales> Productos_Conceptos_Adicionales1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos_Caducidad> Productos_Conceptos_Caducidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos_Caducidad> Productos_Conceptos_Caducidad1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos_Caducidad> Productos_Conceptos_Caducidad2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos_Caducidad> Productos_Conceptos_Caducidad3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos> Productos_Conceptos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos> Productos_Conceptos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos> Productos_Conceptos2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos_Cliente> Productos_Conceptos_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos_Cliente> Productos_Conceptos_Cliente1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receta_Detalle> Receta_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receta_Detalle> Receta_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receta_Detalle> Receta_Detalle2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receta_Proceso> Receta_Proceso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro_Venta_Salida> Registro_Venta_Salida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rel_Homologacion_Articulos> Rel_Homologacion_Articulos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rel_Homologacion_Articulos> Rel_Homologacion_Articulos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Cajero_Almacen> Relacion_Cajero_Almacen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Depto_CC> Relacion_Depto_CC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Depto_CC> Relacion_Depto_CC1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Depto_CC> Relacion_Depto_CC2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Sucursal_Caja> Relacion_Sucursal_Caja { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Sucursal_Caja> Relacion_Sucursal_Caja1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Sucursal_Caja_Detalle> Relacion_Sucursal_Caja_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Sucursal_IVA> Relacion_Sucursal_IVA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Sucursal_IVA> Relacion_Sucursal_IVA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Sucursal_IVA> Relacion_Sucursal_IVA2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Revision_Calidad> Revision_Calidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Revision_Calidad> Revision_Calidad1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Almacen> Salida_Almacen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Almacen> Salida_Almacen1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Almacen_Detalle> Salida_Almacen_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Almacen_Detalle> Salida_Almacen_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Almacen_Detalle> Salida_Almacen_Detalle2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Almacen_Detalle> Salida_Almacen_Detalle3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Almacen_Detalle> Salida_Almacen_Detalle4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Almacen_Detalle> Salida_Almacen_Detalle5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Almacen_Detalle> Salida_Almacen_Detalle6 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sol_Prod_Detalle_Transformada> Sol_Prod_Detalle_Transformada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sol_Prod_Detalle_Transformada> Sol_Prod_Detalle_Transformada1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sol_Prod_Detalle_Transformada> Sol_Prod_Detalle_Transformada2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sol_Prod_Detalle_Transformada> Sol_Prod_Detalle_Transformada3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sol_Prod_Detalle_Transformada> Sol_Prod_Detalle_Transformada4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sucursal_Almacen_virtual> Sucursal_Almacen_virtual { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sucursal_Almacen_virtual> Sucursal_Almacen_virtual1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sucursal> Sucursals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sucursal_Docto_Folio> Sucursal_Docto_Folio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sucursal_Docto_Folio> Sucursal_Docto_Folio1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taller_Calculo_CP> Taller_Calculo_CP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taller_Calculo_CP_Detalle> Taller_Calculo_CP_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taller_Calculo_CP_Detalle> Taller_Calculo_CP_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taller_Productos> Taller_Productos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taller_Productos> Taller_Productos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taller_Productos> Taller_Productos2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transacciones_Contables> Transacciones_Contables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transporte_Vehiculo> Transporte_Vehiculo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja> Venta_Caja { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja> Venta_Caja1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja> Venta_Caja2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja> Venta_Caja3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja> Venta_Caja4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Almacen> Venta_Caja_Almacen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Almacen> Venta_Caja_Almacen1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Apertura> Venta_Caja_Apertura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Apertura> Venta_Caja_Apertura1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Apertura_Detalle> Venta_Caja_Apertura_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Cierre> Venta_Caja_Cierre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Cierre> Venta_Caja_Cierre1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Cierre> Venta_Caja_Cierre2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Cierre_Pagos> Venta_Caja_Cierre_Pagos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Detalle> Venta_Caja_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Detalle> Venta_Caja_Detalle1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Detalle> Venta_Caja_Detalle2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Pagos> Venta_Caja_Pagos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Pagos> Venta_Caja_Pagos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Salida> Venta_Salida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Salida> Venta_Salida1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Salida> Venta_Salida2 { get; set; }
    }
}
