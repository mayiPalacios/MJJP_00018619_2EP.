using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SourceCode.Clases;

namespace SourceCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           /* Poblarcontroles();*/
        }

        private void Poblarcontroles()
        {
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "password";
            cmbUsuario.DisplayMember = "username";
            cmbUsuario.DataSource = ConsultaUsuario.getLista();
        }

        
        private void btIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUsuario.SelectedValue.Equals(txtContra.Text))
                {
                    Usuario u = (Usuario) cmbUsuario.SelectedItem;
                   /* u.username = cmbUsuario.Text;
                    u.password = txtContra.Text;*/
                    if (u.userType)
                    {
                        MessageBox.Show("¡Bienvenido Administrador!",
                            "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formAdmi ventana1 = new formAdmi(u);
                        ventana1.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("¡Bienvenido Cliente!",
                            "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formCliente Ventana2 = new formCliente(u);
                        Ventana2.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!", "Clase GUI 05",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("¡Contraseña incorrecta!", "Preparcial",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
        
        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btIniciar_Click(sender, e);
        }

        

        private void btContraChange_Click(object sender, EventArgs e)
        {
            formCambicontra unaVentana = new formCambicontra();
            unaVentana.ShowDialog();
            Poblarcontroles();
        }
    private void Form1_Load(object sender, EventArgs e)
{ Poblarcontroles(); }

   
    }
}