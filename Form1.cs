using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_De_Inventario
{
    public partial class Form1 : Form
    {
        //Listas simples
        Inventario inv = new Inventario();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = (txtNombre.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int costo = Convert.ToInt32(txtPrecio.Text);

            inv.agregar(codigo, nombre, cantidad, costo);

            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            inv.eliminar(codigo);

            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string nombre = (txtNombre.Text);
            txtReporte.Text = inv.buscar(nombre);

            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inv.reporte();
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = (txtNombre.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int costo = Convert.ToInt32(txtPrecio.Text);
            int pos = Convert.ToInt32(txtPos.Text);

            inv.insertar(codigo, nombre, cantidad, costo, pos);

            txtNombre.Text = "";
        }

        private void cmdalInicio_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = (txtNombre.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int costo = Convert.ToInt32(txtPrecio.Text);

            inv.agregaInicio(codigo, nombre, cantidad, costo);

            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void cmdalFinal_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = (txtNombre.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int costo = Convert.ToInt32(txtPrecio.Text);

            inv.agregaFinal(codigo, nombre, cantidad, costo);

            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void cmdInverso_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inv.reporteInverso();
        }

        private void cmdDelInicio_Click(object sender, EventArgs e)
        {
            inv.eliminarInicio();
        }

        private void cmdDelFin_Click(object sender, EventArgs e)
        {
            inv.eliminarFinal();
        }
    }
}
