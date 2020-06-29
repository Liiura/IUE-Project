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
   
    public partial class frmasesor : Form
    {
        string secre;
        string ids;
        public frmasesor(string secre_, string id)
        {
            secre = secre_;
            ids = id;
            InitializeComponent();
            label2.Text = secre;
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

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            frmeditprocea user = new frmeditprocea(secre,ids);
            user.Show();
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
