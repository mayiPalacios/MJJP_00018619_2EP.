using Preparcial.Controlador;
using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparcial.Vista
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../../Recursos/UCA.png");
pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

ActualizarControlers();
}

private void ActualizarControlers()
{
comboBox1.ValueMember = "Contrasena";
comboBox1.DataSource = ControladorUsuario.GetUsuarios();
comboBox1.DisplayMember = "NombreUsuario";
}

private void Button1_Click(object sender, EventArgs e)
{
    //correccion hacemos una validacion que no dejemos campos vacios
if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString()) && txtNewPassword.Text.Length>0)
{       
var obtenerUsuario = (Usuario)comboBox1.SelectedItem;

ActualizarControlers();
                
ControladorUsuario.ActualizarContrasena(obtenerUsuario.IdUsuario,
txtNewPassword.Text);
}
else
// correcion: cambiamos el mensaje ya que puede que no haya agregado nada
    MessageBox.Show("error verifique que haya escrito algo o que su contrasena sea correcta");
        }
    }
}
