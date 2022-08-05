namespace KaraokeDesktop
{
    partial class Catalogo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalCanciones = new System.Windows.Forms.Label();
            this.lblNumeroCanciones = new System.Windows.Forms.Label();
            this.dgvCanciones = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.lblNumeroCanciones);
            this.panel1.Controls.Add(this.lblTotalCanciones);
            this.panel1.Controls.Add(this.btnEliminarTodo);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 79);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(22, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 4);
            this.panel2.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.txtBuscar.Location = new System.Drawing.Point(22, 23);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(253, 30);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarTodo.FlatAppearance.BorderSize = 0;
            this.btnEliminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTodo.Image = global::KaraokeDesktop.Properties.Resources.escobaok;
            this.btnEliminarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarTodo.Location = new System.Drawing.Point(515, 23);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(181, 34);
            this.btnEliminarTodo.TabIndex = 4;
            this.btnEliminarTodo.Text = "Eliminar Todo";
            this.btnEliminarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::KaraokeDesktop.Properties.Resources.naranja;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(402, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 34);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KaraokeDesktop.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(281, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotalCanciones
            // 
            this.lblTotalCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCanciones.ForeColor = System.Drawing.Color.White;
            this.lblTotalCanciones.Location = new System.Drawing.Point(784, 30);
            this.lblTotalCanciones.Name = "lblTotalCanciones";
            this.lblTotalCanciones.Size = new System.Drawing.Size(150, 23);
            this.lblTotalCanciones.TabIndex = 5;
            this.lblTotalCanciones.Text = "Total Canciones:";
            this.lblTotalCanciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumeroCanciones
            // 
            this.lblNumeroCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCanciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.lblNumeroCanciones.Location = new System.Drawing.Point(940, 29);
            this.lblNumeroCanciones.Name = "lblNumeroCanciones";
            this.lblNumeroCanciones.Size = new System.Drawing.Size(65, 23);
            this.lblNumeroCanciones.TabIndex = 7;
            this.lblNumeroCanciones.Text = "0";
            this.lblNumeroCanciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCanciones
            // 
            this.dgvCanciones.AllowUserToAddRows = false;
            this.dgvCanciones.AllowUserToDeleteRows = false;
            this.dgvCanciones.AllowUserToResizeRows = false;
            this.dgvCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCanciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvCanciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCanciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCanciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanciones.ColumnHeadersVisible = false;
            this.dgvCanciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvCanciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCanciones.Location = new System.Drawing.Point(0, 79);
            this.dgvCanciones.Name = "dgvCanciones";
            this.dgvCanciones.ReadOnly = true;
            this.dgvCanciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCanciones.RowHeadersVisible = false;
            this.dgvCanciones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvCanciones.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCanciones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCanciones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCanciones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCanciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanciones.Size = new System.Drawing.Size(1024, 466);
            this.dgvCanciones.TabIndex = 1;
            this.dgvCanciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCanciones_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::KaraokeDesktop.Properties.Resources.borrar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 5;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCanciones);
            this.Controls.Add(this.panel1);
            this.Name = "Catalogo";
            this.Size = new System.Drawing.Size(1024, 545);
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Label lblNumeroCanciones;
        private System.Windows.Forms.Label lblTotalCanciones;
        private System.Windows.Forms.DataGridView dgvCanciones;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
