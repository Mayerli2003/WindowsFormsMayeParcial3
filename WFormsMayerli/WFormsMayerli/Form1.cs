using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFormsMayerli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Crear un registro
        private void Agregar_Click(object sender, EventArgs e)
        {
            using (SuperMercadoEntities dato = new SuperMercadoEntities())
            {
                Articulo oArticulo = new Articulo();
                oArticulo.nombre = textNombre.Text;
                oArticulo.descripcion = textDescripcion.Text;
                oArticulo.precio = decimal.Parse(textPrecio.Text);
                oArticulo.cantidad = int.Parse(textCantidad.Text);
                oArticulo.codigo = textCodigo.Text;
                oArticulo.proveedor = textProveedor.Text;
                oArticulo.estado = int.Parse(textEstado.Text);

                dato.Articulo.Add(oArticulo);
                dato.SaveChanges();
                MessageBox.Show("Se ha creado correctamente");
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
