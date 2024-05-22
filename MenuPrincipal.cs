using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace WinFormPantallas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        //Boton para agregar un nuevo articulo
        private void buttonBuscarArticulo_Click(object sender, EventArgs e)
        {
            MenuBuscarArticulo menuBuscarArticulo = new MenuBuscarArticulo();
            menuBuscarArticulo.ShowDialog();
        }
        //OPCIONES DEL MENU...
        //ARTICULOS - Listar 

        private void buscadorDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(MenuListadoArticulos))
                {
                    MessageBox.Show("Ya existe esta ventana abierta");
                    return;
                }
            }

            MenuListadoArticulos listado = new MenuListadoArticulos();
            listado.MdiParent = this;
            listado.Show();
        }

        
    }
}
