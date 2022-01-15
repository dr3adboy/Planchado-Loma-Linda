
namespace Tintorería
{
    partial class Form_Interfaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Interfaz));
            this.chkbx_esEmpleado = new System.Windows.Forms.CheckBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.combobx_puesto = new System.Windows.Forms.ComboBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.dgv_tablaClientes = new System.Windows.Forms.DataGridView();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_esEmpleado = new System.Windows.Forms.Label();
            this.lbl_puesto = new System.Windows.Forms.Label();
            this.tbx_direccion = new System.Windows.Forms.TextBox();
            this.tbx_telefono = new System.Windows.Forms.TextBox();
            this.dgv_tablaEmpleados = new System.Windows.Forms.DataGridView();
            this.btn_insertarUsuario = new System.Windows.Forms.Button();
            this.btn_buscarCli = new System.Windows.Forms.Button();
            this.tbx_claveCli = new System.Windows.Forms.TextBox();
            this.lbl_claveCli = new System.Windows.Forms.Label();
            this.lbl_claveEmp = new System.Windows.Forms.Label();
            this.tbx_claveEmp = new System.Windows.Forms.TextBox();
            this.btn_buscarEmp = new System.Windows.Forms.Button();
            this.dgv_tablaPedidos = new System.Windows.Forms.DataGridView();
            this.btn_insertarPed = new System.Windows.Forms.Button();
            this.btn_buscarPed = new System.Windows.Forms.Button();
            this.tbx_clavePrenda = new System.Windows.Forms.TextBox();
            this.lbl_clavePrenda = new System.Windows.Forms.Label();
            this.lbl_fechaE = new System.Windows.Forms.Label();
            this.lbl_prenda = new System.Windows.Forms.Label();
            this.lbl_claveEmpPed = new System.Windows.Forms.Label();
            this.dtp_fechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.tbx_claveEmpPed = new System.Windows.Forms.TextBox();
            this.tbx_prenda = new System.Windows.Forms.TextBox();
            this.lbl_claveCliPed = new System.Windows.Forms.Label();
            this.tbx_claveCliPed = new System.Windows.Forms.TextBox();
            this.combobx_tipoTela = new System.Windows.Forms.ComboBox();
            this.btn_eliminarCli = new System.Windows.Forms.Button();
            this.btn_eliminarEmp = new System.Windows.Forms.Button();
            this.btn_entregarPedido = new System.Windows.Forms.Button();
            this.lbl_tipoTela = new System.Windows.Forms.Label();
            this.btn_cancelarPedido = new System.Windows.Forms.Button();
            this.pnl_fondo = new System.Windows.Forms.Panel();
            this.lbl_tablaPedidos = new System.Windows.Forms.Label();
            this.lbl_tablaEmpl = new System.Windows.Forms.Label();
            this.lbl_tablaCli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // chkbx_esEmpleado
            // 
            this.chkbx_esEmpleado.AutoSize = true;
            this.chkbx_esEmpleado.Location = new System.Drawing.Point(88, 145);
            this.chkbx_esEmpleado.Name = "chkbx_esEmpleado";
            this.chkbx_esEmpleado.Size = new System.Drawing.Size(15, 14);
            this.chkbx_esEmpleado.TabIndex = 0;
            this.chkbx_esEmpleado.UseVisualStyleBackColor = true;
            this.chkbx_esEmpleado.CheckedChanged += new System.EventHandler(this.chkbx_esEmpleado_CheckedChanged);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 55);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // combobx_puesto
            // 
            this.combobx_puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobx_puesto.FormattingEnabled = true;
            this.combobx_puesto.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.combobx_puesto.Location = new System.Drawing.Point(88, 175);
            this.combobx_puesto.Name = "combobx_puesto";
            this.combobx_puesto.Size = new System.Drawing.Size(100, 21);
            this.combobx_puesto.TabIndex = 2;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(88, 48);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(100, 20);
            this.tbx_nombre.TabIndex = 3;
            // 
            // dgv_tablaClientes
            // 
            this.dgv_tablaClientes.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgv_tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaClientes.Location = new System.Drawing.Point(12, 288);
            this.dgv_tablaClientes.Name = "dgv_tablaClientes";
            this.dgv_tablaClientes.Size = new System.Drawing.Size(300, 150);
            this.dgv_tablaClientes.TabIndex = 4;
            this.dgv_tablaClientes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tablaClientes_CellValueChanged);
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(12, 85);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_direccion.TabIndex = 1;
            this.lbl_direccion.Text = "Dirección:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(12, 115);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefono.TabIndex = 1;
            this.lbl_telefono.Text = "Teléfono:";
            // 
            // lbl_esEmpleado
            // 
            this.lbl_esEmpleado.AutoSize = true;
            this.lbl_esEmpleado.Location = new System.Drawing.Point(12, 145);
            this.lbl_esEmpleado.Name = "lbl_esEmpleado";
            this.lbl_esEmpleado.Size = new System.Drawing.Size(66, 13);
            this.lbl_esEmpleado.TabIndex = 1;
            this.lbl_esEmpleado.Text = "¿Empleado?";
            // 
            // lbl_puesto
            // 
            this.lbl_puesto.AutoSize = true;
            this.lbl_puesto.Location = new System.Drawing.Point(12, 175);
            this.lbl_puesto.Name = "lbl_puesto";
            this.lbl_puesto.Size = new System.Drawing.Size(43, 13);
            this.lbl_puesto.TabIndex = 1;
            this.lbl_puesto.Text = "Puesto:";
            // 
            // tbx_direccion
            // 
            this.tbx_direccion.Location = new System.Drawing.Point(88, 82);
            this.tbx_direccion.Name = "tbx_direccion";
            this.tbx_direccion.Size = new System.Drawing.Size(100, 20);
            this.tbx_direccion.TabIndex = 3;
            // 
            // tbx_telefono
            // 
            this.tbx_telefono.Location = new System.Drawing.Point(88, 112);
            this.tbx_telefono.Name = "tbx_telefono";
            this.tbx_telefono.Size = new System.Drawing.Size(100, 20);
            this.tbx_telefono.TabIndex = 3;
            // 
            // dgv_tablaEmpleados
            // 
            this.dgv_tablaEmpleados.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgv_tablaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaEmpleados.Location = new System.Drawing.Point(488, 288);
            this.dgv_tablaEmpleados.Name = "dgv_tablaEmpleados";
            this.dgv_tablaEmpleados.Size = new System.Drawing.Size(300, 150);
            this.dgv_tablaEmpleados.TabIndex = 4;
            this.dgv_tablaEmpleados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tablaEmpleados_CellValueChanged);
            // 
            // btn_insertarUsuario
            // 
            this.btn_insertarUsuario.Location = new System.Drawing.Point(15, 219);
            this.btn_insertarUsuario.Name = "btn_insertarUsuario";
            this.btn_insertarUsuario.Size = new System.Drawing.Size(173, 23);
            this.btn_insertarUsuario.TabIndex = 6;
            this.btn_insertarUsuario.Text = "Insertar Usuario";
            this.btn_insertarUsuario.UseVisualStyleBackColor = true;
            this.btn_insertarUsuario.Click += new System.EventHandler(this.btn_insertarUsuario_Click);
            // 
            // btn_buscarCli
            // 
            this.btn_buscarCli.Location = new System.Drawing.Point(262, 259);
            this.btn_buscarCli.Name = "btn_buscarCli";
            this.btn_buscarCli.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarCli.TabIndex = 6;
            this.btn_buscarCli.Text = "Buscar";
            this.btn_buscarCli.UseVisualStyleBackColor = true;
            this.btn_buscarCli.Click += new System.EventHandler(this.btn_buscarCli_Click);
            // 
            // tbx_claveCli
            // 
            this.tbx_claveCli.Location = new System.Drawing.Point(140, 261);
            this.tbx_claveCli.Name = "tbx_claveCli";
            this.tbx_claveCli.Size = new System.Drawing.Size(75, 20);
            this.tbx_claveCli.TabIndex = 3;
            // 
            // lbl_claveCli
            // 
            this.lbl_claveCli.AutoSize = true;
            this.lbl_claveCli.Location = new System.Drawing.Point(143, 245);
            this.lbl_claveCli.Name = "lbl_claveCli";
            this.lbl_claveCli.Size = new System.Drawing.Size(72, 13);
            this.lbl_claveCli.TabIndex = 1;
            this.lbl_claveCli.Text = "Clave Cliente:";
            // 
            // lbl_claveEmp
            // 
            this.lbl_claveEmp.AutoSize = true;
            this.lbl_claveEmp.Location = new System.Drawing.Point(592, 245);
            this.lbl_claveEmp.Name = "lbl_claveEmp";
            this.lbl_claveEmp.Size = new System.Drawing.Size(87, 13);
            this.lbl_claveEmp.TabIndex = 1;
            this.lbl_claveEmp.Text = "Clave Empleado:";
            // 
            // tbx_claveEmp
            // 
            this.tbx_claveEmp.Location = new System.Drawing.Point(595, 261);
            this.tbx_claveEmp.Name = "tbx_claveEmp";
            this.tbx_claveEmp.Size = new System.Drawing.Size(84, 20);
            this.tbx_claveEmp.TabIndex = 3;
            // 
            // btn_buscarEmp
            // 
            this.btn_buscarEmp.Location = new System.Drawing.Point(713, 259);
            this.btn_buscarEmp.Name = "btn_buscarEmp";
            this.btn_buscarEmp.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarEmp.TabIndex = 6;
            this.btn_buscarEmp.Text = "Buscar";
            this.btn_buscarEmp.UseVisualStyleBackColor = true;
            this.btn_buscarEmp.Click += new System.EventHandler(this.btn_buscarEmp_Click);
            // 
            // dgv_tablaPedidos
            // 
            this.dgv_tablaPedidos.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgv_tablaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaPedidos.Location = new System.Drawing.Point(463, 27);
            this.dgv_tablaPedidos.Name = "dgv_tablaPedidos";
            this.dgv_tablaPedidos.Size = new System.Drawing.Size(325, 150);
            this.dgv_tablaPedidos.TabIndex = 4;
            this.dgv_tablaPedidos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tablaPedidos_CellValueChanged);
            // 
            // btn_insertarPed
            // 
            this.btn_insertarPed.Location = new System.Drawing.Point(343, 219);
            this.btn_insertarPed.Name = "btn_insertarPed";
            this.btn_insertarPed.Size = new System.Drawing.Size(100, 23);
            this.btn_insertarPed.TabIndex = 6;
            this.btn_insertarPed.Text = "Solicitar Pedido";
            this.btn_insertarPed.UseVisualStyleBackColor = true;
            this.btn_insertarPed.Click += new System.EventHandler(this.btn_insertarPed_Click);
            // 
            // btn_buscarPed
            // 
            this.btn_buscarPed.Location = new System.Drawing.Point(713, 183);
            this.btn_buscarPed.Name = "btn_buscarPed";
            this.btn_buscarPed.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarPed.TabIndex = 6;
            this.btn_buscarPed.Text = "Buscar";
            this.btn_buscarPed.UseVisualStyleBackColor = true;
            this.btn_buscarPed.Click += new System.EventHandler(this.btn_buscarPed_Click);
            // 
            // tbx_clavePrenda
            // 
            this.tbx_clavePrenda.Location = new System.Drawing.Point(623, 185);
            this.tbx_clavePrenda.Name = "tbx_clavePrenda";
            this.tbx_clavePrenda.Size = new System.Drawing.Size(84, 20);
            this.tbx_clavePrenda.TabIndex = 3;
            // 
            // lbl_clavePrenda
            // 
            this.lbl_clavePrenda.AutoSize = true;
            this.lbl_clavePrenda.Location = new System.Drawing.Point(543, 188);
            this.lbl_clavePrenda.Name = "lbl_clavePrenda";
            this.lbl_clavePrenda.Size = new System.Drawing.Size(74, 13);
            this.lbl_clavePrenda.TabIndex = 1;
            this.lbl_clavePrenda.Text = "Clave Prenda:";
            // 
            // lbl_fechaE
            // 
            this.lbl_fechaE.AutoSize = true;
            this.lbl_fechaE.Location = new System.Drawing.Point(243, 55);
            this.lbl_fechaE.Name = "lbl_fechaE";
            this.lbl_fechaE.Size = new System.Drawing.Size(94, 13);
            this.lbl_fechaE.TabIndex = 1;
            this.lbl_fechaE.Text = "Fecha de entrega:";
            // 
            // lbl_prenda
            // 
            this.lbl_prenda.AutoSize = true;
            this.lbl_prenda.Location = new System.Drawing.Point(293, 85);
            this.lbl_prenda.Name = "lbl_prenda";
            this.lbl_prenda.Size = new System.Drawing.Size(44, 13);
            this.lbl_prenda.TabIndex = 1;
            this.lbl_prenda.Text = "Prenda:";
            // 
            // lbl_claveEmpPed
            // 
            this.lbl_claveEmpPed.AutoSize = true;
            this.lbl_claveEmpPed.Location = new System.Drawing.Point(267, 145);
            this.lbl_claveEmpPed.Name = "lbl_claveEmpPed";
            this.lbl_claveEmpPed.Size = new System.Drawing.Size(70, 13);
            this.lbl_claveEmpPed.TabIndex = 1;
            this.lbl_claveEmpPed.Text = "Atendido por:";
            // 
            // dtp_fechaEntrega
            // 
            this.dtp_fechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaEntrega.Location = new System.Drawing.Point(343, 52);
            this.dtp_fechaEntrega.Name = "dtp_fechaEntrega";
            this.dtp_fechaEntrega.Size = new System.Drawing.Size(100, 20);
            this.dtp_fechaEntrega.TabIndex = 7;
            this.dtp_fechaEntrega.ValueChanged += new System.EventHandler(this.dtp_fechaEntrega_ValueChanged);
            // 
            // tbx_claveEmpPed
            // 
            this.tbx_claveEmpPed.Location = new System.Drawing.Point(343, 142);
            this.tbx_claveEmpPed.Name = "tbx_claveEmpPed";
            this.tbx_claveEmpPed.Size = new System.Drawing.Size(100, 20);
            this.tbx_claveEmpPed.TabIndex = 3;
            // 
            // tbx_prenda
            // 
            this.tbx_prenda.Location = new System.Drawing.Point(343, 82);
            this.tbx_prenda.Name = "tbx_prenda";
            this.tbx_prenda.Size = new System.Drawing.Size(100, 20);
            this.tbx_prenda.TabIndex = 3;
            // 
            // lbl_claveCliPed
            // 
            this.lbl_claveCliPed.AutoSize = true;
            this.lbl_claveCliPed.Location = new System.Drawing.Point(257, 115);
            this.lbl_claveCliPed.Name = "lbl_claveCliPed";
            this.lbl_claveCliPed.Size = new System.Drawing.Size(80, 13);
            this.lbl_claveCliPed.TabIndex = 1;
            this.lbl_claveCliPed.Text = "Encargado por:";
            // 
            // tbx_claveCliPed
            // 
            this.tbx_claveCliPed.Location = new System.Drawing.Point(343, 112);
            this.tbx_claveCliPed.Name = "tbx_claveCliPed";
            this.tbx_claveCliPed.Size = new System.Drawing.Size(100, 20);
            this.tbx_claveCliPed.TabIndex = 3;
            // 
            // combobx_tipoTela
            // 
            this.combobx_tipoTela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobx_tipoTela.FormattingEnabled = true;
            this.combobx_tipoTela.Location = new System.Drawing.Point(343, 175);
            this.combobx_tipoTela.Name = "combobx_tipoTela";
            this.combobx_tipoTela.Size = new System.Drawing.Size(100, 21);
            this.combobx_tipoTela.TabIndex = 2;
            // 
            // btn_eliminarCli
            // 
            this.btn_eliminarCli.Location = new System.Drawing.Point(15, 258);
            this.btn_eliminarCli.Name = "btn_eliminarCli";
            this.btn_eliminarCli.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminarCli.TabIndex = 6;
            this.btn_eliminarCli.Text = "Eliminar";
            this.btn_eliminarCli.UseVisualStyleBackColor = true;
            this.btn_eliminarCli.Click += new System.EventHandler(this.btn_eliminarCliente_Click);
            // 
            // btn_eliminarEmp
            // 
            this.btn_eliminarEmp.Location = new System.Drawing.Point(464, 258);
            this.btn_eliminarEmp.Name = "btn_eliminarEmp";
            this.btn_eliminarEmp.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminarEmp.TabIndex = 6;
            this.btn_eliminarEmp.Text = "Eliminar";
            this.btn_eliminarEmp.UseVisualStyleBackColor = true;
            this.btn_eliminarEmp.Click += new System.EventHandler(this.btn_eliminarEmp_Click);
            // 
            // btn_entregarPedido
            // 
            this.btn_entregarPedido.Location = new System.Drawing.Point(463, 183);
            this.btn_entregarPedido.Name = "btn_entregarPedido";
            this.btn_entregarPedido.Size = new System.Drawing.Size(75, 23);
            this.btn_entregarPedido.TabIndex = 6;
            this.btn_entregarPedido.Text = "Entregar";
            this.btn_entregarPedido.UseVisualStyleBackColor = true;
            this.btn_entregarPedido.Click += new System.EventHandler(this.btn_entregarPedido_Click);
            // 
            // lbl_tipoTela
            // 
            this.lbl_tipoTela.AutoSize = true;
            this.lbl_tipoTela.Location = new System.Drawing.Point(267, 178);
            this.lbl_tipoTela.Name = "lbl_tipoTela";
            this.lbl_tipoTela.Size = new System.Drawing.Size(66, 13);
            this.lbl_tipoTela.TabIndex = 1;
            this.lbl_tipoTela.Text = "Tipo de tela:";
            // 
            // btn_cancelarPedido
            // 
            this.btn_cancelarPedido.Location = new System.Drawing.Point(666, 212);
            this.btn_cancelarPedido.Name = "btn_cancelarPedido";
            this.btn_cancelarPedido.Size = new System.Drawing.Size(122, 23);
            this.btn_cancelarPedido.TabIndex = 6;
            this.btn_cancelarPedido.Text = "Cancelar Pedido";
            this.btn_cancelarPedido.UseVisualStyleBackColor = true;
            this.btn_cancelarPedido.Click += new System.EventHandler(this.btn_cancelarPedido_Click);
            // 
            // pnl_fondo
            // 
            this.pnl_fondo.BackgroundImage = global::Tintorería.Properties.Resources.Logo;
            this.pnl_fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_fondo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_fondo.Location = new System.Drawing.Point(326, 307);
            this.pnl_fondo.Name = "pnl_fondo";
            this.pnl_fondo.Size = new System.Drawing.Size(148, 68);
            this.pnl_fondo.TabIndex = 8;
            // 
            // lbl_tablaPedidos
            // 
            this.lbl_tablaPedidos.AutoSize = true;
            this.lbl_tablaPedidos.Location = new System.Drawing.Point(570, 9);
            this.lbl_tablaPedidos.Name = "lbl_tablaPedidos";
            this.lbl_tablaPedidos.Size = new System.Drawing.Size(110, 13);
            this.lbl_tablaPedidos.TabIndex = 9;
            this.lbl_tablaPedidos.Text = "TABLA DE PEDIDOS";
            // 
            // lbl_tablaEmpl
            // 
            this.lbl_tablaEmpl.AutoSize = true;
            this.lbl_tablaEmpl.Location = new System.Drawing.Point(574, 441);
            this.lbl_tablaEmpl.Name = "lbl_tablaEmpl";
            this.lbl_tablaEmpl.Size = new System.Drawing.Size(128, 13);
            this.lbl_tablaEmpl.TabIndex = 9;
            this.lbl_tablaEmpl.Text = "TABLA DE EMPLEADOS";
            // 
            // lbl_tablaCli
            // 
            this.lbl_tablaCli.AutoSize = true;
            this.lbl_tablaCli.Location = new System.Drawing.Point(105, 441);
            this.lbl_tablaCli.Name = "lbl_tablaCli";
            this.lbl_tablaCli.Size = new System.Drawing.Size(114, 13);
            this.lbl_tablaCli.TabIndex = 9;
            this.lbl_tablaCli.Text = "TABLA DE CLIENTES";
            // 
            // Form_Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.lbl_tablaCli);
            this.Controls.Add(this.lbl_tablaEmpl);
            this.Controls.Add(this.lbl_tablaPedidos);
            this.Controls.Add(this.pnl_fondo);
            this.Controls.Add(this.dtp_fechaEntrega);
            this.Controls.Add(this.btn_buscarPed);
            this.Controls.Add(this.btn_buscarEmp);
            this.Controls.Add(this.btn_insertarPed);
            this.Controls.Add(this.btn_cancelarPedido);
            this.Controls.Add(this.btn_entregarPedido);
            this.Controls.Add(this.btn_eliminarEmp);
            this.Controls.Add(this.btn_eliminarCli);
            this.Controls.Add(this.btn_buscarCli);
            this.Controls.Add(this.btn_insertarUsuario);
            this.Controls.Add(this.dgv_tablaEmpleados);
            this.Controls.Add(this.dgv_tablaPedidos);
            this.Controls.Add(this.dgv_tablaClientes);
            this.Controls.Add(this.tbx_telefono);
            this.Controls.Add(this.tbx_clavePrenda);
            this.Controls.Add(this.tbx_claveEmp);
            this.Controls.Add(this.tbx_direccion);
            this.Controls.Add(this.tbx_claveCli);
            this.Controls.Add(this.tbx_claveCliPed);
            this.Controls.Add(this.tbx_claveEmpPed);
            this.Controls.Add(this.tbx_prenda);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.lbl_clavePrenda);
            this.Controls.Add(this.lbl_claveEmp);
            this.Controls.Add(this.combobx_tipoTela);
            this.Controls.Add(this.combobx_puesto);
            this.Controls.Add(this.lbl_claveCli);
            this.Controls.Add(this.lbl_puesto);
            this.Controls.Add(this.lbl_esEmpleado);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_claveCliPed);
            this.Controls.Add(this.lbl_tipoTela);
            this.Controls.Add(this.lbl_claveEmpPed);
            this.Controls.Add(this.lbl_prenda);
            this.Controls.Add(this.lbl_fechaE);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.chkbx_esEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planchado Loma Linda";
            this.Load += new System.EventHandler(this.Form_Interfaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbx_esEmpleado;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.ComboBox combobx_puesto;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.DataGridView dgv_tablaClientes;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_esEmpleado;
        private System.Windows.Forms.Label lbl_puesto;
        private System.Windows.Forms.TextBox tbx_direccion;
        private System.Windows.Forms.TextBox tbx_telefono;
        private System.Windows.Forms.DataGridView dgv_tablaEmpleados;
        private System.Windows.Forms.Button btn_insertarUsuario;
        private System.Windows.Forms.Button btn_buscarCli;
        private System.Windows.Forms.TextBox tbx_claveCli;
        private System.Windows.Forms.Label lbl_claveCli;
        private System.Windows.Forms.Label lbl_claveEmp;
        private System.Windows.Forms.TextBox tbx_claveEmp;
        private System.Windows.Forms.Button btn_actualizarTablaEmp;
        private System.Windows.Forms.Button btn_buscarEmp;
        private System.Windows.Forms.DataGridView dgv_tablaPedidos;
        private System.Windows.Forms.Button btn_insertarPed;
        private System.Windows.Forms.Button btn_buscarPed;
        private System.Windows.Forms.TextBox tbx_clavePrenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_clavePrenda;
        private System.Windows.Forms.Label lbl_fechaE;
        private System.Windows.Forms.Label lbl_prenda;
        private System.Windows.Forms.Label lbl_claveEmpPed;
        private System.Windows.Forms.DateTimePicker dtp_fechaEntrega;
        private System.Windows.Forms.TextBox tbx_claveEmpPed;
        private System.Windows.Forms.TextBox tbx_prenda;
        private System.Windows.Forms.Label lbl_claveCliPed;
        private System.Windows.Forms.TextBox tbx_claveCliPed;
        private System.Windows.Forms.ComboBox combobx_tipoTela;
        private System.Windows.Forms.Button btn_eliminarCli;
        private System.Windows.Forms.Button btn_eliminarEmp;
        private System.Windows.Forms.Button btn_entregarPedido;
        private System.Windows.Forms.Label lbl_tipoTela;
        private System.Windows.Forms.Button btn_cancelarPedido;
        private System.Windows.Forms.Panel pnl_fondo;
        private System.Windows.Forms.Label lbl_tablaPedidos;
        private System.Windows.Forms.Label lbl_tablaEmpl;
        private System.Windows.Forms.Label lbl_tablaCli;
    }
}