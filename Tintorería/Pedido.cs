using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tintorería
{
    class Pedido
    {

        int cve_prenda, cve_cliente, cve_empleado;
        DateTime fecha_ingreso = new DateTime();
        DateTime fecha_entrega = new DateTime();

        public Pedido(int cve_prenda, int cve_cliente, int cve_empleado, DateTime fecha_ingreso, DateTime fecha_entrega)
        {
            this.cve_prenda = cve_prenda;
            this.cve_cliente = cve_cliente;
            this.cve_empleado = cve_empleado;
            this.fecha_ingreso = fecha_ingreso;
            this.fecha_entrega = fecha_entrega;
        }

        public int Cve_prenda { get => cve_prenda; set => cve_prenda = value; }
        public int Cve_cliente { get => cve_cliente; set => cve_cliente = value; }
        public int Cve_empleado { get => cve_empleado; set => cve_empleado = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public DateTime Fecha_entrega { get => fecha_entrega; set => fecha_entrega = value; }
    }
}
