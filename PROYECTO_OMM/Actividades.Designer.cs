namespace PROYECTO_OMM
{
    partial class Actividades
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoInstitucion = new System.Windows.Forms.ComboBox();
            this.msktxtHora = new System.Windows.Forms.MaskedTextBox();
            this.txtcupos = new System.Windows.Forms.TextBox();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.cmbTipoActividad = new System.Windows.Forms.ComboBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegis = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Activdad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Actividad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoInstitucion);
            this.groupBox1.Controls.Add(this.msktxtHora);
            this.groupBox1.Controls.Add(this.txtcupos);
            this.groupBox1.Controls.Add(this.txtActividad);
            this.groupBox1.Controls.Add(this.cmbTipoActividad);
            this.groupBox1.Controls.Add(this.dtpfecha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 319);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACTIVIDADES";
            // 
            // cmbTipoInstitucion
            // 
            this.cmbTipoInstitucion.FormattingEnabled = true;
            this.cmbTipoInstitucion.Location = new System.Drawing.Point(475, 238);
            this.cmbTipoInstitucion.Name = "cmbTipoInstitucion";
            this.cmbTipoInstitucion.Size = new System.Drawing.Size(160, 23);
            this.cmbTipoInstitucion.TabIndex = 13;
            this.cmbTipoInstitucion.SelectedIndexChanged += new System.EventHandler(this.cmbTipoInstitucion_SelectedIndexChanged);
            // 
            // msktxtHora
            // 
            this.msktxtHora.Location = new System.Drawing.Point(266, 238);
            this.msktxtHora.Mask = "00:00:00";
            this.msktxtHora.Name = "msktxtHora";
            this.msktxtHora.Size = new System.Drawing.Size(82, 21);
            this.msktxtHora.TabIndex = 12;
            this.msktxtHora.ValidatingType = typeof(System.DateTime);
            // 
            // txtcupos
            // 
            this.txtcupos.Location = new System.Drawing.Point(89, 238);
            this.txtcupos.Name = "txtcupos";
            this.txtcupos.Size = new System.Drawing.Size(72, 21);
            this.txtcupos.TabIndex = 11;
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(188, 87);
            this.txtActividad.MaxLength = 40;
            this.txtActividad.Multiline = true;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(408, 51);
            this.txtActividad.TabIndex = 10;
            // 
            // cmbTipoActividad
            // 
            this.cmbTipoActividad.FormattingEnabled = true;
            this.cmbTipoActividad.Location = new System.Drawing.Point(188, 35);
            this.cmbTipoActividad.Name = "cmbTipoActividad";
            this.cmbTipoActividad.Size = new System.Drawing.Size(149, 23);
            this.cmbTipoActividad.TabIndex = 9;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(188, 171);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(266, 21);
            this.dtpfecha.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Institución";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cupos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Realizacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(472, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 28);
            this.label9.TabIndex = 5;
            this.label9.Text = "INGRESAR ACTIVIDADES";
            // 
            // btnRegis
            // 
            this.btnRegis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegis.Location = new System.Drawing.Point(24, 382);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(104, 56);
            this.btnRegis.TabIndex = 6;
            this.btnRegis.Text = "Registrar Actividad";
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(1079, 394);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(99, 44);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(680, 62);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.Size = new System.Drawing.Size(507, 310);
            this.dgvActividades.TabIndex = 8;
            this.dgvActividades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActividades_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(290, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 56);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar Actividad";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(156, 382);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 56);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar Actividad";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "Actividades";
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.Actividades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.TextBox txtcupos;
        public System.Windows.Forms.TextBox txtActividad;
        public System.Windows.Forms.ComboBox cmbTipoActividad;
        public System.Windows.Forms.DateTimePicker dtpfecha;
        public System.Windows.Forms.ComboBox cmbTipoInstitucion;
        public System.Windows.Forms.MaskedTextBox msktxtHora;
    }
}