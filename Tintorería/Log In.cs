using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tintorería
{
    public partial class Form_inicio : Form
    {
        //Creamos nuestros objetos
        Empleado empleado = new Empleado();
        DateTime diaDeHoy = System.DateTime.Now;

        string conexionString = "Data Source=SEBASTIANG;Initial " +
            "Catalog=TINTORERIA;User ID=ADMIN;Password=TINTORERIA";

        public Form_inicio()
        {
            InitializeComponent();
        }

        private void Form_inicio_Load(object sender, EventArgs e)
        {
            lbl_fecha.Text = diaDeHoy.Day.ToString() + "/" + diaDeHoy.Month.ToString() +
                "/" + diaDeHoy.Year.ToString();
            lbl_hora.Text = diaDeHoy.Hour.ToString() + ":" + diaDeHoy.Minute.ToString();
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            if (tbx_clave.Text != null && tbx_clave.Text != "")
            {
                empleado.Cve_empleado = Int32.Parse(tbx_clave.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM EMPLEADO " +
                    "WHERE cve_empleado = '" + empleado.Cve_empleado.ToString()+"'", conexionString);
                DataSet ds = new DataSet();
                datos.Fill(dt);
                if (dt.Rows.Count != 0) {
                    empleado.Nombre = dt.Rows[0][1].ToString();
                    empleado.Puesto = dt.Rows[0][2].ToString();
                    empleado.Direccion = dt.Rows[0][3].ToString();
                    empleado.Telefono = dt.Rows[0][4].ToString();
                    if (empleado.Puesto.Equals("Administrador"))
                    {
                        this.Hide();
                        var form_RegistrarUsuario = new Form_Interfaz(0);
                        form_RegistrarUsuario.Closed += (s, args) => this.Close();
                        form_RegistrarUsuario.Show();
                    }
                    if (empleado.Puesto.Equals("Empleado"))
                    {
                        this.Hide();
                        var form_RegistrarUsuario = new Form_Interfaz(1);
                        form_RegistrarUsuario.Closed += (s, args) => this.Close();
                        form_RegistrarUsuario.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No se encuentra un usuario con esa clave.", "Iniciar Sesión",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }


    }
}
