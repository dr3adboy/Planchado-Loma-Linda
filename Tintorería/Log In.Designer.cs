
namespace Tintorería
{
    partial class Form_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_inicio));
            this.lbl_saludo = new System.Windows.Forms.Label();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.tbx_clave = new System.Windows.Forms.TextBox();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.pnl_fondo = new System.Windows.Forms.Panel();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_saludo
            // 
            this.lbl_saludo.AutoSize = true;
            this.lbl_saludo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saludo.Location = new System.Drawing.Point(122, 9);
            this.lbl_saludo.Name = "lbl_saludo";
            this.lbl_saludo.Size = new System.Drawing.Size(116, 20);
            this.lbl_saludo.TabIndex = 0;
            this.lbl_saludo.Text = "Bienvenid@";
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.Location = new System.Drawing.Point(132, 107);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciarSesion.TabIndex = 1;
            this.btn_iniciarSesion.Text = "Iniciar Sesión";
            this.btn_iniciarSesion.UseVisualStyleBackColor = true;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
            // 
            // tbx_clave
            // 
            this.tbx_clave.Location = new System.Drawing.Point(126, 63);
            this.tbx_clave.Name = "tbx_clave";
            this.tbx_clave.Size = new System.Drawing.Size(100, 20);
            this.tbx_clave.TabIndex = 2;
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clave.Location = new System.Drawing.Point(71, 64);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(49, 16);
            this.lbl_clave.TabIndex = 0;
            this.lbl_clave.Text = "Clave:";
            // 
            // pnl_fondo
            // 
            this.pnl_fondo.BackgroundImage = global::Tintorería.Properties.Resources.Logo;
            this.pnl_fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_fondo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_fondo.Location = new System.Drawing.Point(95, 137);
            this.pnl_fondo.Name = "pnl_fondo";
            this.pnl_fondo.Size = new System.Drawing.Size(148, 68);
            this.pnl_fondo.TabIndex = 9;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(59, 13);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(0, 13);
            this.lbl_fecha.TabIndex = 10;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(244, 13);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(0, 13);
            this.lbl_hora.TabIndex = 10;
            // 
            // Form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(324, 217);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.pnl_fondo);
            this.Controls.Add(this.tbx_clave);
            this.Controls.Add(this.btn_iniciarSesion);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.lbl_saludo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenid@";
            this.Load += new System.EventHandler(this.Form_inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_saludo;
        private System.Windows.Forms.Button btn_iniciarSesion;
        private System.Windows.Forms.TextBox tbx_clave;
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.Panel pnl_fondo;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
    }
}

