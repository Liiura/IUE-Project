namespace Consultorio_jrd
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbxuser = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnmini = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.Khaki;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(271, 102);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(472, 20);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "Usuario";
            this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Khaki;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(274, 158);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(474, 20);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Text = "Contraseña";
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(418, 266);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(190, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // cbxuser
            // 
            this.cbxuser.BackColor = System.Drawing.Color.Khaki;
            this.cbxuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxuser.FormattingEnabled = true;
            this.cbxuser.Items.AddRange(new object[] {
            "Asesor",
            "Practicante",
            "Secretaria"});
            this.cbxuser.Location = new System.Drawing.Point(273, 204);
            this.cbxuser.Name = "cbxuser";
            this.cbxuser.Size = new System.Drawing.Size(470, 29);
            this.cbxuser.TabIndex = 18;
            this.cbxuser.Text = "Seleccione tipo de usuario";
            // 
            // back
            // 
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(43, 34);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 17;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 380);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 380);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 271;
            this.lineShape1.X2 = 743;
            this.lineShape1.Y1 = 190;
            this.lineShape1.Y2 = 190;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 274;
            this.lineShape2.X2 = 745;
            this.lineShape2.Y1 = 134;
            this.lineShape2.Y2 = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(412, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Iniciar sesión";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Chocolate;
            this.linkLabel1.Location = new System.Drawing.Point(396, 331);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(241, 21);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Has olvidado la contraseña?";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncerrar.Location = new System.Drawing.Point(746, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(34, 40);
            this.btncerrar.TabIndex = 22;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnmini
            // 
            this.btnmini.BackColor = System.Drawing.Color.Transparent;
            this.btnmini.FlatAppearance.BorderSize = 0;
            this.btnmini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnmini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnmini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmini.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmini.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnmini.Location = new System.Drawing.Point(714, 0);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(34, 40);
            this.btnmini.TabIndex = 23;
            this.btnmini.Text = "—";
            this.btnmini.UseVisualStyleBackColor = false;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(780, 380);
            this.Controls.Add(this.btnmini);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxuser);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cbxuser;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnmini;
    }
}

