using System;
using System.Windows.Forms;
using SourceCode.Clases;

namespace SourceCode
{
    public partial class formCambicontra : Form
    {
        
        public formCambicontra()
        {
            InitializeComponent();
            
        }

       

        private void formCambicontra_Load(object sender, EventArgs e)
        {
            comboUsuario.DataSource = null;
            comboUsuario.ValueMember = "password";
            comboUsuario.DisplayMember = "username";
            comboUsuario.DataSource = ConsultaUsuario.getLista();

        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            bool actualIgual = comboUsuario.SelectedValue.Equals(textActual.Text);
            bool nuevaIgual = textNueva.Text.Equals(textRepetir.Text);
            bool nuevaValida = textNueva.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    ConsultaUsuario.actualizarContra(comboUsuario.Text, textNueva.Text);
                    
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.", 
                        "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡¡Favor verifique que los datos sean correctos!", 
                    "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}