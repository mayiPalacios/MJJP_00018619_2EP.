namespace SourceCode
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxHugo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btContraChange = new System.Windows.Forms.Button();
            this.btIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxHugo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHugo
            // 
            this.pictureBoxHugo.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBoxHugo.BackgroundImage")));
            this.pictureBoxHugo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHugo.Location = new System.Drawing.Point(29, 86);
            this.pictureBoxHugo.Name = "pictureBoxHugo";
            this.pictureBoxHugo.Size = new System.Drawing.Size(115, 140);
            this.pictureBoxHugo.TabIndex = 0;
            this.pictureBoxHugo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(168, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(168, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contrasena";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(271, 97);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(124, 21);
            this.cmbUsuario.TabIndex = 3;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(279, 170);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(116, 20);
            this.txtContra.TabIndex = 4;
            // 
            // btContraChange
            // 
            this.btContraChange.BackColor = System.Drawing.Color.White;
            this.btContraChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btContraChange.Location = new System.Drawing.Point(73, 253);
            this.btContraChange.Name = "btContraChange";
            this.btContraChange.Size = new System.Drawing.Size(119, 33);
            this.btContraChange.TabIndex = 5;
            this.btContraChange.Text = "Cambiar contrasena";
            this.btContraChange.UseVisualStyleBackColor = false;
            this.btContraChange.Click += new System.EventHandler(this.btContraChange_Click);
            // 
            // btIniciar
            // 
            this.btIniciar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btIniciar.Location = new System.Drawing.Point(260, 253);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(124, 33);
            this.btIniciar.TabIndex = 6;
            this.btIniciar.Text = "Iniciar sesion";
            this.btIniciar.UseVisualStyleBackColor = false;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(448, 318);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.btContraChange);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxHugo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxHugo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btContraChange;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxHugo;
        private System.Windows.Forms.TextBox txtContra;

        #endregion
    }
}