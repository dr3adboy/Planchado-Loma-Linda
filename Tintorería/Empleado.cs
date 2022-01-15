using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tintorería
{
    class Empleado : Usuario
    {
        int cve_empleado;
        String puesto;

        public int Cve_empleado { get => cve_empleado; set => cve_empleado = value; }
        public string Puesto { get => puesto; set => puesto = value; }
    }
}
