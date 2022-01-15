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
using System.Configuration;
using System.Collections.Specialized;

namespace Tintorería
{


    public partial class Form_Interfaz : Form
    {
      
        Empleado empleado = new Empleado();
        int nivel;
        SqlCommand comandoSQL;
        SqlConnection conexionString = new SqlConnection("Data Source=SEBASTIANG;Initial " +
            "Catalog=TINTORERIA;User ID=ADMIN;Password=TINTORERIA");

        public Form_Interfaz(int nivel)
        {
            this.nivel = nivel;
            InitializeComponent();
        }

        private void Form_Interfaz_Load(object sender, EventArgs e)
        {
            SeleccionarInterfaz();
            RefrescarTablaCli();
            RefrescarTablaEmp();
            RefrescarTablaPed();
            SacarPrecioTela();
        }
        private void SacarPrecioTela()
        {
            Tela Crepe = new Tela();
            Crepe.NombreTela = "Crepé";
            Crepe.CostoServicio = 8;
            combobx_tipoTela.Items.Add(Crepe);
            Tela Batista = new Tela();
            Batista.NombreTela = "Batista";
            Batista.CostoServicio = 5;
            combobx_tipoTela.Items.Add(Batista);
            Tela Brocado = new Tela();
            Brocado.NombreTela = "Brocado";
            Brocado.CostoServicio = 7;
            combobx_tipoTela.Items.Add(Brocado);
            Tela Chambray = new Tela();
            Chambray.NombreTela = "Chambray";
            Chambray.CostoServicio = 7;
            combobx_tipoTela.Items.Add(Chambray);
            Tela Cretona = new Tela();
            Cretona.NombreTela = "Cretona";
            Cretona.CostoServicio = 5;
            combobx_tipoTela.Items.Add(Cretona);
            Tela Chifon = new Tela();
            Chifon.NombreTela = "Chifón";
            Chifon.CostoServicio = 6;
            combobx_tipoTela.Items.Add(Chifon);
            Tela Gabardina = new Tela();
            Gabardina.NombreTela = "Gabardina";
            Gabardina.CostoServicio = 10;
            combobx_tipoTela.Items.Add(Gabardina);
            Tela Encaje = new Tela();
            Encaje.NombreTela = "Encaje";
            Encaje.CostoServicio = 7;
            combobx_tipoTela.Items.Add(Encaje);
        }

        private void RefrescarTablaCli()
        {
            SqlDataAdapter datosClientes = new SqlDataAdapter("SELECT cve_cliente AS 'Clave', nombre AS 'Nombre'," +
            "direccion AS 'Dirección', telefono AS 'Teléfono' FROM CLIENTE ", conexionString);
            DataSet dsCli = new DataSet();
            datosClientes.Fill(dsCli);
            dgv_tablaClientes.DataSource = dsCli.Tables[0];

        }

        private void RefrescarTablaPed()
        {
            SqlDataAdapter datosPedidos = new SqlDataAdapter("SELECT fecha_ingreso AS 'Fecha de ingreso'," +
            "fecha_entrega AS 'Fecha de entrega', cve_prenda AS 'Clave prenda', cve_cliente AS 'Clave cliente'," +
            "cve_empleado AS 'Clave empleado', costo AS 'Costo' FROM PEDIDOS ", conexionString);
            DataSet dsPed = new DataSet();
            datosPedidos.Fill(dsPed);
            dgv_tablaPedidos.DataSource = dsPed.Tables[0];

        }

        private void RefrescarTablaEmp()
        {
            SqlDataAdapter datosEmpleados = new SqlDataAdapter("SELECT cve_empleado AS 'Clave', nombre AS 'Nombre'," +
            "puesto AS 'Puesto', direccion AS 'Dirección', telefono AS 'Teléfono' FROM EMPLEADO", conexionString);
            DataSet dsEmp = new DataSet();
            datosEmpleados.Fill(dsEmp);
            dgv_tablaEmpleados.DataSource = dsEmp.Tables[0];
        }

        private void SeleccionarInterfaz()
        {
            if (nivel == 0) //Interfaz de admin.
            {

            } else if (nivel == 1) //Interfaz de empleado.
            {
                chkbx_esEmpleado.Visible = false;
                combobx_puesto.Visible = false;
                dgv_tablaEmpleados.Visible = false;
                lbl_claveEmp.Visible = false;
                lbl_esEmpleado.Visible = false;
                lbl_tablaEmpl.Visible = false;
                btn_buscarEmp.Visible = false;
                btn_eliminarEmp.Visible = false;
                tbx_claveEmp.Visible = false;
                
            }
        }

