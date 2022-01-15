using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tintorería
{
    class Prenda
    {
        int cve_prenda;
        String nombre_prenda, tipo_tela;

        public Prenda(int cve_prenda, string nombre_prenda, string tipo_tela)
        {
            this.cve_prenda = cve_prenda;
            this.nombre_prenda = nombre_prenda;
            this.tipo_tela = tipo_tela;
        }

        public string Nombre_prenda { get => nombre_prenda; set => nombre_prenda = value; }
        public string Tipo_tela { get => tipo_tela; set => tipo_tela = value; }
        public int Cve_prenda { get => cve_prenda; set => cve_prenda = value; }
    }
}
