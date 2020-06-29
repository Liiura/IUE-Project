namespace Consultorio_jrd
{
    partial class frmsecretariacs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsecretariacs));
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.contenedor2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnpracticantes = new System.Windows.Forms.Button();
            this.btnasesores = new System.Windows.Forms.Button();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcabecera = new System.Windows.Forms.Panel();
            this.btnmini = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelcontenedor.SuspendLayout();
            this.contenedor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelcabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.Khaki;
            this.panelcontenedor.Controls.Add(this.contenedor2);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(202, 40);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(598, 410);
            this.panelcontenedor.TabIndex = 5;
            this.panelcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontenedor_Paint);
            this.panelcontenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panelcontenedor_MouseDown);
            // 
            // contenedor2
            // 
            this.contenedor2.Controls.Add(this.label2);
            this.contenedor2.Controls.Add(this.pictureBox2);
            this.contenedor2.Controls.Add(this.label1);
            this.contenedor2.Location = new System.Drawing.Point(145, 88);
            this.contenedor2.Name = "contenedor2";
            this.contenedor2.Size = new System.Drawing.Size(400, 261);
            this.contenedor2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "generico";
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
            this.label1.Size = new System.Drawing.Size(189, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenida";
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.Black;
            this.panelmenu.Controls.Add(this.btnpracticantes);
            this.panelmenu.Controls.Add(this.btnasesores);
            this.panelmenu.Controls.Add(this.btnusuarios);
            this.panelmenu.Controls.Add(this.pictureBox1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 40);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(202, 410);
            this.panelmenu.TabIndex = 4;
            this.panelmenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panelmenu_MouseDown);
            // 
            // btnpracticantes
            // 
            this.btnpracticantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpracticantes.FlatAppearance.BorderSize = 0;
            this.btnpracticantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpracticantes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpracticantes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpracticantes.Image = ((System.Drawing.Image)(resources.GetObject("btnpracticantes.Image")));
            this.btnpracticantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpracticantes.Location = new System.Drawing.Point(0, 221);
            this.btnpracticantes.Name = "btnpracticantes";
            this.btnpracticantes.Size = new System.Drawing.Size(202, 32);
            this.btnpracticantes.TabIndex = 3;
            this.btnpracticantes.Text = "Practicantes";
            this.btnpracticantes.UseVisualStyleBackColor = true;
            this.btnpracticantes.Click += new System.EventHandler(this.Btnpracticantes_Click);
            // 
            // btnasesores
            // 
            this.btnasesores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnasesores.FlatAppearance.BorderSize = 0;
            this.btnasesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnasesores.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnasesores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnasesores.Image = ((System.Drawing.Image)(resources.GetObject("btnasesores.Image")));
            this.btnasesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnasesores.Location = new System.Drawing.Point(0, 172);
            this.btnasesores.Name = "btnasesores";
            this.btnasesores.Size = new System.Drawing.Size(202, 32);
            this.btnasesores.TabIndex = 2;
            this.btnasesores.Text = "Asesores";
            this.btnasesores.UseVisualStyleBackColor = true;
            this.btnasesores.Click += new System.EventHandler(this.Btnasesores_Click);
            // 
            // btnusuarios
            // 
            this.btnusuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusuarios.FlatAppearance.BorderSize = 0;
            this.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuarios.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnusuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnusuarios.Image")));
            this.btnusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuarios.Location = new System.Drawing.Point(0, 123);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(202, 32);
            this.btnusuarios.TabIndex = 1;
            this.btnusuarios.Text = "Usuarios";
            this.btnusuarios.UseVisualStyleBackColor = true;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelcabecera
            // 
            this.panelcabecera.BackColor = System.Drawing.Color.Goldenrod;
            this.panelcabecera.Controls.Add(this.btnmini);
            this.panelcabecera.Controls.Add(this.btncerrar);
            this.panelcabecera.Controls.Add(this.pictureBox3);
            this.panelcabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcabecera.Location = new System.Drawing.Point(0, 0);
            this.panelcabecera.Name = "panelcabecera";
            this.panelcabecera.Size = new System.Drawing.Size(800, 40);
            this.panelcabecera.TabIndex = 3;
            this.panelcabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panelcabecera_MouseDown);
            // 
            // btnmini
            // 
            this.btnmini.BackColor = System.Drawing.Color.Transparent;
            this.btnmini.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmini.FlatAppearance.BorderSize = 0;
            this.btnmini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnmini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnmini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmini.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmini.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnmini.Location = new System.Drawing.Point(732, 0);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(34, 40);
            this.btnmini.TabIndex = 27;
            this.btnmini.Text = "—";
            this.btnmini.UseVisualStyleBackColor = false;
            this.btnmini.Click += new System.EventHandler(this.Btnmini_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncerrar.Location = new System.Drawing.Point(766, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(34, 40);
            this.btncerrar.TabIndex = 26;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmsecretariacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panelcabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsecretariacs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsecretariacs";
            this.panelcontenedor.ResumeLayout(false);
            this.contenedor2.ResumeLayout(false);
            this.contenedor2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelcabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Panel contenedor2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btnasesores;
        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelcabecera;
        private System.Windows.Forms.Button btnpracticantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnmini;
        private System.Windows.Forms.Button btncerrar;
    }
}