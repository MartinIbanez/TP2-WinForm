using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;
using Dominio;

namespace WinFormPantallas
{
    public partial class MenuBuscarArticulo : Form
    {
        private List<Articulo> listaArticulo;
        public MenuBuscarArticulo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuBuscarArticulo_Load(object sender, EventArgs e)
        {

        }



        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("imagen");

            }

        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            
            string filtro = txtFiltro.Text.Trim().ToUpper();

            List<Articulo> listaFiltrada;

            if (!string.IsNullOrEmpty(filtro))
            {
                listaFiltrada = listaArticulo.FindAll(a => a.codigo.ToUpper().Contains(filtro));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }
            dgvBuscar.DataSource= listaFiltrada;
            

            if (listaFiltrada.Count > 0 && dgvBuscar.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvBuscar.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
            else
            {
                pbxArticulo.Load("https://i.pinimg.com/564x/a5/6e/f6/a56ef61429307a58fbcbb16139d623f6.jpg");
            }
        }

        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvBuscar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBuscar.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvBuscar.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        
    }
    }
    

