namespace Consultorio_jrd
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelcabecera = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.brnRegistro = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.contenedor2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelcabecera.SuspendLayout();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelcontenedor.SuspendLayout();
            this.contenedor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcabecera
            // 
            this.panelcabecera.BackColor = System.Drawing.Color.Goldenrod;
            this.panelcabecera.Controls.Add(this.minimizar);
            this.panelcabecera.Controls.Add(this.maximizar);
            this.panelcabecera.Controls.Add(this.button1);
            this.panelcabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcabecera.Location = new System.Drawing.Point(0, 0);
            this.panelcabecera.Name = "panelcabecera";
            this.panelcabecera.Size = new System.Drawing.Size(800, 40);
            this.panelcabecera.TabIndex = 0;
            this.panelcabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelcabecera_MouseDown);
            // 
            // minimizar
            // 
            this.minimizar.BackColor = System.Drawing.Color.Transparent;
            this.minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimizar.Location = new System.Drawing.Point(698, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(34, 40);
            this.minimizar.TabIndex = 2;
            this.minimizar.Text = "—";
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.BackColor = System.Drawing.Color.Transparent;
            this.maximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maximizar.Location = new System.Drawing.Point(732, 0);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(34, 40);
            this.maximizar.TabIndex = 1;
            this.maximizar.Text = "+";
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(766, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.Black;
            this.panelmenu.Controls.Add(this.brnRegistro);
            this.panelmenu.Controls.Add(this.btnLogin);
            this.panelmenu.Controls.Add(this.pictureBox1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 40);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(160, 410);
            this.panelmenu.TabIndex = 1;
            this.panelmenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmenu_MouseDown);
            // 
            // brnRegistro
            // 
            this.brnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brnRegistro.FlatAppearance.BorderSize = 0;
            this.brnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnRegistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.brnRegistro.Image = ((System.Drawing.Image)(resources.GetObject("brnRegistro.Image")));
            this.brnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnRegistro.Location = new System.Drawing.Point(0, 179);
            this.brnRegistro.Name = "brnRegistro";
            this.brnRegistro.Size = new System.Drawing.Size(157, 32);
            this.brnRegistro.TabIndex = 2;
            this.brnRegistro.Text = "Registrar";
            this.brnRegistro.UseVisualStyleBackColor = true;
            this.brnRegistro.Click += new System.EventHandler(this.BrnRegistro_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 123);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 32);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.Khaki;
            this.panelcontenedor.Controls.Add(this.contenedor2);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(160, 40);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(640, 410);
            this.panelcontenedor.TabIndex = 2;
            this.panelcontenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelcontenedor_MouseDown);
            this.panelcontenedor.Resize += new System.EventHandler(this.Panelcontenedor_Resize);
            // 
            // contenedor2
            // 
            this.contenedor2.Controls.Add(this.pictureBox2);
            this.contenedor2.Controls.Add(this.label1);
            this.contenedor2.Location = new System.Drawing.Point(145, 88);
            this.contenedor2.Name = "contenedor2";
            this.contenedor2.Size = new System.Drawing.Size(400, 261);
            this.contenedor2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(83, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panelcabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMenu_MouseDown);
            this.panelcabecera.ResumeLayout(false);
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelcontenedor.ResumeLayout(false);
            this.contenedor2.ResumeLayout(false);
            this.contenedor2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcabecera;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button brnRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Panel contenedor2;
    }
}