﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte objcd_reporte = new CD_Reporte();

        public List<ReporteCompra> Compra(string fechaInicio, string fechaFin, int idProveedor)
        {
            return objcd_reporte.Compra(fechaInicio, fechaFin, idProveedor);
        }

        public List<ReporteVenta> Venta(string fechaInicio, string fechaFin)
        {
            return objcd_reporte.Venta(fechaInicio, fechaFin);
        }
    }
}
