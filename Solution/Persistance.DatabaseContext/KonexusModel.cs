namespace Persistance.DatabaseContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KonexusModel : DbContext
    {
        public KonexusModel()
            : base("name=KonexusModel")
        {
        }

        public virtual DbSet<Activo_Fijo> Activo_Fijo { get; set; }
        public virtual DbSet<Activo_Fijo_Alta> Activo_Fijo_Alta { get; set; }
        public virtual DbSet<Activo_Fijo_Alta_Detalle> Activo_Fijo_Alta_Detalle { get; set; }
        public virtual DbSet<Activo_Fijo_Asignacion> Activo_Fijo_Asignacion { get; set; }
        public virtual DbSet<Activo_Fijo_Baja> Activo_Fijo_Baja { get; set; }
        public virtual DbSet<Activo_Fijo_Depreciacion> Activo_Fijo_Depreciacion { get; set; }
        public virtual DbSet<Activo_Fijo_Relacion_Contabilidad> Activo_Fijo_Relacion_Contabilidad { get; set; }
        public virtual DbSet<Activos_Fijos_Conceptos> Activos_Fijos_Conceptos { get; set; }
        public virtual DbSet<Activos_Fijos_Depresiacion> Activos_Fijos_Depresiacion { get; set; }
        public virtual DbSet<Actualizacion_Controles> Actualizacion_Controles { get; set; }
        public virtual DbSet<Actualizacion_Controles_Detalle> Actualizacion_Controles_Detalle { get; set; }
        public virtual DbSet<Administracion_Recursos> Administracion_Recursos { get; set; }
        public virtual DbSet<Administracion_Recursos_Detalle> Administracion_Recursos_Detalle { get; set; }
        public virtual DbSet<Alamcen_Solicitud> Alamcen_Solicitud { get; set; }
        public virtual DbSet<Alamcen_Solicitud_Detalle> Alamcen_Solicitud_Detalle { get; set; }
        public virtual DbSet<Almacen> Almacens { get; set; }
        public virtual DbSet<Almacen_Articulos_Negados> Almacen_Articulos_Negados { get; set; }
        public virtual DbSet<Almacen_Concepto_Relacion> Almacen_Concepto_Relacion { get; set; }
        public virtual DbSet<Almacen_Conceptos_UM_Base> Almacen_Conceptos_UM_Base { get; set; }
        public virtual DbSet<Almacen_Conceptos_UM_Equivalencia> Almacen_Conceptos_UM_Equivalencia { get; set; }
        public virtual DbSet<Almacen_Diferencia> Almacen_Diferencia { get; set; }
        public virtual DbSet<Almacen_Inventario> Almacen_Inventario { get; set; }
        public virtual DbSet<Almacen_Requerimiento_Stock> Almacen_Requerimiento_Stock { get; set; }
        public virtual DbSet<Almacen_Requerimiento_Stock_Detalle> Almacen_Requerimiento_Stock_Detalle { get; set; }
        public virtual DbSet<Almacen_Saldo_Inicial> Almacen_Saldo_Inicial { get; set; }
        public virtual DbSet<Almacen_Sol_Prod_Detalle> Almacen_Sol_Prod_Detalle { get; set; }
        public virtual DbSet<Almacen_Sol_Prod_Empaques> Almacen_Sol_Prod_Empaques { get; set; }
        public virtual DbSet<Almacen_Sol_Produccion> Almacen_Sol_Produccion { get; set; }
        public virtual DbSet<Almacen_Transferencia_Detalle> Almacen_Transferencia_Detalle { get; set; }
        public virtual DbSet<Almacen_Transferencia_Detalle_No> Almacen_Transferencia_Detalle_No { get; set; }
        public virtual DbSet<Almacen_Transferencias> Almacen_Transferencias { get; set; }
        public virtual DbSet<Almacen_Transferencias_R> Almacen_Transferencias_R { get; set; }
        public virtual DbSet<Almacen_Transferencias_R_Detalle> Almacen_Transferencias_R_Detalle { get; set; }
        public virtual DbSet<Almacen_UM_Equivalencia> Almacen_UM_Equivalencia { get; set; }
        public virtual DbSet<Almacen_Usuario> Almacen_Usuario { get; set; }
        public virtual DbSet<Articulo_Concepto_Impuesto> Articulo_Concepto_Impuesto { get; set; }
        public virtual DbSet<Articulo_Kit> Articulo_Kit { get; set; }
        public virtual DbSet<Articulo_proveedor> Articulo_proveedor { get; set; }
        public virtual DbSet<Articulo_Transformada> Articulo_Transformada { get; set; }
        public virtual DbSet<Articulo_Transformada_Detalle> Articulo_Transformada_Detalle { get; set; }
        public virtual DbSet<Autoriza_Perfil_Pantalla> Autoriza_Perfil_Pantalla { get; set; }
        public virtual DbSet<Auxiliar_Bitacora> Auxiliar_Bitacora { get; set; }
        public virtual DbSet<Avance_Orden_Produccion> Avance_Orden_Produccion { get; set; }
        public virtual DbSet<Balanza_Tipo> Balanza_Tipo { get; set; }
        public virtual DbSet<BalanzaTMP_TC_Cerrada> BalanzaTMP_TC_Cerrada { get; set; }
        public virtual DbSet<Banco_Conceptos_Transito> Banco_Conceptos_Transito { get; set; }
        public virtual DbSet<Banco_Cuenta_Tercero_Persona_Facultad> Banco_Cuenta_Tercero_Persona_Facultad { get; set; }
        public virtual DbSet<Banco_Formato_Impresion> Banco_Formato_Impresion { get; set; }
        public virtual DbSet<Banco_Mapeo_Conciliacion> Banco_Mapeo_Conciliacion { get; set; }
        public virtual DbSet<Banco_Movimiento_Transferencia> Banco_Movimiento_Transferencia { get; set; }
        public virtual DbSet<Banco_Movimiento_Transferencia_Detalle> Banco_Movimiento_Transferencia_Detalle { get; set; }
        public virtual DbSet<Banco_Num_Reg_Poliza> Banco_Num_Reg_Poliza { get; set; }
        public virtual DbSet<Banco_Num_Reg_Poliza_Transaccion> Banco_Num_Reg_Poliza_Transaccion { get; set; }
        public virtual DbSet<Banco_Transaccion_Multiempresa> Banco_Transaccion_Multiempresa { get; set; }
        public virtual DbSet<Banco_Transito_Movimiento> Banco_Transito_Movimiento { get; set; }
        public virtual DbSet<Banco_Transito_Relacion> Banco_Transito_Relacion { get; set; }
        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<Bancos_Autorizacion_Terceros> Bancos_Autorizacion_Terceros { get; set; }
        public virtual DbSet<Bancos_Conciliacion> Bancos_Conciliacion { get; set; }
        public virtual DbSet<Bancos_Conciliacion_Detalle> Bancos_Conciliacion_Detalle { get; set; }
        public virtual DbSet<Bancos_Cuentas_Propias> Bancos_Cuentas_Propias { get; set; }
        public virtual DbSet<Bancos_Cuentas_Propias_Facultades> Bancos_Cuentas_Propias_Facultades { get; set; }
        public virtual DbSet<Bancos_Cuentas_Terceros> Bancos_Cuentas_Terceros { get; set; }
        public virtual DbSet<Bancos_Cuentas_Terceros_Archivo> Bancos_Cuentas_Terceros_Archivo { get; set; }
        public virtual DbSet<Bancos_Folios_Cancelados> Bancos_Folios_Cancelados { get; set; }
        public virtual DbSet<Bancos_Movimientos_Multiples> Bancos_Movimientos_Multiples { get; set; }
        public virtual DbSet<Bancos_Registro_Movimiento> Bancos_Registro_Movimiento { get; set; }
        public virtual DbSet<Bancos_Rep_Posicion_General_Transito> Bancos_Rep_Posicion_General_Transito { get; set; }
        public virtual DbSet<Bancos_Traspaso_Cuenta> Bancos_Traspaso_Cuenta { get; set; }
        public virtual DbSet<Banda_Relacion_Cliente> Banda_Relacion_Cliente { get; set; }
        public virtual DbSet<Bitacora> Bitacoras { get; set; }
        public virtual DbSet<Caja> Cajas { get; set; }
        public virtual DbSet<Caja_Apertura_Dotacion> Caja_Apertura_Dotacion { get; set; }
        public virtual DbSet<Caja_Arqueo> Caja_Arqueo { get; set; }
        public virtual DbSet<Caja_Arqueo_Detalle> Caja_Arqueo_Detalle { get; set; }
        public virtual DbSet<Caja_Arqueo_Efectivo> Caja_Arqueo_Efectivo { get; set; }
        public virtual DbSet<Caja_Chica> Caja_Chica { get; set; }
        public virtual DbSet<Caja_Chica_Caja_Concepto> Caja_Chica_Caja_Concepto { get; set; }
        public virtual DbSet<Caja_Chica_Comprobacion> Caja_Chica_Comprobacion { get; set; }
        public virtual DbSet<Caja_Chica_Deducible> Caja_Chica_Deducible { get; set; }
        public virtual DbSet<Caja_Chica_Dotacion> Caja_Chica_Dotacion { get; set; }
        public virtual DbSet<Caja_Chica_Dotacion_Comprobacion> Caja_Chica_Dotacion_Comprobacion { get; set; }
        public virtual DbSet<Caja_Chica_Egreso> Caja_Chica_Egreso { get; set; }
        public virtual DbSet<Caja_Chica_Solicitud_Reembolso> Caja_Chica_Solicitud_Reembolso { get; set; }
        public virtual DbSet<Caja_Chica_Solicitud_Reembolso_Detalle> Caja_Chica_Solicitud_Reembolso_Detalle { get; set; }
        public virtual DbSet<Caja_Comprobacion> Caja_Comprobacion { get; set; }
        public virtual DbSet<Caja_Concepto> Caja_Concepto { get; set; }
        public virtual DbSet<Caja_Corte> Caja_Corte { get; set; }
        public virtual DbSet<Caja_Detalle> Caja_Detalle { get; set; }
        public virtual DbSet<Caja_Devolucion> Caja_Devolucion { get; set; }
        public virtual DbSet<Caja_Dotacion> Caja_Dotacion { get; set; }
        public virtual DbSet<Caja_Dotacion_Comprobacion> Caja_Dotacion_Comprobacion { get; set; }
        public virtual DbSet<Caja_Egreso> Caja_Egreso { get; set; }
        public virtual DbSet<Caja_Facultad> Caja_Facultad { get; set; }
        public virtual DbSet<Caja_Pago> Caja_Pago { get; set; }
        public virtual DbSet<Caja_Relacion_Devolucion> Caja_Relacion_Devolucion { get; set; }
        public virtual DbSet<Caja_Solicitud_Reembolso> Caja_Solicitud_Reembolso { get; set; }
        public virtual DbSet<Caja_Solicitud_Reembolso_Detalle> Caja_Solicitud_Reembolso_Detalle { get; set; }
        public virtual DbSet<Calculo_Rendimiento> Calculo_Rendimiento { get; set; }
        public virtual DbSet<CartaModelo> CartaModeloes { get; set; }
        public virtual DbSet<Catalogo> Catalogoes { get; set; }
        public virtual DbSet<Catalogo_Bandas> Catalogo_Bandas { get; set; }
        public virtual DbSet<Catalogo_Bandas_Detalle> Catalogo_Bandas_Detalle { get; set; }
        public virtual DbSet<Catalogo_Margen_Utilidad> Catalogo_Margen_Utilidad { get; set; }
        public virtual DbSet<Catalogo_Nodos> Catalogo_Nodos { get; set; }
        public virtual DbSet<Catalogo_Nodos_Detalle> Catalogo_Nodos_Detalle { get; set; }
        public virtual DbSet<CatalogoDetalle> CatalogoDetalles { get; set; }
        public virtual DbSet<cc_Pagos> cc_Pagos { get; set; }
        public virtual DbSet<cc_Pagos_Detalle> cc_Pagos_Detalle { get; set; }
        public virtual DbSet<Cierre_Contable_Auxiliar> Cierre_Contable_Auxiliar { get; set; }
        public virtual DbSet<Cierre_Inventario> Cierre_Inventario { get; set; }
        public virtual DbSet<Cierres_Contables> Cierres_Contables { get; set; }
        public virtual DbSet<Clasificacion> Clasificacions { get; set; }
        public virtual DbSet<ClasificacionTMP> ClasificacionTMPs { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cliente_Comision_Factura> Cliente_Comision_Factura { get; set; }
        public virtual DbSet<Cliente_Credito> Cliente_Credito { get; set; }
        public virtual DbSet<Cliente_Departamento> Cliente_Departamento { get; set; }
        public virtual DbSet<Cliente_Expediente> Cliente_Expediente { get; set; }
        public virtual DbSet<Cliente_Referencia> Cliente_Referencia { get; set; }
        public virtual DbSet<Cliente_Tab> Cliente_Tab { get; set; }
        public virtual DbSet<Cliente_Vendedor> Cliente_Vendedor { get; set; }
        public virtual DbSet<co_Contabilidad_Polizas_Fecha> co_Contabilidad_Polizas_Fecha { get; set; }
        public virtual DbSet<co_Contabilidad_Polizas_Periodo> co_Contabilidad_Polizas_Periodo { get; set; }
        public virtual DbSet<co_Plantilla> co_Plantilla { get; set; }
        public virtual DbSet<co_Reportes_Contables> co_Reportes_Contables { get; set; }
        public virtual DbSet<co_Reportes_Contables_Detalle> co_Reportes_Contables_Detalle { get; set; }
        public virtual DbSet<co_Reportes_Contables_Importes> co_Reportes_Contables_Importes { get; set; }
        public virtual DbSet<co_Reportes_Contables_Registros> co_Reportes_Contables_Registros { get; set; }
        public virtual DbSet<Compras_Configuracion> Compras_Configuracion { get; set; }
        public virtual DbSet<Conceptos_Entrada_Salida_Almacen> Conceptos_Entrada_Salida_Almacen { get; set; }
        public virtual DbSet<Condiciones_Facturacion_Pago> Condiciones_Facturacion_Pago { get; set; }
        public virtual DbSet<Condiciones_Financieras> Condiciones_Financieras { get; set; }
        public virtual DbSet<Condiciones_Financieras_Descuento> Condiciones_Financieras_Descuento { get; set; }
        public virtual DbSet<Config_Cat_Contable> Config_Cat_Contable { get; set; }
        public virtual DbSet<Contabilidad_Cuenta_Mayor> Contabilidad_Cuenta_Mayor { get; set; }
        public virtual DbSet<Contabilidad_Cuentas_Inhabilitadas> Contabilidad_Cuentas_Inhabilitadas { get; set; }
        public virtual DbSet<Contabilidad_Periodos> Contabilidad_Periodos { get; set; }
        public virtual DbSet<Contabilidad_Polizas> Contabilidad_Polizas { get; set; }
        public virtual DbSet<Contabilidad_Polizas_Alternas> Contabilidad_Polizas_Alternas { get; set; }
        public virtual DbSet<Contabilidad_Relacion_TC> Contabilidad_Relacion_TC { get; set; }
        public virtual DbSet<Contabilidad_Relacion_TipoCuenta> Contabilidad_Relacion_TipoCuenta { get; set; }
        public virtual DbSet<Contabilidad_Resultados_TC> Contabilidad_Resultados_TC { get; set; }
        public virtual DbSet<Contabilidad_TC_TMP> Contabilidad_TC_TMP { get; set; }
        public virtual DbSet<Contacto> Contactoes { get; set; }
        public virtual DbSet<Contacto_Proveedor> Contacto_Proveedor { get; set; }
        public virtual DbSet<Control_Materiales> Control_Materiales { get; set; }
        public virtual DbSet<Control_Materiales_Recibe> Control_Materiales_Recibe { get; set; }
        public virtual DbSet<Control_Procesos> Control_Procesos { get; set; }
        public virtual DbSet<Cotizacion> Cotizacions { get; set; }
        public virtual DbSet<Cotizacion_Autorizar> Cotizacion_Autorizar { get; set; }
        public virtual DbSet<Cotizacion_Cancelada> Cotizacion_Cancelada { get; set; }
        public virtual DbSet<Cotizacion_Comisionistas> Cotizacion_Comisionistas { get; set; }
        public virtual DbSet<Cotizacion_Detalle> Cotizacion_Detalle { get; set; }
        public virtual DbSet<Cotizacion_Detalle_Almacen> Cotizacion_Detalle_Almacen { get; set; }
        public virtual DbSet<Cotizacion_Detalle_Caracteristicas> Cotizacion_Detalle_Caracteristicas { get; set; }
        public virtual DbSet<Cotizacion_Detalle_Impuesto> Cotizacion_Detalle_Impuesto { get; set; }
        public virtual DbSet<Cotizacion_Estatus_Dias> Cotizacion_Estatus_Dias { get; set; }
        public virtual DbSet<Cotizacion_MatRecibido> Cotizacion_MatRecibido { get; set; }
        public virtual DbSet<Cotizacion_Programada> Cotizacion_Programada { get; set; }
        public virtual DbSet<Cotizacion_Relacion_Condiciones_Financiaeras_TMP> Cotizacion_Relacion_Condiciones_Financiaeras_TMP { get; set; }
        public virtual DbSet<Cotizacion_Simple> Cotizacion_Simple { get; set; }
        public virtual DbSet<Cotizacion_Simple_Detalle> Cotizacion_Simple_Detalle { get; set; }
        public virtual DbSet<Cotizacion_Simple_Detalle_Impuesto> Cotizacion_Simple_Detalle_Impuesto { get; set; }
        public virtual DbSet<CP_Anticipos_Intercompanias> CP_Anticipos_Intercompanias { get; set; }
        public virtual DbSet<cp_Pagos> cp_Pagos { get; set; }
        public virtual DbSet<cp_Pagos_Detalle> cp_Pagos_Detalle { get; set; }
        public virtual DbSet<CProyecto_Relacion> CProyecto_Relacion { get; set; }
        public virtual DbSet<CProyecto_Relacion_Concepto_Detalle> CProyecto_Relacion_Concepto_Detalle { get; set; }
        public virtual DbSet<CProyecto_Relacion_Concepto_Detalle_WHERE> CProyecto_Relacion_Concepto_Detalle_WHERE { get; set; }
        public virtual DbSet<CProyecto> CProyectos { get; set; }
        public virtual DbSet<CProyectos_Cotiza> CProyectos_Cotiza { get; set; }
        public virtual DbSet<CProyectos_CP> CProyectos_CP { get; set; }
        public virtual DbSet<CProyectos_Cuentas> CProyectos_Cuentas { get; set; }
        public virtual DbSet<CProyectos_Expediente> CProyectos_Expediente { get; set; }
        public virtual DbSet<CProyectos_Facturas> CProyectos_Facturas { get; set; }
        public virtual DbSet<CProyectos_NC> CProyectos_NC { get; set; }
        public virtual DbSet<CProyectos_Personal> CProyectos_Personal { get; set; }
        public virtual DbSet<CProyectos_Personas> CProyectos_Personas { get; set; }
        public virtual DbSet<CProyectos_Presupuesto> CProyectos_Presupuesto { get; set; }
        public virtual DbSet<CProyectos_Real> CProyectos_Real { get; set; }
        public virtual DbSet<CProyectos_Reg_Polizas> CProyectos_Reg_Polizas { get; set; }
        public virtual DbSet<CProyectos_Relacion_Nomina> CProyectos_Relacion_Nomina { get; set; }
        public virtual DbSet<CProyectos_Relacion_Productos> CProyectos_Relacion_Productos { get; set; }
        public virtual DbSet<CProyectos_Viaticos> CProyectos_Viaticos { get; set; }
        public virtual DbSet<Cuentas_Cobrar> Cuentas_Cobrar { get; set; }
        public virtual DbSet<Cuentas_Cobrar_Antiguedad> Cuentas_Cobrar_Antiguedad { get; set; }
        public virtual DbSet<Cuentas_Cobrar_Antiguedad_Cadena> Cuentas_Cobrar_Antiguedad_Cadena { get; set; }
        public virtual DbSet<Cuentas_Cobrar_Aplicacion_Anticipo> Cuentas_Cobrar_Aplicacion_Anticipo { get; set; }
        public virtual DbSet<Cuentas_Cobrar_Conceptos> Cuentas_Cobrar_Conceptos { get; set; }
        public virtual DbSet<Cuentas_Cobrar_Conceptos_Pantalla> Cuentas_Cobrar_Conceptos_Pantalla { get; set; }
        public virtual DbSet<Cuentas_Cobrar_RAA_TMP> Cuentas_Cobrar_RAA_TMP { get; set; }
        public virtual DbSet<Cuentas_Cobrar_RAN_TMP> Cuentas_Cobrar_RAN_TMP { get; set; }
        public virtual DbSet<Cuentas_Pagar> Cuentas_Pagar { get; set; }
        public virtual DbSet<Cuentas_Pagar_Anticipos> Cuentas_Pagar_Anticipos { get; set; }
        public virtual DbSet<Cuentas_Pagar_Antiguedad> Cuentas_Pagar_Antiguedad { get; set; }
        public virtual DbSet<Cuentas_Pagar_Conceptos> Cuentas_Pagar_Conceptos { get; set; }
        public virtual DbSet<Cuentas_Pagar_RAA_TMP> Cuentas_Pagar_RAA_TMP { get; set; }
        public virtual DbSet<Cuentas_Pagar_RAN_TMP> Cuentas_Pagar_RAN_TMP { get; set; }
        public virtual DbSet<Datos_Conceptos_Plan_Maestro> Datos_Conceptos_Plan_Maestro { get; set; }
        public virtual DbSet<Datos_Embarque> Datos_Embarque { get; set; }
        public virtual DbSet<Descuento_Concepto> Descuento_Concepto { get; set; }
        public virtual DbSet<Deudor_Gastos> Deudor_Gastos { get; set; }
        public virtual DbSet<Devolucion_Cliente> Devolucion_Cliente { get; set; }
        public virtual DbSet<Devolucion_Cliente_Detalle> Devolucion_Cliente_Detalle { get; set; }
        public virtual DbSet<Dia_Horario> Dia_Horario { get; set; }
        public virtual DbSet<Domicilio> Domicilios { get; set; }
        public virtual DbSet<Domicilio_Cliente_Zambrano> Domicilio_Cliente_Zambrano { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Empresa_Horarios> Empresa_Horarios { get; set; }
        public virtual DbSet<Empresa_Logo> Empresa_Logo { get; set; }
        public virtual DbSet<Empresa_Servicios> Empresa_Servicios { get; set; }
        public virtual DbSet<Entrada_Almacen> Entrada_Almacen { get; set; }
        public virtual DbSet<Entrada_Almacen_Detalle> Entrada_Almacen_Detalle { get; set; }
        public virtual DbSet<Entrada_Almacen_Detalle_No> Entrada_Almacen_Detalle_No { get; set; }
        public virtual DbSet<Entrada_Almacen_Detalle_Serie> Entrada_Almacen_Detalle_Serie { get; set; }
        public virtual DbSet<Entrada_Almacen_Detalle_Serie_Compuesta> Entrada_Almacen_Detalle_Serie_Compuesta { get; set; }
        public virtual DbSet<Entrada_Almacen_Producto_Total> Entrada_Almacen_Producto_Total { get; set; }
        public virtual DbSet<Entrada_Almacen_Stock_Excedente> Entrada_Almacen_Stock_Excedente { get; set; }
        public virtual DbSet<Entrada_Almacen_Verificacion> Entrada_Almacen_Verificacion { get; set; }
        public virtual DbSet<Entrega_Almacen_Prod> Entrega_Almacen_Prod { get; set; }
        public virtual DbSet<Entrega_Almacen_Prod_Detalle> Entrega_Almacen_Prod_Detalle { get; set; }
        public virtual DbSet<Entrega_Almacen_Prod_Motivos> Entrega_Almacen_Prod_Motivos { get; set; }
        public virtual DbSet<Equivalencia> Equivalencias { get; set; }
        public virtual DbSet<Equivalencia_Detalle> Equivalencia_Detalle { get; set; }
        public virtual DbSet<Estadisticos_Compras_Articulo_TMP> Estadisticos_Compras_Articulo_TMP { get; set; }
        public virtual DbSet<Estadisticos_Compras_Proveedor_TMP> Estadisticos_Compras_Proveedor_TMP { get; set; }
        public virtual DbSet<Estadisticos_Ventas_Articulo_TMP> Estadisticos_Ventas_Articulo_TMP { get; set; }
        public virtual DbSet<Estadisticos_Ventas_Cliente_TMP> Estadisticos_Ventas_Cliente_TMP { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Factura_Comisionistas> Factura_Comisionistas { get; set; }
        public virtual DbSet<Factura_Concepto> Factura_Concepto { get; set; }
        public virtual DbSet<Factura_Detalle> Factura_Detalle { get; set; }
        public virtual DbSet<Factura_Detalle_Anexo> Factura_Detalle_Anexo { get; set; }
        public virtual DbSet<Factura_Email> Factura_Email { get; set; }
        public virtual DbSet<Factura_Folio_Relacionado> Factura_Folio_Relacionado { get; set; }
        public virtual DbSet<Factura_Ingreso_Diferido> Factura_Ingreso_Diferido { get; set; }
        public virtual DbSet<Factura_Interface_Relacion_Concepto> Factura_Interface_Relacion_Concepto { get; set; }
        public virtual DbSet<Factura_Interface_Relacion_Empresa> Factura_Interface_Relacion_Empresa { get; set; }
        public virtual DbSet<Factura_Interface_XLS> Factura_Interface_XLS { get; set; }
        public virtual DbSet<Factura_Interface_XLS_Detalle> Factura_Interface_XLS_Detalle { get; set; }
        public virtual DbSet<Factura_Interface_XLS_Multiple_TMP> Factura_Interface_XLS_Multiple_TMP { get; set; }
        public virtual DbSet<Factura_Libre> Factura_Libre { get; set; }
        public virtual DbSet<Factura_Libre_Detalle> Factura_Libre_Detalle { get; set; }
        public virtual DbSet<Factura_Relacion_Auxiliar> Factura_Relacion_Auxiliar { get; set; }
        public virtual DbSet<FacturacionDefinicionTimbrado> FacturacionDefinicionTimbradoes { get; set; }
        public virtual DbSet<Facultades_extraordinarias> Facultades_extraordinarias { get; set; }
        public virtual DbSet<Familia> Familias { get; set; }
        public virtual DbSet<fFamilia> fFamilias { get; set; }
        public virtual DbSet<FImpuesto> FImpuestoes { get; set; }
        public virtual DbSet<Flujo_Efectivo_CC> Flujo_Efectivo_CC { get; set; }
        public virtual DbSet<Flujo_Efectivo_CP> Flujo_Efectivo_CP { get; set; }
        public virtual DbSet<Flujo_Efectivo_Egresos> Flujo_Efectivo_Egresos { get; set; }
        public virtual DbSet<Flujo_Efectivo_Encabezado> Flujo_Efectivo_Encabezado { get; set; }
        public virtual DbSet<Flujo_Efectivo_Ingresos> Flujo_Efectivo_Ingresos { get; set; }
        public virtual DbSet<Folio> Folios { get; set; }
        public virtual DbSet<Folio_Campos_Factura_Relacion> Folio_Campos_Factura_Relacion { get; set; }
        public virtual DbSet<Folio_Facultad> Folio_Facultad { get; set; }
        public virtual DbSet<Folio_Relacion_Docto_FE> Folio_Relacion_Docto_FE { get; set; }
        public virtual DbSet<Folios_Cancelados> Folios_Cancelados { get; set; }
        public virtual DbSet<Fondo> Fondoes { get; set; }
        public virtual DbSet<Gastos_Asignacion> Gastos_Asignacion { get; set; }
        public virtual DbSet<Gastos_Asignacion_Deudores> Gastos_Asignacion_Deudores { get; set; }
        public virtual DbSet<Gastos_Reporte> Gastos_Reporte { get; set; }
        public virtual DbSet<Gastos_Reporte_Detalle> Gastos_Reporte_Detalle { get; set; }
        public virtual DbSet<Gastos_Solicitud> Gastos_Solicitud { get; set; }
        public virtual DbSet<Gastos_Solicitud_Tramite> Gastos_Solicitud_Tramite { get; set; }
        public virtual DbSet<Grupo_Persona> Grupo_Persona { get; set; }
        public virtual DbSet<Grupo_Persona_Detalle> Grupo_Persona_Detalle { get; set; }
        public virtual DbSet<Historico_Articulo_Concepto_Impuesto> Historico_Articulo_Concepto_Impuesto { get; set; }
        public virtual DbSet<Historico_Prod_Detalle> Historico_Prod_Detalle { get; set; }
        public virtual DbSet<Historico_Produccion> Historico_Produccion { get; set; }
        public virtual DbSet<Homologacion_Articulos> Homologacion_Articulos { get; set; }
        public virtual DbSet<Homologacion_Modelos> Homologacion_Modelos { get; set; }
        public virtual DbSet<Impuesto> Impuestoes { get; set; }
        public virtual DbSet<ks_Parametros_Comision> ks_Parametros_Comision { get; set; }
        public virtual DbSet<ks_Pedido> ks_Pedido { get; set; }
        public virtual DbSet<ks_Pedido_Detalle> ks_Pedido_Detalle { get; set; }
        public virtual DbSet<ks_Pedido_Entrega> ks_Pedido_Entrega { get; set; }
        public virtual DbSet<Liberacion_Pedidos_Prod> Liberacion_Pedidos_Prod { get; set; }
        public virtual DbSet<Lista_Precios> Lista_Precios { get; set; }
        public virtual DbSet<Lista_Precios_Detalle> Lista_Precios_Detalle { get; set; }
        public virtual DbSet<Lista_Precios_Detalle_TMP> Lista_Precios_Detalle_TMP { get; set; }
        public virtual DbSet<LOG> LOGs { get; set; }
        public virtual DbSet<Material_Procesos> Material_Procesos { get; set; }
        public virtual DbSet<Mensaje> Mensajes { get; set; }
        public virtual DbSet<Metodo_Costeo_Rangos> Metodo_Costeo_Rangos { get; set; }
        public virtual DbSet<Modelo> Modeloes { get; set; }
        public virtual DbSet<Modelo_Detalle> Modelo_Detalle { get; set; }
        public virtual DbSet<Modelo_Producto_Det> Modelo_Producto_Det { get; set; }
        public virtual DbSet<Modelo_Producto_Enc> Modelo_Producto_Enc { get; set; }
        public virtual DbSet<Modelo_Producto_Prod> Modelo_Producto_Prod { get; set; }
        public virtual DbSet<MTransformada_MPrima> MTransformada_MPrima { get; set; }
        public virtual DbSet<Nodo_Relacion_Proveedor> Nodo_Relacion_Proveedor { get; set; }
        public virtual DbSet<Nomina_Cont_Relacion_Empresas> Nomina_Cont_Relacion_Empresas { get; set; }
        public virtual DbSet<Nomina_Fac_Rechazados> Nomina_Fac_Rechazados { get; set; }
        public virtual DbSet<Nota_Credito> Nota_Credito { get; set; }
        public virtual DbSet<Nota_Credito_Concepto> Nota_Credito_Concepto { get; set; }
        public virtual DbSet<Notas_Credito_Compras> Notas_Credito_Compras { get; set; }
        public virtual DbSet<Notas_Credito_Compras_Det> Notas_Credito_Compras_Det { get; set; }
        public virtual DbSet<OP_Receta_Tiempo> OP_Receta_Tiempo { get; set; }
        public virtual DbSet<OP_Receta_Tiempo_Det> OP_Receta_Tiempo_Det { get; set; }
        public virtual DbSet<Orden_Autoriza> Orden_Autoriza { get; set; }
        public virtual DbSet<Orden_Compras> Orden_Compras { get; set; }
        public virtual DbSet<Orden_Compras_Art_No_Catalogo> Orden_Compras_Art_No_Catalogo { get; set; }
        public virtual DbSet<Orden_Compras_Detalle> Orden_Compras_Detalle { get; set; }
        public virtual DbSet<Orden_Compras_Detalle_Impuesto> Orden_Compras_Detalle_Impuesto { get; set; }
        public virtual DbSet<Orden_Compras_No> Orden_Compras_No { get; set; }
        public virtual DbSet<Orden_Compras_Persona> Orden_Compras_Persona { get; set; }
        public virtual DbSet<Orden_Produccion> Orden_Produccion { get; set; }
        public virtual DbSet<Orden_Produccion_Detalle> Orden_Produccion_Detalle { get; set; }
        public virtual DbSet<Orden_Produccion_Lotes> Orden_Produccion_Lotes { get; set; }
        public virtual DbSet<Pago_Comisiones> Pago_Comisiones { get; set; }
        public virtual DbSet<Pendiente> Pendientes { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<Perfil_Autoriza_Venta> Perfil_Autoriza_Venta { get; set; }
        public virtual DbSet<Perfil_concepto> Perfil_concepto { get; set; }
        public virtual DbSet<Perfil_Pendientes> Perfil_Pendientes { get; set; }
        public virtual DbSet<Perfil_programa> Perfil_programa { get; set; }
        public virtual DbSet<Perfil_usuario> Perfil_usuario { get; set; }
        public virtual DbSet<Periodos_Siguientes_Sel> Periodos_Siguientes_Sel { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Persona_Concepto> Persona_Concepto { get; set; }
        public virtual DbSet<Persona_Foto> Persona_Foto { get; set; }
        public virtual DbSet<Persona_Relacion> Persona_Relacion { get; set; }
        public virtual DbSet<Persona_Relacion_Cliente> Persona_Relacion_Cliente { get; set; }
        public virtual DbSet<Plan_Prod_Detalle_Masivo> Plan_Prod_Detalle_Masivo { get; set; }
        public virtual DbSet<Plan_Prod_Fechas> Plan_Prod_Fechas { get; set; }
        public virtual DbSet<Plan_Prod_Fechas_Partidas> Plan_Prod_Fechas_Partidas { get; set; }
        public virtual DbSet<Plan_Prod_Masivo> Plan_Prod_Masivo { get; set; }
        public virtual DbSet<Plan_Prod_Partidas_Masivo> Plan_Prod_Partidas_Masivo { get; set; }
        public virtual DbSet<Plan_Prod_Periodos_Masivo> Plan_Prod_Periodos_Masivo { get; set; }
        public virtual DbSet<Plan_Produccion> Plan_Produccion { get; set; }
        public virtual DbSet<Produccion_Almacen> Produccion_Almacen { get; set; }
        public virtual DbSet<Produccion_Almacen_Detalle> Produccion_Almacen_Detalle { get; set; }
        public virtual DbSet<Produccion_Salida_Almacen> Produccion_Salida_Almacen { get; set; }
        public virtual DbSet<Produccion_Salida_Almacen_Detalle> Produccion_Salida_Almacen_Detalle { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<Producto_Cliente> Producto_Cliente { get; set; }
        public virtual DbSet<Producto_Impuesto> Producto_Impuesto { get; set; }
        public virtual DbSet<Productos_Conceptos> Productos_Conceptos { get; set; }
        public virtual DbSet<Productos_Conceptos_Adicionales> Productos_Conceptos_Adicionales { get; set; }
        public virtual DbSet<Productos_Conceptos_Caducidad> Productos_Conceptos_Caducidad { get; set; }
        public virtual DbSet<Productos_Conceptos_Cliente> Productos_Conceptos_Cliente { get; set; }
        public virtual DbSet<Productos_Conceptos_Kits> Productos_Conceptos_Kits { get; set; }
        public virtual DbSet<Programa> Programas { get; set; }
        public virtual DbSet<Proveedor> Proveedors { get; set; }
        public virtual DbSet<Proveedor_Iva> Proveedor_Iva { get; set; }
        public virtual DbSet<Receta> Recetas { get; set; }
        public virtual DbSet<Receta_Detalle> Receta_Detalle { get; set; }
        public virtual DbSet<Receta_Proceso> Receta_Proceso { get; set; }
        public virtual DbSet<Registro_Pago> Registro_Pago { get; set; }
        public virtual DbSet<Rel_Homologacion_Articulos> Rel_Homologacion_Articulos { get; set; }
        public virtual DbSet<Rel_Homologacion_Modelos> Rel_Homologacion_Modelos { get; set; }
        public virtual DbSet<Relacion_Caja_Cajero> Relacion_Caja_Cajero { get; set; }
        public virtual DbSet<Relacion_Cajero_Almacen> Relacion_Cajero_Almacen { get; set; }
        public virtual DbSet<Relacion_Cliente_Proveedor> Relacion_Cliente_Proveedor { get; set; }
        public virtual DbSet<Relacion_Depto_CC> Relacion_Depto_CC { get; set; }
        public virtual DbSet<Relacion_Sucursal_Caja> Relacion_Sucursal_Caja { get; set; }
        public virtual DbSet<Relacion_Sucursal_Caja_Detalle> Relacion_Sucursal_Caja_Detalle { get; set; }
        public virtual DbSet<Relacion_Sucursal_IVA> Relacion_Sucursal_IVA { get; set; }
        public virtual DbSet<Relacion_Venta_Almacen> Relacion_Venta_Almacen { get; set; }
        public virtual DbSet<Report_Cont_1_2> Report_Cont_1_2 { get; set; }
        public virtual DbSet<Reporte_Etiquetas_Embarque> Reporte_Etiquetas_Embarque { get; set; }
        public virtual DbSet<Reporte_Orden_Embarque> Reporte_Orden_Embarque { get; set; }
        public virtual DbSet<Requisicion_Autoriza> Requisicion_Autoriza { get; set; }
        public virtual DbSet<Requisicion_Compra> Requisicion_Compra { get; set; }
        public virtual DbSet<Requisicion_Compra_Art_No_Catalogo> Requisicion_Compra_Art_No_Catalogo { get; set; }
        public virtual DbSet<Requisicion_Compra_Det> Requisicion_Compra_Det { get; set; }
        public virtual DbSet<Requisicion_Persona> Requisicion_Persona { get; set; }
        public virtual DbSet<Revision_Calidad> Revision_Calidad { get; set; }
        public virtual DbSet<RH_Persona> RH_Persona { get; set; }
        public virtual DbSet<Salida_Almacen> Salida_Almacen { get; set; }
        public virtual DbSet<Salida_Almacen_Costo> Salida_Almacen_Costo { get; set; }
        public virtual DbSet<Salida_Almacen_Detalle> Salida_Almacen_Detalle { get; set; }
        public virtual DbSet<Salida_Almacen_Detalle_No> Salida_Almacen_Detalle_No { get; set; }
        public virtual DbSet<Salida_Almacen_Relacion_Conceptos> Salida_Almacen_Relacion_Conceptos { get; set; }
        public virtual DbSet<Sat_Catalogo_prod_Serv> Sat_Catalogo_prod_Serv { get; set; }
        public virtual DbSet<Sol_Prod_Detalle_Transformada> Sol_Prod_Detalle_Transformada { get; set; }
        public virtual DbSet<Solicitud_Cotizacion> Solicitud_Cotizacion { get; set; }
        public virtual DbSet<Solicitud_Cotizacion_Art_No_Catalogo> Solicitud_Cotizacion_Art_No_Catalogo { get; set; }
        public virtual DbSet<Solicitud_Cotizacion_Detalle> Solicitud_Cotizacion_Detalle { get; set; }
        public virtual DbSet<Solicitud_Cotizacion_Persona> Solicitud_Cotizacion_Persona { get; set; }
        public virtual DbSet<Sucursal> Sucursals { get; set; }
        public virtual DbSet<Sucursal_Almacen_virtual> Sucursal_Almacen_virtual { get; set; }
        public virtual DbSet<Sucursal_Docto_Folio> Sucursal_Docto_Folio { get; set; }
        public virtual DbSet<Sucursal_Usuario> Sucursal_Usuario { get; set; }
        public virtual DbSet<Sucursal_Usuario_TMP> Sucursal_Usuario_TMP { get; set; }
        public virtual DbSet<Taller_Calculo_CP> Taller_Calculo_CP { get; set; }
        public virtual DbSet<Taller_Calculo_CP_Detalle> Taller_Calculo_CP_Detalle { get; set; }
        public virtual DbSet<Taller_Impuestos> Taller_Impuestos { get; set; }
        public virtual DbSet<Taller_Productos> Taller_Productos { get; set; }
        public virtual DbSet<Tipo_Cambio> Tipo_Cambio { get; set; }
        public virtual DbSet<Transaccion_Contable_Matriz> Transaccion_Contable_Matriz { get; set; }
        public virtual DbSet<Transaccion_Contable_Matriz_Detalle> Transaccion_Contable_Matriz_Detalle { get; set; }
        public virtual DbSet<Transaccion_Matriz_Tipo> Transaccion_Matriz_Tipo { get; set; }
        public virtual DbSet<Transaccion_Programa> Transaccion_Programa { get; set; }
        public virtual DbSet<Transaccion_Programa_Auxiliar> Transaccion_Programa_Auxiliar { get; set; }
        public virtual DbSet<Transacciones_Contables> Transacciones_Contables { get; set; }
        public virtual DbSet<Transporte_Rutas> Transporte_Rutas { get; set; }
        public virtual DbSet<Transporte_Rutas_Detalle> Transporte_Rutas_Detalle { get; set; }
        public virtual DbSet<Transporte_Rutas_Permiso> Transporte_Rutas_Permiso { get; set; }
        public virtual DbSet<Transporte_Vehiculo> Transporte_Vehiculo { get; set; }
        public virtual DbSet<Ubicacion_Articulo> Ubicacion_Articulo { get; set; }
        public virtual DbSet<Ultima_Compra_Proveedor_TMP> Ultima_Compra_Proveedor_TMP { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Usuario_Tipo_Cliente> Usuario_Tipo_Cliente { get; set; }
        public virtual DbSet<Vendedor> Vendedors { get; set; }
        public virtual DbSet<Vendedor_Comision_Producto> Vendedor_Comision_Producto { get; set; }
        public virtual DbSet<Vendedor_Desc_Factura> Vendedor_Desc_Factura { get; set; }
        public virtual DbSet<Vendedor_TipoCliente> Vendedor_TipoCliente { get; set; }
        public virtual DbSet<Venta_Auxiliares_Cajeros> Venta_Auxiliares_Cajeros { get; set; }
        public virtual DbSet<Venta_Caja> Venta_Caja { get; set; }
        public virtual DbSet<Venta_Caja_Almacen> Venta_Caja_Almacen { get; set; }
        public virtual DbSet<Venta_Caja_Apertura> Venta_Caja_Apertura { get; set; }
        public virtual DbSet<Venta_Caja_Apertura_Detalle> Venta_Caja_Apertura_Detalle { get; set; }
        public virtual DbSet<Venta_Caja_Cierre> Venta_Caja_Cierre { get; set; }
        public virtual DbSet<Venta_Caja_Cierre_Detalle> Venta_Caja_Cierre_Detalle { get; set; }
        public virtual DbSet<Venta_Caja_Cierre_Pagos> Venta_Caja_Cierre_Pagos { get; set; }
        public virtual DbSet<Venta_Caja_Detalle> Venta_Caja_Detalle { get; set; }
        public virtual DbSet<Venta_Caja_Pagos> Venta_Caja_Pagos { get; set; }
        public virtual DbSet<Venta_Configuracion> Venta_Configuracion { get; set; }
        public virtual DbSet<Viaticos_Asignacion> Viaticos_Asignacion { get; set; }
        public virtual DbSet<Viaticos_Conceptos> Viaticos_Conceptos { get; set; }
        public virtual DbSet<Viaticos_Devolucion> Viaticos_Devolucion { get; set; }
        public virtual DbSet<Viaticos_Liquidacion> Viaticos_Liquidacion { get; set; }
        public virtual DbSet<Viaticos_Liquidacion_Detalle> Viaticos_Liquidacion_Detalle { get; set; }
        public virtual DbSet<Viaticos_Solicitud> Viaticos_Solicitud { get; set; }
        public virtual DbSet<Viaticos_Solicitud_Tramite> Viaticos_Solicitud_Tramite { get; set; }
        public virtual DbSet<Zona_Relacion_Almacen> Zona_Relacion_Almacen { get; set; }
        public virtual DbSet<Activo_Fijo_Asignacion_Consulta_Tmp> Activo_Fijo_Asignacion_Consulta_Tmp { get; set; }
        public virtual DbSet<Activo_Fijo_Consulta_Depreciacion_Tmp> Activo_Fijo_Consulta_Depreciacion_Tmp { get; set; }
        public virtual DbSet<Activo_Fijo_Consulta_Tmp> Activo_Fijo_Consulta_Tmp { get; set; }
        public virtual DbSet<Alamcen_Solicitud_Autoriza> Alamcen_Solicitud_Autoriza { get; set; }
        public virtual DbSet<Almacen_Existencia_TMP> Almacen_Existencia_TMP { get; set; }
        public virtual DbSet<Almacen_Inventario_Detalle> Almacen_Inventario_Detalle { get; set; }
        public virtual DbSet<Almacen_Listado> Almacen_Listado { get; set; }
        public virtual DbSet<Almacen_Transferencia_Detalles> Almacen_Transferencia_Detalles { get; set; }
        public virtual DbSet<Almacen_Ubicacion> Almacen_Ubicacion { get; set; }
        public virtual DbSet<Apertura_Inventario> Apertura_Inventario { get; set; }
        public virtual DbSet<Archivo_Nomina_Alterna> Archivo_Nomina_Alterna { get; set; }
        public virtual DbSet<Articulo> Articuloes { get; set; }
        public virtual DbSet<Articulo_Concepto> Articulo_Concepto { get; set; }
        public virtual DbSet<Articulo_Depto> Articulo_Depto { get; set; }
        public virtual DbSet<Articulo_Descuento_Cliente1_TMP> Articulo_Descuento_Cliente1_TMP { get; set; }
        public virtual DbSet<AuxMovChequerasNC> AuxMovChequerasNCs { get; set; }
        public virtual DbSet<Banco_Concepto_Conciliacion> Banco_Concepto_Conciliacion { get; set; }
        public virtual DbSet<Banco_Conciliacion_XLS> Banco_Conciliacion_XLS { get; set; }
        public virtual DbSet<Banco_Reporte_No_Conciliados> Banco_Reporte_No_Conciliados { get; set; }
        public virtual DbSet<Bancos_Contactos> Bancos_Contactos { get; set; }
        public virtual DbSet<Bancos_Mon_Ext_Revaluado_Rpt> Bancos_Mon_Ext_Revaluado_Rpt { get; set; }
        public virtual DbSet<Bancos_Movimientos_Multiples_Detalle> Bancos_Movimientos_Multiples_Detalle { get; set; }
        public virtual DbSet<Bancos_Relacion_Cuentas> Bancos_Relacion_Cuentas { get; set; }
        public virtual DbSet<Bitacora_Autorizacion> Bitacora_Autorizacion { get; set; }
        public virtual DbSet<Caja_Arqueo_Egresos_TMP> Caja_Arqueo_Egresos_TMP { get; set; }
        public virtual DbSet<Caja_Arqueo_Seleccion_TMP> Caja_Arqueo_Seleccion_TMP { get; set; }
        public virtual DbSet<Caja_Relacion_Auxiliar> Caja_Relacion_Auxiliar { get; set; }
        public virtual DbSet<Campos_Calculo_CP> Campos_Calculo_CP { get; set; }
        public virtual DbSet<Campos_Calculo_CP_Relacion> Campos_Calculo_CP_Relacion { get; set; }
        public virtual DbSet<CamposCheque> CamposCheques { get; set; }
        public virtual DbSet<CartaModelo_Detalle> CartaModelo_Detalle { get; set; }
        public virtual DbSet<CartaModeloTMP> CartaModeloTMPs { get; set; }
        public virtual DbSet<Catalogo_Inventarios_ag> Catalogo_Inventarios_ag { get; set; }
        public virtual DbSet<cc_Anticipos_Clientes_TMP> cc_Anticipos_Clientes_TMP { get; set; }
        public virtual DbSet<cc_Estado_Cuenta_TMP> cc_Estado_Cuenta_TMP { get; set; }
        public virtual DbSet<cc_Proceso_Pago> cc_Proceso_Pago { get; set; }
        public virtual DbSet<ChequerasBanco> ChequerasBancoes { get; set; }
        public virtual DbSet<ChequesBanco> ChequesBancoes { get; set; }
        public virtual DbSet<Cierre_Inventario_Detalle> Cierre_Inventario_Detalle { get; set; }
        public virtual DbSet<Cliente_Comision_Vendedor_Art> Cliente_Comision_Vendedor_Art { get; set; }
        public virtual DbSet<Cliente_Desc_Factura> Cliente_Desc_Factura { get; set; }
        public virtual DbSet<Cliente_Desc_Factura_TMP> Cliente_Desc_Factura_TMP { get; set; }
        public virtual DbSet<Clientes_Conta_Comparativo> Clientes_Conta_Comparativo { get; set; }
        public virtual DbSet<co_Parametros_Reporteador> co_Parametros_Reporteador { get; set; }
        public virtual DbSet<co_Reportes_Plantilla> co_Reportes_Plantilla { get; set; }
        public virtual DbSet<Concepto> Conceptoes { get; set; }
        public virtual DbSet<ConceptoBanco> ConceptoBancoes { get; set; }
        public virtual DbSet<ConceptoInterno> ConceptoInternoes { get; set; }
        public virtual DbSet<Conceptos_Devolucion_Cliente> Conceptos_Devolucion_Cliente { get; set; }
        public virtual DbSet<Conceptos_Entrada_Salida_Almacen_TMP> Conceptos_Entrada_Salida_Almacen_TMP { get; set; }
        public virtual DbSet<ConceptoTMP> ConceptoTMPs { get; set; }
        public virtual DbSet<Condiciones_Facturacion_Revision> Condiciones_Facturacion_Revision { get; set; }
        public virtual DbSet<Consulta_Apartados_TMP> Consulta_Apartados_TMP { get; set; }
        public virtual DbSet<Consulta_Punto_Reorden_TMP> Consulta_Punto_Reorden_TMP { get; set; }
        public virtual DbSet<Contabilidad> Contabilidads { get; set; }
        public virtual DbSet<Contabilidad_Cuenta_Mayor_TMP> Contabilidad_Cuenta_Mayor_TMP { get; set; }
        public virtual DbSet<Contabilidad_Polizas_Importadas> Contabilidad_Polizas_Importadas { get; set; }
        public virtual DbSet<Contabilidad_Polizas_Paso> Contabilidad_Polizas_Paso { get; set; }
        public virtual DbSet<Contabilidad_Polizas_Revaluacion> Contabilidad_Polizas_Revaluacion { get; set; }
        public virtual DbSet<Contabilidad_Polizas_Simples> Contabilidad_Polizas_Simples { get; set; }
        public virtual DbSet<Contabilidad_Polizas_Tipo> Contabilidad_Polizas_Tipo { get; set; }
        public virtual DbSet<Contabilidad_Polizas_TMP> Contabilidad_Polizas_TMP { get; set; }
        public virtual DbSet<ControlOficina> ControlOficinas { get; set; }
        public virtual DbSet<CorteOficinaUsuario> CorteOficinaUsuarios { get; set; }
        public virtual DbSet<Cotizacion_Art_Descuentos> Cotizacion_Art_Descuentos { get; set; }
        public virtual DbSet<Cotizacion_Autoriza> Cotizacion_Autoriza { get; set; }
        public virtual DbSet<Cotizacion_Comisiones_Productos> Cotizacion_Comisiones_Productos { get; set; }
        public virtual DbSet<Cotizacion_Detalle_Almacen_TMP> Cotizacion_Detalle_Almacen_TMP { get; set; }
        public virtual DbSet<Cotizacion_Detalle_Caracteristicas_TMP> Cotizacion_Detalle_Caracteristicas_TMP { get; set; }
        public virtual DbSet<Cotizacion_Encabezado_XLS> Cotizacion_Encabezado_XLS { get; set; }
        public virtual DbSet<Cotizacion_Entrega> Cotizacion_Entrega { get; set; }
        public virtual DbSet<Cotizacion_Fac_Descuentos> Cotizacion_Fac_Descuentos { get; set; }
        public virtual DbSet<Cotizacion_Simple_Detalle_Almacen_TMP> Cotizacion_Simple_Detalle_Almacen_TMP { get; set; }
        public virtual DbSet<cp_Anticipos_Proveedores_TMP> cp_Anticipos_Proveedores_TMP { get; set; }
        public virtual DbSet<cp_Consulta_por_Concepto_TMP> cp_Consulta_por_Concepto_TMP { get; set; }
        public virtual DbSet<cp_Diot_Proceso> cp_Diot_Proceso { get; set; }
        public virtual DbSet<cp_Estado_Cuenta_TMP> cp_Estado_Cuenta_TMP { get; set; }
        public virtual DbSet<cp_Pagos_Poliza> cp_Pagos_Poliza { get; set; }
        public virtual DbSet<cp_Proceso_Contabilidad> cp_Proceso_Contabilidad { get; set; }
        public virtual DbSet<cp_Proceso_Pago> cp_Proceso_Pago { get; set; }
        public virtual DbSet<CProyecto_Relacion_Concepto> CProyecto_Relacion_Concepto { get; set; }
        public virtual DbSet<CProyectos_Tab> CProyectos_Tab { get; set; }
        public virtual DbSet<Cuentas_Cobrar_Anticipos> Cuentas_Cobrar_Anticipos { get; set; }
        public virtual DbSet<Cuentas_Cobrar_Comparativo_Tmp> Cuentas_Cobrar_Comparativo_Tmp { get; set; }
        public virtual DbSet<Cuentas_Cobrar_Conceptos_TMP> Cuentas_Cobrar_Conceptos_TMP { get; set; }
        public virtual DbSet<Cuentas_Cobrar_Global> Cuentas_Cobrar_Global { get; set; }
        public virtual DbSet<Cuentas_Cobrar_Tmp> Cuentas_Cobrar_Tmp { get; set; }
        public virtual DbSet<Cuentas_Pagar_Comparativo_Tmp> Cuentas_Pagar_Comparativo_Tmp { get; set; }
        public virtual DbSet<Cuentas_Pagar_Conceptos_TMP> Cuentas_Pagar_Conceptos_TMP { get; set; }
        public virtual DbSet<Entrada_Almacen_Costo> Entrada_Almacen_Costo { get; set; }
        public virtual DbSet<Entrada_Almacen_Detalle_TMP> Entrada_Almacen_Detalle_TMP { get; set; }
        public virtual DbSet<Entrada_Salida_Almacen> Entrada_Salida_Almacen { get; set; }
        public virtual DbSet<Entrada_Salida_Almacen_Det> Entrada_Salida_Almacen_Det { get; set; }
        public virtual DbSet<Estadisticos_Compras_Articulo_TMP1> Estadisticos_Compras_Articulo_TMP1 { get; set; }
        public virtual DbSet<Estadisticos_Ventas_Cliente_TMP1> Estadisticos_Ventas_Cliente_TMP1 { get; set; }
        public virtual DbSet<Estado_Resultados_Anual> Estado_Resultados_Anual { get; set; }
        public virtual DbSet<Estado_Resultados_Anual_Concen> Estado_Resultados_Anual_Concen { get; set; }
        public virtual DbSet<Estado_Resultados_Mensual> Estado_Resultados_Mensual { get; set; }
        public virtual DbSet<Estado_Resultados_Mensual_Concen> Estado_Resultados_Mensual_Concen { get; set; }
        public virtual DbSet<Estado_Resultados_Mensual1> Estado_Resultados_Mensual1 { get; set; }
        public virtual DbSet<exporta_cheques> exporta_cheques { get; set; }
        public virtual DbSet<Factura_Concepto_TMP> Factura_Concepto_TMP { get; set; }
        public virtual DbSet<Factura_Descuentos> Factura_Descuentos { get; set; }
        public virtual DbSet<Factura_Descuentos_Art> Factura_Descuentos_Art { get; set; }
        public virtual DbSet<Factura_Descuentos_Art_TMP> Factura_Descuentos_Art_TMP { get; set; }
        public virtual DbSet<Factura_Detalle_Impuesto> Factura_Detalle_Impuesto { get; set; }
        public virtual DbSet<Factura_Interface_Totales> Factura_Interface_Totales { get; set; }
        public virtual DbSet<Factura_XLS> Factura_XLS { get; set; }
        public virtual DbSet<Facturacion_Cuentas_Pagar_TMP> Facturacion_Cuentas_Pagar_TMP { get; set; }
        public virtual DbSet<Facturas_Periodicas> Facturas_Periodicas { get; set; }
        public virtual DbSet<Facturas_Periodicas_Encabezado> Facturas_Periodicas_Encabezado { get; set; }
        public virtual DbSet<FamiliaTMP> FamiliaTMPs { get; set; }
        public virtual DbSet<FBitacora_Autorizacion> FBitacora_Autorizacion { get; set; }
        public virtual DbSet<FE_CxC_Sin_FF> FE_CxC_Sin_FF { get; set; }
        public virtual DbSet<FE_CxP_Sin_FF> FE_CxP_Sin_FF { get; set; }
        public virtual DbSet<FE_CxP_Sin_FF_Todos> FE_CxP_Sin_FF_Todos { get; set; }
        public virtual DbSet<FE_Datos_CFDI_CxP> FE_Datos_CFDI_CxP { get; set; }
        public virtual DbSet<FE_NO_Relacion_CFDI_CxC> FE_NO_Relacion_CFDI_CxC { get; set; }
        public virtual DbSet<FE_NO_Relacion_CFDI_CxP> FE_NO_Relacion_CFDI_CxP { get; set; }
        public virtual DbSet<FE_Relacion_CFDI_CxC> FE_Relacion_CFDI_CxC { get; set; }
        public virtual DbSet<FE_Relacion_CFDI_CxP> FE_Relacion_CFDI_CxP { get; set; }
        public virtual DbSet<fFactura> fFacturas { get; set; }
        public virtual DbSet<Folio_Campos_Factura> Folio_Campos_Factura { get; set; }
        public virtual DbSet<Folio_Campos_Factura_Relacion_Partida> Folio_Campos_Factura_Relacion_Partida { get; set; }
        public virtual DbSet<Folio_TMP> Folio_TMP { get; set; }
        public virtual DbSet<fRecibo> fReciboes { get; set; }
        public virtual DbSet<Gastos_Solicitud_Autorizacion> Gastos_Solicitud_Autorizacion { get; set; }
        public virtual DbSet<Historico_Productos_Conceptos> Historico_Productos_Conceptos { get; set; }
        public virtual DbSet<Ingresos_Diferidos> Ingresos_Diferidos { get; set; }
        public virtual DbSet<Ingresos_Diferidos_Consulta> Ingresos_Diferidos_Consulta { get; set; }
        public virtual DbSet<Ingresos_Diferidos_Consulta_Detalles> Ingresos_Diferidos_Consulta_Detalles { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<Inventario_Movimientos> Inventario_Movimientos { get; set; }
        public virtual DbSet<Liberacion_Cheque> Liberacion_Cheque { get; set; }
        public virtual DbSet<Liberacion_Factura> Liberacion_Factura { get; set; }
        public virtual DbSet<Metodo_Costeo_Reporte_TMP> Metodo_Costeo_Reporte_TMP { get; set; }
        public virtual DbSet<Modelo_Importacion_Polizas> Modelo_Importacion_Polizas { get; set; }
        public virtual DbSet<Modelo_Niveles> Modelo_Niveles { get; set; }
        public virtual DbSet<Modelo_Parametro> Modelo_Parametro { get; set; }
        public virtual DbSet<Modelo_Producto_Prod_TMP> Modelo_Producto_Prod_TMP { get; set; }
        public virtual DbSet<Modelo_Producto_TMP> Modelo_Producto_TMP { get; set; }
        public virtual DbSet<Moneda> Monedas { get; set; }
        public virtual DbSet<MovChequera> MovChequeras { get; set; }
        public virtual DbSet<MovEdoCta> MovEdoCtas { get; set; }
        public virtual DbSet<Nomina_Cont_Cve_Conc> Nomina_Cont_Cve_Conc { get; set; }
        public virtual DbSet<nomina_contabilidad_Rechazados> nomina_contabilidad_Rechazados { get; set; }
        public virtual DbSet<Nomina_Fact_Relacion_Empresas> Nomina_Fact_Relacion_Empresas { get; set; }
        public virtual DbSet<Nota_Credito_Detalle> Nota_Credito_Detalle { get; set; }
        public virtual DbSet<Nota_Credito_Detalle_Impuesto> Nota_Credito_Detalle_Impuesto { get; set; }
        public virtual DbSet<Numero_ID_Consulta> Numero_ID_Consulta { get; set; }
        public virtual DbSet<OP_Simulacion> OP_Simulacion { get; set; }
        public virtual DbSet<OP_Simulacion_Detalle> OP_Simulacion_Detalle { get; set; }
        public virtual DbSet<OP_Simulacion_Detalle_Resumen> OP_Simulacion_Detalle_Resumen { get; set; }
        public virtual DbSet<OperacionesProgramada> OperacionesProgramadas { get; set; }
        public virtual DbSet<Orden_Compras_Art_No_Cat_Pre> Orden_Compras_Art_No_Cat_Pre { get; set; }
        public virtual DbSet<Orden_Compras_Encabezado_XLS> Orden_Compras_Encabezado_XLS { get; set; }
        public virtual DbSet<Orden_Compras_Factura> Orden_Compras_Factura { get; set; }
        public virtual DbSet<Orden_Compras_Factura_Detalle> Orden_Compras_Factura_Detalle { get; set; }
        public virtual DbSet<Orden_Compras_Factura_Multiple> Orden_Compras_Factura_Multiple { get; set; }
        public virtual DbSet<Orden_Compras_Factura_Multiple_Det> Orden_Compras_Factura_Multiple_Det { get; set; }
        public virtual DbSet<Orden_Compras_Factura_No> Orden_Compras_Factura_No { get; set; }
        public virtual DbSet<Orden_Compras_Gastos> Orden_Compras_Gastos { get; set; }
        public virtual DbSet<Orden_Compras_Pre> Orden_Compras_Pre { get; set; }
        public virtual DbSet<Orden_MTransformada_MPrima_TMP> Orden_MTransformada_MPrima_TMP { get; set; }
        public virtual DbSet<Ordene> Ordenes { get; set; }
        public virtual DbSet<Pago_Comisiones_Previa> Pago_Comisiones_Previa { get; set; }
        public virtual DbSet<Parametros_Produccion> Parametros_Produccion { get; set; }
        public virtual DbSet<Pedido> Pedidoes { get; set; }
        public virtual DbSet<Pedido_Articulo> Pedido_Articulo { get; set; }
        public virtual DbSet<PendientesTMP> PendientesTMPs { get; set; }
        public virtual DbSet<Perfil_ConceptoTMP> Perfil_ConceptoTMP { get; set; }
        public virtual DbSet<Perfil_EmpresaTMP> Perfil_EmpresaTMP { get; set; }
        public virtual DbSet<Perfil_usuarioTMP> Perfil_usuarioTMP { get; set; }
        public virtual DbSet<Persona_Tipo_Relacion> Persona_Tipo_Relacion { get; set; }
        public virtual DbSet<Plan_Produccion_Detalle> Plan_Produccion_Detalle { get; set; }
        public virtual DbSet<Prorrateo_Taller> Prorrateo_Taller { get; set; }
        public virtual DbSet<Prorrateo_Taller_Detalle> Prorrateo_Taller_Detalle { get; set; }
        public virtual DbSet<Proveedor_Conta_Comparativo> Proveedor_Conta_Comparativo { get; set; }
        public virtual DbSet<Proveedor_Contrato> Proveedor_Contrato { get; set; }
        public virtual DbSet<Receta_Crea_TMP> Receta_Crea_TMP { get; set; }
        public virtual DbSet<Registro_Venta_Salida> Registro_Venta_Salida { get; set; }
        public virtual DbSet<Relacion_Articulo_Costo> Relacion_Articulo_Costo { get; set; }
        public virtual DbSet<Relacion_Persona_Tipo_Docto> Relacion_Persona_Tipo_Docto { get; set; }
        public virtual DbSet<Reporte_Entrada_Salida_Relacion> Reporte_Entrada_Salida_Relacion { get; set; }
        public virtual DbSet<Reporte_Orden_Salida_Almacen_TMP> Reporte_Orden_Salida_Almacen_TMP { get; set; }
        public virtual DbSet<Reporte_Transaccion_Contable_Matriz_TMP> Reporte_Transaccion_Contable_Matriz_TMP { get; set; }
        public virtual DbSet<Requisicion_Compra_Autoriza> Requisicion_Compra_Autoriza { get; set; }
        public virtual DbSet<Requisicion_Firmas> Requisicion_Firmas { get; set; }
        public virtual DbSet<Salida_Almacen_Punto_Venta> Salida_Almacen_Punto_Venta { get; set; }
        public virtual DbSet<Salida_Almacen_Punto_Venta_Rechazado> Salida_Almacen_Punto_Venta_Rechazado { get; set; }
        public virtual DbSet<Salida_Almacen_Punto_Venta_Rechazado_TMP> Salida_Almacen_Punto_Venta_Rechazado_TMP { get; set; }
        public virtual DbSet<Salida_Costo_TMP> Salida_Costo_TMP { get; set; }
        public virtual DbSet<Salida_Entrada_XLS_TMP> Salida_Entrada_XLS_TMP { get; set; }
        public virtual DbSet<Salida_Pedido_TMP> Salida_Pedido_TMP { get; set; }
        public virtual DbSet<Salida_Produccion_XLS> Salida_Produccion_XLS { get; set; }
        public virtual DbSet<Sat_Catalogo_CP> Sat_Catalogo_CP { get; set; }
        public virtual DbSet<Sat_Catalogo_Prod_Serv_Homologado> Sat_Catalogo_Prod_Serv_Homologado { get; set; }
        public virtual DbSet<Sat_Clave_Unidad> Sat_Clave_Unidad { get; set; }
        public virtual DbSet<TipoCambio> TipoCambios { get; set; }
        public virtual DbSet<TipoOficina> TipoOficinas { get; set; }
        public virtual DbSet<Transaccion_Contable_Matriz_Producto> Transaccion_Contable_Matriz_Producto { get; set; }
        public virtual DbSet<Transaccion_Programa_Auxiliar_TMP> Transaccion_Programa_Auxiliar_TMP { get; set; }
        public virtual DbSet<Transaccion_Programa_TMP> Transaccion_Programa_TMP { get; set; }
        public virtual DbSet<Transacciones_Contables_TMP> Transacciones_Contables_TMP { get; set; }
        public virtual DbSet<Transferencia> Transferencias { get; set; }
        public virtual DbSet<vcp_Pagos_Multiples> vcp_Pagos_Multiples { get; set; }
        public virtual DbSet<Vendedor_Desc_Productos> Vendedor_Desc_Productos { get; set; }
        public virtual DbSet<Venta_Salida> Venta_Salida { get; set; }
        public virtual DbSet<Verifica_CxP> Verifica_CxP { get; set; }
        public virtual DbSet<Viaticos_Comprobantes> Viaticos_Comprobantes { get; set; }
        public virtual DbSet<Viaticos_Justificacion_Rpt> Viaticos_Justificacion_Rpt { get; set; }
        public virtual DbSet<Viaticos_Num_Reg_Poliza> Viaticos_Num_Reg_Poliza { get; set; }
        public virtual DbSet<Viaticos_Relacion_Auxiliar> Viaticos_Relacion_Auxiliar { get; set; }
        public virtual DbSet<Viaticos_Solicitud_Autorizacion> Viaticos_Solicitud_Autorizacion { get; set; }
        public virtual DbSet<Viatios_Facultades> Viatios_Facultades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activo_Fijo>()
                .HasMany(e => e.Activo_Fijo_Depreciacion)
                .WithRequired(e => e.Activo_Fijo)
                .HasForeignKey(e => new { e.Numero_EMpresa, e.Numero_Activo_Fijo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activo_Fijo_Alta>()
                .Property(e => e.Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Alta>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Activo_Fijo_Alta_Detalle>()
                .Property(e => e.Descripcion_Caracteristica)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Alta_Detalle>()
                .Property(e => e.Clave_Inventario)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Alta_Detalle>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Baja>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Actualizacion_Controles_Detalle>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Actualizacion_Controles_Detalle>()
                .Property(e => e.Tiempo)
                .IsUnicode(false);

            modelBuilder.Entity<Administracion_Recursos>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Administracion_Recursos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Administracion_Recursos>()
                .HasMany(e => e.Administracion_Recursos_Detalle)
                .WithRequired(e => e.Administracion_Recursos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Admon })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Administracion_Recursos_Detalle>()
                .Property(e => e.Cantidad_Batch)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Administracion_Recursos_Detalle>()
                .Property(e => e.Tiempo_Batch)
                .IsUnicode(false);

            modelBuilder.Entity<Alamcen_Solicitud_Detalle>()
                .Property(e => e.Numero_Parte)
                .IsUnicode(false);

            modelBuilder.Entity<Alamcen_Solicitud_Detalle>()
                .Property(e => e.Caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Alamcen_Solicitud_Detalle>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Conceptos_UM_Equivalencia>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Diferencia>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Diferencia>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Requerimiento_Stock_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Saldo_Inicial>()
                .Property(e => e.Existencia)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Saldo_Inicial>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Saldo_Inicial>()
                .Property(e => e.TC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Sol_Prod_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Almacen_Sol_Prod_Detalle>()
                .Property(e => e.Cantidad_Recibida)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Almacen_Sol_Prod_Empaques>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Almacen_Sol_Prod_Empaques>()
                .Property(e => e.Cantidad_Recibida)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Almacen_Sol_Prod_Empaques>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Sol_Produccion>()
                .HasMany(e => e.Almacen_Sol_Prod_Detalle)
                .WithRequired(e => e.Almacen_Sol_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Solicitud })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Almacen_Sol_Produccion>()
                .HasMany(e => e.Almacen_Sol_Prod_Empaques)
                .WithRequired(e => e.Almacen_Sol_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Solicitud })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Almacen_Sol_Produccion>()
                .HasMany(e => e.Sol_Prod_Detalle_Transformada)
                .WithRequired(e => e.Almacen_Sol_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Solicitud })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Almacen_Transferencia_Detalle>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencia_Detalle>()
                .Property(e => e.Numero_Entrada)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencia_Detalle>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Transferencia_Detalle>()
                .Property(e => e.Des_Articulo_Nuevo)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencia_Detalle>()
                .Property(e => e.Cantidad_Recibida)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Transferencia_Detalle_No>()
                .Property(e => e.Nombre_Articulo)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencia_Detalle_No>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencia_Detalle_No>()
                .Property(e => e.Numero_Entrada)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencias>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencias>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencias_R>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencias_R>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencias_R_Detalle>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencias_R_Detalle>()
                .Property(e => e.Numero_Entrada)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencias_R_Detalle>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Transferencias_R_Detalle>()
                .Property(e => e.Des_Articulo_Nuevo)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencias_R_Detalle>()
                .Property(e => e.Cantidad_Recibida)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Articulo_Concepto_Impuesto>()
                .Property(e => e.Valor)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Articulo_Transformada>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Articulo_Transformada>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Articulo_Transformada>()
                .HasMany(e => e.Articulo_Transformada_Detalle)
                .WithRequired(e => e.Articulo_Transformada)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Articulo_Transformada>()
                .HasMany(e => e.MTransformada_MPrima)
                .WithRequired(e => e.Articulo_Transformada)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_MTransformada })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Auxiliar_Bitacora>()
                .Property(e => e.Programa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Auxiliar_Bitacora>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Auxiliar_Bitacora>()
                .Property(e => e.Accion)
                .IsUnicode(false);

            modelBuilder.Entity<Avance_Orden_Produccion>()
                .Property(e => e.Cantidad_Producida)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Avance_Orden_Produccion>()
                .Property(e => e.Aprobacion_Calidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Balanza_Tipo>()
                .Property(e => e.Niveles)
                .IsUnicode(false);

            modelBuilder.Entity<BalanzaTMP_TC_Cerrada>()
                .Property(e => e.Cve_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<BalanzaTMP_TC_Cerrada>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Cuenta_Tercero_Persona_Facultad>()
                .Property(e => e.Puesto)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Formato_Impresion>()
                .Property(e => e.Campo)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Movimiento_Transferencia>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Movimiento_Transferencia>()
                .Property(e => e.Recibo)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Movimiento_Transferencia_Detalle>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Movimiento_Transferencia_Detalle>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Movimiento_Transferencia_Detalle>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Transaccion_Multiempresa>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.Nombre_Banco)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.Nombre_Corto_Banco)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .HasMany(e => e.Banco_Formato_Impresion)
                .WithRequired(e => e.Banco)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Banco })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Banco>()
                .HasMany(e => e.Bancos_Cuentas_Propias)
                .WithRequired(e => e.Banco)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Num_Banco })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Banco>()
                .HasMany(e => e.Caja_Dotacion)
                .WithOptional(e => e.Banco)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Banco });

            modelBuilder.Entity<Banco>()
                .HasMany(e => e.Caja_Dotacion1)
                .WithOptional(e => e.Banco1)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Banco });

            modelBuilder.Entity<Banco>()
                .HasMany(e => e.Bancos_Cuentas_Terceros)
                .WithRequired(e => e.Banco)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Banco })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bancos_Cuentas_Propias>()
                .Property(e => e.Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Cuentas_Propias>()
                .Property(e => e.Num_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Cuentas_Propias>()
                .Property(e => e.Digito_Interbancario)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Cuentas_Propias>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Cuentas_Propias>()
                .Property(e => e.Num_Cheque_Inicial)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Cuentas_Propias>()
                .HasMany(e => e.Bancos_Contactos)
                .WithRequired(e => e.Bancos_Cuentas_Propias)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Banco, e.Cont_Clas_Cuenta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bancos_Cuentas_Propias>()
                .HasMany(e => e.Bancos_Cuentas_Propias_Facultades)
                .WithRequired(e => e.Bancos_Cuentas_Propias)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Num_Banco, e.Num_Cuenta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bancos_Cuentas_Propias>()
                .HasMany(e => e.Bancos_Registro_Movimiento)
                .WithRequired(e => e.Bancos_Cuentas_Propias)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Banco, e.Clas_Cuenta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bancos_Cuentas_Terceros>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Cuentas_Terceros>()
                .Property(e => e.Digito_Interbancario)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Cuentas_Terceros>()
                .Property(e => e.Tutular_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Cuentas_Terceros>()
                .Property(e => e.Num_Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Cuentas_Terceros_Archivo>()
                .Property(e => e.Cadena)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Folios_Cancelados>()
                .Property(e => e.Clas_Cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Folios_Cancelados>()
                .Property(e => e.Numero_Documento_Anterior)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Folios_Cancelados>()
                .Property(e => e.Numero_Documento_Actual)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Folios_Cancelados>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Movimientos_Multiples>()
                .Property(e => e.Titulo_Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Movimientos_Multiples>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Bancos_Movimientos_Multiples>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Registro_Movimiento>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Registro_Movimiento>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Registro_Movimiento>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Registro_Movimiento>()
                .Property(e => e.Nombre_Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Registro_Movimiento>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Bancos_Registro_Movimiento>()
                .Property(e => e.TC_Mes)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Bancos_Registro_Movimiento>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Registro_Movimiento>()
                .HasMany(e => e.Caja_Chica_Dotacion)
                .WithOptional(e => e.Bancos_Registro_Movimiento)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Reg_Mov_Chequeras });

            modelBuilder.Entity<Bancos_Registro_Movimiento>()
                .HasMany(e => e.Caja_Dotacion)
                .WithOptional(e => e.Bancos_Registro_Movimiento)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Reg_Mov_Chequeras });

            modelBuilder.Entity<Bancos_Rep_Posicion_General_Transito>()
                .Property(e => e.Campo)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Rep_Posicion_General_Transito>()
                .Property(e => e.Campo1)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Rep_Posicion_General_Transito>()
                .Property(e => e.Campo2)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Rep_Posicion_General_Transito>()
                .Property(e => e.Campo3)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Rep_Posicion_General_Transito>()
                .Property(e => e.Campo4)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Rep_Posicion_General_Transito>()
                .Property(e => e.Campo5)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Traspaso_Cuenta>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Traspaso_Cuenta>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Bancos_Traspaso_Cuenta>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Traspaso_Cuenta>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Bitacora>()
                .Property(e => e.Programa)
                .IsUnicode(false);

            modelBuilder.Entity<Bitacora>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Caja>()
                .Property(e => e.Caja_Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Caja>()
                .HasMany(e => e.Caja_Arqueo)
                .WithRequired(e => e.Caja)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja>()
                .HasMany(e => e.Caja_Concepto)
                .WithRequired(e => e.Caja)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja>()
                .HasMany(e => e.Caja_Concepto1)
                .WithRequired(e => e.Caja1)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja>()
                .HasMany(e => e.Caja_Detalle)
                .WithRequired(e => e.Caja)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja>()
                .HasMany(e => e.Caja_Dotacion)
                .WithRequired(e => e.Caja)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja>()
                .HasMany(e => e.Caja_Egreso)
                .WithRequired(e => e.Caja)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja>()
                .HasMany(e => e.Caja_Solicitud_Reembolso)
                .WithRequired(e => e.Caja)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja_Apertura_Dotacion>()
                .Property(e => e.Importe)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Caja_Arqueo>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Arqueo>()
                .HasMany(e => e.Caja_Arqueo_Detalle)
                .WithRequired(e => e.Caja_Arqueo)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Arqueo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja_Arqueo>()
                .HasMany(e => e.Caja_Arqueo_Efectivo)
                .WithRequired(e => e.Caja_Arqueo)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Arqueo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja_Chica>()
                .Property(e => e.Caja_Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Chica>()
                .HasMany(e => e.Caja_Chica_Caja_Concepto)
                .WithRequired(e => e.Caja_Chica)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja_Chica_Comprobacion>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Chica_Comprobacion>()
                .Property(e => e.Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Chica_Deducible>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Chica_Dotacion>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Chica_Dotacion>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Chica_Egreso>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Chica_Egreso>()
                .Property(e => e.Persona_Asignado)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Chica_Egreso>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Chica_Egreso>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Caja_Chica_Solicitud_Reembolso>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Comprobacion>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Comprobacion>()
                .Property(e => e.Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Comprobacion>()
                .HasMany(e => e.Caja_Dotacion_Comprobacion)
                .WithRequired(e => e.Caja_Comprobacion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Egreso, e.Numero_Comprobante })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja_Concepto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Corte>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Corte>()
                .Property(e => e.Importe)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Caja_Corte>()
                .Property(e => e.tipo_cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Caja_Devolucion>()
                .Property(e => e.Importe)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Caja_Devolucion>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Dotacion>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Dotacion>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Dotacion>()
                .HasMany(e => e.Caja_Dotacion_Comprobacion)
                .WithRequired(e => e.Caja_Dotacion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Dotacion })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja_Egreso>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Egreso>()
                .Property(e => e.Num_Vale)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Egreso>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Egreso>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Caja_Egreso>()
                .HasMany(e => e.Caja_Arqueo_Detalle)
                .WithOptional(e => e.Caja_Egreso)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Egreso });

            modelBuilder.Entity<Caja_Egreso>()
                .HasMany(e => e.Caja_Comprobacion)
                .WithRequired(e => e.Caja_Egreso)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Egreso })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja_Egreso>()
                .HasMany(e => e.Caja_Dotacion_Comprobacion)
                .WithRequired(e => e.Caja_Egreso)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Egreso })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja_Pago>()
                .Property(e => e.Num_Comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Solicitud_Reembolso>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Calculo_Rendimiento>()
                .Property(e => e.Batches_Planeados)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Calculo_Rendimiento>()
                .Property(e => e.Batches_Reales)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Calculo_Rendimiento>()
                .Property(e => e.Reproceso_Real)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Calculo_Rendimiento>()
                .Property(e => e.Producto_Bueno_Real)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Calculo_Rendimiento>()
                .Property(e => e.Reproceso_Utilizado)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Calculo_Rendimiento>()
                .Property(e => e.Producto_Real)
                .HasPrecision(20, 8);

            modelBuilder.Entity<CartaModelo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CartaModelo>()
                .Property(e => e.Seccion1)
                .IsUnicode(false);

            modelBuilder.Entity<CartaModelo>()
                .Property(e => e.Seccion2)
                .IsUnicode(false);

            modelBuilder.Entity<CartaModelo>()
                .Property(e => e.Seccion3)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo>()
                .Property(e => e.CATALOGODESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo>()
                .Property(e => e.OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo>()
                .HasMany(e => e.CatalogoDetalles)
                .WithRequired(e => e.Catalogo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Catalogo_Bandas>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Bandas>()
                .HasMany(e => e.Banda_Relacion_Cliente)
                .WithRequired(e => e.Catalogo_Bandas)
                .HasForeignKey(e => new { e.Numero_Empresa, e.ID_Banda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Catalogo_Bandas>()
                .HasOptional(e => e.Catalogo_Bandas1)
                .WithRequired(e => e.Catalogo_Bandas2);

            modelBuilder.Entity<Catalogo_Bandas>()
                .HasMany(e => e.Catalogo_Bandas_Detalle)
                .WithRequired(e => e.Catalogo_Bandas)
                .HasForeignKey(e => new { e.Numero_Empresa, e.ID_Banda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Catalogo_Nodos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Nodos_Detalle>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoDetalle>()
                .Property(e => e.CATALOGODETALLECLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoDetalle>()
                .Property(e => e.CATALOGODETALLEDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoDetalle>()
                .Property(e => e.DESCRIPCION2)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoDetalle>()
                .Property(e => e.OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoDetalle>()
                .Property(e => e.D1)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoDetalle>()
                .Property(e => e.D2)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Pagos>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Pagos>()
                .HasMany(e => e.cc_Pagos_Detalle)
                .WithRequired(e => e.cc_Pagos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Pago })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cc_Pagos_Detalle>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cc_Pagos_Detalle>()
                .Property(e => e.Importe)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Cierre_Inventario>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Clave1)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion1)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Clave2)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion2)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Clave3)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion3)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Clave4)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion4)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Clave5)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion5)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Clave6)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion6)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Clave7)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion7)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Clave8)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion8)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Clave9)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion9)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Clave_Padre)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Activo_Fijo)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Activo, e.Numero_Empresa, e.Familia_Activo_Fijo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Administracion_Recursos)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_TRecurso, e.Numero_Empresa, e.Familia_TRecurso })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Administracion_Recursos_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Producto, e.Numero_Empresa, e.Familia_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Administracion_Recursos_Detalle1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_UMedida, e.Numero_Empresa, e.Familia_UMedida })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Almacen_Sol_Prod_Detalle)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_UMedida, e.Numero_Empresa, e.Familia_UMedida });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Almacen_Sol_Prod_Empaques)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Empaque, e.Numero_Empresa, e.Familia_Empaque })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Almacen_Sol_Prod_Empaques1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_Almacen, e.Numero_Empresa, e.Familia_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Almacen_Sol_Prod_Empaques2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Numero_UMedida, e.Numero_Empresa, e.Familia_UMedida });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Almacen_Sol_Produccion)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Estatus, e.Numero_Empresa, e.Familia_Estatus })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Almacen_Sol_Produccion1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_Almacen, e.Numero_Empresa, e.Familia_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Almacen_UM_Equivalencia)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_UM, e.Numero_Empresa, e.Familia_UM })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Almacen_UM_Equivalencia1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_UM_Equivalencia, e.Numero_Empresa, e.Familia_UM_Equivalencia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Articulo_Transformada)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_ATransformada, e.Numero_Empresa, e.Familia_ATransformada })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Articulo_Transformada1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_UMedida, e.Numero_Empresa, e.Familia_UMedida })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Articulo_Transformada_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Caracteristica, e.Numero_Empresa, e.Familia_Caracteristica })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Articulo_Transformada_Detalle1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_Dato, e.Numero_Empresa, e.Familia_Dato })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Bancos)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Pais, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Bancos1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Ciudad, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Bancos2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Ciudad, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Bancos_Cuentas_Propias)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Clas_Moneda });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Bancos_Cuentas_Propias1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Estatus, e.Numero_Empresa, e.Familia_Clas_Estatus });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Bancos_Cuentas_Propias2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Estatus, e.Numero_Empresa, e.Familia_Clas_Estatus });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Bancos_Cuentas_Propias_Facultades)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Facultad, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Bancos_Registro_Movimiento)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Bancos_Registro_Movimiento1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Cuenta, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Cajas)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Estatus, e.Numero_Empresa, e.Familia_Estatus });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Cajas1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Cajas2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Cont_Clas_Caja, e.Numero_Empresa, e.Familia_Estatus });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Arqueo_Efectivo)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Chica)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Estatus, e.Numero_Empresa, e.Familia_Estatus })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Chica1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Chica2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Cont_Clas_Caja, e.Numero_Empresa, e.Familia_Centro_Costo });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Chica_Comprobacion)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Estatus, e.Numero_Empresa, e.Familia_Estatus })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Comprobacion)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Iva, e.Numero_Empresa, e.Familia_Iva_Retencion })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Comprobacion1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Estatus, e.Numero_Empresa, e.Familia_Estatus_Cuenta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Comprobacion2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Cuenta, e.Numero_Empresa, e.Familia_Estatus_Cuenta });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Comprobacion3)
                .WithOptional(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_Depto, e.Numero_Empresa, e.Familia_Departamento });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Concepto)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Tipo, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Detalle)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Departamento, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Caja_Detalle1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Seccion, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasOptional(e => e.Cierre_Contable_Auxiliar)
                .WithRequired(e => e.Clasificacion);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Cierre_Inventario)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Sucursal, e.Numero_Empresa, e.Familia_Sucursal })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Cierre_Inventario1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Caja, e.Numero_Empresa, e.Familia_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Apertura_Inventario)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Almacen, e.Numero_Empresa, e.Familia_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Apertura_Inventario1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Apertura_Inventario2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Apertura_Inventario3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_UM, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Articuloes)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Tipo_Compra, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Articuloes1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Compra, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Articulo_Concepto)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Concepto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Articulo_Concepto1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Tipo_Concepto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.cc_Proceso_Pago)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.cc_Proceso_Pago1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_IVA, e.Numero_Empresa, e.Familia_IVA })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Cierre_Inventario_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Almacen, e.Numero_Empresa, e.Familia_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Cierre_Inventario_Detalle1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Cierre_Inventario_Detalle2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Cierre_Inventario_Detalle3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_UM, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.co_Contabilidad_Polizas_Fecha)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Cuenta, e.Numero_Empresa, e.Familia_Cuenta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.co_Contabilidad_Polizas_Periodo)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Cuenta, e.Numero_Empresa, e.Familia_Cuenta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.co_Parametros_Reporteador)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Costo, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.co_Parametros_Reporteador1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Costo_Base, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.co_Parametros_Reporteador2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Gasto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.co_Parametros_Reporteador3)
                .WithOptional(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_Gasto_Base, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.co_Parametros_Reporteador4)
                .WithOptional(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Clas_Ingreso, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.co_Parametros_Reporteador5)
                .WithOptional(e => e.Clasificacion5)
                .HasForeignKey(e => new { e.Clas_Ingreso_Base, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.co_Reportes_Contables_Detalle)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Numero_Detalle, e.Numero_Empresa, e.Familia_Numero_Detalle });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.co_Reportes_Contables_Registros)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Numero, e.Numero_Empresa, e.Familia_Numero });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Conceptos_Devolucion_Cliente)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasOptional(e => e.Contabilidad_Cuentas_Inhabilitadas)
                .WithRequired(e => e.Clasificacion);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Contabilidad_Polizas)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Cuenta, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasOptional(e => e.Contabilidad_Relacion_TC)
                .WithRequired(e => e.Clasificacion);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Contabilidad_Relacion_TipoCuenta)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Cuenta, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Control_Materiales)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Producto, e.Numero_Empresa, e.Familia_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Control_Materiales1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_Proceso, e.Numero_Empresa, e.Familia_Proceso })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Control_Materiales2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Numero_Entrega, e.Numero_Empresa, e.Familia_Entrega });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Control_Materiales_Recibe)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Recibe, e.Numero_Empresa, e.Familia_Recibe })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Control_Procesos)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Proceso, e.Numero_Empresa, e.Familia_Proceso })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Control_Procesos1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Tipo_Proceso, e.Numero_Empresa, e.Familia_TProceso })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.cp_Pagos_Poliza)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.cp_Pagos_Poliza1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Cuenta, e.Numero_Empresa, e.Familia_Cuenta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.cp_Proceso_Contabilidad)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.cp_Proceso_Contabilidad1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Cuenta, e.Numero_Empresa, e.Familia_Cuenta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.cp_Proceso_Pago)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.cp_Proceso_Pago1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_IVA, e.Numero_Empresa, e.Familia_IVA })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Datos_Conceptos_Plan_Maestro)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_TProducto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Datos_Conceptos_Plan_Maestro1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Datos_Conceptos_Plan_Maestro2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_TConcepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Datos_Conceptos_Plan_Maestro3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Datos_Conceptos_Plan_Maestro4)
                .WithRequired(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Clas_UM, e.Numero_Empresa, e.Familia_UM })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Datos_Embarque)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Lugar_Destino, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Datos_Embarque1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Num_Contenido, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Devolucion_Cliente)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia_Concepto_Causa })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Devolucion_Cliente1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_Almacen, e.Numero_Empresa, e.Familia_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Devolucion_Cliente2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Devolucion_Cliente3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_Iva, e.Numero_Empresa, e.Familia_Iva })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Devolucion_Cliente_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Devolucion_Cliente_Detalle1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Almacen, e.Numero_Empresa, e.Familia_Inventario })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Detalle1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_TProducto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Detalle2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Detalle3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_TConcepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Detalle4)
                .WithRequired(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Detalle5)
                .WithRequired(e => e.Clasificacion5)
                .HasForeignKey(e => new { e.Clas_moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Producto_Total)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Almacen, e.Numero_Empresa, e.Familia_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Producto_Total1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_TProducto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Producto_Total2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Producto_Total3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_TConcepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Producto_Total4)
                .WithRequired(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrada_Almacen_Producto_Total5)
                .WithRequired(e => e.Clasificacion5)
                .HasForeignKey(e => new { e.Clas_UM, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrega_Almacen_Prod_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Almacen, e.Numero_Empresa, e.Familia_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrega_Almacen_Prod_Detalle1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_Estatus, e.Numero_Empresa, e.Familia_Estatus })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Entrega_Almacen_Prod_Motivos)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Motivo, e.Numero_Empresa, e.Familia_Motivo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Equivalencia_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Concepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Equivalencia_Detalle1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Articulo_Transformada, e.Numero_Empresa, e.Familia_ATransformada })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Estadisticos_Compras_Articulo_TMP)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Estadisticos_Compras_Articulo_TMP1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_TProducto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Estadisticos_Compras_Articulo_TMP2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Estadisticos_Compras_Articulo_TMP3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_TConcepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Estadisticos_Compras_Articulo_TMP4)
                .WithRequired(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Estadisticos_Ventas_Articulo_TMP)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Estadisticos_Ventas_Articulo_TMP1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_TProducto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Estadisticos_Ventas_Articulo_TMP2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Estadisticos_Ventas_Articulo_TMP3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_TConcepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Estadisticos_Ventas_Articulo_TMP4)
                .WithRequired(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Factura_Comisionistas)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Tipo_Pago, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Historico_Prod_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Historico_Prod_Detalle1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Historico_Prod_Detalle2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_UM, e.Numero_Empresa, e.Familia_UM })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Historico_Produccion)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Historico_Produccion1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Iva, e.Numero_Empresa, e.Familia_Iva })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.ks_Pedido_Entrega)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Forma_Envio, e.Numero_Empresa, e.Familia_Forma_Envio });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Lista_Precios_Detalle)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Lista_Precios_Detalle_TMP)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Lista_Precios_Detalle1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Lista_Precios_Detalle_TMP1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Lista_Precios_Detalle2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Tipo_Concepto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Lista_Precios_Detalle_TMP2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Tipo_Concepto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Lista_Precios)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Tipo_Cliente, e.Numero_Empresa, e.Familia_Tipo_Cliente })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Material_Procesos)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Proceso, e.Numero_Empresa, e.Familia_Proceso })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Material_Procesos1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clasificacion_Producto, e.Numero_Empresa, e.Familia_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Material_Procesos2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clasificacion_Concepto, e.Numero_Empresa, e.Familia_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Modelo_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Padre, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Modelo_Detalle1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_Detalle, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Modelo_Producto_Det)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Padre, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Modelo_Producto_Det1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_Detalle, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Modelo_Producto_Prod)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Padre, e.Numero_Empresa, e.Familia_Padre_Det })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Modelo_Producto_Prod1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_Detalle, e.Numero_Empresa, e.Familia_Padre_Det })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Modelo_Producto_Prod2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Modelo_Producto_Prod3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.MTransformada_MPrima)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clasificacion_Concepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.MTransformada_MPrima1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_UMedida, e.Numero_Empresa, e.Familia_UMedida })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Orden_Produccion)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_TProducto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Orden_Produccion1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Orden_Produccion2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_TConcepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Orden_Produccion3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Orden_Produccion4)
                .WithRequired(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Numero_Estatus, e.Numero_Empresa, e.Familia_Estatus })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Orden_Produccion5)
                .WithRequired(e => e.Clasificacion5)
                .HasForeignKey(e => new { e.Numero_UMedida, e.Numero_Empresa, e.Familia_UMedida })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Periodos_Siguientes_Sel)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Periodos_Siguientes_Sel1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Periodos_Siguientes_Sel2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_UM, e.Numero_Empresa, e.Familia_UM })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Plan_Prod_Detalle_Masivo)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_TProducto, e.Numero_Empresa, e.Fam_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Plan_Prod_Detalle_Masivo1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Fam_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Plan_Prod_Detalle_Masivo2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_TConcepto, e.Numero_Empresa, e.Fam_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Plan_Prod_Detalle_Masivo3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Fam_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Plan_Prod_Detalle_Masivo4)
                .WithRequired(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Clas_UM, e.Numero_Empresa, e.Familia_UM })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Plan_Prod_Fechas)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clasificacion_TProducto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Plan_Prod_Fechas1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clasificacion_Producto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Plan_Prod_Fechas2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clasificacion_TConcepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Plan_Prod_Fechas3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clasificacion_Concepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productoes)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Moneda, e.Numero_empresa, e.Familia_Moneda });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productoes1)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Estatus, e.Numero_empresa, e.Familia_Prod_Tipo_Estatus });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productoes2)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Tipo_producto, e.Numero_empresa, e.Familia_Prod_Tipo_Estatus })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productoes3)
                .WithOptional(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Clasificacion_articulo, e.Numero_empresa, e.Familia_Art });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productoes4)
                .WithRequired(e => e.Clasificacion5)
                .HasForeignKey(e => new { e.Clasificacion, e.Numero_empresa, e.Familia_Prod_Tipo_Estatus })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productos_Conceptos_Adicionales)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productos_Conceptos_Adicionales1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productos_Conceptos_Caducidad)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_TProducto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productos_Conceptos_Caducidad1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productos_Conceptos_Caducidad2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_TConcepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productos_Conceptos_Caducidad3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productos_Conceptos)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Unidad_Costo, e.Numero_Empresa, e.Familia_Prod_Concepto_UCosto })
                .WillCascadeOnDelete();

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productos_Conceptos1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Periodo_Pago, e.Numero_Empresa, e.Familia_Periodo_Pago });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productos_Conceptos2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clasificacion_Concepto, e.Numero_Empresa, e.Familia_Prod_Concepto_UCosto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productos_Conceptos_Cliente)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Productos_Conceptos_Cliente1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Receta_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clasificacion_Producto, e.Numero_Empresa, e.Familia_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Receta_Detalle1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clasificacion_Concepto, e.Numero_Empresa, e.Familia_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Receta_Detalle2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Unidad_Medida, e.Numero_Empresa, e.Familia_UMedida })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Receta_Proceso)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_TCProceso, e.Numero_Empresa, e.Familia_TCProceso })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Registro_Venta_Salida)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Almacen, e.Numero_Empresa, e.Familia_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Rel_Homologacion_Articulos)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Rel_Homologacion_Articulos1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Relacion_Cajero_Almacen)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Almacen, e.Numero_Empresa, e.Familia_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Relacion_Depto_CC)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Depto, e.Numero_Empresa, e.Familia_Depto });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Relacion_Depto_CC1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Cuenta_CC, e.Numero_Empresa, e.Familia_CC });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Relacion_Depto_CC2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Cuenta_Gasto, e.Numero_Empresa, e.Familia_CC });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Relacion_Sucursal_Caja)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Sucursal, e.Numero_Empresa, e.Familia_Sucursal })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Relacion_Sucursal_Caja1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Caja, e.Numero_Empresa, e.Familia_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Relacion_Sucursal_Caja_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Forma_Pago, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Relacion_Sucursal_IVA)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Sucursal, e.Numero_Empresa, e.Familia_Sucursal })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Relacion_Sucursal_IVA1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_IVA, e.Numero_Empresa, e.Familia_IVA })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Relacion_Sucursal_IVA2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Revision_Calidad)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Diagnostico, e.Numero_Empresa, e.Familia_Diagnostico })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Revision_Calidad1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_Causa, e.Numero_Empresa, e.Familia_Causa })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Salida_Almacen)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Almacen, e.Numero_Empresa, e.Familia_Tipo_Docto_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Salida_Almacen1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Salida_Almacen_Detalle)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Almacen, e.Numero_Empresa, e.Familia_Inventario })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Salida_Almacen_Detalle1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_TProducto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Salida_Almacen_Detalle2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Salida_Almacen_Detalle3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clas_TConcepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Salida_Almacen_Detalle4)
                .WithRequired(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Salida_Almacen_Detalle5)
                .WithRequired(e => e.Clasificacion5)
                .HasForeignKey(e => new { e.Clas_UM, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Salida_Almacen_Detalle6)
                .WithRequired(e => e.Clasificacion6)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Sol_Prod_Detalle_Transformada)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clasificacion_TProducto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Sol_Prod_Detalle_Transformada1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clasificacion_Producto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Sol_Prod_Detalle_Transformada2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clasificacion_TConcepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Sol_Prod_Detalle_Transformada3)
                .WithRequired(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Clasificacion_Concepto, e.Numero_Empresa, e.Familia_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Sol_Prod_Detalle_Transformada4)
                .WithOptional(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Numero_UMedida, e.Numero_Empresa, e.Familia_UMedida });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Sucursal_Almacen_virtual)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Sucursal, e.Numero_Empresa, e.Familia_Sucursal });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Sucursal_Almacen_virtual1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Almacen, e.Numero_Empresa, e.Familia_Almacen });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Sucursals)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Sucursal, e.Numero_Empresa, e.Familia_Sucursal })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Sucursal_Docto_Folio)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Sucursal, e.Numero_Empresa, e.Familia_Sucursal });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Sucursal_Docto_Folio1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Tipo_Docto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Taller_Calculo_CP)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Valor, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Taller_Calculo_CP_Detalle)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Operador, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Taller_Calculo_CP_Detalle1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Variable, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Taller_Productos)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Concepto, e.Numero_Empresa, e.Familia_Prod })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Taller_Productos1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Numero_Padre, e.Numero_Empresa, e.Familia_Caract })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Taller_Productos2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Numero_Detalle, e.Numero_Empresa, e.Familia_Caract })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Transacciones_Contables)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Numero_Cuenta, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Transporte_Vehiculo)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Unidad, e.Numero_Empresa, e.Familia_Unidad })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Sucursal, e.Numero_Empresa, e.Familia_Sucursal })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Caja, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Estatus, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja3)
                .WithOptional(e => e.Clasificacion3)
                .HasForeignKey(e => new { e.Moneda, e.Numero_Empresa, e.Familia_Moneda });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja4)
                .WithRequired(e => e.Clasificacion4)
                .HasForeignKey(e => new { e.Clas_IVA, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Almacen)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Caja, e.Numero_Empresa, e.Familia_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Almacen1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Almacen, e.Numero_Empresa, e.Familia_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Apertura)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Sucursal, e.Numero_Empresa, e.Familia_Sucursal })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Apertura1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Caja, e.Numero_Empresa, e.Familia_Caja })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Apertura_Detalle)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Cierre)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Sucursal, e.Numero_Empresa, e.Familia_Sucursal })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Cierre1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Caja, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Cierre2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Concepto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Cierre_Pagos)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Detalle)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Detalle1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Detalle2)
                .WithOptional(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_UM, e.Numero_Empresa, e.Familia_UM });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Pagos)
                .WithOptional(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Forma_Pago, e.Numero_Empresa, e.Familia });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Caja_Pagos1)
                .WithOptional(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Moneda, e.Numero_Empresa, e.Familia_Moneda });

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Salida)
                .WithRequired(e => e.Clasificacion)
                .HasForeignKey(e => new { e.Clas_Almacen, e.Numero_Empresa, e.Familia_Almacen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Salida1)
                .WithRequired(e => e.Clasificacion1)
                .HasForeignKey(e => new { e.Clas_Producto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Venta_Salida2)
                .WithRequired(e => e.Clasificacion2)
                .HasForeignKey(e => new { e.Clas_Concepto, e.Numero_Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Clave1)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Descripcion1)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Clave2)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Descripcion2)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Clave3)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Descripcion3)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Clave4)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Descripcion4)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Clave5)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Descripcion5)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Clave6)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Descripcion6)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Clave7)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Descripcion7)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Clave8)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Descripcion8)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Clave9)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Descripcion9)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Clave_Padre)
                .IsUnicode(false);

            modelBuilder.Entity<ClasificacionTMP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Giro)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Dato_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Numero_RegTributario)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Cliente_Credito)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cliente })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Cliente_Departamento)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cliente })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasOptional(e => e.Cliente_Referencia)
                .WithRequired(e => e.Cliente);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Cliente_Vendedor)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cliente_Persona })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Condiciones_Facturacion_Pago)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cliente_Persona })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Condiciones_Facturacion_Revision)
                .WithOptional(e => e.Cliente)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cliente_Persona });

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Contactoes)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => new { e.Empresa, e.Numero_Cliente })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Cotizacions)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cliente })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Cotizacion_Simple)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cliente })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Cuentas_Cobrar)
                .WithOptional(e => e.Cliente)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cliente });

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Producto_Cliente)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cliente })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Relacion_Cliente_Proveedor)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cliente })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Personas)
                .WithMany(e => e.Clientes)
                .Map(m => m.ToTable("Relacion_Cliente_Transportista").MapLeftKey(new[] { "Numero_Empresa", "Numero_Cliente" }).MapRightKey("Numero_Transportista"));

            modelBuilder.Entity<Cliente_Departamento>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente_Departamento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente_Expediente>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente_Referencia>()
                .Property(e => e.Numero_Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente_Referencia>()
                .Property(e => e.Referencia1)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente_Referencia>()
                .Property(e => e.Referencia2)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente_Referencia>()
                .Property(e => e.Referencia3)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente_Tab>()
                .Property(e => e.Nombre_Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<co_Contabilidad_Polizas_Fecha>()
                .Property(e => e.Debe)
                .HasPrecision(20, 8);

            modelBuilder.Entity<co_Contabilidad_Polizas_Fecha>()
                .Property(e => e.Haber)
                .HasPrecision(20, 8);

            modelBuilder.Entity<co_Contabilidad_Polizas_Periodo>()
                .Property(e => e.Debe)
                .HasPrecision(20, 8);

            modelBuilder.Entity<co_Contabilidad_Polizas_Periodo>()
                .Property(e => e.Haber)
                .HasPrecision(20, 8);

            modelBuilder.Entity<co_Plantilla>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<co_Plantilla>()
                .Property(e => e.Nombre_Reporte)
                .IsUnicode(false);

            modelBuilder.Entity<co_Plantilla>()
                .HasMany(e => e.co_Reportes_Contables)
                .WithRequired(e => e.co_Plantilla)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Plantilla })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<co_Reportes_Contables>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Contables>()
                .HasMany(e => e.co_Reportes_Contables_Detalle)
                .WithRequired(e => e.co_Reportes_Contables)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Reporte })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<co_Reportes_Contables>()
                .HasMany(e => e.co_Reportes_Contables_Importes)
                .WithRequired(e => e.co_Reportes_Contables)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Reporte })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<co_Reportes_Contables>()
                .HasMany(e => e.co_Reportes_Contables_Registros)
                .WithRequired(e => e.co_Reportes_Contables)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Reporte })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<co_Reportes_Contables_Detalle>()
                .Property(e => e.Operador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Contables_Registros>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Contables_Registros>()
                .Property(e => e.Operacion)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Contables_Registros>()
                .HasMany(e => e.co_Reportes_Contables_Detalle)
                .WithRequired(e => e.co_Reportes_Contables_Registros)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Reporte, e.Numero_Registro })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<co_Reportes_Contables_Registros>()
                .HasMany(e => e.co_Reportes_Contables_Importes)
                .WithRequired(e => e.co_Reportes_Contables_Registros)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Reporte, e.Numero_Registro })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Compras_Configuracion>()
                .Property(e => e.Costo_Minimo)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Compras_Configuracion>()
                .Property(e => e.Costo_Maximo)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Conceptos_Entrada_Salida_Almacen>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Conceptos_Entrada_Salida_Almacen>()
                .Property(e => e.Signo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Condiciones_Facturacion_Pago>()
                .Property(e => e.Dia_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Cuenta_Mayor>()
                .Property(e => e.Des_Cuenta_Mayor)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Cuenta_Mayor>()
                .Property(e => e.Des_Clave_Mayor)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas>()
                .Property(e => e.Numero_Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Contabilidad_Polizas>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas_Alternas>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas_Alternas>()
                .Property(e => e.Numero_Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Contabilidad_Polizas_Alternas>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Resultados_TC>()
                .Property(e => e.TC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Contabilidad_TC_TMP>()
                .Property(e => e.TC_Cierre)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Contabilidad_TC_TMP>()
                .Property(e => e.TC_Promedio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.Puesto)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto_Proveedor>()
                .Property(e => e.Puesto)
                .IsUnicode(false);

            modelBuilder.Entity<Control_Materiales>()
                .HasMany(e => e.Control_Materiales_Recibe)
                .WithRequired(e => e.Control_Materiales)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Control })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Control_Procesos>()
                .Property(e => e.Tiempo)
                .IsUnicode(false);

            modelBuilder.Entity<Control_Procesos>()
                .Property(e => e.Costo)
                .HasPrecision(20, 2);

            modelBuilder.Entity<Control_Procesos>()
                .HasMany(e => e.Actualizacion_Controles_Detalle)
                .WithRequired(e => e.Control_Procesos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Control_Procesos>()
                .HasMany(e => e.Personas)
                .WithMany(e => e.Control_Procesos1)
                .Map(m => m.ToTable("Control_Procesos_Usuario").MapLeftKey(new[] { "Numero_Empresa", "Numero" }).MapRightKey("Numero_Persona"));

            modelBuilder.Entity<Cotizacion>()
                .Property(e => e.Nombre_Proyecto)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion>()
                .Property(e => e.Observaciones2)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion>()
                .Property(e => e.Num_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion>()
                .Property(e => e.Dato_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion>()
                .HasMany(e => e.Cotizacion_Art_Descuentos)
                .WithRequired(e => e.Cotizacion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cotizacion })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cotizacion>()
                .HasOptional(e => e.Cotizacion_Autorizar)
                .WithRequired(e => e.Cotizacion);

            modelBuilder.Entity<Cotizacion>()
                .HasMany(e => e.Cotizacion_Fac_Descuentos)
                .WithRequired(e => e.Cotizacion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cotizacion })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cotizacion>()
                .HasMany(e => e.Cotizacion_MatRecibido)
                .WithRequired(e => e.Cotizacion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cotizacion })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cotizacion>()
                .HasMany(e => e.Cotizacion_Programada)
                .WithRequired(e => e.Cotizacion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cotiza })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cotizacion>()
                .HasMany(e => e.Cotizacion_Detalle)
                .WithRequired(e => e.Cotizacion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cotiza });

            modelBuilder.Entity<Cotizacion>()
                .HasMany(e => e.Registro_Pago)
                .WithRequired(e => e.Cotizacion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cotizacion })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cotizacion_Detalle>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Detalle>()
                .Property(e => e.Seccion)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Detalle>()
                .Property(e => e.Caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Detalle>()
                .Property(e => e.Cantidad_Facturada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Detalle>()
                .Property(e => e.Costo_Referencia)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Detalle>()
                .Property(e => e.Costo_Proveedor)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Detalle>()
                .Property(e => e.Precio_Lista_Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Detalle>()
                .Property(e => e.Peso)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Detalle>()
                .Property(e => e.Precio_Estilo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Detalle>()
                .HasMany(e => e.Cotizacion_Detalle_Almacen)
                .WithRequired(e => e.Cotizacion_Detalle)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cotiza, e.Partida, e.Orden })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cotizacion_Detalle>()
                .HasMany(e => e.Cotizacion_Detalle_Impuesto)
                .WithRequired(e => e.Cotizacion_Detalle)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cotiza, e.Partida, e.Orden })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cotizacion_Detalle_Almacen>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Detalle_Caracteristicas>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Detalle_Impuesto>()
                .Property(e => e.Operacion)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Detalle_Impuesto>()
                .Property(e => e.Valor)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cotizacion_Detalle_Impuesto>()
                .Property(e => e.Importe)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cotizacion_MatRecibido>()
                .Property(e => e.Cantidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_MatRecibido>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_MatRecibido>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_MatRecibido>()
                .Property(e => e.Programa)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_MatRecibido>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Simple>()
                .Property(e => e.Nombre_Proyecto)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Simple>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Simple>()
                .Property(e => e.Observaciones2)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Simple>()
                .Property(e => e.Num_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Simple>()
                .Property(e => e.Dato_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Simple_Detalle>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Simple_Detalle>()
                .Property(e => e.Seccion)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Simple_Detalle>()
                .Property(e => e.Caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Simple_Detalle>()
                .Property(e => e.Cantidad_Facturada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Simple_Detalle>()
                .Property(e => e.Costo_Referencia)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Simple_Detalle>()
                .Property(e => e.Costo_Proveedor)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Simple_Detalle>()
                .Property(e => e.Precio_Lista_Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Simple_Detalle>()
                .Property(e => e.Peso)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Simple_Detalle>()
                .HasMany(e => e.Cotizacion_Simple_Detalle_Impuesto)
                .WithRequired(e => e.Cotizacion_Simple_Detalle)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cotiza, e.Partida, e.Orden })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cotizacion_Simple_Detalle_Impuesto>()
                .Property(e => e.Operacion)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Simple_Detalle_Impuesto>()
                .Property(e => e.Valor)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cotizacion_Simple_Detalle_Impuesto>()
                .Property(e => e.Importe)
                .HasPrecision(18, 10);

            modelBuilder.Entity<CP_Anticipos_Intercompanias>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<CP_Anticipos_Intercompanias>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CP_Anticipos_Intercompanias>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Pagos>()
                .Property(e => e.Tipo_Cambio_Pago)
                .HasPrecision(18, 10);

            modelBuilder.Entity<cp_Pagos>()
                .HasMany(e => e.cp_Pagos_Detalle)
                .WithRequired(e => e.cp_Pagos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Pago })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cp_Pagos>()
                .HasMany(e => e.cp_Pagos_Poliza)
                .WithRequired(e => e.cp_Pagos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Pago })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cp_Pagos_Detalle>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cp_Pagos_Detalle>()
                .Property(e => e.Importe)
                .HasPrecision(20, 4);

            modelBuilder.Entity<CProyecto_Relacion_Concepto_Detalle>()
                .Property(e => e.Tabla)
                .IsUnicode(false);

            modelBuilder.Entity<CProyecto_Relacion_Concepto_Detalle>()
                .Property(e => e.Campo)
                .IsUnicode(false);

            modelBuilder.Entity<CProyecto_Relacion_Concepto_Detalle>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<CProyecto_Relacion_Concepto_Detalle_WHERE>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CProyecto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CProyecto>()
                .Property(e => e.Nombre_Corto)
                .IsUnicode(false);

            modelBuilder.Entity<CProyecto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CProyecto>()
                .HasMany(e => e.CProyectos_Expediente)
                .WithRequired(e => e.CProyecto)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_CProyecto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CProyecto>()
                .HasMany(e => e.CProyectos_Tab)
                .WithRequired(e => e.CProyecto)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_CProyecto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CProyectos_Expediente>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<CProyectos_Real>()
                .Property(e => e.Porcentaje)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cuentas_Cobrar>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar>()
                .Property(e => e.Numero_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar>()
                .Property(e => e.Numero_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cuentas_Cobrar>()
                .Property(e => e.TC_Mes)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cuentas_Cobrar>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar>()
                .Property(e => e.Forma_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar>()
                .Property(e => e.Folio_Fiscal_CRP)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar>()
                .HasMany(e => e.cc_Pagos_Detalle)
                .WithRequired(e => e.Cuentas_Cobrar)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_CC })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuentas_Cobrar>()
                .HasMany(e => e.cc_Proceso_Pago)
                .WithOptional(e => e.Cuentas_Cobrar)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_CC });

            modelBuilder.Entity<Cuentas_Cobrar_Antiguedad_Cadena>()
                .Property(e => e.Nombre_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Antiguedad_Cadena>()
                .Property(e => e.Nombre_Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Antiguedad_Cadena>()
                .Property(e => e.Nombre_Cadena)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Antiguedad_Cadena>()
                .Property(e => e.Nombre_Vendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Antiguedad_Cadena>()
                .Property(e => e.Nombre_Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Antiguedad_Cadena>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Antiguedad_Cadena>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cuentas_Cobrar_Antiguedad_Cadena>()
                .Property(e => e.Caso)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Conceptos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Conceptos>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Conceptos>()
                .HasMany(e => e.Cuentas_Cobrar)
                .WithOptional(e => e.Cuentas_Cobrar_Conceptos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Concepto });

            modelBuilder.Entity<Cuentas_Cobrar_Conceptos>()
                .HasMany(e => e.cc_Proceso_Pago)
                .WithRequired(e => e.Cuentas_Cobrar_Conceptos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuentas_Cobrar_Conceptos>()
                .HasMany(e => e.Cuentas_Cobrar_Conceptos_Pantalla)
                .WithRequired(e => e.Cuentas_Cobrar_Conceptos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuentas_Cobrar_RAA_TMP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_RAN_TMP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar>()
                .Property(e => e.Numero_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cuentas_Pagar>()
                .Property(e => e.TC_Mes)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cuentas_Pagar>()
                .Property(e => e.Referencia_Texto)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar>()
                .Property(e => e.Numero_CProyecto)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar>()
                .HasMany(e => e.cp_Pagos_Detalle)
                .WithRequired(e => e.Cuentas_Pagar)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_CP })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuentas_Pagar>()
                .HasMany(e => e.cp_Proceso_Pago)
                .WithOptional(e => e.Cuentas_Pagar)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_CP });

            modelBuilder.Entity<Cuentas_Pagar_Anticipos>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Anticipos>()
                .Property(e => e.Numero_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Anticipos>()
                .Property(e => e.Tipo_cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cuentas_Pagar_Anticipos>()
                .Property(e => e.TC_Mes)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cuentas_Pagar_Anticipos>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Anticipos>()
                .HasMany(e => e.cp_Pagos)
                .WithOptional(e => e.Cuentas_Pagar_Anticipos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Anticipo });

            modelBuilder.Entity<Cuentas_Pagar_Conceptos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Conceptos>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Conceptos>()
                .HasMany(e => e.Cuentas_Pagar)
                .WithOptional(e => e.Cuentas_Pagar_Conceptos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Concepto });

            modelBuilder.Entity<Cuentas_Pagar_Conceptos>()
                .HasMany(e => e.cp_Proceso_Pago)
                .WithRequired(e => e.Cuentas_Pagar_Conceptos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Concepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuentas_Pagar_RAA_TMP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_RAN_TMP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Datos_Conceptos_Plan_Maestro>()
                .Property(e => e.Inventario_Inicial)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Datos_Conceptos_Plan_Maestro>()
                .Property(e => e.Inventario_Final)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Datos_Conceptos_Plan_Maestro>()
                .Property(e => e.Inventario_Deseado)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Datos_Conceptos_Plan_Maestro>()
                .Property(e => e.Back_Order)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Datos_Conceptos_Plan_Maestro>()
                .Property(e => e.OP_Proceso)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Datos_Conceptos_Plan_Maestro>()
                .Property(e => e.Pronostico)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Datos_Conceptos_Plan_Maestro>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Datos_Conceptos_Plan_Maestro>()
                .Property(e => e.Produccion_Entrega)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Datos_Embarque>()
                .Property(e => e.No_Guia_Talon)
                .IsUnicode(false);

            modelBuilder.Entity<Datos_Embarque>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Datos_Embarque>()
                .Property(e => e.Causa_Cancelacion)
                .IsUnicode(false);

            modelBuilder.Entity<Descuento_Concepto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Descuento_Concepto>()
                .HasMany(e => e.Lista_Precios_Detalle)
                .WithRequired(e => e.Descuento_Concepto)
                .HasForeignKey(e => new { e.Taller_Concepto, e.Numero_Empresa })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Descuento_Concepto>()
                .HasMany(e => e.Lista_Precios_Detalle_TMP)
                .WithRequired(e => e.Descuento_Concepto)
                .HasForeignKey(e => new { e.Taller_Concepto, e.Numero_Empresa })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Deudor_Gastos>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Devolucion_Cliente>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(20, 9);

            modelBuilder.Entity<Devolucion_Cliente>()
                .Property(e => e.SubTotal)
                .HasPrecision(20, 9);

            modelBuilder.Entity<Devolucion_Cliente>()
                .Property(e => e.Iva)
                .HasPrecision(20, 9);

            modelBuilder.Entity<Devolucion_Cliente>()
                .Property(e => e.Total)
                .HasPrecision(20, 9);

            modelBuilder.Entity<Devolucion_Cliente>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Devolucion_Cliente>()
                .Property(e => e.Causa_Cancelacion)
                .IsUnicode(false);

            modelBuilder.Entity<Devolucion_Cliente_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 9);

            modelBuilder.Entity<Devolucion_Cliente_Detalle>()
                .Property(e => e.Precio_Unitario)
                .HasPrecision(20, 9);

            modelBuilder.Entity<Devolucion_Cliente_Detalle>()
                .Property(e => e.Cantidad_Ingresada)
                .HasPrecision(20, 9);

            modelBuilder.Entity<Devolucion_Cliente_Detalle>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Domicilio>()
                .Property(e => e.Domicilio1)
                .IsUnicode(false);

            modelBuilder.Entity<Domicilio>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<Domicilio>()
                .Property(e => e.Delegacion_municipio)
                .IsUnicode(false);

            modelBuilder.Entity<Domicilio>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Domicilio>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Domicilio>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Domicilio>()
                .HasMany(e => e.ks_Pedido_Entrega)
                .WithOptional(e => e.Domicilio)
                .HasForeignKey(e => e.Numero_Domicilio_Consig);

            modelBuilder.Entity<Domicilio>()
                .HasMany(e => e.Sucursals)
                .WithRequired(e => e.Domicilio)
                .HasForeignKey(e => e.Num_Domicilio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Nombre_Corto)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Delegacion_municipio)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Codigo_postal)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Representante_legal)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Servidor)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Puerto)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Contraseña)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Texto)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Clave_Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Activo_Fijo)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Activo_Fijo_Depreciacion)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_EMpresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Autoriza_Perfil_Pantalla)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Banco_Formato_Impresion)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Bancos)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Bancos_Cuentas_Propias)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Bancos_Cuentas_Propias_Facultades)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Bancos_Cuentas_Terceros)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Bancos_Registro_Movimiento)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Cajas)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Caja_Apertura_Dotacion)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Caja_Chica)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Caja_Corte)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Caja_Detalle)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Clasificacions)
                .WithRequired(e => e.Empresa1)
                .HasForeignKey(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Contabilidad_Polizas)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Cotizacions)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Cotizacion_Detalle)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Cotizacion_Simple)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Cotizacion_Simple_Detalle)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Articuloes)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Bancos_Contactos)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Empresa_Horarios)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Facultades_extraordinarias)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Familias)
                .WithRequired(e => e.Empresa1)
                .HasForeignKey(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Folios)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Grupo_Persona_Detalle)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Grupo_Persona)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Perfil_usuario)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Persona_Relacion)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Producto_Cliente)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Productoes)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Productos_Conceptos)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Proveedors)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Registro_Pago)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.RH_Persona)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Transacciones_Contables)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Viaticos_Solicitud)
                .WithRequired(e => e.Empresa)
                .HasForeignKey(e => e.Numero_Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Perfils)
                .WithMany(e => e.Empresas)
                .Map(m => m.ToTable("Perfil_empresa").MapLeftKey("Numero_empresa").MapRightKey("Numero_perfil"));

            modelBuilder.Entity<Empresa_Horarios>()
                .Property(e => e.Horario)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa_Horarios>()
                .HasMany(e => e.Transporte_Rutas_Detalle)
                .WithRequired(e => e.Empresa_Horarios)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Horario })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa_Logo>()
                .Property(e => e.Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa_Servicios>()
                .Property(e => e.Clasificacion_Producto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen>()
                .Property(e => e.Numero_Docto_Entrada)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen>()
                .Property(e => e.Anexo)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen>()
                .Property(e => e.Causa_Cancelacion)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen>()
                .Property(e => e.Pedimento)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Cantidad_Recibida)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Cantidad_Facturada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Parte)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Cantidad_Apartada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Des_Articulo_Nuevo)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Cantidad_Recibida_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle>()
                .Property(e => e.Cantidad_Entregada_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle_No>()
                .Property(e => e.Numero_RC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_No>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Entrada_Almacen_Detalle_No>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_No>()
                .Property(e => e.Cantidad_Facturada)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Entrada_Almacen_Detalle_No>()
                .Property(e => e.Nombre_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_No>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle_No>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle_No>()
                .Property(e => e.Parte)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_Serie>()
                .Property(e => e.Relacion_Salida)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_Serie>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_Serie>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle_Serie>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle_Serie>()
                .Property(e => e.Codigo_Barra)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_Serie>()
                .Property(e => e.Numero_Apartado)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_Serie_Compuesta>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Producto_Total>()
                .Property(e => e.Cantidad_Recibida_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Producto_Total>()
                .Property(e => e.Cantidad_Entregada_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Producto_Total>()
                .Property(e => e.Cantidad_Apartada_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Stock_Excedente>()
                .Property(e => e.Cantidad_Execente)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Verificacion>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Entrega_Almacen_Prod>()
                .HasMany(e => e.Entrega_Almacen_Prod_Detalle)
                .WithRequired(e => e.Entrega_Almacen_Prod)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Entrega })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entrega_Almacen_Prod>()
                .HasMany(e => e.Entrega_Almacen_Prod_Motivos)
                .WithRequired(e => e.Entrega_Almacen_Prod)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Entrega })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entrega_Almacen_Prod_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Entrega_Almacen_Prod_Detalle>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Entrega_Almacen_Prod_Detalle>()
                .Property(e => e.Num_Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Entrega_Almacen_Prod_Detalle>()
                .Property(e => e.Costo)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Entrega_Almacen_Prod_Motivos>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Equivalencia>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencia>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Equivalencia>()
                .HasMany(e => e.Equivalencia_Detalle)
                .WithRequired(e => e.Equivalencia)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Equivalencia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Equivalencia_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Equivalencia_Detalle>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Importe_Letra)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Nombre_Proyecto)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Numero_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Referencia2)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Referencia3)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.PATH)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Forma_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Condicion_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Metodo_Pago_Sat)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Clas_Metodo_Pago_Sat)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Metodo_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Nombre_Programa)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .HasMany(e => e.Devolucion_Cliente)
                .WithOptional(e => e.Factura)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Factura });

            modelBuilder.Entity<Factura>()
                .HasMany(e => e.Factura_Comisionistas)
                .WithRequired(e => e.Factura)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Factura })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Factura_Concepto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Factura_Detalle>()
                .Property(e => e.Clave_Prod_Sat)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Detalle>()
                .Property(e => e.Clave_UM_Sat)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Detalle_Anexo>()
                .Property(e => e.Pedimento)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Email>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Email>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Email>()
                .Property(e => e.BASEDATOS)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Email>()
                .Property(e => e.RUTA)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Email>()
                .Property(e => e.D1)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Interface_XLS>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Factura_Interface_XLS>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Libre>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Libre>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Factura_Libre>()
                .Property(e => e.Referencia2)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Libre>()
                .Property(e => e.Referencia3)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Libre_Detalle>()
                .Property(e => e.Caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Libre_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Factura_Libre_Detalle>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Factura_Libre_Detalle>()
                .Property(e => e.Iva)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Facultades_extraordinarias>()
                .Property(e => e.Signo)
                .IsUnicode(false);

            modelBuilder.Entity<Facultades_extraordinarias>()
                .Property(e => e.Alta)
                .IsUnicode(false);

            modelBuilder.Entity<Facultades_extraordinarias>()
                .Property(e => e.Modificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Facultades_extraordinarias>()
                .Property(e => e.Baja)
                .IsUnicode(false);

            modelBuilder.Entity<Facultades_extraordinarias>()
                .Property(e => e.Autoriza)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Nivel1)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Tipo1)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Nivel2)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Tipo2)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Nivel3)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Tipo3)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Nivel4)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Tipo4)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Nivel5)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Tipo5)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Nivel6)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Tipo6)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Nivel7)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Tipo7)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Nivel8)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Tipo8)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Nivel9)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .Property(e => e.Tipo9)
                .IsUnicode(false);

            modelBuilder.Entity<Familia>()
                .HasMany(e => e.Clasificacions)
                .WithRequired(e => e.Familia1)
                .HasForeignKey(e => new { e.Empresa, e.Familia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flujo_Efectivo_Egresos>()
                .Property(e => e.Monto)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Flujo_Efectivo_Encabezado>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Flujo_Efectivo_Encabezado>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Flujo_Efectivo_Ingresos>()
                .Property(e => e.Numero_CC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flujo_Efectivo_Ingresos>()
                .Property(e => e.Monto)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Folio>()
                .Property(e => e.Prefijo)
                .IsUnicode(false);

            modelBuilder.Entity<Folio>()
                .HasMany(e => e.Folio_Facultad)
                .WithRequired(e => e.Folio)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Reg })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Folio_Relacion_Docto_FE>()
                .Property(e => e.Ruta_Key)
                .IsUnicode(false);

            modelBuilder.Entity<Folio_Relacion_Docto_FE>()
                .Property(e => e.Contraseña_Key)
                .IsUnicode(false);

            modelBuilder.Entity<Folio_Relacion_Docto_FE>()
                .Property(e => e.Ruta_Cer)
                .IsUnicode(false);

            modelBuilder.Entity<Folio_Relacion_Docto_FE>()
                .Property(e => e.Num_Aprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<Folio_Relacion_Docto_FE>()
                .Property(e => e.Ruta_Logo)
                .IsUnicode(false);

            modelBuilder.Entity<Folio_Relacion_Docto_FE>()
                .Property(e => e.Ruta_Almacenamiento)
                .IsUnicode(false);

            modelBuilder.Entity<Folios_Cancelados>()
                .Property(e => e.Tipo_Factura_Relacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Folios_Cancelados>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Fondo>()
                .Property(e => e.Fondo_Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<Gastos_Asignacion>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Gastos_Asignacion>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Gastos_Asignacion_Deudores>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<Gastos_Reporte>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Gastos_Reporte>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Gastos_Reporte_Detalle>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Gastos_Reporte_Detalle>()
                .Property(e => e.Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Gastos_Solicitud>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Gastos_Solicitud>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo_Persona>()
                .HasMany(e => e.Grupo_Persona_Detalle)
                .WithRequired(e => e.Grupo_Persona1)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Grupo_Persona })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Historico_Articulo_Concepto_Impuesto>()
                .Property(e => e.Valor)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Historico_Prod_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Historico_Prod_Detalle>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Historico_Prod_Detalle>()
                .Property(e => e.Precio_Unitario)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Historico_Produccion>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Historico_Produccion>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Historico_Produccion>()
                .Property(e => e.SubTotal)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Historico_Produccion>()
                .Property(e => e.Monto_Descuento)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Historico_Produccion>()
                .Property(e => e.Monto_Iva)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Historico_Produccion>()
                .Property(e => e.Monto_Total)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Historico_Produccion>()
                .Property(e => e.Importe_Letra)
                .IsUnicode(false);

            modelBuilder.Entity<Historico_Produccion>()
                .Property(e => e.Causa_Cancelacion)
                .IsUnicode(false);

            modelBuilder.Entity<Historico_Produccion>()
                .HasMany(e => e.Historico_Prod_Detalle)
                .WithRequired(e => e.Historico_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Historico });

            modelBuilder.Entity<Homologacion_Articulos>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Homologacion_Articulos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Homologacion_Articulos>()
                .HasMany(e => e.Rel_Homologacion_Articulos)
                .WithRequired(e => e.Homologacion_Articulos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Articulo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Homologacion_Modelos>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Homologacion_Modelos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Homologacion_Modelos>()
                .HasMany(e => e.Rel_Homologacion_Modelos)
                .WithRequired(e => e.Homologacion_Modelos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_ModeloH })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ks_Pedido>()
                .Property(e => e.Solicitante)
                .IsUnicode(false);

            modelBuilder.Entity<ks_Pedido>()
                .Property(e => e.Monto_Importe)
                .HasPrecision(20, 8);

            modelBuilder.Entity<ks_Pedido>()
                .Property(e => e.Monto_Descuento)
                .HasPrecision(20, 8);

            modelBuilder.Entity<ks_Pedido>()
                .Property(e => e.Monto_Subtotal)
                .HasPrecision(20, 8);

            modelBuilder.Entity<ks_Pedido>()
                .Property(e => e.Monto_IVA)
                .HasPrecision(20, 8);

            modelBuilder.Entity<ks_Pedido>()
                .Property(e => e.Monto_Total)
                .HasPrecision(20, 8);

            modelBuilder.Entity<ks_Pedido>()
                .Property(e => e.Total_Letra)
                .IsUnicode(false);

            modelBuilder.Entity<ks_Pedido>()
                .HasMany(e => e.ks_Pedido_Detalle)
                .WithRequired(e => e.ks_Pedido)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Cotiza })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ks_Pedido>()
                .HasOptional(e => e.ks_Pedido_Entrega)
                .WithRequired(e => e.ks_Pedido);

            modelBuilder.Entity<ks_Pedido_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<ks_Pedido_Detalle>()
                .Property(e => e.Precio)
                .HasPrecision(20, 8);

            modelBuilder.Entity<ks_Pedido_Detalle>()
                .Property(e => e.Importe)
                .HasPrecision(20, 8);

            modelBuilder.Entity<ks_Pedido_Detalle>()
                .Property(e => e.Descuento)
                .HasPrecision(20, 8);

            modelBuilder.Entity<ks_Pedido_Detalle>()
                .Property(e => e.Subtotal)
                .HasPrecision(20, 8);

            modelBuilder.Entity<ks_Pedido_Entrega>()
                .Property(e => e.Orden_Compra)
                .IsUnicode(false);

            modelBuilder.Entity<ks_Pedido_Entrega>()
                .Property(e => e.Numero_Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<ks_Pedido_Entrega>()
                .Property(e => e.Des_Ocurre)
                .IsUnicode(false);

            modelBuilder.Entity<Lista_Precios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Lista_Precios>()
                .HasMany(e => e.Lista_Precios_Detalle)
                .WithRequired(e => e.Lista_Precios)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Lista })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lista_Precios>()
                .HasMany(e => e.Lista_Precios_Detalle_TMP)
                .WithRequired(e => e.Lista_Precios)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Lista })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lista_Precios_Detalle>()
                .Property(e => e.Porcentaje_Importe)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Lista_Precios_Detalle_TMP>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Lista_Precios_Detalle_TMP>()
                .Property(e => e.Porcentaje_Importe)
                .HasPrecision(18, 10);

            modelBuilder.Entity<LOG>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.LOCATION)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.OS_BROWSER)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.FUNCTION_METHOD)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.MODULE)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<LOG>()
                .Property(e => e.DETAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Material_Procesos>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Material_Procesos>()
                .Property(e => e.Costo)
                .HasPrecision(20, 2);

            modelBuilder.Entity<Mensaje>()
                .Property(e => e.Mensaje_Texto)
                .IsUnicode(false);

            modelBuilder.Entity<Mensaje>()
                .Property(e => e.Fuente)
                .IsUnicode(false);

            modelBuilder.Entity<Mensaje>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo>()
                .HasMany(e => e.Historico_Prod_Detalle)
                .WithRequired(e => e.Modelo)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Modelo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Modelo>()
                .HasMany(e => e.Modelo_Detalle)
                .WithRequired(e => e.Modelo)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Modelo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Modelo>()
                .HasOptional(e => e.Modelo_Producto_Enc)
                .WithRequired(e => e.Modelo);

            modelBuilder.Entity<Modelo>()
                .HasMany(e => e.Rel_Homologacion_Modelos)
                .WithRequired(e => e.Modelo)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Modelo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Modelo_Producto_Enc>()
                .HasMany(e => e.Modelo_Producto_Det)
                .WithRequired(e => e.Modelo_Producto_Enc)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Modelo_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Modelo_Producto_Enc>()
                .HasMany(e => e.Modelo_Producto_Prod)
                .WithRequired(e => e.Modelo_Producto_Enc)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Modelo_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MTransformada_MPrima>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.compania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.nombre_compania)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.agrupacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.nombre_agrupacion)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.dato)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.nombre_dato)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.trabajador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.nombre_trabajador)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.referencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.Plaza)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fac_Rechazados>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Nota_Credito>()
                .Property(e => e.Numero_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<Nota_Credito>()
                .Property(e => e.Importe_Letra)
                .IsUnicode(false);

            modelBuilder.Entity<Nota_Credito>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Nota_Credito>()
                .Property(e => e.Numero_Docto)
                .IsUnicode(false);

            modelBuilder.Entity<Nota_Credito>()
                .Property(e => e.Numero_Factura_Relacion)
                .IsUnicode(false);

            modelBuilder.Entity<Nota_Credito>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Nota_Credito>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Nota_Credito>()
                .Property(e => e.Nombre_Programa)
                .IsUnicode(false);

            modelBuilder.Entity<Notas_Credito_Compras>()
                .Property(e => e.Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Notas_Credito_Compras>()
                .Property(e => e.Fecha_NC)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Notas_Credito_Compras>()
                .Property(e => e.Numero_Documento_NC)
                .IsUnicode(false);

            modelBuilder.Entity<Notas_Credito_Compras>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Notas_Credito_Compras_Det>()
                .Property(e => e.Documento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_Receta_Tiempo>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Orden_Compras>()
                .Property(e => e.Otros_Impuestos)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Orden_Compras>()
                .Property(e => e.Subtotal)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Orden_Compras>()
                .Property(e => e.Total)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Orden_Compras_Detalle>()
                .Property(e => e.Precio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Orden_Compras_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Orden_Compras_Detalle>()
                .Property(e => e.Cantidad_Facturada)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Orden_Compras_Detalle>()
                .Property(e => e.Descuento)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Orden_Compras_Detalle_Impuesto>()
                .Property(e => e.Operacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Detalle_Impuesto>()
                .Property(e => e.Valor)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Orden_Compras_Detalle_Impuesto>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Orden_Compras_No>()
                .Property(e => e.Precio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Orden_Compras_No>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Orden_Compras_No>()
                .Property(e => e.Cantidad_Facturada)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Orden_Compras_Persona>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Produccion>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Produccion>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Orden_Produccion>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Produccion>()
                .HasOptional(e => e.Actualizacion_Controles)
                .WithRequired(e => e.Orden_Produccion);

            modelBuilder.Entity<Orden_Produccion>()
                .HasMany(e => e.Almacen_Sol_Produccion)
                .WithRequired(e => e.Orden_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Orden })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orden_Produccion>()
                .HasMany(e => e.Avance_Orden_Produccion)
                .WithRequired(e => e.Orden_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Orden })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orden_Produccion>()
                .HasOptional(e => e.Calculo_Rendimiento)
                .WithRequired(e => e.Orden_Produccion);

            modelBuilder.Entity<Orden_Produccion>()
                .HasMany(e => e.Entrega_Almacen_Prod)
                .WithRequired(e => e.Orden_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Orden })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orden_Produccion>()
                .HasMany(e => e.Liberacion_Pedidos_Prod)
                .WithRequired(e => e.Orden_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Orden })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orden_Produccion>()
                .HasMany(e => e.Orden_Produccion_Detalle)
                .WithRequired(e => e.Orden_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Orden })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orden_Produccion>()
                .HasMany(e => e.Orden_Produccion_Lotes)
                .WithRequired(e => e.Orden_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Orden })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orden_Produccion>()
                .HasMany(e => e.Plan_Prod_Fechas_Partidas)
                .WithOptional(e => e.Orden_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Orden });

            modelBuilder.Entity<Orden_Produccion>()
                .HasMany(e => e.Revision_Calidad)
                .WithRequired(e => e.Orden_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Orden })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orden_Produccion_Detalle>()
                .Property(e => e.Cantidad_Total)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Orden_Produccion_Detalle>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Produccion_Lotes>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Produccion_Lotes>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Pendiente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil>()
                .HasMany(e => e.Autoriza_Perfil_Pantalla)
                .WithRequired(e => e.Perfil1)
                .HasForeignKey(e => e.Perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Perfil>()
                .HasMany(e => e.Perfil_concepto)
                .WithRequired(e => e.Perfil)
                .HasForeignKey(e => e.Numero_perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Perfil>()
                .HasMany(e => e.Perfil_programa)
                .WithRequired(e => e.Perfil)
                .HasForeignKey(e => e.Numero_perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Perfil>()
                .HasMany(e => e.Perfil_usuario)
                .WithRequired(e => e.Perfil)
                .HasForeignKey(e => e.Numero_perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Perfil_concepto>()
                .Property(e => e.Importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Perfil_programa>()
                .Property(e => e.Alta)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil_programa>()
                .Property(e => e.Modificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil_programa>()
                .Property(e => e.Baja)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil_programa>()
                .Property(e => e.Autoriza)
                .IsUnicode(false);

            modelBuilder.Entity<Periodos_Siguientes_Sel>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Nombre_Completo)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Paterno)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Materno)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Nombre_Corto)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Radiolocalizador)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.correo_electronico)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Personalidad_juridica)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Numero_Confia)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Actualizacion_Controles)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Actualizacion_Controles_Detalle)
                .WithOptional(e => e.Persona)
                .HasForeignKey(e => e.Numero_Responsable)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Almacen_Sol_Produccion)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Caja_Apertura_Dotacion)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.cc_Pagos)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Cierre_Inventario)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Cajero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.co_Reportes_Contables)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Condiciones_Financieras)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Cliente_Persona);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Contactoes)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Contacto_Persona);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Control_Procesos)
                .WithOptional(e => e.Persona)
                .HasForeignKey(e => e.Numero_Persona)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Cotizacions)
                .WithOptional(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Cotizacions1)
                .WithRequired(e => e.Persona1)
                .HasForeignKey(e => e.Numero_Cliente);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Cotizacions2)
                .WithOptional(e => e.Persona2)
                .HasForeignKey(e => e.Numero_Responsable);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Cotizacion_Simple)
                .WithOptional(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Cotizacion_Simple1)
                .WithRequired(e => e.Persona1)
                .HasForeignKey(e => e.Numero_Cliente);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Cotizacion_Simple2)
                .WithOptional(e => e.Persona2)
                .HasForeignKey(e => e.Numero_Responsable);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.cp_Pagos)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.CProyectos_Personal)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Personal);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.CProyectos_Personas)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Persona);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Datos_Embarque)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Devolucion_Cliente)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Cliente);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Devolucion_Cliente1)
                .WithRequired(e => e.Persona1)
                .HasForeignKey(e => e.Numero_Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Domicilios)
                .WithOptional(e => e.Persona)
                .HasForeignKey(e => e.Numero_Persona)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Estadisticos_Compras_Articulo_TMP)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Estadisticos_Compras_Proveedor_TMP)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Estadisticos_Compras_Proveedor_TMP1)
                .WithRequired(e => e.Persona1)
                .HasForeignKey(e => e.Numero_Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Estadisticos_Ventas_Articulo_TMP)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Estadisticos_Ventas_Cliente_TMP)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Estadisticos_Ventas_Cliente_TMP1)
                .WithRequired(e => e.Persona1)
                .HasForeignKey(e => e.Numero_Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Gastos_Asignacion_Deudores)
                .WithOptional(e => e.Persona)
                .HasForeignKey(e => e.Numero_Persona);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Grupo_Persona)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Persona_Grupo);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Grupo_Persona_Detalle)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Persona);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Historico_Produccion)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Cliente);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Historico_Produccion1)
                .WithOptional(e => e.Persona1)
                .HasForeignKey(e => e.Usuario_Cancelacion);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Homologacion_Articulos)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Homologacion_Modelos)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.ks_Pedido)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Vendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.ks_Pedido_Entrega)
                .WithOptional(e => e.Persona)
                .HasForeignKey(e => e.Numero_Persona_Consig);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Modeloes)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Modelo_Producto_Enc)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Orden_Produccion)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Periodos_Siguientes_Sel)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Persona);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Proveedor_Iva)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.cc_Proceso_Pago)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.cc_Proceso_Pago1)
                .WithRequired(e => e.Persona1)
                .HasForeignKey(e => e.Numero_Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.cp_Proceso_Contabilidad)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.cp_Proceso_Pago)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.cp_Proceso_Pago1)
                .WithRequired(e => e.Persona1)
                .HasForeignKey(e => e.Numero_Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Persona_Relacion)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Persona);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Productos_Conceptos_Cliente)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Proveedors)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_persona);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Recetas)
                .WithOptional(e => e.Persona)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Relacion_Caja_Cajero)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Cajero);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Relacion_Cajero_Almacen)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Cajero);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Revision_Calidad)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Usuario);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Salida_Almacen)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Taller_Calculo_CP)
                .WithOptional(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Persona>()
                .HasOptional(e => e.Usuario)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Usuario_Tipo_Cliente)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Vendedors)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Persona);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Venta_Caja)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Cajero);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Venta_Caja1)
                .WithOptional(e => e.Persona1)
                .HasForeignKey(e => e.Numero_Cliente);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Venta_Caja2)
                .WithOptional(e => e.Persona2)
                .HasForeignKey(e => e.Numero_Contacto);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Venta_Caja3)
                .WithOptional(e => e.Persona3)
                .HasForeignKey(e => e.Usuario_Cancela);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Venta_Caja_Apertura)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Cajero);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Venta_Caja_Cierre)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Numero_Cajero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Venta_Caja_Cierre1)
                .WithOptional(e => e.Persona1)
                .HasForeignKey(e => e.Usuario_Cancela);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Viaticos_Solicitud)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Persona_Solicitante);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Viaticos_Solicitud1)
                .WithOptional(e => e.Persona1)
                .HasForeignKey(e => e.Persona_Factura);

            modelBuilder.Entity<Persona_Concepto>()
                .Property(e => e.Importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Plan_Prod_Detalle_Masivo>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Plan_Prod_Fechas>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Plan_Prod_Fechas>()
                .HasMany(e => e.Plan_Prod_Fechas_Partidas)
                .WithRequired(e => e.Plan_Prod_Fechas)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Fecha })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plan_Prod_Fechas_Partidas>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Plan_Prod_Masivo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Plan_Prod_Masivo>()
                .HasMany(e => e.Plan_Prod_Detalle_Masivo)
                .WithRequired(e => e.Plan_Prod_Masivo)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Plan })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plan_Prod_Masivo>()
                .HasMany(e => e.Plan_Prod_Periodos_Masivo)
                .WithRequired(e => e.Plan_Prod_Masivo)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Plan })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plan_Prod_Partidas_Masivo>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Plan_Prod_Periodos_Masivo>()
                .HasMany(e => e.Plan_Prod_Detalle_Masivo)
                .WithRequired(e => e.Plan_Prod_Periodos_Masivo)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Plan, e.Numero_Periodo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plan_Produccion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Plan_Produccion>()
                .HasMany(e => e.Plan_Prod_Fechas)
                .WithOptional(e => e.Plan_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Plan });

            modelBuilder.Entity<Plan_Produccion>()
                .HasMany(e => e.Plan_Produccion_Detalle)
                .WithRequired(e => e.Plan_Produccion)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Plan })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produccion_Almacen>()
                .Property(e => e.Num_Produccion)
                .IsUnicode(false);

            modelBuilder.Entity<Produccion_Almacen>()
                .Property(e => e.Num_Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Produccion_Almacen>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Produccion_Almacen>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Produccion_Almacen>()
                .Property(e => e.Causa_Cancelacion)
                .IsUnicode(false);

            modelBuilder.Entity<Produccion_Almacen>()
                .HasMany(e => e.Produccion_Almacen_Detalle)
                .WithRequired(e => e.Produccion_Almacen)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_PA })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produccion_Almacen>()
                .HasMany(e => e.Produccion_Salida_Almacen_Detalle)
                .WithRequired(e => e.Produccion_Almacen)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_PSA })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produccion_Almacen_Detalle>()
                .Property(e => e.Clas_Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Produccion_Almacen_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Produccion_Almacen_Detalle>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Produccion_Almacen_Detalle>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Produccion_Salida_Almacen>()
                .Property(e => e.Num_Produccion)
                .IsUnicode(false);

            modelBuilder.Entity<Produccion_Salida_Almacen>()
                .Property(e => e.Num_Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Produccion_Salida_Almacen>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Produccion_Salida_Almacen>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Produccion_Salida_Almacen>()
                .Property(e => e.Causa_Cancelacion)
                .IsUnicode(false);

            modelBuilder.Entity<Produccion_Salida_Almacen>()
                .HasMany(e => e.Produccion_Salida_Almacen_Detalle)
                .WithRequired(e => e.Produccion_Salida_Almacen)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_PSA })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produccion_Salida_Almacen_Detalle>()
                .Property(e => e.Clas_Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Produccion_Salida_Almacen_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Produccion_Salida_Almacen_Detalle>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Produccion_Salida_Almacen_Detalle>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Producto_Cliente)
                .WithRequired(e => e.Producto)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Clasificacion_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Productos_Conceptos)
                .WithRequired(e => e.Producto)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Clasificacion_Producto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto_Impuesto>()
                .Property(e => e.Valor)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Productos_Conceptos>()
                .Property(e => e.Precio)
                .HasPrecision(18, 7);

            modelBuilder.Entity<Productos_Conceptos>()
                .Property(e => e.Costo)
                .HasPrecision(18, 7);

            modelBuilder.Entity<Productos_Conceptos>()
                .Property(e => e.Nombre_Corto)
                .IsUnicode(false);

            modelBuilder.Entity<Productos_Conceptos>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Productos_Conceptos>()
                .Property(e => e.Caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Productos_Conceptos>()
                .Property(e => e.Parte)
                .IsUnicode(false);

            modelBuilder.Entity<Productos_Conceptos>()
                .Property(e => e.Peso)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Productos_Conceptos_Adicionales>()
                .Property(e => e.Clave_Anterior)
                .IsUnicode(false);

            modelBuilder.Entity<Productos_Conceptos_Adicionales>()
                .Property(e => e.Descripcion_Anterior)
                .IsUnicode(false);

            modelBuilder.Entity<Productos_Conceptos_Cliente>()
                .Property(e => e.SKU)
                .IsUnicode(false);

            modelBuilder.Entity<Productos_Conceptos_Kits>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Productos_Conceptos_Kits>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Programa>()
                .Property(e => e.Nombre_programa)
                .IsUnicode(false);

            modelBuilder.Entity<Programa>()
                .Property(e => e.Tipo_programa)
                .IsUnicode(false);

            modelBuilder.Entity<Programa>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Programa>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Programa>()
                .HasMany(e => e.Autoriza_Perfil_Pantalla)
                .WithRequired(e => e.Programa)
                .HasForeignKey(e => e.Numero_Pantalla)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Programa>()
                .HasMany(e => e.Facultades_extraordinarias)
                .WithRequired(e => e.Programa)
                .HasForeignKey(e => e.Numero_programa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Programa>()
                .HasMany(e => e.Perfil_programa)
                .WithRequired(e => e.Programa)
                .HasForeignKey(e => e.Numero_programa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.Articulo_proveedor)
                .WithRequired(e => e.Proveedor)
                .HasForeignKey(e => new { e.Numero_empresa, e.Numero_proveedor })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.Contacto_Proveedor)
                .WithRequired(e => e.Proveedor)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Proveedor })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.Cuentas_Pagar)
                .WithOptional(e => e.Proveedor)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Proveedor });

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.Relacion_Cliente_Proveedor)
                .WithRequired(e => e.Proveedor)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Proveedor })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receta>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Receta>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Receta>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Receta>()
                .HasMany(e => e.Control_Materiales)
                .WithRequired(e => e.Receta)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Receta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receta>()
                .HasMany(e => e.Control_Procesos)
                .WithRequired(e => e.Receta)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Receta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receta>()
                .HasMany(e => e.Orden_Produccion)
                .WithRequired(e => e.Receta)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Receta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receta>()
                .HasMany(e => e.Receta_Detalle)
                .WithRequired(e => e.Receta)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Receta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receta>()
                .HasMany(e => e.Receta_Proceso)
                .WithRequired(e => e.Receta)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Receta })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receta_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Receta_Detalle>()
                .HasMany(e => e.Almacen_Sol_Prod_Detalle)
                .WithRequired(e => e.Receta_Detalle)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receta_Detalle>()
                .HasMany(e => e.Orden_Produccion_Detalle)
                .WithRequired(e => e.Receta_Detalle)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Registro_Pago>()
                .Property(e => e.Importe_Letra)
                .IsUnicode(false);

            modelBuilder.Entity<Registro_Pago>()
                .Property(e => e.Familia_Tipo_Documento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Registro_Pago>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Report_Cont_1_2>()
                .Property(e => e.cam_1)
                .IsUnicode(false);

            modelBuilder.Entity<Report_Cont_1_2>()
                .Property(e => e.cam_2)
                .IsUnicode(false);

            modelBuilder.Entity<Report_Cont_1_2>()
                .Property(e => e.cam_3)
                .IsUnicode(false);

            modelBuilder.Entity<Report_Cont_1_2>()
                .Property(e => e.cam_4)
                .IsUnicode(false);

            modelBuilder.Entity<Report_Cont_1_2>()
                .Property(e => e.cam_5)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Nombre_Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Domicilio_Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Telefono_Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Nombre_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Nombre_Transporte)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Facturas)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Pedidos)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Consignatario)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Domicilio_Tario)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.RFC_Consignatario)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Contenido)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Consignacion)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Etiquetas_Embarque>()
                .Property(e => e.Domicilio_Cion)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Nombre_Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Domicilio_Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Telefono_Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.RFC_Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Correo_Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Nombre_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Nombre_Transporte)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Facturas)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Pedidos)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Consignatario)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Domicilio_Tario)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.RFC_Consignatario)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Consignacion)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Domicilio_Cion)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Ocurre)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Orden_Embarque>()
                .Property(e => e.Contenido)
                .IsUnicode(false);

            modelBuilder.Entity<Requisicion_Compra>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Requisicion_Compra>()
                .Property(e => e.Entrega_Requerida)
                .IsUnicode(false);

            modelBuilder.Entity<Requisicion_Compra>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Requisicion_Compra_Art_No_Catalogo>()
                .Property(e => e.Des_Articulo)
                .IsUnicode(false);

            modelBuilder.Entity<Requisicion_Compra_Art_No_Catalogo>()
                .Property(e => e.Precio_1)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Requisicion_Compra_Art_No_Catalogo>()
                .Property(e => e.Precio_2)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Requisicion_Compra_Art_No_Catalogo>()
                .Property(e => e.Caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Requisicion_Compra_Art_No_Catalogo>()
                .Property(e => e.Parte)
                .IsUnicode(false);

            modelBuilder.Entity<Requisicion_Compra_Det>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Requisicion_Compra_Det>()
                .Property(e => e.Precio_1)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Requisicion_Compra_Det>()
                .Property(e => e.Precio_2)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Requisicion_Compra_Det>()
                .Property(e => e.Caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Requisicion_Compra_Det>()
                .Property(e => e.Parte)
                .IsUnicode(false);

            modelBuilder.Entity<Requisicion_Persona>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Revision_Calidad>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<RH_Persona>()
                .Property(e => e.Turno3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RH_Persona>()
                .HasMany(e => e.CProyectos)
                .WithOptional(e => e.RH_Persona)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Responsable });

            modelBuilder.Entity<RH_Persona>()
                .HasMany(e => e.Transporte_Vehiculo)
                .WithRequired(e => e.RH_Persona)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Persona_Operador })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Salida_Almacen>()
                .Property(e => e.Numero_Docto_Entrada)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen>()
                .Property(e => e.Anexo)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen_Costo>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Costo>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Costo>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Costo>()
                .Property(e => e.Cantidad_Recibida_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Costo>()
                .Property(e => e.Cantidad_Entregada_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Costo>()
                .Property(e => e.Cantidad_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Detalle>()
                .Property(e => e.Cantidad_Recibida)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Detalle>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen_Detalle>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Detalle>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Detalle>()
                .Property(e => e.Des_Articulo_Nuevo)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen_Detalle>()
                .Property(e => e.Cantidad_Recibida_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Detalle_No>()
                .Property(e => e.Numero_RC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen_Detalle_No>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen_Detalle_No>()
                .Property(e => e.Cantidad_Facturada)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Salida_Almacen_Detalle_No>()
                .Property(e => e.Nombre_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen_Detalle_No>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Detalle_No>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Sat_Catalogo_prod_Serv>()
                .Property(e => e.c_ClaveProdServ)
                .IsUnicode(false);

            modelBuilder.Entity<Sat_Catalogo_prod_Serv>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sol_Prod_Detalle_Transformada>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Sol_Prod_Detalle_Transformada>()
                .Property(e => e.Cantidad_Recibida)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Solicitud_Cotizacion_Persona>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursal>()
                .Property(e => e.Comision)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Taller_Calculo_CP>()
                .HasMany(e => e.Taller_Calculo_CP_Detalle)
                .WithRequired(e => e.Taller_Calculo_CP)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Clas_Valor })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Taller_Impuestos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Taller_Impuestos>()
                .Property(e => e.Operacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Taller_Impuestos>()
                .Property(e => e.c_Impuesto_Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Taller_Impuestos>()
                .HasMany(e => e.Articulo_Concepto_Impuesto)
                .WithRequired(e => e.Taller_Impuestos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Num_Impuesto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Taller_Impuestos>()
                .HasMany(e => e.Historico_Articulo_Concepto_Impuesto)
                .WithRequired(e => e.Taller_Impuestos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Num_Impuesto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Taller_Impuestos>()
                .HasMany(e => e.Producto_Impuesto)
                .WithRequired(e => e.Taller_Impuestos)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Num_Impuesto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tipo_Cambio>()
                .Property(e => e.Compra)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Tipo_Cambio>()
                .Property(e => e.Venta)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Transaccion_Contable_Matriz>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Transaccion_Matriz_Tipo>()
                .Property(e => e.Nombre_Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Transaccion_Programa>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Transaccion_Programa_Auxiliar>()
                .Property(e => e.Des_Auxiliar)
                .IsUnicode(false);

            modelBuilder.Entity<Transacciones_Contables>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_Rutas>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_Rutas>()
                .Property(e => e.Hora_Extra)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Transporte_Rutas>()
                .HasMany(e => e.Transporte_Rutas_Detalle)
                .WithRequired(e => e.Transporte_Rutas)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Transporte_Rutas })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transporte_Rutas>()
                .HasOptional(e => e.Transporte_Rutas_Permiso)
                .WithRequired(e => e.Transporte_Rutas);

            modelBuilder.Entity<Transporte_Vehiculo>()
                .Property(e => e.Placas)
                .IsUnicode(false);

            modelBuilder.Entity<Transporte_Vehiculo>()
                .HasMany(e => e.Transporte_Rutas)
                .WithRequired(e => e.Transporte_Vehiculo)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Unidad })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ubicacion_Articulo>()
                .Property(e => e.Stock_Aviso)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Ultima_Compra_Proveedor_TMP>()
                .Property(e => e.Nombre_Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Ultima_Compra_Proveedor_TMP>()
                .Property(e => e.Des_Compra)
                .IsUnicode(false);

            modelBuilder.Entity<Ultima_Compra_Proveedor_TMP>()
                .Property(e => e.Des_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Ultima_Compra_Proveedor_TMP>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Contraseña)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Almacen_Usuario)
                .WithOptional(e => e.Usuario)
                .HasForeignKey(e => e.Numero_Usuario);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Caja_Arqueo)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.Numero_Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Caja_Chica_Comprobacion)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Caja_Chica_Dotacion)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Caja_Chica_Solicitud_Reembolso)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Caja_Comprobacion)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Caja_Dotacion)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Caja_Solicitud_Reembolso)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Facultades_extraordinarias)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Metodo_Costeo_Rangos)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Perfil_usuario)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Persona_Concepto)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendedor>()
                .HasMany(e => e.Cliente_Vendedor)
                .WithRequired(e => e.Vendedor)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Vendedor_Persona })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendedor>()
                .HasMany(e => e.Vendedor_Comision_Producto)
                .WithRequired(e => e.Vendedor)
                .HasForeignKey(e => new { e.Numero_empresa, e.Numero_Persona_Vendedor })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendedor>()
                .HasMany(e => e.Vendedor_TipoCliente)
                .WithRequired(e => e.Vendedor)
                .HasForeignKey(e => new { e.Numero_Empresa, e.Numero_Vendedor_Persona })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Venta_Caja>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Venta_Caja>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Venta_Caja_Apertura>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Venta_Caja_Cierre>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Venta_Caja_Cierre_Detalle>()
                .Property(e => e.Monto)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Venta_Caja_Cierre_Pagos>()
                .Property(e => e.Monto)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Venta_Caja_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Venta_Caja_Detalle>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Venta_Caja_Detalle>()
                .Property(e => e.Importe)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Venta_Caja_Detalle>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Venta_Caja_Pagos>()
                .Property(e => e.Monto)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Venta_Caja_Pagos>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Venta_Configuracion>()
                .Property(e => e.Peso_Max)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Viaticos_Asignacion>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Viaticos_Asignacion>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Conceptos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Devolucion>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Devolucion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Devolucion>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Viaticos_Devolucion>()
                .Property(e => e.Moneda)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Viaticos_Liquidacion>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Liquidacion_Detalle>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Viaticos_Liquidacion_Detalle>()
                .Property(e => e.Monto_TC)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Viaticos_Liquidacion_Detalle>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Liquidacion_Detalle>()
                .Property(e => e.Comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Liquidacion_Detalle>()
                .Property(e => e.Num_Docto)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Solicitud>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Solicitud>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Asignacion_Consulta_Tmp>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Asignacion_Consulta_Tmp>()
                .Property(e => e.Tipo_Activo)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Depreciacion_Tmp>()
                .Property(e => e.Cve_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Depreciacion_Tmp>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Depreciacion_Tmp>()
                .Property(e => e.Tipo_Activo)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Depreciacion_Tmp>()
                .Property(e => e.Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Depreciacion_Tmp>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Tmp>()
                .Property(e => e.Inventario)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Tmp>()
                .Property(e => e.Cve_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Tmp>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Tmp>()
                .Property(e => e.Tipo_Activo)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Tmp>()
                .Property(e => e.Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Tmp>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Activo_Fijo_Consulta_Tmp>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Existencia_TMP>()
                .Property(e => e.Total_Existencia)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Almacen_Existencia_TMP>()
                .Property(e => e.Total_Apartado)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Almacen_Existencia_TMP>()
                .Property(e => e.Parte)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Existencia_TMP>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Existencia_TMP>()
                .Property(e => e.Cantidad_Recibida_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Existencia_TMP>()
                .Property(e => e.Cantidad_Entregada_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Existencia_TMP>()
                .Property(e => e.Cantidad_Apartada_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Existencia_TMP>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Existencia_TMP>()
                .Property(e => e.Ultimo_Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Inventario_Detalle>()
                .Property(e => e.Parte)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Inventario_Detalle>()
                .Property(e => e.Costo_Promedio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Listado>()
                .Property(e => e.Almacen)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Listado>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Listado>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Listado>()
                .Property(e => e.Parte)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Listado>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Listado>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Almacen_Listado>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencia_Detalles>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencia_Detalles>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen_Transferencia_Detalles>()
                .Property(e => e.Signo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Archivo_Nomina_Alterna>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Articulo_Concepto>()
                .Property(e => e.Cantidad_UM)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Articulo_Concepto>()
                .Property(e => e.Caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Articulo_Concepto>()
                .Property(e => e.Parte)
                .IsUnicode(false);

            modelBuilder.Entity<Articulo_Concepto>()
                .Property(e => e.SMinimo)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Articulo_Concepto>()
                .Property(e => e.SMaximo)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Articulo_Concepto>()
                .Property(e => e.Nombre_Corto)
                .IsUnicode(false);

            modelBuilder.Entity<Articulo_Concepto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Articulo_Descuento_Cliente1_TMP>()
                .Property(e => e.Descuento)
                .HasPrecision(18, 10);

            modelBuilder.Entity<AuxMovChequerasNC>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AuxMovChequerasNC>()
                .Property(e => e.Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AuxMovChequerasNC>()
                .Property(e => e.Importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AuxMovChequerasNC>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<AuxMovChequerasNC>()
                .Property(e => e.NombreBanco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AuxMovChequerasNC>()
                .Property(e => e.NombreCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AuxMovChequerasNC>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AuxMovChequerasNC>()
                .Property(e => e.Titulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Concepto_Conciliacion>()
                .Property(e => e.Concepto_Interno)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Concepto_Conciliacion>()
                .Property(e => e.Concepto_Banco)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Concepto_Conciliacion>()
                .Property(e => e.Clave_Banco)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Conciliacion_XLS>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Banco_Reporte_No_Conciliados>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Contactos>()
                .Property(e => e.Puesto)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Mon_Ext_Revaluado_Rpt>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Bancos_Movimientos_Multiples_Detalle>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos_Movimientos_Multiples_Detalle>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Bitacora_Autorizacion>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Bitacora_Autorizacion>()
                .Property(e => e.Movimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Bitacora_Autorizacion>()
                .Property(e => e.Modulo)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Arqueo_Egresos_TMP>()
                .Property(e => e.Num_Vale)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Arqueo_Egresos_TMP>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Arqueo_Egresos_TMP>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Arqueo_Egresos_TMP>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Arqueo_Seleccion_TMP>()
                .Property(e => e.Num_Vale)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Arqueo_Seleccion_TMP>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Arqueo_Seleccion_TMP>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Caja_Arqueo_Seleccion_TMP>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Campos_Calculo_CP>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Campos_Calculo_CP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Campos_Calculo_CP>()
                .Property(e => e.Tabla)
                .IsUnicode(false);

            modelBuilder.Entity<Campos_Calculo_CP>()
                .Property(e => e.Campo)
                .IsUnicode(false);

            modelBuilder.Entity<Campos_Calculo_CP_Relacion>()
                .Property(e => e.Campo)
                .IsUnicode(false);

            modelBuilder.Entity<CamposCheque>()
                .Property(e => e.Campo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CartaModeloTMP>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CartaModeloTMP>()
                .Property(e => e.Seccion1)
                .IsUnicode(false);

            modelBuilder.Entity<CartaModeloTMP>()
                .Property(e => e.Seccion2)
                .IsUnicode(false);

            modelBuilder.Entity<CartaModeloTMP>()
                .Property(e => e.Seccion3)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Inventarios_ag>()
                .Property(e => e.Inicial)
                .HasPrecision(15, 4);

            modelBuilder.Entity<Catalogo_Inventarios_ag>()
                .Property(e => e.Entrada)
                .HasPrecision(15, 4);

            modelBuilder.Entity<Catalogo_Inventarios_ag>()
                .Property(e => e.Salida)
                .HasPrecision(15, 4);

            modelBuilder.Entity<cc_Anticipos_Clientes_TMP>()
                .Property(e => e.Nombre_Completo)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Anticipos_Clientes_TMP>()
                .Property(e => e.Des_Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Anticipos_Clientes_TMP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Anticipos_Clientes_TMP>()
                .Property(e => e.Des_Iva)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Anticipos_Clientes_TMP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Estado_Cuenta_TMP>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Estado_Cuenta_TMP>()
                .Property(e => e.Des_Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Estado_Cuenta_TMP>()
                .Property(e => e.Des_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Estado_Cuenta_TMP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Estado_Cuenta_TMP>()
                .Property(e => e.Numero_Factura_Abono)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Estado_Cuenta_TMP>()
                .Property(e => e.Des_Moneda_Origen)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Estado_Cuenta_TMP>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<cc_Proceso_Pago>()
                .Property(e => e.Numero_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Proceso_Pago>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Proceso_Pago>()
                .Property(e => e.Monto)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cc_Proceso_Pago>()
                .Property(e => e.Abono)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cc_Proceso_Pago>()
                .Property(e => e.Saldo)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cc_Proceso_Pago>()
                .Property(e => e.Importe)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cc_Proceso_Pago>()
                .Property(e => e.Des_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Proceso_Pago>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(20, 10);

            modelBuilder.Entity<cc_Proceso_Pago>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<cc_Proceso_Pago>()
                .Property(e => e.Forma_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<ChequerasBanco>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChequerasBanco>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ChequerasBanco>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChequerasBanco>()
                .Property(e => e.RutaConciliacion)
                .IsUnicode(false);

            modelBuilder.Entity<ChequerasBanco>()
                .Property(e => e.Sucursal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChequesBanco>()
                .Property(e => e.Clave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChequesBanco>()
                .Property(e => e.Campo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cliente_Desc_Factura>()
                .Property(e => e.Descuento)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cliente_Desc_Factura_TMP>()
                .Property(e => e.Descuento)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Clientes_Conta_Comparativo>()
                .Property(e => e.Nombre_Completo)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes_Conta_Comparativo>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes_Conta_Comparativo>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes_Conta_Comparativo>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes_Conta_Comparativo>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Plantilla>()
                .Property(e => e.cam_1)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Plantilla>()
                .Property(e => e.cam_2)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Plantilla>()
                .Property(e => e.cam_3)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Plantilla>()
                .Property(e => e.cam_4)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Plantilla>()
                .Property(e => e.cam_5)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Plantilla>()
                .Property(e => e.cam_6)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Plantilla>()
                .Property(e => e.cam_7)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Plantilla>()
                .Property(e => e.cam_8)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Plantilla>()
                .Property(e => e.cam_9)
                .IsUnicode(false);

            modelBuilder.Entity<co_Reportes_Plantilla>()
                .Property(e => e.cam_10)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Etiqueta_Importe1)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Etiqueta_Importe2)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Etiqueta_Importe3)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Etiqueta_Importe4)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Etiqueta_Importe5)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Etiqueta_Importe6)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Etiqueta_Importe7)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Etiqueta_Importe8)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Etiqueta_Importe9)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Etiqueta_Importe10)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoBanco>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoBanco>()
                .Property(e => e.ConceptoInterno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoBanco>()
                .Property(e => e.ConceptoBanco1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoInterno>()
                .Property(e => e.Clave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoInterno>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoInterno>()
                .Property(e => e.TipoAfectacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Conceptos_Entrada_Salida_Almacen_TMP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Conceptos_Entrada_Salida_Almacen_TMP>()
                .Property(e => e.Signo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoTMP>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoTMP>()
                .Property(e => e.Etiqueta_Importe1)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoTMP>()
                .Property(e => e.Etiqueta_Importe2)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoTMP>()
                .Property(e => e.Etiqueta_Importe3)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoTMP>()
                .Property(e => e.Etiqueta_Importe4)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoTMP>()
                .Property(e => e.Etiqueta_Importe5)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoTMP>()
                .Property(e => e.Etiqueta_Importe6)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoTMP>()
                .Property(e => e.Etiqueta_Importe7)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoTMP>()
                .Property(e => e.Etiqueta_Importe8)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoTMP>()
                .Property(e => e.Etiqueta_Importe9)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoTMP>()
                .Property(e => e.Etiqueta_Importe10)
                .IsUnicode(false);

            modelBuilder.Entity<Condiciones_Facturacion_Revision>()
                .Property(e => e.Dia_Revision)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Des_Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Des_Almacen)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Cotiza_Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Nombre_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Cve_TProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Des_TProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Cve_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Des_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Cve_TConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Des_TConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Cve_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Des_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Cantidad_Solicitada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Cantidad_Restante)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Folio_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Factura_Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Tipo_Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Apartados_TMP>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Des_Almacen)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Des_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Cve_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Des_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Disponible)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Promedio_Dia)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Disponible_Dia)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Pendiente_Llegar)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Stock_Maximo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Disponible_Maximo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Stock_Reposicion)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Disponible_Reposicion)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Stock_Minimo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Disponible_Minimo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Compra_Sugerida)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Consulta_Punto_Reorden_TMP>()
                .Property(e => e.Des_UM)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Cuenta_Mayor_TMP>()
                .Property(e => e.Des_Cuenta_Mayor)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Cuenta_Mayor_TMP>()
                .Property(e => e.Des_Clave_Mayor)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas_Importadas>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas_Paso>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Contabilidad_Polizas_Revaluacion>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas_Revaluacion>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas_Tipo>()
                .Property(e => e.Nombre_Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas_Tipo>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas_TMP>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas_TMP>()
                .Property(e => e.Numero_Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Contabilidad_Polizas_TMP>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Contabilidad_Polizas_TMP>()
                .Property(e => e.folio_fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.Calle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.Colonia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.Ciudad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.CodigoPostal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.BancoDeposito)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.BancoConcentracion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.BancoPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.BancoDispersion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.TipoComisiones)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.CategoriaCompetencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.CategoriaZona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.ImporteFijoPago)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ControlOficina>()
                .Property(e => e.PermitirCheques)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CorteOficinaUsuario>()
                .Property(e => e.ImporteEfectivo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CorteOficinaUsuario>()
                .Property(e => e.ImporteCheques)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CorteOficinaUsuario>()
                .Property(e => e.OrdenesPagadas)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CorteOficinaUsuario>()
                .Property(e => e.PagoAgente)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Cotizacion_Art_Descuentos>()
                .Property(e => e.Des_Concepto_Descuento)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Art_Descuentos>()
                .Property(e => e.Importe_Tipo_Cambio)
                .HasPrecision(18, 7);

            modelBuilder.Entity<Cotizacion_Detalle_Almacen_TMP>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Detalle_Caracteristicas_TMP>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Numero_Cotizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Responsable)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Vendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Nombre_Proyecto)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Moneda_Facturar)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Periodicidad_Pagos)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Texto_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Contacto_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Domicilio_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Colonia_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Delegación_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Estado_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.CP_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Encabezado_XLS>()
                .Property(e => e.Telefono_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Entrega>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Entrega>()
                .Property(e => e.Num_Guia)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Entrega>()
                .Property(e => e.Destino)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Entrega>()
                .Property(e => e.Peso)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Entrega>()
                .Property(e => e.Medida)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Fac_Descuentos>()
                .Property(e => e.Des_Concepto_Descuento)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion_Simple_Detalle_Almacen_TMP>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<cp_Anticipos_Proveedores_TMP>()
                .Property(e => e.Nombre_Completo)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Anticipos_Proveedores_TMP>()
                .Property(e => e.Des_Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Anticipos_Proveedores_TMP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Anticipos_Proveedores_TMP>()
                .Property(e => e.Des_Iva)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Anticipos_Proveedores_TMP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Consulta_por_Concepto_TMP>()
                .Property(e => e.Nombre_Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Consulta_por_Concepto_TMP>()
                .Property(e => e.Des_Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Consulta_por_Concepto_TMP>()
                .Property(e => e.Des_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Consulta_por_Concepto_TMP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Consulta_por_Concepto_TMP>()
                .Property(e => e.Numero_Factura_Abono)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Consulta_por_Concepto_TMP>()
                .Property(e => e.Referencia_Texto)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Consulta_por_Concepto_TMP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Consulta_por_Concepto_TMP>()
                .Property(e => e.Des_Moneda_Origen)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Consulta_por_Concepto_TMP>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<cp_Consulta_por_Concepto_TMP>()
                .Property(e => e.Nombre_Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Diot_Proceso>()
                .Property(e => e.Cadena)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Estado_Cuenta_TMP>()
                .Property(e => e.Nombre_Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Estado_Cuenta_TMP>()
                .Property(e => e.Des_Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Estado_Cuenta_TMP>()
                .Property(e => e.Des_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Estado_Cuenta_TMP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Estado_Cuenta_TMP>()
                .Property(e => e.Numero_Factura_Abono)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Estado_Cuenta_TMP>()
                .Property(e => e.Referencia_Texto)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Estado_Cuenta_TMP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Estado_Cuenta_TMP>()
                .Property(e => e.Des_Moneda_Origen)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Estado_Cuenta_TMP>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<cp_Pagos_Poliza>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(20, 10);

            modelBuilder.Entity<cp_Pagos_Poliza>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Pagos_Poliza>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Pagos_Poliza>()
                .Property(e => e.Debe)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cp_Pagos_Poliza>()
                .Property(e => e.Haber)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cp_Pagos_Poliza>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Proceso_Contabilidad>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(20, 10);

            modelBuilder.Entity<cp_Proceso_Contabilidad>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Proceso_Contabilidad>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Proceso_Contabilidad>()
                .Property(e => e.Debe)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cp_Proceso_Contabilidad>()
                .Property(e => e.Haber)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cp_Proceso_Contabilidad>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Proceso_Pago>()
                .Property(e => e.Numero_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Proceso_Pago>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Proceso_Pago>()
                .Property(e => e.Monto)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cp_Proceso_Pago>()
                .Property(e => e.Abono)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cp_Proceso_Pago>()
                .Property(e => e.Saldo)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cp_Proceso_Pago>()
                .Property(e => e.Importe)
                .HasPrecision(20, 2);

            modelBuilder.Entity<cp_Proceso_Pago>()
                .Property(e => e.Des_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Proceso_Pago>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(20, 10);

            modelBuilder.Entity<cp_Proceso_Pago>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<cp_Proceso_Pago>()
                .Property(e => e.Clas_FPago)
                .IsUnicode(false);

            modelBuilder.Entity<CProyecto_Relacion_Concepto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Anticipos>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Anticipos>()
                .Property(e => e.Numero_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Anticipos>()
                .Property(e => e.Numero_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Anticipos>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cuentas_Cobrar_Anticipos>()
                .Property(e => e.TC_Mes)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cuentas_Cobrar_Anticipos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Anticipos>()
                .Property(e => e.UsoCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Anticipos>()
                .Property(e => e.Metodo_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Anticipos>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Anticipos>()
                .Property(e => e.nombre_programa)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Comparativo_Tmp>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Comparativo_Tmp>()
                .Property(e => e.Numero_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Comparativo_Tmp>()
                .Property(e => e.Numero_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Comparativo_Tmp>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cuentas_Cobrar_Conceptos_TMP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Conceptos_TMP>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Global>()
                .Property(e => e.Numero_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Global>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Global>()
                .Property(e => e.Cuenta_Banco)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Global>()
                .Property(e => e.Tipo_Cambio_MES)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Cuentas_Cobrar_Tmp>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Tmp>()
                .Property(e => e.Numero_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Tmp>()
                .Property(e => e.Numero_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Tmp>()
                .Property(e => e.Numero_Factura_Abono)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Cobrar_Tmp>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cuentas_Cobrar_Tmp>()
                .Property(e => e.Tipo_Cambio_Integra)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cuentas_Cobrar_Tmp>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Comparativo_Tmp>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Comparativo_Tmp>()
                .Property(e => e.Numero_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Comparativo_Tmp>()
                .Property(e => e.Referencia_Texto)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Comparativo_Tmp>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Comparativo_Tmp>()
                .Property(e => e.Numero_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Comparativo_Tmp>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Cuentas_Pagar_Conceptos_TMP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas_Pagar_Conceptos_TMP>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Costo>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Costo>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Costo>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Costo>()
                .Property(e => e.Cantidad_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Costo>()
                .Property(e => e.Cantidad_Entregada_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Costo>()
                .Property(e => e.Cantidad_Recibida_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle_TMP>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_TMP>()
                .Property(e => e.Cantidad_Facturada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle_TMP>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle_TMP>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle_TMP>()
                .Property(e => e.Parte)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_TMP>()
                .Property(e => e.Cantidad_Apartada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle_TMP>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_TMP>()
                .Property(e => e.Des_Articulo_Nuevo)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Almacen_Detalle_TMP>()
                .Property(e => e.Cantidad_Recibida_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Almacen_Detalle_TMP>()
                .Property(e => e.Cantidad_Entregada_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Entrada_Salida_Almacen_Det>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Salida_Almacen_Det>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Entrada_Salida_Almacen_Det>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Estadisticos_Ventas_Cliente_TMP1>()
                .Property(e => e.Importe_Total)
                .HasPrecision(38, 6);

            modelBuilder.Entity<Estado_Resultados_Anual>()
                .Property(e => e.Numero_Tipo_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Estado_Resultados_Anual>()
                .Property(e => e.Orden)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Estado_Resultados_Anual_Concen>()
                .Property(e => e.Numero_Tipo_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Estado_Resultados_Anual_Concen>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Estado_Resultados_Anual_Concen>()
                .Property(e => e.Orden)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Estado_Resultados_Mensual>()
                .Property(e => e.Numero_Tipo_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Estado_Resultados_Mensual>()
                .Property(e => e.Orden)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Estado_Resultados_Mensual_Concen>()
                .Property(e => e.Numero_Tipo_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Estado_Resultados_Mensual_Concen>()
                .Property(e => e.Des_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Estado_Resultados_Mensual_Concen>()
                .Property(e => e.Orden)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Estado_Resultados_Mensual1>()
                .Property(e => e.Numero_Tipo_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Estado_Resultados_Mensual1>()
                .Property(e => e.Orden)
                .HasPrecision(18, 1);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.compania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.nombre_compania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.trabajador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.nombre_trab)
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.chequera)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.importe_letra)
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.Agrupacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.Desc_Agr)
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.Dato)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.Desc_Dato)
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.agr_desarrollo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.desc_agr_des)
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.dato_desarrollo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.desc_dato_des)
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.desc_forma_pago)
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.Plaza)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<exporta_cheques>()
                .Property(e => e.Folio_Cheque)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Concepto_TMP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Descuentos>()
                .Property(e => e.Des_Concepto_Descuento)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Descuentos>()
                .Property(e => e.Importe_Monto_Descuento)
                .HasPrecision(18, 7);

            modelBuilder.Entity<Factura_Descuentos_Art>()
                .Property(e => e.Desc_Concepto_Descuento)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Descuentos_Art>()
                .Property(e => e.Monto_Descuento)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Factura_Descuentos_Art_TMP>()
                .Property(e => e.Desc_Concepto_Descuento)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Descuentos_Art_TMP>()
                .Property(e => e.Monto_Descuento)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Factura_Detalle_Impuesto>()
                .Property(e => e.Operacion)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_Detalle_Impuesto>()
                .Property(e => e.Valor)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Factura_Detalle_Impuesto>()
                .Property(e => e.Importe)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Factura_XLS>()
                .Property(e => e.Num_Docto)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_XLS>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_XLS>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_XLS>()
                .Property(e => e.Caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Factura_XLS>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Factura_XLS>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Factura_XLS>()
                .Property(e => e.TC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Facturacion_Cuentas_Pagar_TMP>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Facturacion_Cuentas_Pagar_TMP>()
                .Property(e => e.Numero_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Facturacion_Cuentas_Pagar_TMP>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Facturacion_Cuentas_Pagar_TMP>()
                .Property(e => e.TC_Mes)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Facturas_Periodicas>()
                .Property(e => e.Numero_Factura_Periodica_Encabezado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_Periodicas_Encabezado>()
                .Property(e => e.Importe_Letra)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_Periodicas_Encabezado>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<FE_CxP_Sin_FF>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<FE_CxP_Sin_FF_Todos>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Comprobante_Folio)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Comprobante_Fecha)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Comprobante_Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Emisor_RFC)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Emisor_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Emisor_Calle)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Emisor_Exterior)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Emisor_Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Emisor_Localidad)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Emisor_Municipio)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Emisor_Estado)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Emisor_Pais)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Emisor_CP)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Receptor_RFC)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Datos_CFDI_CxP>()
                .Property(e => e.Carpeta_Importaciones)
                .IsUnicode(false);

            modelBuilder.Entity<FE_NO_Relacion_CFDI_CxC>()
                .Property(e => e.Carpeta)
                .IsUnicode(false);

            modelBuilder.Entity<FE_NO_Relacion_CFDI_CxC>()
                .Property(e => e.Concepto_Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<FE_NO_Relacion_CFDI_CxC>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<FE_NO_Relacion_CFDI_CxC>()
                .Property(e => e.Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<FE_NO_Relacion_CFDI_CxP>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<FE_NO_Relacion_CFDI_CxP>()
                .Property(e => e.Fecha_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<FE_NO_Relacion_CFDI_CxP>()
                .Property(e => e.RFC_Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<FE_NO_Relacion_CFDI_CxP>()
                .Property(e => e.Nombre_Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<FE_NO_Relacion_CFDI_CxP>()
                .Property(e => e.Carpeta)
                .IsUnicode(false);

            modelBuilder.Entity<FE_NO_Relacion_CFDI_CxP>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<FE_NO_Relacion_CFDI_CxP>()
                .Property(e => e.Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Relacion_CFDI_CxC>()
                .Property(e => e.Carpeta)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Relacion_CFDI_CxC>()
                .Property(e => e.Concepto_Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Relacion_CFDI_CxC>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Relacion_CFDI_CxP>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Relacion_CFDI_CxP>()
                .Property(e => e.Concepto_Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<FE_Relacion_CFDI_CxP>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Folio_Campos_Factura>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Folio_TMP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Folio_TMP>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Folio_TMP>()
                .Property(e => e.Prefijo)
                .IsUnicode(false);

            modelBuilder.Entity<Historico_Productos_Conceptos>()
                .Property(e => e.Precio)
                .HasPrecision(18, 7);

            modelBuilder.Entity<Ingresos_Diferidos>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Ingresos_Diferidos>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Ingresos_Diferidos>()
                .Property(e => e.Caracteristicas)
                .IsUnicode(false);

            modelBuilder.Entity<Ingresos_Diferidos>()
                .Property(e => e.Num_Contrato)
                .IsUnicode(false);

            modelBuilder.Entity<Ingresos_Diferidos>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Ingresos_Diferidos>()
                .Property(e => e.Num_Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Ingresos_Diferidos>()
                .Property(e => e.Site_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_Movimientos>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_Movimientos>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_Movimientos>()
                .Property(e => e.Signo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Liberacion_Cheque>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Metodo_Costeo_Reporte_TMP>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Metodo_Costeo_Reporte_TMP>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Metodo_Costeo_Reporte_TMP>()
                .Property(e => e.Cantidad_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Modelo_Importacion_Polizas>()
                .Property(e => e.Compania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Modelo_Importacion_Polizas>()
                .Property(e => e.Nombre_Compania)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo_Importacion_Polizas>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo_Importacion_Polizas>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo_Importacion_Polizas>()
                .Property(e => e.Cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Modelo_Importacion_Polizas>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo_Importacion_Polizas>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo_Importacion_Polizas>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo_Importacion_Polizas>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.Clave1)
                .IsUnicode(false);

            modelBuilder.Entity<MovChequera>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MovChequera>()
                .Property(e => e.Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MovChequera>()
                .Property(e => e.Importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MovChequera>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<MovEdoCta>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MovEdoCta>()
                .Property(e => e.ConceptoBanco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MovEdoCta>()
                .Property(e => e.Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MovEdoCta>()
                .Property(e => e.Importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MovEdoCta>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Cont_Cve_Conc>()
                .Property(e => e.Clave_Central)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Cont_Cve_Conc>()
                .Property(e => e.Clave_Final)
                .IsUnicode(false);

            modelBuilder.Entity<nomina_contabilidad_Rechazados>()
                .Property(e => e.compania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<nomina_contabilidad_Rechazados>()
                .Property(e => e.nombre_compania)
                .IsUnicode(false);

            modelBuilder.Entity<nomina_contabilidad_Rechazados>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<nomina_contabilidad_Rechazados>()
                .Property(e => e.concepto)
                .IsUnicode(false);

            modelBuilder.Entity<nomina_contabilidad_Rechazados>()
                .Property(e => e.cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<nomina_contabilidad_Rechazados>()
                .Property(e => e.poliza_adam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<nomina_contabilidad_Rechazados>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<nomina_contabilidad_Rechazados>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<nomina_contabilidad_Rechazados>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fact_Relacion_Empresas>()
                .Property(e => e.Numero_Referencia_NE)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Fact_Relacion_Empresas>()
                .Property(e => e.Numero_Referencia_NER)
                .IsUnicode(false);

            modelBuilder.Entity<Nota_Credito_Detalle_Impuesto>()
                .Property(e => e.Operacion)
                .IsUnicode(false);

            modelBuilder.Entity<Nota_Credito_Detalle_Impuesto>()
                .Property(e => e.Valor)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Nota_Credito_Detalle_Impuesto>()
                .Property(e => e.Importe)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Numero_ID_Consulta>()
                .Property(e => e.NDecimal_ID1)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Numero_ID_Consulta>()
                .Property(e => e.NDecimal_ID2)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Numero_ID_Consulta>()
                .Property(e => e.NDecimal_ID3)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Numero_ID_Consulta>()
                .Property(e => e.NDecimal_ID4)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Numero_ID_Consulta>()
                .Property(e => e.NDecimal_ID5)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Numero_ID_Consulta>()
                .Property(e => e.Cadena)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Simulacion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Simulacion>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Simulacion_Detalle_Resumen>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OP_Simulacion_Detalle_Resumen>()
                .Property(e => e.Cantidad_Entregada)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OperacionesProgramada>()
                .Property(e => e.TipoOperacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionesProgramada>()
                .Property(e => e.BancoCargo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionesProgramada>()
                .Property(e => e.BancoAbono)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionesProgramada>()
                .Property(e => e.Moneda)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OperacionesProgramada>()
                .Property(e => e.Importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OperacionesProgramada>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionesProgramada>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Encabezado_XLS>()
                .Property(e => e.Numero_OC)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Encabezado_XLS>()
                .Property(e => e.Numero_Cotizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Encabezado_XLS>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Encabezado_XLS>()
                .Property(e => e.Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Encabezado_XLS>()
                .Property(e => e.Solicitante)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Encabezado_XLS>()
                .Property(e => e.Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Encabezado_XLS>()
                .Property(e => e.Periodicidad_Pagos)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Encabezado_XLS>()
                .Property(e => e.Tipo_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Encabezado_XLS>()
                .Property(e => e.Persona_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Encabezado_XLS>()
                .Property(e => e.Almacen)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Encabezado_XLS>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Factura>()
                .Property(e => e.Numero_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Factura>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Orden_Compras_Factura>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Factura_Detalle>()
                .Property(e => e.Precio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Orden_Compras_Factura_Detalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Orden_Compras_Factura_Multiple>()
                .Property(e => e.Numero_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Factura_Multiple>()
                .Property(e => e.TC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Orden_Compras_Factura_Multiple>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Factura_Multiple>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Factura_Multiple>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<Orden_Compras_Factura_Multiple_Det>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Orden_Compras_Factura_Multiple_Det>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Orden_Compras_Factura_No>()
                .Property(e => e.Precio)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Orden_Compras_Factura_No>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Orden_MTransformada_MPrima_TMP>()
                .Property(e => e.Cantidad)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.ImporteOrigen)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.ComisionCliente)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.ImporteDestino)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.UtilidadCambiaria)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.ComisionOrigen)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.ComisionDestino)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.EfectivoEnvio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.BancoCheque)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.ImporteCheque)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.TipoAlerta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.TipoOperacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.TipoIdentificacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ordene>()
                .Property(e => e.NumeroIdentificacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Parametros_Produccion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Parametros_Produccion>()
                .Property(e => e.Etiqueta)
                .IsUnicode(false);

            modelBuilder.Entity<Parametros_Produccion>()
                .Property(e => e.Merma)
                .HasPrecision(20, 8);

            modelBuilder.Entity<Pedido>()
                .Property(e => e.Numero_Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pedido>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<PendientesTMP>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil_ConceptoTMP>()
                .Property(e => e.Importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prorrateo_Taller>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Prorrateo_Taller_Detalle>()
                .Property(e => e.Porcentaje)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Proveedor_Conta_Comparativo>()
                .Property(e => e.Nombre_Completo)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor_Conta_Comparativo>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor_Conta_Comparativo>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor_Conta_Comparativo>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor_Conta_Comparativo>()
                .Property(e => e.Folio_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor_Contrato>()
                .Property(e => e.Numero_Contrato)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor_Contrato>()
                .Property(e => e.Dia_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor_Contrato>()
                .Property(e => e.Familia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Receta_Crea_TMP>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Receta_Crea_TMP>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Receta_Crea_TMP>()
                .Property(e => e.Materia_Prima)
                .IsUnicode(false);

            modelBuilder.Entity<Receta_Crea_TMP>()
                .Property(e => e.Materia_Prima_UM)
                .IsUnicode(false);

            modelBuilder.Entity<Receta_Crea_TMP>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Receta_Crea_TMP>()
                .Property(e => e.Problema)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Clas_Cve_Almacen)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Clas_Des_Almacen)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Clas_Cve_TProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Clas_Des_TProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Clas_Cve_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Clas_Des_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Clas_Cve_TConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Clas_Des_TConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Concepto_Cve)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Concepto_Des)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Des_Tipo_Entrada)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Des_Tipo_Docto_Entrada)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Numero_Docto_Entrada)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Cantidad_Recibida)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Cantidad_Salida)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Saldo)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Costo)
                .HasPrecision(16, 4);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Saldo_Neto)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Reporte_Entrada_Salida_Relacion>()
                .Property(e => e.Saldo_Almacen)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Nombre_Programa)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Desc_Programa)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Modulo)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Nombre_Tipo_Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Concepto_Contable)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Cve_Tipo_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Nombre_Tipo_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Cve_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Nombre_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Cve_Tipo_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Nombre_Tipo_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Cve_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Nombre_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Nombre_Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Clave_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Nombre_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Reporte_Transaccion_Contable_Matriz_TMP>()
                .Property(e => e.Nombre_Auxiliar)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen_Punto_Venta>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Punto_Venta_Rechazado>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Punto_Venta_Rechazado>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen_Punto_Venta_Rechazado>()
                .Property(e => e.Comentario_Tecnico)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen_Punto_Venta_Rechazado_TMP>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Almacen_Punto_Venta_Rechazado_TMP>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Almacen_Punto_Venta_Rechazado_TMP>()
                .Property(e => e.Comentario_Tecnico)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Costo_TMP>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Costo_TMP>()
                .Property(e => e.Cantidad_Base)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Entrada_XLS_TMP>()
                .Property(e => e.Numero_Produccion)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Entrada_XLS_TMP>()
                .Property(e => e.Num_Docto)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Entrada_XLS_TMP>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Entrada_XLS_TMP>()
                .Property(e => e.Costo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Entrada_XLS_TMP>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Entrada_XLS_TMP>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Entrada_XLS_TMP>()
                .Property(e => e.Anexo)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Entrada_XLS_TMP>()
                .Property(e => e.Pedimento)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Entrada_XLS_TMP>()
                .Property(e => e.Causa_Cancelacion)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Entrada_XLS_TMP>()
                .Property(e => e.TC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Salida_Pedido_TMP>()
                .Property(e => e.Folio_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Pedido_TMP>()
                .Property(e => e.Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Pedido_TMP>()
                .Property(e => e.Nombre_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Pedido_TMP>()
                .Property(e => e.Factura_Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Pedido_TMP>()
                .Property(e => e.Des_Almacen)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Pedido_TMP>()
                .Property(e => e.Tipo_Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Pedido_TMP>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Produccion_XLS>()
                .Property(e => e.Numero_Produccion)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Produccion_XLS>()
                .Property(e => e.Num_Docto)
                .IsUnicode(false);

            modelBuilder.Entity<Salida_Produccion_XLS>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Sat_Catalogo_CP>()
                .Property(e => e.C_Codigo_Postal)
                .IsUnicode(false);

            modelBuilder.Entity<Sat_Catalogo_CP>()
                .Property(e => e.c_Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Sat_Catalogo_CP>()
                .Property(e => e.c_Municipio)
                .IsUnicode(false);

            modelBuilder.Entity<Sat_Catalogo_CP>()
                .Property(e => e.c_Localidad)
                .IsUnicode(false);

            modelBuilder.Entity<Sat_Catalogo_Prod_Serv_Homologado>()
                .Property(e => e.c_ClaveProdServ)
                .IsUnicode(false);

            modelBuilder.Entity<Sat_Clave_Unidad>()
                .Property(e => e.c_ClaveUnidad)
                .IsUnicode(false);

            modelBuilder.Entity<Sat_Clave_Unidad>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Sat_Clave_Unidad>()
                .Property(e => e.Descripción)
                .IsUnicode(false);

            modelBuilder.Entity<Sat_Clave_Unidad>()
                .Property(e => e.Simbolo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCambio>()
                .Property(e => e.Compra)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TipoCambio>()
                .Property(e => e.Venta)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TipoOficina>()
                .Property(e => e.Cancelacion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TipoOficina>()
                .Property(e => e.CambioInstruccion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TipoOficina>()
                .Property(e => e.Reenvio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TipoOficina>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Transaccion_Programa_Auxiliar_TMP>()
                .Property(e => e.Des_Auxiliar)
                .IsUnicode(false);

            modelBuilder.Entity<Transaccion_Programa_TMP>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Transacciones_Contables_TMP>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencia>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Transferencia>()
                .Property(e => e.ImporteSol)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transferencia>()
                .Property(e => e.ImporteReq)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transferencia>()
                .Property(e => e.ImporteDestino)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transferencia>()
                .Property(e => e.UtilidadCambiaria)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vcp_Pagos_Multiples>()
                .Property(e => e.Nombre_Banco)
                .IsUnicode(false);

            modelBuilder.Entity<vcp_Pagos_Multiples>()
                .Property(e => e.Numero_Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<vcp_Pagos_Multiples>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<vcp_Pagos_Multiples>()
                .Property(e => e.Documentos)
                .IsUnicode(false);

            modelBuilder.Entity<vcp_Pagos_Multiples>()
                .Property(e => e.Nombre_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<vcp_Pagos_Multiples>()
                .Property(e => e.Des_Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<vcp_Pagos_Multiples>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<vcp_Pagos_Multiples>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<vcp_Pagos_Multiples>()
                .Property(e => e.Tipo_Cambio_Pago)
                .HasPrecision(18, 10);

            modelBuilder.Entity<vcp_Pagos_Multiples>()
                .Property(e => e.Nombre_Moneda_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<vcp_Pagos_Multiples>()
                .Property(e => e.Documento_Anticipo)
                .IsUnicode(false);

            modelBuilder.Entity<Venta_Salida>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Verifica_CxP>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Comprobantes>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Justificacion_Rpt>()
                .Property(e => e.Comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Justificacion_Rpt>()
                .Property(e => e.Descripcion_Liquidacion)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Justificacion_Rpt>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Viaticos_Justificacion_Rpt>()
                .Property(e => e.Descripcion_Devolucion)
                .IsUnicode(false);
        }
    }
}
