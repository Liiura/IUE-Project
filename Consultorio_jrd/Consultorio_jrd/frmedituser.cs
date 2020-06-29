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
    
    public partial class frmedituser : Form
    {
        string secres;
        public SqlConnection cn;
        public Boolean s = false;
        DateTime fecha = DateTime.Now;


        public frmedituser(string nombre)
        {
            secres=nombre;
            InitializeComponent();
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Proyecto_poo\\Consultorio_IUE.mdf;Integrated Security=True;Connect Timeout=30");
            
            Console.WriteLine(fecha);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmregister rs = new frmregister();
            rs.Show();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            frmsecretariacs sec = new frmsecretariacs(secres);
            sec.Show();
            this.Close();
        }




        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }



        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



       
        public DataTable Mostrar()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            cn.Open();
            comando = new SqlCommand("SELECT * FROM Usuario", cn);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            cn.Close();
            return tabla;
        }
        public DataTable MostrarUser()
        {
            DataTable tabla = new DataTable();
            tabla = Mostrar();
            return tabla;
        }

        private void frmedituser_Load(object sender, EventArgs e)
        {
            dtgdatos.DataSource = MostrarUser();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {

            if (s == false)
            {
                try
                {
                    cn.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO USUARIO VALUES('" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtCorreo.Text + "','" + txtTelefono.Text + "','" + txtestrato.Text + "','" + txtcedsecre.Text + "')", cn);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado ");
                    cn.Close();
                    Limpiar();
                    dtgdatos.DataSource = MostrarUser();

                }
                catch (Exception s)
                {

                    MessageBox.Show("Error al guardar el usuario");

                }
            }
            if (s == true)
                {
                  
                        cn.Open();
                        SqlCommand comando = new SqlCommand("update Usuario set cedula='" + txtCedula.Text + "', nombre='" + txtNombre.Text + "', apellido='" + txtApellido.Text + "', correo='" + txtCorreo.Text + "', telefono='" + txtTelefono.Text + "', estrato='" + txtestrato.Text + "', Cedula_secretaria='" + txtcedsecre.Text + "'where cedula='" + txtCedula.Text + "'", cn);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Información editada correctamente");
                        cn.Close();
                        dtgdatos.DataSource = MostrarUser();
                        Limpiar();
            }
        
        }
 
        public void Limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtestrato.Text = "";
            txtcedsecre.Text = "";
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgdatos.SelectedRows.Count > 0)
            {
                s = true;
                txtCedula.Text = dtgdatos.CurrentRow.Cells["cedula"].Value.ToString();
                txtNombre.Text = dtgdatos.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellido.Text = dtgdatos.CurrentRow.Cells["apellido"].Value.ToString();
                txtCorreo.Text = dtgdatos.CurrentRow.Cells["correo"].Value.ToString();
                txtTelefono.Text = dtgdatos.CurrentRow.Cells["telefono"].Value.ToString();
                txtestrato.Text = dtgdatos.CurrentRow.Cells["estrato"].Value.ToString();
                txtcedsecre.Text = dtgdatos.CurrentRow.Cells["Cedula_secretaria"].Value.ToString();
               
            }
            else
            {
                MessageBox.Show("Seleccione una fila por editar");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
            if (dtgdatos.SelectedRows.Count > 0)
            {
                DialogResult respuesta;
               respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?","Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand eliminar = new SqlCommand("delete from Usuario where cedula='" + dtgdatos.CurrentRow.Cells["cedula"].Value.ToString() + "'", cn);
                    eliminar.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Usuario eliminado satisfactoriamente");
                    dtgdatos.DataSource = MostrarUser();
                    Limpiar();

                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por eliminar");
            }
        }

        private void Btnproceso_Click(object sender, EventArgs e)
        {
            if (dtgdatos.SelectedRows.Count > 0)
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Está seguro que desea crear un nuevo proceso con el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand buscar = new SqlCommand("select * from Proceso where ced_user='" + dtgdatos.CurrentRow.Cells["cedula"].Value.ToString() + "'", cn);
                    SqlDataAdapter da = new SqlDataAdapter(buscar);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cn.Close();
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("El usuario con cédula " + dtgdatos.CurrentRow.Cells["cedula"].Value.ToString() + " tiene un proceso en curso actualmente");
                    }
                    else { 
                    string hoy = fecha.ToShortDateString();
                    cn.Open();
                    SqlCommand comando = new SqlCommand("insert into Proceso (fecha_inicio,ced_user) values ('" + hoy + "','" + dtgdatos.CurrentRow.Cells["cedula"].Value.ToString() + "')", cn);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El proceso ha sido creado ");
                    cn.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccione un usuario para crear un proceso");
            }
        }
    }
}

//}