using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tintorería
{
    class Telas
    {
        string nombreTela;
        int costoServicio;

        public Telas(string nombreTela, int costoServicio)
        {
            NombreTela = nombreTela;
            CostoServicio = costoServicio;
        }

        public string NombreTela { get => nombreTela; set => nombreTela = value; }
        public int CostoServicio { get => costoServicio; set => costoServicio = value; }
    }
}
