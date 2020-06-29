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
namespace Consultorio_jrd
{
   
    public partial class frmprac : Form
    {
        string prac;
        int ids;
        public frmprac(string prac_, int id)
        {
            prac = prac_;
            ids = id;
            InitializeComponent();
            label2.Text = prac;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMenu mn = new frmMenu();
            this.Close();
            mn.Show();
        }

        private void Btnprocesos_Click(object sender, EventArgs e)
        {
            frmeditproce proce = new frmeditproce(prac,ids);
            this.Close();
            proce.Show();
        }

        private void Btninformacion_Click(object sender, EventArgs e)
        {
            frmeditmiproce miproc = new frmeditmiproce(prac,ids);
            miproc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmeditmiprocer miproc= new frmeditmiprocer(prac, ids);
            miproc.Show();
            this.Hide();
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnmini_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void Panelcabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panelcontenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panelmenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
