namespace PROYECTO_OMM
{
    partial class Opciones_Avanzadas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteEI = new System.Windows.Forms.Button();
            this.btnUpdateEI = new System.Windows.Forms.Button();
            this.txtEstadoInves = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddEI = new System.Windows.Forms.Button();
            this.gbx2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTDA = new System.Windows.Forms.Button();
            this.btnUpdateTDA = new System.Windows.Forms.Button();
            this.btnAddTDA = new System.Windows.Forms.Button();
            this.txtTipoAct = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gbx3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteINS = new System.Windows.Forms.Button();
            this.txtINST = new System.Windows.Forms.TextBox();
            this.btnUpdateINS = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnAddINS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opciones Avanzadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado:";
            // 
            // gbx1
            // 
            this.gbx1.Controls.Add(this.btnDeleteEI);
            this.gbx1.Controls.Add(this.btnUpdateEI);
            this.gbx1.Controls.Add(this.txtEstadoInves);
            this.gbx1.Controls.Add(this.dataGridView1);
            this.gbx1.Controls.Add(this.btnAddEI);
            this.gbx1.Controls.Add(this.label2);
            this.gbx1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx1.Location = new System.Drawing.Point(12, 102);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(451, 235);
            this.gbx1.TabIndex = 2;
            this.gbx1.TabStop = false;
            this.gbx1.Text = "Estado Investigaciones";
            // 
            // btnDeleteEI
            // 
            this.btnDeleteEI.Location = new System.Drawing.Point(319, 161);
            this.btnDeleteEI.Name = "btnDeleteEI";
            this.btnDeleteEI.Size = new System.Drawing.Size(100, 42);
            this.btnDeleteEI.TabIndex = 5;
            this.btnDeleteEI.Text = "Eliminar";
            this.btnDeleteEI.UseVisualStyleBackColor = true;
            this.btnDeleteEI.Click += new System.EventHandler(this.btnDeleteEI_Click);
            // 
            // btnUpdateEI
            // 
            this.btnUpdateEI.Location = new System.Drawing.Point(319, 115);
            this.btnUpdateEI.Name = "btnUpdateEI";
            this.btnUpdateEI.Size = new System.Drawing.Size(100, 42);
            this.btnUpdateEI.TabIndex = 6;
            this.btnUpdateEI.Text = "Actualizar";
            this.btnUpdateEI.UseVisualStyleBackColor = true;
            this.btnUpdateEI.Click += new System.EventHandler(this.btnUpdateEI_Click);
            // 
            // txtEstadoInves
            // 
            this.txtEstadoInves.Location = new System.Drawing.Point(74, 43);
            this.txtEstadoInves.Name = "txtEstadoInves";
            this.txtEstadoInves.Size = new System.Drawing.Size(195, 24);
            this.txtEstadoInves.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(254, 108);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAddEI
            // 
            this.btnAddEI.Location = new System.Drawing.Point(319, 67);
            this.btnAddEI.Name = "btnAddEI";
            this.btnAddEI.Size = new System.Drawing.Size(100, 42);
            this.btnAddEI.TabIndex = 4;
            this.btnAddEI.Text = "Agregar";
            this.btnAddEI.UseVisualStyleBackColor = true;
            this.btnAddEI.Click += new System.EventHandler(this.btnAddEI_Click);
            // 
            // gbx2
            // 
            this.gbx2.Controls.Add(this.btnDeleteTDA);
            this.gbx2.Controls.Add(this.btnUpdateTDA);
            this.gbx2.Controls.Add(this.btnAddTDA);
            this.gbx2.Controls.Add(this.txtTipoAct);
            this.gbx2.Controls.Add(this.dataGridView2);
            this.gbx2.Controls.Add(this.label3);
            this.gbx2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx2.Location = new System.Drawing.Point(517, 103);
            this.gbx2.Name = "gbx2";
            this.gbx2.Size = new System.Drawing.Size(451, 234);
            this.gbx2.TabIndex = 3;
            this.gbx2.TabStop = false;
            this.gbx2.Text = "Tipo de Actividad";
            // 
            // btnDeleteTDA
            // 
            this.btnDeleteTDA.Location = new System.Drawing.Point(321, 160);
            this.btnDeleteTDA.Name = "btnDeleteTDA";
            this.btnDeleteTDA.Size = new System.Drawing.Size(100, 42);
            this.btnDeleteTDA.TabIndex = 8;
            this.btnDeleteTDA.Text = "Eliminar";
            this.btnDeleteTDA.UseVisualStyleBackColor = true;
            this.btnDeleteTDA.Click += new System.EventHandler(this.btnDeleteTDA_Click);
            // 
            // btnUpdateTDA
            // 
            this.btnUpdateTDA.Location = new System.Drawing.Point(321, 114);
            this.btnUpdateTDA.Name = "btnUpdateTDA";
            this.btnUpdateTDA.Size = new System.Drawing.Size(100, 42);
            this.btnUpdateTDA.TabIndex = 9;
            this.btnUpdateTDA.Text = "Actualizar";
            this.btnUpdateTDA.UseVisualStyleBackColor = true;
            this.btnUpdateTDA.Click += new System.EventHandler(this.btnUpdateTDA_Click);
            // 
            // btnAddTDA
            // 
            this.btnAddTDA.Location = new System.Drawing.Point(321, 66);
            this.btnAddTDA.Name = "btnAddTDA";
            this.btnAddTDA.Size = new System.Drawing.Size(100, 42);
            this.btnAddTDA.TabIndex = 7;
            this.btnAddTDA.Text = "Agregar";
            this.btnAddTDA.UseVisualStyleBackColor = true;
            this.btnAddTDA.Click += new System.EventHandler(this.btnAddTDA_Click);
            // 
            // txtTipoAct
            // 
            this.txtTipoAct.Location = new System.Drawing.Point(60, 42);
            this.txtTipoAct.Name = "txtTipoAct";
            this.txtTipoAct.Size = new System.Drawing.Size(212, 24);
            this.txtTipoAct.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(257, 108);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo:";
            // 
            // gbx3
            // 
            this.gbx3.Controls.Add(this.btnDeleteINS);
            this.gbx3.Controls.Add(this.txtINST);
            this.gbx3.Controls.Add(this.btnUpdateINS);
            this.gbx3.Controls.Add(this.dataGridView3);
            this.gbx3.Controls.Add(this.btnAddINS);
            this.gbx3.Controls.Add(this.label4);
            this.gbx3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx3.Location = new System.Drawing.Point(272, 366);
            this.gbx3.Name = "gbx3";
            this.gbx3.Size = new System.Drawing.Size(451, 218);
            this.gbx3.TabIndex = 3;
            this.gbx3.TabStop = false;
            this.gbx3.Text = "Instituciones";
            // 
            // btnDeleteINS
            // 
            this.btnDeleteINS.Location = new System.Drawing.Point(319, 163);
            this.btnDeleteINS.Name = "btnDeleteINS";
            this.btnDeleteINS.Size = new System.Drawing.Size(100, 42);
            this.btnDeleteINS.TabIndex = 8;
            this.btnDeleteINS.Text = "Eliminar";
            this.btnDeleteINS.UseVisualStyleBackColor = true;
            this.btnDeleteINS.Click += new System.EventHandler(this.btnDeleteINS_Click);
            // 
            // txtINST
            // 
            this.txtINST.Location = new System.Drawing.Point(98, 47);
            this.txtINST.Name = "txtINST";
            this.txtINST.Size = new System.Drawing.Size(184, 24);
            this.txtINST.TabIndex = 4;
            // 
            // btnUpdateINS
            // 
            this.btnUpdateINS.Location = new System.Drawing.Point(319, 117);
            this.btnUpdateINS.Name = "btnUpdateINS";
            this.btnUpdateINS.Size = new System.Drawing.Size(100, 42);
            this.btnUpdateINS.TabIndex = 9;
            this.btnUpdateINS.Text = "Actualizar";
            this.btnUpdateINS.UseVisualStyleBackColor = true;
            this.btnUpdateINS.Click += new System.EventHandler(this.btnUpdateINS_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(15, 93);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(267, 108);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // btnAddINS
            // 
            this.btnAddINS.Location = new System.Drawing.Point(319, 69);
            this.btnAddINS.Name = "btnAddINS";
            this.btnAddINS.Size = new System.Drawing.Size(100, 42);
            this.btnAddINS.TabIndex = 7;
            this.btnAddINS.Text = "Agregar";
            this.btnAddINS.UseVisualStyleBackColor = true;
            this.btnAddINS.Click += new System.EventHandler(this.btnAddINS_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Instituciòn:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(27, 558);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(892, 560);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 36);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(918, 602);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pág 1/2";
            // 
            // Opciones_Avanzadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 630);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbx3);
            this.Controls.Add(this.gbx2);
            this.Controls.Add(this.gbx1);
            this.Controls.Add(this.label1);
            this.Name = "Opciones_Avanzadas";
            this.Text = "Opciones_Avanzadas";
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbx2.ResumeLayout(false);
            this.gbx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbx3.ResumeLayout(false);
            this.gbx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbx2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteEI;
        private System.Windows.Forms.Button btnUpdateEI;
        private System.Windows.Forms.Button btnAddEI;
        private System.Windows.Forms.Button btnDeleteTDA;
        private System.Windows.Forms.Button btnUpdateTDA;
        private System.Windows.Forms.Button btnAddTDA;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gbx3;
        private System.Windows.Forms.Button btnDeleteINS;
        private System.Windows.Forms.Button btnUpdateINS;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnAddINS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEstadoInves;
        public System.Windows.Forms.TextBox txtTipoAct;
        public System.Windows.Forms.TextBox txtINST;
    }
}