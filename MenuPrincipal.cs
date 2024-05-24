using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_2_Programacion3;



namespace WinFormPantallas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        
        //OPCIONES DEL MENU...
        //ARTICULOS - Listar 

        private void buscadorDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(MenuListadoArticulos))
                {
                    MessageBox.Show("Esta Opcion se encuentra en ejecucion");
                    return;
                }
            }

            MenuListadoArticulos listado = new MenuListadoArticulos();
            listado.MdiParent = this;
            listado.Show();
        }

        private void AgregarArticuloMenu_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(MenuAgregarArticulo))
                {
                    MessageBox.Show("Esta Opcion se encuentra en ejecucion");
                    return;
                }
            }

            MenuAgregarArticulo listado= new MenuAgregarArticulo();
            listado.MdiParent = this;
            listado.Show();
            

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(CrearCategoria))
                {
                    MessageBox.Show("Esta opcion se encuentra en ejecucion");
                    return;
                }
            }
            CrearCategoria ventana = new CrearCategoria();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void BuscadorArticuloMenu_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(MenuBuscarArticulo))
                {
                    MessageBox.Show("Esta opcion se encuentra en ejecucion");
                    return;
                }
            }
            MenuBuscarArticulo ventana= new MenuBuscarArticulo();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}