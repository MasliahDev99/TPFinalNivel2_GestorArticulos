namespace TPFinlal_FelipeMaslia.GestorArticulos
{
    partial class modificar
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cb_MarcaArticulo = new System.Windows.Forms.ComboBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.rich_descripcion = new System.Windows.Forms.RichTextBox();
            this.txt_codArticulo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_nombreArticulo = new System.Windows.Forms.TextBox();
            this.btn_cargarImagen = new System.Windows.Forms.Button();
            this.pb_imagenArticulo = new System.Windows.Forms.PictureBox();
            this.btn_seleccionarFoto = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(503, 404);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(100, 39);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(72, 363);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(235, 46);
            this.btn_agregar.TabIndex = 18;
            this.btn_agregar.Text = "Modificar Artículo";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(71, 135);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 29);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.Text = "Seleccione categoría";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 135);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Seleccione categoría";
            // 
            // txt_img
            // 
            this.txt_img.Location = new System.Drawing.Point(71, 320);
            this.txt_img.Margin = new System.Windows.Forms.Padding(4);
            this.txt_img.Name = "txt_img";
            this.txt_img.ReadOnly = true;
            this.txt_img.Size = new System.Drawing.Size(235, 22);
            this.txt_img.TabIndex = 19;
            this.txt_img.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_img.Leave += new System.EventHandler(this.txt_img_Leave);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(72, 101);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 29);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "Seleccione Marca";
            // 
            // cb_MarcaArticulo
            // 
            this.cb_MarcaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MarcaArticulo.FormattingEnabled = true;
            this.cb_MarcaArticulo.Location = new System.Drawing.Point(72, 101);
            this.cb_MarcaArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.cb_MarcaArticulo.Name = "cb_MarcaArticulo";
            this.cb_MarcaArticulo.Size = new System.Drawing.Size(197, 28);
            this.cb_MarcaArticulo.TabIndex = 13;
            this.cb_MarcaArticulo.Text = "Seleccione Marca";
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(71, 283);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(200, 28);
            this.txt_precio.TabIndex = 17;
            this.txt_precio.Text = "Precio";
            this.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // rich_descripcion
            // 
            this.rich_descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_descripcion.Location = new System.Drawing.Point(71, 172);
            this.rich_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.rich_descripcion.MaxLength = 150;
            this.rich_descripcion.Name = "rich_descripcion";
            this.rich_descripcion.Size = new System.Drawing.Size(220, 90);
            this.rich_descripcion.TabIndex = 16;
            this.rich_descripcion.Text = "Descripción del artículo";
            // 
            // txt_codArticulo
            // 
            this.txt_codArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codArticulo.Location = new System.Drawing.Point(71, 25);
            this.txt_codArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codArticulo.Name = "txt_codArticulo";
            this.txt_codArticulo.ReadOnly = true;
            this.txt_codArticulo.Size = new System.Drawing.Size(200, 26);
            this.txt_codArticulo.TabIndex = 9;
            this.txt_codArticulo.Text = "Código de artículo";
            this.txt_codArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(72, 66);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(200, 28);
            this.txt_nombre.TabIndex = 10;
            this.txt_nombre.Text = "Nombre de artículo";
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombreArticulo
            // 
            this.txt_nombreArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreArticulo.Location = new System.Drawing.Point(71, 66);
            this.txt_nombreArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreArticulo.Name = "txt_nombreArticulo";
            this.txt_nombreArticulo.Size = new System.Drawing.Size(200, 26);
            this.txt_nombreArticulo.TabIndex = 11;
            this.txt_nombreArticulo.Text = "Nombre de artículo";
            this.txt_nombreArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cargarImagen
            // 
            this.btn_cargarImagen.Location = new System.Drawing.Point(356, 320);
            this.btn_cargarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cargarImagen.Name = "btn_cargarImagen";
            this.btn_cargarImagen.Size = new System.Drawing.Size(51, 30);
            this.btn_cargarImagen.TabIndex = 20;
            this.btn_cargarImagen.Text = "+";
            this.btn_cargarImagen.UseVisualStyleBackColor = true;
            this.btn_cargarImagen.Click += new System.EventHandler(this.btn_cargarImagen_Click);
            // 
            // pb_imagenArticulo
            // 
            this.pb_imagenArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_imagenArticulo.Location = new System.Drawing.Point(356, 117);
            this.pb_imagenArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_imagenArticulo.Name = "pb_imagenArticulo";
            this.pb_imagenArticulo.Size = new System.Drawing.Size(211, 181);
            this.pb_imagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagenArticulo.TabIndex = 21;
            this.pb_imagenArticulo.TabStop = false;
            // 
            // btn_seleccionarFoto
            // 
            this.btn_seleccionarFoto.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btn_seleccionarFoto.IconColor = System.Drawing.Color.Blue;
            this.btn_seleccionarFoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_seleccionarFoto.IconSize = 28;
            this.btn_seleccionarFoto.Location = new System.Drawing.Point(325, 363);
            this.btn_seleccionarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_seleccionarFoto.Name = "btn_seleccionarFoto";
            this.btn_seleccionarFoto.Size = new System.Drawing.Size(95, 46);
            this.btn_seleccionarFoto.TabIndex = 22;
            this.btn_seleccionarFoto.UseVisualStyleBackColor = true;
            this.btn_seleccionarFoto.Click += new System.EventHandler(this.btn_seleccionarFoto_Click);
            // 
            // modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(619, 458);
            this.Controls.Add(this.btn_seleccionarFoto);
            this.Controls.Add(this.pb_imagenArticulo);
            this.Controls.Add(this.btn_cargarImagen);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_img);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cb_MarcaArticulo);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.rich_descripcion);
            this.Controls.Add(this.txt_codArticulo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_nombreArticulo);
            this.Controls.Add(this.btn_cerrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificar";
            this.Load += new System.EventHandler(this.modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_agregar;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox cb_MarcaArticulo;
        public System.Windows.Forms.TextBox txt_precio;
        public System.Windows.Forms.RichTextBox rich_descripcion;
        public System.Windows.Forms.TextBox txt_codArticulo;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.TextBox txt_nombreArticulo;
        private System.Windows.Forms.Button btn_cargarImagen;
        public System.Windows.Forms.TextBox txt_img;
        public System.Windows.Forms.PictureBox pb_imagenArticulo;
        private FontAwesome.Sharp.IconButton btn_seleccionarFoto;
    }
}