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
    public partial class frmLogin : Form
    {
        public SqlConnection cn;
        public frmLogin()
        {
           
            InitializeComponent();
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Proyecto_poo\\Consultorio_IUE.mdf;Integrated Security=True;Connect Timeout=30");
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam,int lparam);

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
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

       

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            switch (cbxuser.Text)
            {
                case "Asesor":
                    cn.Open();
                    SqlCommand comando = new SqlCommand("SELECT * FROM Asesor WHERE correo='" + txtuser.Text + "'AND Contraseña='" + txtpassword.Text + "'", cn);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    da.Fill(dt);     
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Bienvenido " + dt.Rows[0][2]);
                        
                        String nom;
                        string ids;
                        ids = Convert.ToString(dt.Rows[0][6]);
                        nom = Convert.ToString(dt.Rows[0][2]);
                        frmasesor ase = new frmasesor(nom,ids);
                        ase.Show();
                        this.Close();
                    }
                    else
                    {
                        SqlCommand comandoS = new SqlCommand("SELECT * FROM Asesor WHERE correo='" + txtuser.Text + "'", cn);
                        SqlDataAdapter daS = new SqlDataAdapter(comandoS);
                        DataTable dtS = new DataTable();
                        daS.Fill(dtS);

                        try
                        {
                            if (dtS.Rows[0][4].Equals(txtuser.Text) && !dtS.Rows[0][7].Equals(txtpassword.Text))
                            {

                                MessageBox.Show("Contraseña ingresada incorrectamente");
                            }
                        }catch(Exception k)
                        {
                            MessageBox.Show("El usuario no existe");
                        }

                    }
                   
                       cn.Close();


                   
                    break;

                case "Practicante":
                    cn.Open();
                    SqlCommand comando1 = new SqlCommand("SELECT * FROM Practicante WHERE Correo='" + txtuser.Text + "'AND Contraseña='" + txtpassword.Text + "'", cn);
                    SqlDataAdapter da1 = new SqlDataAdapter(comando1);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    if (dt1.Rows.Count == 1)
                    {
                        MessageBox.Show("Bienvenido " + dt1.Rows[0][1]);
                        String nom;
                        nom = Convert.ToString(dt1.Rows[0][1]);
                        frmprac prac = new frmprac(nom, Convert.ToInt32(dt1.Rows[0][0]));
                        prac.Show();
                        this.Close();

                    }
                    else
                    {
                        SqlCommand comandoS = new SqlCommand("SELECT * FROM Practicante WHERE correo='" + txtuser.Text + "'", cn);
                        SqlDataAdapter daS = new SqlDataAdapter(comandoS);
                        DataTable dtS = new DataTable();
                        daS.Fill(dtS);

                        try
                        {
                            if (dtS.Rows[0][3].Equals(txtuser.Text) && !dtS.Rows[0][6].Equals(txtpassword.Text))
                            {

                                MessageBox.Show("Contraseña ingresada incorrectamente");
                            }
                        }
                        catch (Exception k)
                        {
                            MessageBox.Show("Usuario no existe");
                        }

                    }

                    cn.Close();


                    break;

                case "Secretaria":
                    cn.Open();
                    SqlCommand comando2 = new SqlCommand("SELECT * FROM Secretaria WHERE Correo='" + txtuser.Text + "'AND Contraseña='" + txtpassword.Text + "'", cn);
                    SqlDataAdapter da2 = new SqlDataAdapter(comando2);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    if (dt2.Rows.Count == 1)
                    {
                        MessageBox.Show("Bienvenida " + dt2.Rows[0][1]);
                        String nom;
                        nom = Convert.ToString(dt2.Rows[0][2]);
                        frmsecretariacs sec = new frmsecretariacs(nom);
                        sec.Show();
                        this.Close();

                    }
                    else
                    {
                        SqlCommand comandoS = new SqlCommand("SELECT * FROM Secretaria WHERE Correo='" + txtuser.Text + "'", cn);
                        SqlDataAdapter daS = new SqlDataAdapter(comandoS);
                        DataTable dtS = new DataTable();
                        daS.Fill(dtS);

                        try
                        {
                            if (dtS.Rows[0][4].Equals(txtuser.Text) && !dtS.Rows[0][5].Equals(txtpassword.Text))
                            {

                                MessageBox.Show("Contraseña ingresada incorrectamente");
                            }
                        }
                        catch (Exception k)
                        {
                            MessageBox.Show("Usuario no existe");
                        }

                    }

                    cn.Close();


                    break;
            }


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

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Contraseña")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Contraseña";
                txtpassword.ForeColor = Color.Black;
                txtpassword.UseSystemPasswordChar = false;
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
