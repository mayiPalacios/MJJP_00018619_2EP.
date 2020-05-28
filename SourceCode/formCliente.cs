using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SourceCode.Clases;

namespace SourceCode
{
    public partial class formCliente : Form
    {
        private Usuario usuario;
        public formCliente(Usuario us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
          /*  throw new System.NotImplementedException();*/
        }

        private void Actualizarcontrol()
        {
            List<ADDRESS> lista1 = ConsultaADDRESS.GetListaDAd(usuario.idUser);
            List<APPORDER> lista2 = ConsultaAPPORDER.getLista();
            List<Inventario> lista3 = ConsultaInventario.getLista();
           
            comboBoxDireccion.DataSource = null;
            comboBoxDireccion.ValueMember = "idaddress";
            comboBoxDireccion .DisplayMember = "address";
            comboBoxDireccion.DataSource = lista1;
            comboOrdenar.DataSource = null;
            comboOrdenar.ValueMember = "idproduct";
            comboOrdenar.DisplayMember = "name";
            comboOrdenar.DataSource = lista3;
            cmbdireccionOrden.DataSource = null;
            cmbdireccionOrden.ValueMember = "idaddress";
            cmbdireccionOrden.DisplayMember = "Aaddress";
            cmbdireccionOrden.DataSource = lista1;
            cmbeliminarorden.DataSource = null;
            cmbeliminarorden.ValueMember = "idproduct";
            cmbeliminarorden.DisplayMember = "idorder";
            cmbeliminarorden.DataSource = lista2;
            
            
        }

        private void buttonagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxdireccion.Text.Length > 0)
                {
                    
                    ConsultaADDRESS.crearNuevoADDRESS(usuario.idUser,textBoxdireccion.Text);
                    
                    MessageBox.Show("¡Direccion agregada!", 
                        "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    textBoxdireccion.Clear();
                    Actualizarcontrol();
                }
                else
                    MessageBox.Show("Favor complete los campos", 
                        "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("La direccion  no se encuentra disponible agregue otro.", 
                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butteliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar la direccion ?" , 
                "SourceCode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int D = (int) comboBoxDireccion.SelectedValue;
                
                ConsultaADDRESS.eliminar(D);
                
                MessageBox.Show("¡Direccion eliminada exitosamente!", 
                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                Actualizarcontrol();
            }
        }

        private void buttonagreorden_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxfecha.Text.Length > 0)
                {
                    Inventario k = (Inventario) comboOrdenar.SelectedItem;
                    ADDRESS m = (ADDRESS) cmbdireccionOrden.SelectedItem;
                        ConsultaAPPORDER.crearUsuario(textBoxfecha.Text, k.idProduct, m.idaddress);
                    
                    MessageBox.Show("¡Orden agregada exitosamente!", 
                        "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    textBoxfecha.Clear();
                   Actualizarcontrol();
                }
                else
                    MessageBox.Show("Favor completar todo", 
                        "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("lo siento la orden no se encuentra disponible.", 
                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btelimiOrden_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar la orden ?" , 
                "Source", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                APPORDER may = (APPORDER) cmbeliminarorden.SelectedItem;
                ConsultaAPPORDER.eliminar(may.idorder);
                
                MessageBox.Show("¡Orden eliminada exitosamente!", 
                    "SourceCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                Actualizarcontrol();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
           /* throw new System.NotImplementedException();*/
        }
    }
}