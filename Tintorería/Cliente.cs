using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tintorería
{
    class Cliente : Usuario
    {
        int cve_cliente, cve_prenda;

        public int Cve_cliente { get => cve_cliente; set => cve_cliente = value; }
        public int Cve_prenda { get => cve_prenda; set => cve_prenda = value; }
    }
}
