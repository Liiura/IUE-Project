using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace Consultorio_jrd
{

    public partial class frmregister : Form
    {
        public SqlConnection cn;
       
        public frmregister()
        {
            InitializeComponent();
            txtgenerico.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            txtcontraseña.Visible = false;
            txtcod.Visible = false;
            label9.Visible = false;
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\Proyecto_poo\\Consultorio_IUE.mdf;Integrated Security=True;Connect Timeout=30");
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Cbxuser_Leave(object sender, EventArgs e)
        {
           
          
          if (cbxuser.Text.Equals("Secretaria"))
            {
                label8.Visible = false;
                txtcontraseña.Visible = false;
                txtgenerico.Visible = true;
                label7.Text = "Contraseña";
                label7.Visible = true;
                txtcod.Visible = false;
                label9.Visible = false;
            }
            else if(cbxuser.Text.Equals("Practicante") || cbxuser.Text.Equals("Asesor") || cbxuser.Text.Equals("Usuario"))
            {
                if (cbxuser.Text.Equals("Practicante"))
                {
                    label7.Text = "Código de asesor";
                    label7.Visible = true;
                    label8.Text = "Contraseña";
                    label8.Visible = true;
                    txtcontraseña.Visible = true;
                    txtcod.Visible = false;
                    label9.Visible = false;
                }
                if(cbxuser.Text.Equals("Asesor"))
                {
                    label7.Text = "Área";
                    label7.Visible = true;
                    label8.Text = "Contraseña";
                    label8.Visible = true;
                    txtcontraseña.Visible = true;
                    label9.Text = "Código de asesor";
                    label9.Visible = true;
                    txtcod.Visible = true;
                    
                }
               

                txtgenerico.Visible = true;

            }
        }

        private void BtnRegistar_Click(object sender, EventArgs e)
        {
            switch (cbxuser.Text)
            {
                case "Secretaria":
                    cn.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO SECRETARIA VALUES('" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtTelefono.Text + "','" + txtCorreo.Text +"','"+ txtgenerico.Text + "')",cn);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Secretaria registrada");
                    cn.Close();
                    Limpiar();
                    break;
                case "Asesor":
                    cn.Open();
                    SqlCommand comando1 = new SqlCommand("INSERT INTO ASESOR VALUES('" + txtcod.Text + "','" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtCorreo.Text + "','" + txtTelefono.Text + "','"+ txtgenerico.Text + "','"+ txtcontraseña.Text +"')", cn);
                    comando1.ExecuteNonQuery();
                    MessageBox.Show("Asesor registrado");
                    cn.Close();
                    Limpiar();
                    break;
                case "Practicante":
                    cn.Open();
                    SqlCommand comando2 = new SqlCommand("INSERT INTO Practicante VALUES('" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtCorreo.Text + "','" + txtTelefono.Text + "','" + txtgenerico.Text + "','" + txtcontraseña.Text + "')", cn);
                    comando2.ExecuteNonQuery();
                    MessageBox.Show("Practicante registrado");
                    cn.Close();
                    Limpiar();
                    break;
            }
        }
        public void Limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtgenerico.Text = "";
            txtgenerico.Text = "";
            txtcontraseña.Text = "";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    }

