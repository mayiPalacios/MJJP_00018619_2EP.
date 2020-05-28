using System.ComponentModel;

namespace SourceCode
{
    partial class formCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxDireccion = new System.Windows.Forms.ComboBox();
            this.butteliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbeliminarorden = new System.Windows.Forms.ComboBox();
            this.btelimiOrden = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbdireccionOrden = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxfecha = new System.Windows.Forms.TextBox();
            this.comboOrdenar = new System.Windows.Forms.ComboBox();
            this.buttonagreorden = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 309);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.comboBoxDireccion);
            this.groupBox2.Controls.Add(this.butteliminar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(17, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 116);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminardireccion";
            // 
            // comboBoxDireccion
            // 
            this.comboBoxDireccion.FormattingEnabled = true;
            this.comboBoxDireccion.Location = new System.Drawing.Point(204, 18);
            this.comboBoxDireccion.Name = "comboBoxDireccion";
            this.comboBoxDireccion.Size = new System.Drawing.Size(131, 21);
            this.comboBoxDireccion.TabIndex = 3;
            // 
            // butteliminar
            // 
            this.butteliminar.BackColor = System.Drawing.Color.Transparent;
            this.butteliminar.ForeColor = System.Drawing.Color.Red;
            this.butteliminar.Location = new System.Drawing.Point(202, 71);
            this.butteliminar.Name = "butteliminar";
            this.butteliminar.Size = new System.Drawing.Size(134, 34);
            this.butteliminar.TabIndex = 2;
            this.butteliminar.Text = "Eliminar";
            this.butteliminar.UseVisualStyleBackColor = false;
            this.butteliminar.Click += new System.EventHandler(this.butteliminar_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(63, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "direccion";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonagregar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxdireccion);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "agregar direccion";
            // 
            // buttonagregar
            // 
            this.buttonagregar.Location = new System.Drawing.Point(202, 71);
            this.buttonagregar.Name = "buttonagregar";
            this.buttonagregar.Size = new System.Drawing.Size(134, 34);
            this.buttonagregar.TabIndex = 2;
            this.buttonagregar.Text = "agregar direccion";
            this.buttonagregar.UseVisualStyleBackColor = true;
            this.buttonagregar.Click += new System.EventHandler(this.buttonagregar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "direccion";
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(202, 19);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(134, 20);
            this.textBoxdireccion.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbeliminarorden);
            this.groupBox4.Controls.Add(this.btelimiOrden);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(17, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(409, 116);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eliminar orden";
            // 
            // cmbeliminarorden
            // 
            this.cmbeliminarorden.FormattingEnabled = true;
            this.cmbeliminarorden.Location = new System.Drawing.Point(204, 18);
            this.cmbeliminarorden.Name = "cmbeliminarorden";
            this.cmbeliminarorden.Size = new System.Drawing.Size(131, 21);
            this.cmbeliminarorden.TabIndex = 3;
            // 
            // btelimiOrden
            // 
            this.btelimiOrden.BackColor = System.Drawing.Color.Transparent;
            this.btelimiOrden.ForeColor = System.Drawing.Color.Red;
            this.btelimiOrden.Location = new System.Drawing.Point(202, 71);
            this.btelimiOrden.Name = "btelimiOrden";
            this.btelimiOrden.Size = new System.Drawing.Size(134, 34);
            this.btelimiOrden.TabIndex = 2;
            this.btelimiOrden.Text = "Eliminar";
            this.btelimiOrden.UseVisualStyleBackColor = false;
            this.btelimiOrden.Click += new System.EventHandler(this.btelimiOrden_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(63, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Orden";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbdireccionOrden);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxfecha);
            this.groupBox3.Controls.Add(this.comboOrdenar);
            this.groupBox3.Controls.Add(this.buttonagreorden);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(24, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 141);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "agregar orden";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "direccion";
            // 
            // cmbdireccionOrden
            // 
            this.cmbdireccionOrden.FormattingEnabled = true;
            this.cmbdireccionOrden.Location = new System.Drawing.Point(85, 100);
            this.cmbdireccionOrden.Name = "cmbdireccionOrden";
            this.cmbdireccionOrden.Size = new System.Drawing.Size(131, 21);
            this.cmbdireccionOrden.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha";
            // 
            // textBoxfecha
            // 
            this.textBoxfecha.Location = new System.Drawing.Point(85, 57);
            this.textBoxfecha.Name = "textBoxfecha";
            this.textBoxfecha.Size = new System.Drawing.Size(134, 20);
            this.textBoxfecha.TabIndex = 5;
            // 
            // comboOrdenar
            // 
            this.comboOrdenar.FormattingEnabled = true;
            this.comboOrdenar.Location = new System.Drawing.Point(82, 19);
            this.comboOrdenar.Name = "comboOrdenar";
            this.comboOrdenar.Size = new System.Drawing.Size(131, 21);
            this.comboOrdenar.TabIndex = 4;
            // 
            // buttonagreorden
            // 
            this.buttonagreorden.Location = new System.Drawing.Point(242, 57);
            this.buttonagreorden.Name = "buttonagreorden";
            this.buttonagreorden.Size = new System.Drawing.Size(134, 34);
            this.buttonagreorden.TabIndex = 2;
            this.buttonagreorden.Text = "agregar orden";
            this.buttonagreorden.UseVisualStyleBackColor = true;
            this.buttonagreorden.Click += new System.EventHandler(this.buttonagreorden_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ordenar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(432, 283);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(432, 283);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-3, 78);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(435, 209);
            this.dataGridView2.TabIndex = 1;
            // 
            // formCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(461, 325);
            this.Controls.Add(this.tabControl1);
            this.Name = "formCliente";
            this.Text = "formCliente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btelimiOrden;
        private System.Windows.Forms.Button butteliminar;
        private System.Windows.Forms.Button buttonagregar;
        private System.Windows.Forms.Button buttonagreorden;
        private System.Windows.Forms.ComboBox cmbdireccionOrden;
        private System.Windows.Forms.ComboBox cmbeliminarorden;
        private System.Windows.Forms.ComboBox comboBoxDireccion;
        private System.Windows.Forms.ComboBox comboOrdenar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.TextBox textBoxfecha;

        #endregion
    }
}