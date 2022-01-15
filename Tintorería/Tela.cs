using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tintorería
{
    class Tela
    {
        string nombreTela;
        int costoServicio;

        public string NombreTela { get => nombreTela; set => nombreTela = value; }
        public int CostoServicio { get => costoServicio; set => costoServicio = value; }
        public override string ToString()
        {
            return nombreTela;
        }
    }

}
