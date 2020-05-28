using System.ComponentModel;

namespace SourceCode
{
    partial class formCambicontra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCambicontra));
            this.comboUsuario = new System.Windows.Forms.ComboBox();
            this.textActual = new System.Windows.Forms.TextBox();
            this.textNueva = new System.Windows.Forms.TextBox();
            this.textRepetir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCambiar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboUsuario
            // 
            this.comboUsuario.FormattingEnabled = true;
            this.comboUsuario.Location = new System.Drawing.Point(318, 39);
            this.comboUsuario.Name = "comboUsuario";
            this.comboUsuario.Size = new System.Drawing.Size(141, 21);
            this.comboUsuario.TabIndex = 0;
            // 
            // textActual
            // 
            this.textActual.Location = new System.Drawing.Point(318, 109);
            this.textActual.Name = "textActual";
            this.textActual.Size = new System.Drawing.Size(132, 20);
            this.textActual.TabIndex = 1;
            // 
            // textNueva
            // 
            this.textNueva.Location = new System.Drawing.Point(318, 155);
            this.textNueva.Name = "textNueva";
            this.textNueva.Size = new System.Drawing.Size(132, 20);
            this.textNueva.TabIndex = 2;
            // 
            // textRepetir
            // 
            this.textRepetir.Location = new System.Drawing.Point(318, 201);
            this.textRepetir.Name = "textRepetir";
            this.textRepetir.Size = new System.Drawing.Size(132, 20);
            this.textRepetir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(201, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(201, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contrasena actual";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(201, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nueva contrasena";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(201, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repetir nueva";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 149);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCambiar
            // 
            this.buttonCambiar.Location = new System.Drawing.Point(78, 247);
            this.buttonCambiar.Name = "buttonCambiar";
            this.buttonCambiar.Size = new System.Drawing.Size(115, 33);
            this.buttonCambiar.TabIndex = 9;
            this.buttonCambiar.Text = "Cambiar contrasena";
            this.buttonCambiar.UseVisualStyleBackColor = true;
            this.buttonCambiar.Click += new System.EventHandler(this.buttonCambiar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(286, 247);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(124, 33);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // formCambicontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(493, 312);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCambiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRepetir);
            this.Controls.Add(this.textNueva);
            this.Controls.Add(this.textActual);
            this.Controls.Add(this.comboUsuario);
            this.Name = "formCambicontra";
            this.Text = "formCambicontra";
            this.Load += new System.EventHandler(this.formCambicontra_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonCambiar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textActual;
        private System.Windows.Forms.TextBox textNueva;
        private System.Windows.Forms.TextBox textRepetir;

        #endregion
    }
}