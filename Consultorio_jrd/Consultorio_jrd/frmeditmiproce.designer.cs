namespace Consultorio_jrd
{
    partial class frmeditmiproce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmeditmiproce));
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
            this.label4 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfechaini = new System.Windows.Forms.TextBox();
            this.txtceduser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid_proceso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtobser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcedprac = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnedi = new System.Windows.Forms.Button();
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
            this.btninsertar.Location = new System.Drawing.Point(943, 496);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(130, 30);
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
            this.panel1.Size = new System.Drawing.Size(1219, 41);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(543, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Procesos en curso";
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
            this.btnmini.Location = new System.Drawing.Point(1145, 1);
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
            this.btncerrar.Location = new System.Drawing.Point(1185, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(34, 40);
            this.btncerrar.TabIndex = 22;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // dtgdatos
            // 
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
            this.dtgdatos.Size = new System.Drawing.Size(648, 229);
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
            this.btneditar.Location = new System.Drawing.Point(21, 330);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(120, 30);
            this.btneditar.TabIndex = 41;
            this.btneditar.Text = "Editar proceso";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(882, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Toma de procesos";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 768;
            this.lineShape1.X2 = 768;
            this.lineShape1.Y1 = 74;
            this.lineShape1.Y2 = 542;
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
            this.shapeContainer1.Size = new System.Drawing.Size(1219, 556);
            this.shapeContainer1.TabIndex = 44;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 767;
            this.lineShape4.X2 = 1197;
            this.lineShape4.Y1 = 542;
            this.lineShape4.Y2 = 542;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 1198;
            this.lineShape3.X2 = 1199;
            this.lineShape3.Y1 = 72;
            this.lineShape3.Y2 = 541;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 768;
            this.lineShape2.X2 = 1197;
            this.lineShape2.Y1 = 73;
            this.lineShape2.Y2 = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(784, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Fecha inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cedula usuario:";
            // 
            // txtfechaini
            // 
            this.txtfechaini.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechaini.Location = new System.Drawing.Point(944, 166);
            this.txtfechaini.Name = "txtfechaini";
            this.txtfechaini.ReadOnly = true;
            this.txtfechaini.Size = new System.Drawing.Size(194, 23);
            this.txtfechaini.TabIndex = 2;
            // 
            // txtceduser
            // 
            this.txtceduser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtceduser.Location = new System.Drawing.Point(943, 202);
            this.txtceduser.Name = "txtceduser";
            this.txtceduser.ReadOnly = true;
            this.txtceduser.Size = new System.Drawing.Size(195, 23);
            this.txtceduser.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(788, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Id proceso:";
            // 
            // txtid_proceso
            // 
            this.txtid_proceso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_proceso.Location = new System.Drawing.Point(944, 134);
            this.txtid_proceso.Name = "txtid_proceso";
            this.txtid_proceso.ReadOnly = true;
            this.txtid_proceso.Size = new System.Drawing.Size(195, 23);
            this.txtid_proceso.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(817, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Observaciones:";
            // 
            // txtobser
            // 
            this.txtobser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobser.Location = new System.Drawing.Point(821, 354);
            this.txtobser.Multiline = true;
            this.txtobser.Name = "txtobser";
            this.txtobser.Size = new System.Drawing.Size(331, 126);
            this.txtobser.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(784, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Cedula practicante:";
            // 
            // txtcedprac
            // 
            this.txtcedprac.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcedprac.Location = new System.Drawing.Point(943, 238);
            this.txtcedprac.Name = "txtcedprac";
            this.txtcedprac.ReadOnly = true;
            this.txtcedprac.Size = new System.Drawing.Size(195, 23);
            this.txtcedprac.TabIndex = 46;
            // 
            // txtarea
            // 
            this.txtarea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarea.Location = new System.Drawing.Point(943, 275);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(195, 23);
            this.txtarea.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(788, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Area:";
            // 
            // btnedi
            // 
            this.btnedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btnedi.FlatAppearance.BorderSize = 0;
            this.btnedi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.btnedi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.btnedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedi.ForeColor = System.Drawing.Color.Black;
            this.btnedi.Location = new System.Drawing.Point(169, 330);
            this.btnedi.Name = "btnedi";
            this.btnedi.Size = new System.Drawing.Size(120, 30);
            this.btnedi.TabIndex = 49;
            this.btnedi.Text = "Finalizar proceso";
            this.btnedi.UseVisualStyleBackColor = false;
            this.btnedi.Click += new System.EventHandler(this.btnedi_Click);
            // 
            // frmeditmiproce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1219, 556);
            this.Controls.Add(this.btnedi);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcedprac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtobser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtid_proceso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtceduser);
            this.Controls.Add(this.txtfechaini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgdatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmeditmiproce";
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
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfechaini;
        private System.Windows.Forms.TextBox txtceduser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid_proceso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtobser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcedprac;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnedi;
    }
}

