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

namespace Mecatena.Clases
{

    public partial class Login : Form
    {
        Clases.ConexionBD cp = new Clases.ConexionBD();

        public Login()
        {
            InitializeComponent();
        }

        //Comandos para poder arrastrar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              if (txt_user.Text == "Root" && txt_password.Text == "1234"){
                  this.Hide();
                  Productos Productos = new Productos();
                  Productos.Show(); 
              }
              else{
                  MessageBox.Show("Error en credenciales. Intente de nuevo.");
                  txt_user.Text = "";
                  txt_password.Text = ""; 
              }
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

    }
    
    
}
