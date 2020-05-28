using System.ComponentModel;

namespace SourceCode
{
    partial class formAdmi
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
            this.cmbeliminarUser = new System.Windows.Forms.ComboBox();
            this.bteliminarusuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btaggusuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.textBoxnickname = new System.Windows.Forms.TextBox();
            this.textBoxfullnombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbEliminarpro = new System.Windows.Forms.ComboBox();
            this.btEraseProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmnegociopro = new System.Windows.Forms.ComboBox();
            this.btproducto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBoxEliminarnegocio = new System.Windows.Forms.ComboBox();
            this.bterasenegocio = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxdescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btAggnegocio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxnegocio = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 321);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(501, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbeliminarUser);
            this.groupBox2.Controls.Add(this.bteliminarusuario);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(29, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Usuario";
            // 
            // cmbeliminarUser
            // 
            this.cmbeliminarUser.FormattingEnabled = true;
            this.cmbeliminarUser.Location = new System.Drawing.Point(94, 37);
            this.cmbeliminarUser.Name = "cmbeliminarUser";
            this.cmbeliminarUser.Size = new System.Drawing.Size(107, 21);
            this.cmbeliminarUser.TabIndex = 7;
            // 
            // bteliminarusuario
            // 
            this.bteliminarusuario.ForeColor = System.Drawing.Color.Red;
            this.bteliminarusuario.Location = new System.Drawing.Point(251, 78);
            this.bteliminarusuario.Name = "bteliminarusuario";
            this.bteliminarusuario.Size = new System.Drawing.Size(116, 37);
            this.bteliminarusuario.TabIndex = 6;
            this.bteliminarusuario.Text = "Eliminar Usuario";
            this.bteliminarusuario.UseVisualStyleBackColor = true;
            this.bteliminarusuario.Click += new System.EventHandler(this.bteliminarusuario_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "nickname";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btaggusuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxContra);
            this.groupBox1.Controls.Add(this.textBoxnickname);
            this.groupBox1.Controls.Add(this.textBoxfullnombre);
            this.groupBox1.Location = new System.Drawing.Point(29, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "agregar Usuarios";
            // 
            // btaggusuario
            // 
            this.btaggusuario.Location = new System.Drawing.Point(251, 78);
            this.btaggusuario.Name = "btaggusuario";
            this.btaggusuario.Size = new System.Drawing.Size(116, 37);
            this.btaggusuario.TabIndex = 6;
            this.btaggusuario.Text = "agregar usuario";
            this.btaggusuario.UseVisualStyleBackColor = true;
            this.btaggusuario.Click += new System.EventHandler(this.btaggusuario_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contrasena";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(201, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "nickname";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "nombre";
            // 
            // textBoxContra
            // 
            this.textBoxContra.Location = new System.Drawing.Point(81, 87);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.Size = new System.Drawing.Size(104, 20);
            this.textBoxContra.TabIndex = 2;
            // 
            // textBoxnickname
            // 
            this.textBoxnickname.Location = new System.Drawing.Point(263, 33);
            this.textBoxnickname.Name = "textBoxnickname";
            this.textBoxnickname.Size = new System.Drawing.Size(104, 20);
            this.textBoxnickname.TabIndex = 1;
            // 
            // textBoxfullnombre
            // 
            this.textBoxfullnombre.Location = new System.Drawing.Point(81, 33);
            this.textBoxfullnombre.Name = "textBoxfullnombre";
            this.textBoxfullnombre.Size = new System.Drawing.Size(104, 20);
            this.textBoxfullnombre.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(501, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbEliminarpro);
            this.groupBox4.Controls.Add(this.btEraseProducto);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(22, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 133);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eliminar producto";
            // 
            // cmbEliminarpro
            // 
            this.cmbEliminarpro.FormattingEnabled = true;
            this.cmbEliminarpro.Location = new System.Drawing.Point(94, 37);
            this.cmbEliminarpro.Name = "cmbEliminarpro";
            this.cmbEliminarpro.Size = new System.Drawing.Size(107, 21);
            this.cmbEliminarpro.TabIndex = 7;
            // 
            // btEraseProducto
            // 
            this.btEraseProducto.ForeColor = System.Drawing.Color.Red;
            this.btEraseProducto.Location = new System.Drawing.Point(251, 78);
            this.btEraseProducto.Name = "btEraseProducto";
            this.btEraseProducto.Size = new System.Drawing.Size(116, 37);
            this.btEraseProducto.TabIndex = 6;
            this.btEraseProducto.Text = "Eliminar producto";
            this.btEraseProducto.UseVisualStyleBackColor = true;
            this.btEraseProducto.Click += new System.EventHandler(this.btEraseProducto_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmnegociopro);
            this.groupBox3.Controls.Add(this.btproducto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxProducto);
            this.groupBox3.Location = new System.Drawing.Point(22, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 144);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "agregar producto";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Negocio de producto";
            // 
            // cmnegociopro
            // 
            this.cmnegociopro.FormattingEnabled = true;
            this.cmnegociopro.Location = new System.Drawing.Point(126, 28);
            this.cmnegociopro.Name = "cmnegociopro";
            this.cmnegociopro.Size = new System.Drawing.Size(107, 21);
            this.cmnegociopro.TabIndex = 8;
            // 
            // btproducto
            // 
            this.btproducto.Location = new System.Drawing.Point(268, 45);
            this.btproducto.Name = "btproducto";
            this.btproducto.Size = new System.Drawing.Size(116, 37);
            this.btproducto.TabIndex = 6;
            this.btproducto.Text = "agregar producto";
            this.btproducto.UseVisualStyleBackColor = true;
            this.btproducto.Click += new System.EventHandler(this.btproducto_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(40, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Producto";
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Location = new System.Drawing.Point(126, 78);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(104, 20);
            this.textBoxProducto.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(501, 295);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBoxEliminarnegocio);
            this.groupBox6.Controls.Add(this.bterasenegocio);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(18, 167);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(434, 122);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Eliminar negocio";
            // 
            // comboBoxEliminarnegocio
            // 
            this.comboBoxEliminarnegocio.FormattingEnabled = true;
            this.comboBoxEliminarnegocio.Location = new System.Drawing.Point(94, 37);
            this.comboBoxEliminarnegocio.Name = "comboBoxEliminarnegocio";
            this.comboBoxEliminarnegocio.Size = new System.Drawing.Size(107, 21);
            this.comboBoxEliminarnegocio.TabIndex = 7;
            // 
            // bterasenegocio
            // 
            this.bterasenegocio.ForeColor = System.Drawing.Color.Red;
            this.bterasenegocio.Location = new System.Drawing.Point(251, 78);
            this.bterasenegocio.Name = "bterasenegocio";
            this.bterasenegocio.Size = new System.Drawing.Size(116, 37);
            this.bterasenegocio.TabIndex = 6;
            this.bterasenegocio.Text = "Eliminar negocio";
            this.bterasenegocio.UseVisualStyleBackColor = true;
            this.bterasenegocio.Click += new System.EventHandler(this.bterasenegocio_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Negocio";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxdescription);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.btAggnegocio);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBoxnegocio);
            this.groupBox5.Location = new System.Drawing.Point(18, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(434, 144);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Agregar negocio";
            // 
            // textBoxdescription
            // 
            this.textBoxdescription.Location = new System.Drawing.Point(123, 87);
            this.textBoxdescription.Name = "textBoxdescription";
            this.textBoxdescription.Size = new System.Drawing.Size(104, 20);
            this.textBoxdescription.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descripcion";
            // 
            // btAggnegocio
            // 
            this.btAggnegocio.Location = new System.Drawing.Point(266, 52);
            this.btAggnegocio.Name = "btAggnegocio";
            this.btAggnegocio.Size = new System.Drawing.Size(116, 37);
            this.btAggnegocio.TabIndex = 6;
            this.btAggnegocio.Text = "agregar negocio";
            this.btAggnegocio.UseVisualStyleBackColor = true;
            this.btAggnegocio.Click += new System.EventHandler(this.btAggnegocio_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Agregar Negocio";
            // 
            // textBoxnegocio
            // 
            this.textBoxnegocio.Location = new System.Drawing.Point(123, 32);
            this.textBoxnegocio.Name = "textBoxnegocio";
            this.textBoxnegocio.Size = new System.Drawing.Size(104, 20);
            this.textBoxnegocio.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(501, 295);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // formAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 340);
            this.Controls.Add(this.tabControl1);
            this.Name = "formAdmi";
            this.Text = "formAdmi";
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btAggnegocio;
        private System.Windows.Forms.Button btaggusuario;
        private System.Windows.Forms.Button bteliminarusuario;
        private System.Windows.Forms.Button bterasenegocio;
        private System.Windows.Forms.Button btEraseProducto;
        private System.Windows.Forms.Button btproducto;
        private System.Windows.Forms.ComboBox cmbEliminarpro;
        private System.Windows.Forms.ComboBox cmbeliminarUser;
        private System.Windows.Forms.ComboBox cmnegociopro;
        private System.Windows.Forms.ComboBox comboBoxEliminarnegocio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxContra;
        private System.Windows.Forms.TextBox textBoxdescription;
        private System.Windows.Forms.TextBox textBoxfullnombre;
        private System.Windows.Forms.TextBox textBoxnegocio;
        private System.Windows.Forms.TextBox textBoxnickname;
        private System.Windows.Forms.TextBox textBoxProducto;

        #endregion
    }
}