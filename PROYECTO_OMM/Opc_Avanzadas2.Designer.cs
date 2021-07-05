namespace PROYECTO_OMM
{
    partial class Opc_Avanzadas2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAYI = new System.Windows.Forms.Button();
            this.btnUpdateAYI = new System.Windows.Forms.Button();
            this.btnAddAYI = new System.Windows.Forms.Button();
            this.cmbInv = new System.Windows.Forms.ComboBox();
            this.cmbCarn1 = new System.Windows.Forms.ComboBox();
            this.DGVInv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAYA = new System.Windows.Forms.Button();
            this.btnUpdateAYA = new System.Windows.Forms.Button();
            this.btnAddAYA = new System.Windows.Forms.Button();
            this.cmbAct = new System.Windows.Forms.ComboBox();
            this.cmbCarne2 = new System.Windows.Forms.ComboBox();
            this.DGVAct = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Opciones Avanzadas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteAYI);
            this.groupBox1.Controls.Add(this.btnUpdateAYI);
            this.groupBox1.Controls.Add(this.btnAddAYI);
            this.groupBox1.Controls.Add(this.cmbInv);
            this.groupBox1.Controls.Add(this.cmbCarn1);
            this.groupBox1.Controls.Add(this.DGVInv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 306);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayudantes para Investigaciones";
            // 
            // btnDeleteAYI
            // 
            this.btnDeleteAYI.Location = new System.Drawing.Point(423, 234);
            this.btnDeleteAYI.Name = "btnDeleteAYI";
            this.btnDeleteAYI.Size = new System.Drawing.Size(91, 39);
            this.btnDeleteAYI.TabIndex = 7;
            this.btnDeleteAYI.Text = "Eliminar";
            this.btnDeleteAYI.UseVisualStyleBackColor = true;
            this.btnDeleteAYI.Click += new System.EventHandler(this.btnDeleteAYI_Click);
            // 
            // btnUpdateAYI
            // 
            this.btnUpdateAYI.Location = new System.Drawing.Point(423, 159);
            this.btnUpdateAYI.Name = "btnUpdateAYI";
            this.btnUpdateAYI.Size = new System.Drawing.Size(91, 39);
            this.btnUpdateAYI.TabIndex = 6;
            this.btnUpdateAYI.Text = "Actualizar";
            this.btnUpdateAYI.UseVisualStyleBackColor = true;
            this.btnUpdateAYI.Click += new System.EventHandler(this.btnUpdateAYI_Click);
            // 
            // btnAddAYI
            // 
            this.btnAddAYI.Location = new System.Drawing.Point(423, 82);
            this.btnAddAYI.Name = "btnAddAYI";
            this.btnAddAYI.Size = new System.Drawing.Size(91, 39);
            this.btnAddAYI.TabIndex = 5;
            this.btnAddAYI.Text = "Agregar";
            this.btnAddAYI.UseVisualStyleBackColor = true;
            this.btnAddAYI.Click += new System.EventHandler(this.btnAddAYI_Click);
            // 
            // cmbInv
            // 
            this.cmbInv.FormattingEnabled = true;
            this.cmbInv.Location = new System.Drawing.Point(126, 99);
            this.cmbInv.Name = "cmbInv";
            this.cmbInv.Size = new System.Drawing.Size(242, 27);
            this.cmbInv.TabIndex = 4;
            // 
            // cmbCarn1
            // 
            this.cmbCarn1.FormattingEnabled = true;
            this.cmbCarn1.Location = new System.Drawing.Point(126, 42);
            this.cmbCarn1.Name = "cmbCarn1";
            this.cmbCarn1.Size = new System.Drawing.Size(242, 27);
            this.cmbCarn1.TabIndex = 3;
            // 
            // DGVInv
            // 
            this.DGVInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInv.Location = new System.Drawing.Point(21, 143);
            this.DGVInv.Name = "DGVInv";
            this.DGVInv.Size = new System.Drawing.Size(347, 150);
            this.DGVInv.TabIndex = 2;
            this.DGVInv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInv_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Investigación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Carnet:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteAYA);
            this.groupBox2.Controls.Add(this.btnUpdateAYA);
            this.groupBox2.Controls.Add(this.btnAddAYA);
            this.groupBox2.Controls.Add(this.cmbAct);
            this.groupBox2.Controls.Add(this.cmbCarne2);
            this.groupBox2.Controls.Add(this.DGVAct);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(578, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 306);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ayudantes para Actividades";
            // 
            // btnDeleteAYA
            // 
            this.btnDeleteAYA.Location = new System.Drawing.Point(423, 234);
            this.btnDeleteAYA.Name = "btnDeleteAYA";
            this.btnDeleteAYA.Size = new System.Drawing.Size(91, 39);
            this.btnDeleteAYA.TabIndex = 7;
            this.btnDeleteAYA.Text = "Eliminar";
            this.btnDeleteAYA.UseVisualStyleBackColor = true;
            this.btnDeleteAYA.Click += new System.EventHandler(this.btnDeleteAYA_Click);
            // 
            // btnUpdateAYA
            // 
            this.btnUpdateAYA.Location = new System.Drawing.Point(423, 159);
            this.btnUpdateAYA.Name = "btnUpdateAYA";
            this.btnUpdateAYA.Size = new System.Drawing.Size(91, 39);
            this.btnUpdateAYA.TabIndex = 6;
            this.btnUpdateAYA.Text = "Actualizar";
            this.btnUpdateAYA.UseVisualStyleBackColor = true;
            this.btnUpdateAYA.Click += new System.EventHandler(this.btnUpdateAYA_Click);
            // 
            // btnAddAYA
            // 
            this.btnAddAYA.Location = new System.Drawing.Point(423, 82);
            this.btnAddAYA.Name = "btnAddAYA";
            this.btnAddAYA.Size = new System.Drawing.Size(91, 39);
            this.btnAddAYA.TabIndex = 5;
            this.btnAddAYA.Text = "Agregar";
            this.btnAddAYA.UseVisualStyleBackColor = true;
            this.btnAddAYA.Click += new System.EventHandler(this.btnAddAYA_Click);
            // 
            // cmbAct
            // 
            this.cmbAct.FormattingEnabled = true;
            this.cmbAct.Location = new System.Drawing.Point(126, 99);
            this.cmbAct.Name = "cmbAct";
            this.cmbAct.Size = new System.Drawing.Size(242, 27);
            this.cmbAct.TabIndex = 4;
            // 
            // cmbCarne2
            // 
            this.cmbCarne2.FormattingEnabled = true;
            this.cmbCarne2.Location = new System.Drawing.Point(126, 42);
            this.cmbCarne2.Name = "cmbCarne2";
            this.cmbCarne2.Size = new System.Drawing.Size(242, 27);
            this.cmbCarne2.TabIndex = 3;
            // 
            // DGVAct
            // 
            this.DGVAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAct.Location = new System.Drawing.Point(21, 143);
            this.DGVAct.Name = "DGVAct";
            this.DGVAct.Size = new System.Drawing.Size(347, 150);
            this.DGVAct.TabIndex = 2;
            this.DGVAct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAct_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Actividad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Carnet:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 464);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<---- Anterior ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1059, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pág 2/2";
            // 
            // Opc_Avanzadas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 525);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Opc_Avanzadas2";
            this.Text = "Opc_Avanzadas2";
            this.Load += new System.EventHandler(this.Opc_Avanzadas2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteAYI;
        private System.Windows.Forms.Button btnUpdateAYI;
        private System.Windows.Forms.Button btnAddAYI;
        private System.Windows.Forms.DataGridView DGVInv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteAYA;
        private System.Windows.Forms.Button btnUpdateAYA;
        private System.Windows.Forms.Button btnAddAYA;
        private System.Windows.Forms.DataGridView DGVAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbInv;
        public System.Windows.Forms.ComboBox cmbCarn1;
        public System.Windows.Forms.ComboBox cmbAct;
        public System.Windows.Forms.ComboBox cmbCarne2;
    }
}