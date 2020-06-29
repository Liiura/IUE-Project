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
    
    public partial class frmeditproce: Form
    {
        string secres;
        public SqlConnection cn;
        public Boolean s = false;
        DateTime fecha = DateTime.Now;
        int ids;

        public frmeditproce(string nombre, int id)
        {
            secres=nombre;
            ids = id;
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
            frmprac sec = new frmprac(secres,ids);
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
            comando = new SqlCommand("SELECT id_proceso, fecha_inicio,ced_user FROM Proceso where ced_practicante is null", cn);
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

            if (s == true)
            {
                try
                {
                    cn.Open();
                SqlCommand comando = new SqlCommand("update Proceso set ced_practicante='" + txtcedprac.Text + "', observaciones='" + txtobser.Text + "'where id_proceso='" + txtid_proceso.Text + "'", cn);
                comando.ExecuteNonQuery();
                    SqlCommand comando2 = new SqlCommand("INSERT INTO Tipo_proceso (area,id_proceso) VALUES('" + txtarea.Text + "','" + txtid_proceso.Text + "')", cn);
                    comando2.ExecuteNonQuery();
                    MessageBox.Show("Proceso conseguido exitosamente");
                    cn.Close();
                    Limpiar();
                    dtgdatos.DataSource = MostrarUser();
                    s = false;
                Mostrar();

                }
                catch (Exception s)
                {

                    MessageBox.Show("Error al tomar el proceso");

                }
            }

        }
 
        public void Limpiar()
        {
            txtid_proceso.Text = "";
            txtfechaini.Text = "";
            txtceduser.Text = "";
            txtcedprac.Text = "";
            txtobser.Text = "";
            txtarea.Text = "";
           
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgdatos.SelectedRows.Count > 0)
            {
                s = true;
                txtid_proceso.Text = dtgdatos.CurrentRow.Cells["id_proceso"].Value.ToString();
                txtfechaini.Text = dtgdatos.CurrentRow.Cells["fecha_inicio"].Value.ToString();
                txtceduser.Text = dtgdatos.CurrentRow.Cells["ced_user"].Value.ToString();   
            }
            else
            {
                MessageBox.Show("Seleccione una registro");
            }
        }


    }
}

//}