using DataManager;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2_Programacion3
{
    public partial class CrearCategoria : Form
    {
        private List<Categoria> listaCategorias;
        public CrearCategoria()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarCategoría_Click(object sender, EventArgs e)
        {
            Categoria nueva= new Categoria();
            CategoriaManager manager = new CategoriaManager();
            List <Categoria> lista= new List<Categoria>();

            lista=manager.Listar();
            try
            {
                nueva.descripcion = txtNuevaCategoria.Text;
                if (nueva.descripcion == "")
                {
                    MessageBox.Show("El campo no puede estar vacio!");
                }
                else
                {
                    if (!lista.Any(c => c.descripcion.Equals(nueva.descripcion, StringComparison.OrdinalIgnoreCase)))
                    {
                        manager.agregarCategoria(nueva);
                        MessageBox.Show("SE AGREGO CATEGORIA");
                        Close();
                    }
                    else { MessageBox.Show("NO ES POSIBLE AGREGAR CATEGORIA, YA EXISTE"); }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
