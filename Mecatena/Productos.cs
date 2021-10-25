using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Mecatena
{
    public partial class Productos : Form
    {
        Clases.ConexionBD cp = new Clases.ConexionBD();
        public Clases.ConexionProductos productoSeleccionado { get; set; }

        public Productos()
        {
            InitializeComponent();
        }
        //Comandos para poder arrastrar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void Productos_Load(object sender, EventArgs e)
        {
            try
            {
                if (cp.AbrirConexion() == true)
                {
                    ListarProductos(cp.conexion, txt_tipo.Text, txt_cantidad.Text, txt_descripcion.Text, txt_precioU.Text, txt_total.Text);
                    cp.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No hay una conexion a BD abierta");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListarProductos(MySqlConnection conexion, string ptipo, string pcantidad, string pdescripcion, string pprecioUnitario, string ptotal)
        {
            dgv_datos.DataSource = Clases.ConexionProductos.Buscar(conexion, ptipo, pcantidad, pdescripcion, pprecioUnitario, ptotal);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cp.AbrirConexion() == true)
                {

                    Clases.ConexionProductos pproducto = new Clases.ConexionProductos();

                    pproducto.tipo = txt_tipo.Text;
                    pproducto.cantidad = txt_cantidad.Text;
                    pproducto.descripcion = txt_descripcion.Text;
                    pproducto.precioUnitario = txt_precioU.Text;
                    pproducto.total = txt_total.Text;

                    int codigoResultado;

                    if (string.IsNullOrEmpty(txt_producto.Text))
                    {
                        codigoResultado = Clases.ConexionProductos.AltaProducto(cp.conexion, pproducto);
                    }
                    else
                    {
                        pproducto.idproducto = Convert.ToInt32(txt_producto.Text); 
                        codigoResultado = Clases.ConexionProductos.CambioProducto(cp.conexion, pproducto);
                    }

                   
                    if (codigoResultado > 0)
                    {
                        txt_producto.Clear();
                        txt_tipo.Clear();
                        txt_cantidad.Clear();
                        txt_descripcion.Clear();
                        txt_precioU.Clear();
                        txt_total.Clear();
                        ListarProductos(cp.conexion, txt_tipo.Text, txt_cantidad.Text, txt_descripcion.Text, txt_precioU.Text, txt_total.Text);
                    }

                    cp.CerrarConexion();

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cp.AbrirConexion() == true)
                {
                    ListarProductos(cp.conexion, txt_tipo.Text, txt_cantidad.Text, txt_descripcion.Text, txt_precioU.Text, txt_total.Text);
                    cp.CerrarConexion();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_datos.SelectedRows.Count == 1)
                {
                    int idProducto = Convert.ToInt32(dgv_datos.CurrentRow.Cells[0].Value);

                    if (cp.AbrirConexion() == true)
                    {
                        productoSeleccionado = Clases.ConexionProductos.obtenerProducto(cp.conexion, idProducto);
                        txt_producto.Text = productoSeleccionado.idproducto.ToString(); 
                        txt_tipo.Text = productoSeleccionado.tipo;
                        txt_cantidad.Text = productoSeleccionado.cantidad;
                        txt_descripcion.Text = productoSeleccionado.descripcion;
                        txt_precioU.Text = productoSeleccionado.precioUnitario;
                        txt_total.Text = productoSeleccionado.total;
                    }

                    if (cp.CerrarConexion() == true)
                    {
                    }

                }
                else
                {
                    MessageBox.Show("Debes seleccionar un registro");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_datos.SelectedRows.Count == 1)
                {
                    int idProducto = Convert.ToInt32(dgv_datos.CurrentRow.Cells[0].Value);

                    DialogResult confirmDelete = MessageBox.Show("SE ELIMINARÁ EL REGISTRO: " + idProducto + ", ¿DESEA CONTINUAR?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo);

                    if (confirmDelete == DialogResult.Yes)
                    {
                        if (cp.AbrirConexion() == true)
                        {
                            int resultado;
                            resultado = Clases.ConexionProductos.BajaProducto(cp.conexion, idProducto);
                            if (resultado > 0)
                            {
                                txt_producto.Clear();
                                txt_tipo.Clear();
                                txt_cantidad.Clear();
                                txt_descripcion.Clear();
                                txt_precioU.Clear();
                                txt_total.Clear();
                                ListarProductos(cp.conexion, txt_tipo.Text, txt_cantidad.Text, txt_descripcion.Text, txt_precioU.Text, txt_total.Text);
                                cp.CerrarConexion();
                            }
                        }
                    }
                    else
                    {
                        cp.AbrirConexion();
                        MessageBox.Show("ELIMINACIÓN CANCELADA");
                        txt_producto.Clear();
                        txt_tipo.Clear();
                        txt_cantidad.Clear();
                        txt_descripcion.Clear();
                        txt_precioU.Clear();
                        txt_total.Clear();
                        ListarProductos(cp.conexion, txt_tipo.Text, txt_cantidad.Text, txt_descripcion.Text, txt_precioU.Text, txt_total.Text);
                        cp.CerrarConexion();
                    }
                }
                else
                {
                    MessageBox.Show("DEBES SELECCIONAR UN REGISTRO");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
