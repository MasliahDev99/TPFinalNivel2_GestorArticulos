namespace TPFinlal_FelipeMaslia.GestorArticulos
{
    partial class ingresoArticulos
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
            this.cerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_seleccionarFoto = new FontAwesome.Sharp.IconButton();
            this.pb_imagenArticulo = new System.Windows.Forms.PictureBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.cb_MarcaArticulo = new System.Windows.Forms.ComboBox();
            this.btn_cargarImagen = new System.Windows.Forms.Button();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.rich_descripcion = new System.Windows.Forms.RichTextBox();
            this.txt_codArticulo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_nombreArticulo = new System.Windows.Forms.TextBox();
            this.dgvListadoAritculos = new System.Windows.Forms.DataGridView();
            this.modificar = new FontAwesome.Sharp.IconButton();
            this.Eliminar = new FontAwesome.Sharp.IconButton();
            this.pb_imagen = new System.Windows.Forms.PictureBox();
            this.ContenedorOp = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagenArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAritculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
            this.ContenedorOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.cerrar.IconColor = System.Drawing.Color.White;
            this.cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cerrar.IconSize = 32;
            this.cerrar.Location = new System.Drawing.Point(375, 4);
            this.cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(33, 31);
            this.cerrar.TabIndex = 0;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingreso ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btn_seleccionarFoto);
            this.panel1.Controls.Add(this.pb_imagenArticulo);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.cb_categoria);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Controls.Add(this.txt_img);
            this.panel1.Controls.Add(this.cb_marca);
            this.panel1.Controls.Add(this.cb_MarcaArticulo);
            this.panel1.Controls.Add(this.btn_cargarImagen);
            this.panel1.Controls.Add(this.txt_precio);
            this.panel1.Controls.Add(this.rich_descripcion);
            this.panel1.Controls.Add(this.txt_codArticulo);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.txt_nombreArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1351, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 774);
            this.panel1.TabIndex = 13;
            // 
            // btn_seleccionarFoto
            // 
            this.btn_seleccionarFoto.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btn_seleccionarFoto.IconColor = System.Drawing.Color.Blue;
            this.btn_seleccionarFoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_seleccionarFoto.IconSize = 28;
            this.btn_seleccionarFoto.Location = new System.Drawing.Point(301, 452);
            this.btn_seleccionarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_seleccionarFoto.Name = "btn_seleccionarFoto";
            this.btn_seleccionarFoto.Size = new System.Drawing.Size(95, 46);
            this.btn_seleccionarFoto.TabIndex = 16;
            this.btn_seleccionarFoto.UseVisualStyleBackColor = true;
            this.btn_seleccionarFoto.Click += new System.EventHandler(this.btn_seleccionarFoto_Click);
            // 
            // pb_imagenArticulo
            // 
            this.pb_imagenArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_imagenArticulo.Location = new System.Drawing.Point(53, 528);
            this.pb_imagenArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_imagenArticulo.Name = "pb_imagenArticulo";
            this.pb_imagenArticulo.Size = new System.Drawing.Size(332, 181);
            this.pb_imagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagenArticulo.TabIndex = 15;
            this.pb_imagenArticulo.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(53, 452);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(235, 46);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "Agregar Articulo";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cb_categoria
            // 
            this.cb_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(76, 228);
            this.cb_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(220, 30);
            this.cb_categoria.TabIndex = 3;
            this.cb_categoria.Text = "Seleccione categoría";
            this.cb_categoria.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.cb_categoria.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 228);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 30);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Seleccione categoría";
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // txt_img
            // 
            this.txt_img.Location = new System.Drawing.Point(76, 412);
            this.txt_img.Margin = new System.Windows.Forms.Padding(4);
            this.txt_img.Name = "txt_img";
            this.txt_img.ReadOnly = true;
            this.txt_img.Size = new System.Drawing.Size(235, 22);
            this.txt_img.TabIndex = 8;
            this.txt_img.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_img.Leave += new System.EventHandler(this.txt_img_Leave);
            // 
            // cb_marca
            // 
            this.cb_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(77, 193);
            this.cb_marca.Margin = new System.Windows.Forms.Padding(4);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(219, 30);
            this.cb_marca.TabIndex = 2;
            this.cb_marca.Text = "Seleccione Marca";
            this.cb_marca.SelectedIndexChanged += new System.EventHandler(this.cb_marca_SelectedIndexChanged);
            this.cb_marca.Enter += new System.EventHandler(this.cb_MarcaArticulo_Enter);
            this.cb_marca.Leave += new System.EventHandler(this.cb_MarcaArticulo_Leave);
            // 
            // cb_MarcaArticulo
            // 
            this.cb_MarcaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MarcaArticulo.FormattingEnabled = true;
            this.cb_MarcaArticulo.Location = new System.Drawing.Point(77, 193);
            this.cb_MarcaArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.cb_MarcaArticulo.Name = "cb_MarcaArticulo";
            this.cb_MarcaArticulo.Size = new System.Drawing.Size(197, 30);
            this.cb_MarcaArticulo.TabIndex = 2;
            this.cb_MarcaArticulo.Text = "Seleccione Marca";
            this.cb_MarcaArticulo.Enter += new System.EventHandler(this.cb_MarcaArticulo_Enter);
            this.cb_MarcaArticulo.Leave += new System.EventHandler(this.cb_MarcaArticulo_Leave);
            // 
            // btn_cargarImagen
            // 
            this.btn_cargarImagen.Location = new System.Drawing.Point(335, 407);
            this.btn_cargarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cargarImagen.Name = "btn_cargarImagen";
            this.btn_cargarImagen.Size = new System.Drawing.Size(51, 30);
            this.btn_cargarImagen.TabIndex = 6;
            this.btn_cargarImagen.Text = "+";
            this.btn_cargarImagen.UseVisualStyleBackColor = true;
            this.btn_cargarImagen.Click += new System.EventHandler(this.btn_cargarImagen_Click_1);
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(76, 375);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(200, 28);
            this.txt_precio.TabIndex = 5;
            this.txt_precio.Text = "Precio";
            this.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_precio.Enter += new System.EventHandler(this.txt_precio_Enter);
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            this.txt_precio.Leave += new System.EventHandler(this.txt_precio_Leave);
            // 
            // rich_descripcion
            // 
            this.rich_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_descripcion.Location = new System.Drawing.Point(76, 265);
            this.rich_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.rich_descripcion.MaxLength = 150;
            this.rich_descripcion.Name = "rich_descripcion";
            this.rich_descripcion.Size = new System.Drawing.Size(220, 90);
            this.rich_descripcion.TabIndex = 4;
            this.rich_descripcion.Text = "Descripción del artículo";
            this.rich_descripcion.Enter += new System.EventHandler(this.rich_descripcion_Enter);
            this.rich_descripcion.Leave += new System.EventHandler(this.rich_descripcion_Leave);
            // 
            // txt_codArticulo
            // 
            this.txt_codArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codArticulo.Location = new System.Drawing.Point(76, 117);
            this.txt_codArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codArticulo.MaxLength = 50;
            this.txt_codArticulo.Name = "txt_codArticulo";
            this.txt_codArticulo.Size = new System.Drawing.Size(220, 28);
            this.txt_codArticulo.TabIndex = 0;
            this.txt_codArticulo.Text = "Código de artículo";
            this.txt_codArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_codArticulo.Enter += new System.EventHandler(this.txt_codArticulo_Enter);
            this.txt_codArticulo.Leave += new System.EventHandler(this.txt_codArticulo_Leave);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(77, 159);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(219, 28);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "Nombre de artículo";
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombreArticulo_Enter);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombreArticulo_Leave);
            // 
            // txt_nombreArticulo
            // 
            this.txt_nombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreArticulo.Location = new System.Drawing.Point(76, 159);
            this.txt_nombreArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreArticulo.Name = "txt_nombreArticulo";
            this.txt_nombreArticulo.Size = new System.Drawing.Size(200, 28);
            this.txt_nombreArticulo.TabIndex = 1;
            this.txt_nombreArticulo.Text = "Nombre de artículo";
            this.txt_nombreArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nombreArticulo.Enter += new System.EventHandler(this.txt_nombreArticulo_Enter);
            this.txt_nombreArticulo.Leave += new System.EventHandler(this.txt_nombreArticulo_Leave);
            // 
            // dgvListadoAritculos
            // 
            this.dgvListadoAritculos.AllowUserToAddRows = false;
            this.dgvListadoAritculos.AllowUserToDeleteRows = false;
            this.dgvListadoAritculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoAritculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListadoAritculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoAritculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvListadoAritculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoAritculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAritculos.Location = new System.Drawing.Point(16, 105);
            this.dgvListadoAritculos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListadoAritculos.Name = "dgvListadoAritculos";
            this.dgvListadoAritculos.ReadOnly = true;
            this.dgvListadoAritculos.RowHeadersWidth = 51;
            this.dgvListadoAritculos.Size = new System.Drawing.Size(1067, 491);
            this.dgvListadoAritculos.TabIndex = 14;
            this.dgvListadoAritculos.SelectionChanged += new System.EventHandler(this.dgvListadoAritculos_SelectionChanged);
            // 
            // modificar
            // 
            this.modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modificar.FlatAppearance.BorderSize = 0;
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.ForeColor = System.Drawing.Color.White;
            this.modificar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.modificar.IconColor = System.Drawing.Color.Goldenrod;
            this.modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modificar.IconSize = 32;
            this.modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificar.Location = new System.Drawing.Point(4, 17);
            this.modificar.Margin = new System.Windows.Forms.Padding(4);
            this.modificar.Name = "modificar";
            this.modificar.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.modificar.Size = new System.Drawing.Size(212, 52);
            this.modificar.TabIndex = 15;
            this.modificar.Text = "Modificar";
            this.modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.White;
            this.Eliminar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Eliminar.IconColor = System.Drawing.Color.Red;
            this.Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Eliminar.IconSize = 32;
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.Location = new System.Drawing.Point(263, 17);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Eliminar.Size = new System.Drawing.Size(204, 49);
            this.Eliminar.TabIndex = 16;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // pb_imagen
            // 
            this.pb_imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_imagen.Location = new System.Drawing.Point(1091, 105);
            this.pb_imagen.Margin = new System.Windows.Forms.Padding(4);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(245, 491);
            this.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagen.TabIndex = 17;
            this.pb_imagen.TabStop = false;
            // 
            // ContenedorOp
            // 
            this.ContenedorOp.Controls.Add(this.Eliminar);
            this.ContenedorOp.Controls.Add(this.modificar);
            this.ContenedorOp.Location = new System.Drawing.Point(375, 603);
            this.ContenedorOp.Margin = new System.Windows.Forms.Padding(4);
            this.ContenedorOp.Name = "ContenedorOp";
            this.ContenedorOp.Size = new System.Drawing.Size(471, 82);
            this.ContenedorOp.TabIndex = 18;
            // 
            // ingresoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1763, 774);
            this.Controls.Add(this.ContenedorOp);
            this.Controls.Add(this.pb_imagen);
            this.Controls.Add(this.dgvListadoAritculos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ingresoArticulos";
            this.Text = "fornularioIngresoArticulo";
            this.Load += new System.EventHandler(this.ingresoArticulos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagenArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAritculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            this.ContenedorOp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_agregar;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_img;
        public System.Windows.Forms.ComboBox cb_MarcaArticulo;
        private System.Windows.Forms.Button btn_cargarImagen;
        public System.Windows.Forms.TextBox txt_precio;
        public System.Windows.Forms.RichTextBox rich_descripcion;
        public System.Windows.Forms.TextBox txt_codArticulo;
        public System.Windows.Forms.TextBox txt_nombreArticulo;
        public System.Windows.Forms.ComboBox cb_categoria;
        public System.Windows.Forms.ComboBox cb_marca;
        public System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pb_imagenArticulo;
        private FontAwesome.Sharp.IconButton modificar;
        private FontAwesome.Sharp.IconButton Eliminar;
        public System.Windows.Forms.DataGridView dgvListadoAritculos;
        private System.Windows.Forms.PictureBox pb_imagen;
        private System.Windows.Forms.Panel ContenedorOp;
        private FontAwesome.Sharp.IconButton btn_seleccionarFoto;
    }
}