using System;
using System.Windows.Forms;
using SourceCode.Clases;
using System.Collections.Generic;

namespace SourceCode
{
    public partial class formAdmi : Form
    {
        private Usuario uss;
        public formAdmi(Usuario use2)
        {
            InitializeComponent();
            uss = use2;
        }

        private void Actualizar()
        {
            List<Usuario> lista1 = ConsultaUsuario.getLista();
            List<BUSINESS> lista2 = ConsultaBUSINESS.getLista();
            List<Inventario> lista3 = ConsultaInventario.getLista();
            List<APPORDER> lista4 = ConsultaAPPORDER.getLista();

            cmbeliminarUser.DataSource = null;
            cmbeliminarUser.ValueMember = "password";
            cmbeliminarUser.DisplayMember = "username";
            cmbeliminarUser.DataSource = lista1;
            cmnegociopro.DataSource = null;
            cmnegociopro.ValueMember = "idbusiness";
            cmnegociopro.DisplayMember = "name";
            cmnegociopro.DataSource = lista2;
            cmbEliminarpro.DataSource = null;
            cmbEliminarpro.ValueMember = "idproduct";
            cmbEliminarpro.DisplayMember = "name";
            cmbEliminarpro.DataSource = lista3;
            comboBoxEliminarnegocio.DataSource = null;
            comboBoxEliminarnegocio.ValueMember = "idbusiness";
            comboBoxEliminarnegocio.DisplayMember = "name";
            comboBoxEliminarnegocio.DataSource = lista2;
        }


        private void btaggusuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxfullnombre.Text.Length > 0 && textBoxnickname.Text.Length > 0)
                {
                    bool usuario = false;
                    ConsultaUsuario.crearNuevo(textBoxfullnombre.Text, textBoxnickname.Text,usuario);
                    
                    MessageBox.Show("¡Usuario agregado exitosamente!" , 
                        "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    textBoxfullnombre.Clear();
                    textBoxnickname.Clear();
                   Actualizar();
                }
                else
                    MessageBox.Show("Favor Complete los campos", 
                        "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.", 
                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bteliminarusuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar al usuario? ",
                "SourceCode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Usuario mayi = (Usuario) cmbeliminarUser.SelectedItem;
                ConsultaUsuario.eliminar(mayi.idUser);

                MessageBox.Show("¡Usuario eliminado exitosamente!",
                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Actualizar();

            }
        }

        private void btproducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxProducto.Text.Length > 0)
                {
                    int idebusiness = (int) cmnegociopro.SelectedValue;
                    ConsultaInventario.crearNuevo(idebusiness, textBoxProducto.Text);
                    
                    MessageBox.Show("¡Producto agregado!", 
                        "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    textBoxProducto.Clear();
                    Actualizar();
                }
                else
                    MessageBox.Show("Favor completar todo", 
                        "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Lo siento el producto que escribio no esta disponible.", 
                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        

        private void btEraseProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el producto?", 
                "SourceCode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idproducto = (int) cmbEliminarpro.SelectedValue;
                ConsultaInventario.eliminar(idproducto);
                
                MessageBox.Show("¡Producto eliminado exitosamente!", 
                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                Actualizar();
            }
        }

        private void btAggnegocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxnegocio.Text.Length > 0 && textBoxdescription.Text.Length > 0)
                {
                    ConsultaBUSINESS.crearNuevo(textBoxnegocio.Text, textBoxdescription.Text);
                    
                    MessageBox.Show("¡Negocio agregado!" , 
                        "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    textBoxnegocio.Clear();
                    textBoxdescription.Clear();
                    Actualizar();
                }
                else
                    MessageBox.Show("Favor Complete todo lo que se le pide", 
                        "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El negocio que ha digitado, no se encuentra disponible.", 
                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bterasenegocio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el negocio ?" , 
                "SourceCode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BUSINESS mayii = (BUSINESS) comboBoxEliminarnegocio.SelectedItem;
                ConsultaBUSINESS.eliminar(mayii.idBussiness);
                
                MessageBox.Show("¡Negocio eliminado!", 
                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                Actualizar();
            }
        }
    }
}