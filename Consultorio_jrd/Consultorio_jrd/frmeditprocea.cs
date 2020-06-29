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
    
    public partial class frmeditprocea: Form
    {
        string secres;
        public SqlConnection cn;
        public Boolean s = false;
        DateTime fecha = DateTime.Now;
       string ids;

        public frmeditprocea(string nombre, string id)
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
            frmasesor sec = new frmasesor(secres,ids);
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
            comando = new SqlCommand("SELECT Proceso.id_proceso, Proceso.fecha_inicio, Proceso.fecha_final,Proceso.ced_user,Proceso.observaciones, Proceso.ced_practicante, Tipo_Proceso.area FROM Proceso inner join Tipo_Proceso on tipo_Proceso.id_proceso=Proceso.id_proceso where Proceso.visto_bueno is null and Tipo_proceso.area='" + ids + "'", cn);
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
                    SqlCommand comando = new SqlCommand("update Proceso set recomendaciones='" + txtreco.Text + "'where id_proceso='" + txtid_proceso.Text + "'", cn);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Recomendaciones ingresadas exitosamente");
                    cn.Close();
                    Limpiar();
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
            txtobser.Text = "";
            txtreco.Text = "";



        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgdatos.SelectedRows.Count > 0)
            {
                s = true;
                txtid_proceso.Text = dtgdatos.CurrentRow.Cells["id_proceso"].Value.ToString();
                txtobser.Text = dtgdatos.CurrentRow.Cells["observaciones"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una registro");
            }
        }

        private void btnvisto_bueno_Click(object sender, EventArgs e)
        {
            if (dtgdatos.SelectedRows.Count > 0)
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Está seguro que desea dar el visto bueno a este proceso proceso ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand veri = new SqlCommand("select * from Proceso where id_proceso='" + dtgdatos.CurrentRow.Cells["id_proceso"].Value.ToString() + "'", cn);
                    SqlDataAdapter da = new SqlDataAdapter(veri);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cn.Close();
                    MessageBox.Show("" + dt.Rows[0][6]);
                    if (Convert.ToString(dt.Rows[0][6]) == "")
                    {
                       
                        cn.Open();
                        string hoy = fecha.ToShortDateString();
                        SqlCommand comando = new SqlCommand("update Proceso  set visto_bueno = 1 where id_proceso='" + dtgdatos.CurrentRow.Cells["id_proceso"].Value.ToString() + "'", cn);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Visto bueno ingresado ");
                        cn.Close();
                        dtgdatos.DataSource = MostrarUser();
                    }
                    else {
                        MessageBox.Show("Este proceso ya tiene un visto bueno ");
                    }
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila ");
            }
        }
    }
}

//}