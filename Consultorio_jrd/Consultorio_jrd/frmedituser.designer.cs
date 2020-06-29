namespace Consultorio_jrd
{
    partial class frmedituser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmedituser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btninsertar = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmini = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.dtgdatos = new System.Windows.Forms.DataGridView();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtestrato = new System.Windows.Forms.TextBox();
            this.txtcedsecre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnproceso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btninsertar
            // 
            this.btninsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btninsertar.FlatAppearance.BorderSize = 0;
            this.btninsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btninsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.ForeColor = System.Drawing.Color.Black;
            this.btninsertar.Location = new System.Drawing.Point(1044, 388);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(108, 30);
            this.btninsertar.TabIndex = 8;
            this.btninsertar.Text = "Guardar";
            this.btninsertar.UseVisualStyleBackColor = false;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.btnmini);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 41);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(471, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Usuarios registrados";
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
            this.btnmini.Location = new System.Drawing.Point(1170, 0);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(34, 40);
            this.btnmini.TabIndex = 23;
            this.btnmini.Text = "—";
            this.btnmini.UseVisualStyleBackColor = false;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
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
            this.btncerrar.Location = new System.Drawing.Point(1210, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(34, 40);
            this.btncerrar.TabIndex = 22;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // dtgdatos
            // 
            this.dtgdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgdatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgdatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(155)))));
            this.dtgdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgdatos.ColumnHeadersHeight = 30;
            this.dtgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgdatos.EnableHeadersVisualStyles = false;
            this.dtgdatos.Location = new System.Drawing.Point(21, 79);
            this.dtgdatos.Name = "dtgdatos";
            this.dtgdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgdatos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgdatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgdatos.Size = new System.Drawing.Size(745, 229);
            this.dtgdatos.TabIndex = 24;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.Black;
            this.btneditar.Location = new System.Drawing.Point(21, 336);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(108, 30);
            this.btneditar.TabIndex = 41;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.Location = new System.Drawing.Point(157, 336);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(108, 30);
            this.btneliminar.TabIndex = 42;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(898, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Registro y edición de usuarios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(857, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(856, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(856, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Correo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(998, 170);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(997, 203);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(195, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(998, 279);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(194, 23);
            this.txtCorreo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(866, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cedula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(997, 135);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(195, 23);
            this.txtCedula.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(855, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(997, 240);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(195, 23);
            this.txtTelefono.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(856, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Estrato";
            // 
            // txtestrato
            // 
            this.txtestrato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestrato.Location = new System.Drawing.Point(998, 313);
            this.txtestrato.Name = "txtestrato";
            this.txtestrato.Size = new System.Drawing.Size(194, 23);
            this.txtestrato.TabIndex = 6;
            // 
            // txtcedsecre
            // 
            this.txtcedsecre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcedsecre.Location = new System.Drawing.Point(998, 350);
            this.txtcedsecre.Name = "txtcedsecre";
            this.txtcedsecre.Size = new System.Drawing.Size(194, 23);
            this.txtcedsecre.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(820, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "cedula de secretaria";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 794;
            this.lineShape1.X2 = 794;
            this.lineShape1.Y1 = 74;
            this.lineShape1.Y2 = 444;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1244, 461);
            this.shapeContainer1.TabIndex = 44;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 795;
            this.lineShape4.X2 = 1221;
            this.lineShape4.Y1 = 444;
            this.lineShape4.Y2 = 444;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 1220;
            this.lineShape3.X2 = 1220;
            this.lineShape3.Y1 = 73;
            this.lineShape3.Y2 = 443;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 794;
            this.lineShape2.X2 = 1219;
            this.lineShape2.Y1 = 73;
            this.lineShape2.Y2 = 73;
            // 
            // btnproceso
            // 
            this.btnproceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnproceso.FlatAppearance.BorderSize = 0;
            this.btnproceso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btnproceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.btnproceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproceso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproceso.ForeColor = System.Drawing.Color.Black;
            this.btnproceso.Location = new System.Drawing.Point(289, 336);
            this.btnproceso.Name = "btnproceso";
            this.btnproceso.Size = new System.Drawing.Size(108, 30);
            this.btnproceso.TabIndex = 45;
            this.btnproceso.Text = "Crear proceso";
            this.btnproceso.UseVisualStyleBackColor = false;
            this.btnproceso.Click += new System.EventHandler(this.Btnproceso_Click);
            // 
            // frmedituser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1244, 461);
            this.Controls.Add(this.btnproceso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcedsecre);
            this.Controls.Add(this.txtestrato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgdatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmedituser";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmedituser_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnmini;
        private System.Windows.Forms.DataGridView dtgdatos;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtestrato;
        private System.Windows.Forms.TextBox txtcedsecre;
        private System.Windows.Forms.Label label8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button btnproceso;
    }
}