        private void LimpiarTbxCliente()
        {
            tbx_nombre.Clear();
            tbx_telefono.Clear();
            tbx_direccion.Clear();
        }

        private void chkbx_esEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_esEmpleado.Checked)
            {
                lbl_puesto.Visible = true;
                combobx_puesto.Visible = true;
            }
            else
            {
                lbl_puesto.Visible = false;
                combobx_puesto.Visible = false;

            }
        }
        private void btn_insertarUsuario_Click(object sender, EventArgs e)
        {
            if (chkbx_esEmpleado.Checked == true)
            {
                if ((tbx_nombre.Text != "" && tbx_telefono.Text != "" && tbx_direccion.Text != "" && combobx_puesto.SelectedIndex !=-1) && (tbx_nombre.Text != null && tbx_telefono != null && tbx_direccion != null && combobx_puesto.SelectedItem != null))
                {
                    comandoSQL = new SqlCommand("INSERT INTO EMPLEADO(cve_empleado,nombre, puesto, direccion, telefono) VALUES  (@Cve_empleado, @Nombre, @Puesto , @Direccion, @Telefono)", conexionString);
                    conexionString.Open();
                    comandoSQL.Parameters.AddWithValue("@Cve_empleado", (ObtenerUltimoTablaEmpleado()+1));
                    comandoSQL.Parameters.AddWithValue("@Nombre", tbx_nombre.Text);
                    comandoSQL.Parameters.AddWithValue("@Puesto", combobx_puesto.SelectedItem);
                    comandoSQL.Parameters.AddWithValue("@Direccion", tbx_direccion.Text);
                    comandoSQL.Parameters.AddWithValue("@Telefono", tbx_telefono.Text);
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Empleado agregado con exito");
                    conexionString.Close();
                    RefrescarTablaEmp();
                    LimpiarTbxCliente();

                }
                else
                    MessageBox.Show("Ingrese la información solicitada.", "Insertar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if ((tbx_nombre.Text != "" && tbx_telefono.Text != "" && tbx_direccion.Text != "") && (tbx_nombre.Text != null && tbx_telefono != null && tbx_direccion != null))
                {
                    comandoSQL = new SqlCommand("INSERT INTO CLIENTE(cve_cliente,nombre, direccion, telefono) VALUES (@Cve_cliente, @Nombre, @Direccion, @Telefono)", conexionString);
                    conexionString.Open();
                    comandoSQL.Parameters.AddWithValue("@Cve_cliente", (ObtenerUltimoTablaCliente() + 1));
                    comandoSQL.Parameters.AddWithValue("@Nombre", tbx_nombre.Text);
                    comandoSQL.Parameters.AddWithValue("@Direccion", tbx_direccion.Text);
                    comandoSQL.Parameters.AddWithValue("@Telefono", tbx_telefono.Text);
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Cliente agregado con exito.");
                    conexionString.Close();
                    RefrescarTablaCli();
                    LimpiarTbxCliente();
                }
                else
                {
                    MessageBox.Show("Ingrese la información solicitada.", "Insertar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public bool RefrescarTablaCli(string nombreTabla, int llave, string dato)
        {
            try
            {
                SqlCommand comando = new SqlCommand("UPDATE " + nombreTabla + " SET" + dato + " WHERE " + llave);
                conexionString.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void dgv_tablaEmpleados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            comandoSQL = new SqlCommand("UPDATE EMPLEADO SET nombre=@Nombre, puesto=@Puesto , direccion=@Direccion, telefono=@Telefono WHERE cve_Empleado=@cve_empleado", conexionString);
            conexionString.Open();
            comandoSQL.Parameters.AddWithValue("@cve_empleado", Int32.Parse(dgv_tablaEmpleados.Rows[0].Cells[0].Value.ToString()));
            comandoSQL.Parameters.AddWithValue("@Nombre", dgv_tablaEmpleados.Rows[0].Cells[1].Value.ToString());
            comandoSQL.Parameters.AddWithValue("@Puesto", dgv_tablaEmpleados.Rows[0].Cells[2].Value.ToString());
            comandoSQL.Parameters.AddWithValue("@Direccion", dgv_tablaEmpleados.Rows[0].Cells[3].Value.ToString());
            comandoSQL.Parameters.AddWithValue("@Telefono", dgv_tablaEmpleados.Rows[0].Cells[4].Value.ToString());
            comandoSQL.ExecuteNonQuery();
            MessageBox.Show("Empleado actualizado");
            conexionString.Close();
        }

        private void dgv_tablaPedidos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            comandoSQL = new SqlCommand("UPDATE PEDIDOS SET fecha_ingreso=@FechaI, " +
                "fecha_entrega=@FechaE, cve_prenda=@Cve_prenda, cve_empleado=@Cve_empleado," +
                " costo=@Costo WHERE cve_Cliente=@Cve_cliente", conexionString);
            conexionString.Open();
            comandoSQL.Parameters.AddWithValue("@FechaI", dgv_tablaClientes.Rows[0].Cells[0].Value);
            comandoSQL.Parameters.AddWithValue("@FechaE", dgv_tablaClientes.Rows[0].Cells[1].Value);
            comandoSQL.Parameters.AddWithValue("@Cve_prenda", Int32.Parse(dgv_tablaClientes.Rows[0].Cells[2].Value.ToString()));
            comandoSQL.Parameters.AddWithValue("@Cve_cliente", Int32.Parse(dgv_tablaClientes.Rows[0].Cells[3].Value.ToString()));
            comandoSQL.Parameters.AddWithValue("@Cve_empleado", Int32.Parse(dgv_tablaClientes.Rows[0].Cells[4].Value.ToString()));
            comandoSQL.Parameters.AddWithValue("@Costo", Int32.Parse(dgv_tablaClientes.Rows[0].Cells[5].Value.ToString()));
            comandoSQL.ExecuteNonQuery();
            MessageBox.Show("Cliente actualizado");
            conexionString.Close();
        }

        private void dgv_tablaClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            comandoSQL = new SqlCommand("UPDATE CLIENTE SET nombre=@Nombre, telefono=@Telefono, direccion=@Direccion WHERE cve_Cliente=@cve_cliente", conexionString);
            conexionString.Open();
            comandoSQL.Parameters.AddWithValue("@cve_cliente", Int32.Parse(dgv_tablaClientes.Rows[0].Cells[0].Value.ToString()));
            comandoSQL.Parameters.AddWithValue("@Nombre", dgv_tablaClientes.Rows[0].Cells[1].Value.ToString());
            comandoSQL.Parameters.AddWithValue("@Direccion", dgv_tablaClientes.Rows[0].Cells[2].Value.ToString());
            comandoSQL.Parameters.AddWithValue("@Telefono", dgv_tablaClientes.Rows[0].Cells[3].Value.ToString());
            comandoSQL.ExecuteNonQuery();
            MessageBox.Show("Cliente actualizado");
            conexionString.Close();
        }

        private void btn_buscarCli_Click(object sender, EventArgs e)
        {
            if (tbx_claveCli.Text != "" && tbx_claveCli != null)
            {
                conexionString.Open();
            SqlDataAdapter datosClientes = new SqlDataAdapter("SELECT cve_cliente AS 'Clave', nombre AS 'Nombre'," +
            "direccion AS 'Dirección', telefono AS 'Teléfono' FROM CLIENTE  WHERE cve_cliente = '"
                + Int32.Parse(tbx_claveCli.Text) + "'", conexionString);
            DataSet dsCli = new DataSet();
            datosClientes.Fill(dsCli);
            dgv_tablaClientes.DataSource = dsCli.Tables[0];
            conexionString.Close();
            }
            else
                MessageBox.Show("Ingrese la clave de cliente.", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_buscarEmp_Click(object sender, EventArgs e)
        {
            if (tbx_claveEmp.Text != "" && tbx_claveEmp != null)
            {
                conexionString.Open();
            SqlDataAdapter datosEmpleados = new SqlDataAdapter("SELECT cve_empleado AS 'Clave', nombre AS 'Nombre'," +
            "puesto AS 'Puesto', direccion AS 'Dirección', telefono AS 'Teléfono' FROM EMPLEADO" +
            "WHERE cve_empleado = '" + Int32.Parse(tbx_claveEmp.Text)
            + "'", conexionString);
            DataSet dsEmp = new DataSet();
            datosEmpleados.Fill(dsEmp);
            dgv_tablaEmpleados.DataSource = dsEmp.Tables[0];
            conexionString.Close();
            }
            else
                MessageBox.Show("Ingrese la clave de empleado.", "Buscar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_buscarPed_Click(object sender, EventArgs e)
        {
            if (tbx_clavePrenda.Text != "" && tbx_clavePrenda != null)
            {
                conexionString.Open();
                SqlDataAdapter datosPedidos = new SqlDataAdapter("SELECT fecha_ingreso AS 'Fecha de ingreso'," +
                "fecha_entrega AS 'Fecha de entrega', cve_prenda AS 'Clave prenda', cve_cliente AS 'Clave cliente'," +
                "cve_empleado AS 'Clave empleado', costo AS 'Costo' FROM PEDIDOS WHERE cve_prenda = '" + Int32.Parse(tbx_clavePrenda.Text)
                    + "'", conexionString);
                DataSet dsPed = new DataSet();
                datosPedidos.Fill(dsPed);
                dgv_tablaPedidos.DataSource = dsPed.Tables[0];
                conexionString.Close();
            }
            else
                MessageBox.Show("Ingrese la clave de la prenda.", "Buscar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        
        

        private void btn_insertarPed_Click(object sender, EventArgs e)
        {
            if ((dtp_fechaEntrega.Value <= DateTime.Today && tbx_prenda.Text != "" && tbx_claveCliPed.Text != "" && tbx_claveEmpPed.Text != "") || (dtp_fechaEntrega.Value != DateTime.Today && tbx_prenda.Text != null && tbx_claveCliPed.Text != null && tbx_claveEmpPed.Text != null))
            {
                int CvePrenda = ObtenerUltimoTablaPrenda() + 1;

                Tela tipoDeTela = (Tela)combobx_tipoTela.SelectedItem;
                string comandoInsertarPedido = "INSERT INTO PEDIDOS(fecha_ingreso, fecha_entrega, " +
                    " cve_prenda, cve_cliente, cve_empleado, costo) VALUES (@Fecha_ingreso, " +
                    "@Fecha_entrega, @Cve_prenda, @Cve_cliente, @cve_empleado, @Costo)";
                string comandoInsertarPrenda = " INSERT INTO PRENDAS(cve_prenda, prenda, tipo_tela) VALUES" +
                    " (@Cve_prenda, @Prenda, @Tipo_tela)";
                
                
                //Ejecucion de query de SQL para insertar la prenda del pedido                
                comandoSQL = new SqlCommand(comandoInsertarPrenda, conexionString);
                conexionString.Open();
                comandoSQL.Parameters.AddWithValue("@Cve_prenda", CvePrenda);
                comandoSQL.Parameters.AddWithValue("@Prenda", tbx_prenda.Text);
                comandoSQL.Parameters.AddWithValue("@Tipo_tela", tipoDeTela.NombreTela);
                comandoSQL.ExecuteNonQuery();
                conexionString.Close();

                //Ejecucion de query de SQL para insertar pedidos
                comandoSQL = new SqlCommand(comandoInsertarPedido, conexionString);
                conexionString.Open();
                comandoSQL.Parameters.AddWithValue("@Fecha_ingreso", DateTime.Today);
                comandoSQL.Parameters.AddWithValue("@Fecha_entrega", dtp_fechaEntrega.Value);
                comandoSQL.Parameters.AddWithValue("@Cve_prenda", CvePrenda);
                comandoSQL.Parameters.AddWithValue("@Cve_cliente", tbx_claveCliPed.Text);
                comandoSQL.Parameters.AddWithValue("@cve_empleado", tbx_claveEmpPed.Text);
                comandoSQL.Parameters.AddWithValue("@Costo", tipoDeTela.CostoServicio + ((DateTime.Today - dtp_fechaEntrega.Value).Days) * 2);
                comandoSQL.ExecuteNonQuery();
                MessageBox.Show("Pedido agregado con exito.");
                conexionString.Close();
                RefrescarTablaPed();
                LimpiarTbxCliente();

            }
            else
            {
                MessageBox.Show("Ingrese la información solicitada.", "Insertar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dtp_fechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            Global.fechaEntrega = dtp_fechaEntrega.Value;
        }

        private void btn_eliminarCliente_Click(object sender, EventArgs e)
        {
            if ((tbx_claveCli.Text != "" && tbx_claveCli != null)) 
            {
                comandoSQL = new SqlCommand("DELETE CLIENTE WHERE cve_cliente = @Cve_cliente", conexionString);
                conexionString.Open();
                comandoSQL.Parameters.AddWithValue("@Cve_cliente", Int32.Parse(tbx_claveCli.Text));
                comandoSQL.ExecuteNonQuery();
                conexionString.Close();
                MessageBox.Show("Cliente eliminado con exito.");
                RefrescarTablaCli();
                tbx_claveCli.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese la información solicitada.", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminarEmp_Click(object sender, EventArgs e)
        {
            if ((tbx_claveEmp.Text != "" && tbx_claveEmp != null))
            {
                comandoSQL = new SqlCommand("DELETE EMPLEADO WHERE cve_empleado = @Cve_empleado", conexionString);
                conexionString.Open();
                comandoSQL.Parameters.AddWithValue("@Cve_empleado", Int32.Parse(tbx_claveEmp.Text));
                comandoSQL.ExecuteNonQuery();
                conexionString.Close();
                MessageBox.Show("EMPLEADO eliminado con exito.");
                RefrescarTablaEmp();
                tbx_claveEmp.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese la información solicitada.", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelarPedido_Click(object sender, EventArgs e)
        {
            if ((tbx_clavePrenda.Text != "" && tbx_clavePrenda.Text != null))
            {
                string comandoEliminarPedido = "DELETE PEDIDOS WHERE cve_prenda = @Cve_prenda";
                string comandoEliminarPrenda = "DELETE PRENDAS WHERE cve_prenda = @Cve_prenda";
                comandoSQL = new SqlCommand(comandoEliminarPedido, conexionString);
                conexionString.Open();
                comandoSQL.Parameters.AddWithValue("@Cve_prenda", Int32.Parse(tbx_clavePrenda.Text));
                comandoSQL.ExecuteNonQuery();
                conexionString.Close();
                comandoSQL = new SqlCommand(comandoEliminarPrenda, conexionString);
                conexionString.Open();
                comandoSQL.Parameters.AddWithValue("@Cve_prenda", Int32.Parse(tbx_clavePrenda.Text));
                comandoSQL.ExecuteNonQuery();
                conexionString.Close();
                MessageBox.Show("Pedido cancelado con éxito.");
                RefrescarTablaPed();
                tbx_clavePrenda.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese la información solicitada.", "Eliminar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerUltimoTablaCliente() {
            conexionString.Open();
            SqlCommand comandoSQLCliente = new SqlCommand("SELECT TOP 1 cve_cliente FROM CLIENTE ORDER BY cve_cliente DESC", conexionString);
            int cveCliente = Convert.ToInt32(comandoSQLCliente.ExecuteScalar());
            conexionString.Close();
            return cveCliente;

        }

        private int ObtenerUltimoTablaEmpleado() {
            conexionString.Open();
            SqlCommand comandoSQLEmpleado = new SqlCommand("SELECT TOP 1 cve_empleado FROM EMPLEADO ORDER BY cve_empleado DESC", conexionString);
            int cveEmpleado = Convert.ToInt32(comandoSQLEmpleado.ExecuteScalar());
            conexionString.Close();
            return cveEmpleado;
        }

        private int ObtenerUltimoTablaPrenda() {
            conexionString.Open();
            SqlCommand comandoSQLPrenda = new SqlCommand("SELECT TOP 1 cve_prenda FROM PRENDAS ORDER BY cve_prenda DESC", conexionString);
            int cvePrenda = Convert.ToInt32(comandoSQLPrenda.ExecuteScalar());
            conexionString.Close();
            return cvePrenda;
        }

        private void btn_entregarPedido_Click(object sender, EventArgs e)
        {
            if ((tbx_clavePrenda.Text != "" && tbx_clavePrenda.Text != null))
            {
                if (MessageBox.Show("¿Desea entregar el pedido?\n El total a pagar es: $"+dgv_tablaPedidos.Rows[Int32.Parse(tbx_clavePrenda.Text)-1].Cells[5].Value, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string comandoEliminarPedido = "DELETE PEDIDOS WHERE cve_prenda = @Cve_prenda";
                    string comandoEliminarPrenda = "DELETE PRENDAS WHERE cve_prenda = @Cve_prenda";
                    comandoSQL = new SqlCommand(comandoEliminarPedido, conexionString);
                    conexionString.Open();
                    comandoSQL.Parameters.AddWithValue("@Cve_prenda", Int32.Parse(tbx_clavePrenda.Text));
                    comandoSQL.ExecuteNonQuery();
                    conexionString.Close();
                    comandoSQL = new SqlCommand(comandoEliminarPrenda, conexionString);
                    conexionString.Open();
                    comandoSQL.Parameters.AddWithValue("@Cve_prenda", Int32.Parse(tbx_clavePrenda.Text));
                    comandoSQL.ExecuteNonQuery();
                    conexionString.Close();
                    RefrescarTablaPed();
                    tbx_clavePrenda.Clear();
                }                
            }
            else
            {
                MessageBox.Show("Ingrese la información solicitada.", "Eliminar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
