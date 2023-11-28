namespace TPFinlal_FelipeMaslia.GestorArticulos
{
    partial class buscarArticulo
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
            this.DGV_ListadoArticulos = new System.Windows.Forms.DataGridView();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.cb_filtros = new System.Windows.Forms.CheckBox();
            this.btn_detalleART = new FontAwesome.Sharp.IconButton();
            this.Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnBuscarFiltros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fPrecioMin = new System.Windows.Forms.TextBox();
            this.txt_fPrecioMax = new System.Windows.Forms.TextBox();
            this.ContenedorFiltros = new System.Windows.Forms.Panel();
            this.pb_imagen = new System.Windows.Forms.PictureBox();
            this.btn_bs = new System.Windows.Forms.Button();
            this.btn_recargar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListadoArticulos)).BeginInit();
            this.ContenedorFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
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
            this.cerrar.Location = new System.Drawing.Point(1713, 15);
            this.cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(33, 31);
            this.cerrar.TabIndex = 1;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // DGV_ListadoArticulos
            // 
            this.DGV_ListadoArticulos.AllowUserToAddRows = false;
            this.DGV_ListadoArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_ListadoArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_ListadoArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DGV_ListadoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_ListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListadoArticulos.Location = new System.Drawing.Point(357, 135);
            this.DGV_ListadoArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_ListadoArticulos.Name = "DGV_ListadoArticulos";
            this.DGV_ListadoArticulos.ReadOnly = true;
            this.DGV_ListadoArticulos.RowHeadersWidth = 51;
            this.DGV_ListadoArticulos.Size = new System.Drawing.Size(784, 357);
            this.DGV_ListadoArticulos.TabIndex = 3;
            this.DGV_ListadoArticulos.SelectionChanged += new System.EventHandler(this.DGV_ListadoArticulos_SelectionChanged);
            // 
            // txt_buscador
            // 
            this.txt_buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscador.Location = new System.Drawing.Point(357, 74);
            this.txt_buscador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_buscador.MaxLength = 50;
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(273, 34);
            this.txt_buscador.TabIndex = 4;
            this.txt_buscador.Text = "Buscar..";
            this.txt_buscador.Enter += new System.EventHandler(this.txt_buscador_Enter);
            this.txt_buscador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscador_KeyDown);
            this.txt_buscador.Leave += new System.EventHandler(this.txt_buscador_Leave);
            // 
            // cb_filtros
            // 
            this.cb_filtros.AutoSize = true;
            this.cb_filtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filtros.ForeColor = System.Drawing.Color.White;
            this.cb_filtros.Location = new System.Drawing.Point(884, 82);
            this.cb_filtros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_filtros.Name = "cb_filtros";
            this.cb_filtros.Size = new System.Drawing.Size(199, 28);
            this.cb_filtros.TabIndex = 8;
            this.cb_filtros.Text = "Filtros de búsqueda";
            this.cb_filtros.UseVisualStyleBackColor = true;
            this.cb_filtros.CheckedChanged += new System.EventHandler(this.cb_filtros_CheckedChanged);
            // 
            // btn_detalleART
            // 
            this.btn_detalleART.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_detalleART.FlatAppearance.BorderSize = 0;
            this.btn_detalleART.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detalleART.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalleART.ForeColor = System.Drawing.Color.White;
            this.btn_detalleART.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btn_detalleART.IconColor = System.Drawing.Color.MediumBlue;
            this.btn_detalleART.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_detalleART.IconSize = 32;
            this.btn_detalleART.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_detalleART.Location = new System.Drawing.Point(941, 500);
            this.btn_detalleART.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_detalleART.Name = "btn_detalleART";
            this.btn_detalleART.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btn_detalleART.Size = new System.Drawing.Size(244, 38);
            this.btn_detalleART.TabIndex = 9;
            this.btn_detalleART.Text = "Ver detalle";
            this.btn_detalleART.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_detalleART.UseVisualStyleBackColor = true;
            this.btn_detalleART.Click += new System.EventHandler(this.btn_detalleART_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.White;
            this.Eliminar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Eliminar.IconColor = System.Drawing.Color.Red;
            this.Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Eliminar.IconSize = 32;
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.Location = new System.Drawing.Point(741, 500);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Eliminar.Size = new System.Drawing.Size(192, 48);
            this.Eliminar.TabIndex = 10;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // btnBuscarFiltros
            // 
            this.btnBuscarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFiltros.Location = new System.Drawing.Point(92, 284);
            this.btnBuscarFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarFiltros.Name = "btnBuscarFiltros";
            this.btnBuscarFiltros.Size = new System.Drawing.Size(183, 36);
            this.btnBuscarFiltros.TabIndex = 5;
            this.btnBuscarFiltros.Text = "Buscar";
            this.btnBuscarFiltros.UseVisualStyleBackColor = true;
            this.btnBuscarFiltros.Click += new System.EventHandler(this.btnBuscarFiltros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtros de búsqueda";
            // 
            // txt_fPrecioMin
            // 
            this.txt_fPrecioMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fPrecioMin.Location = new System.Drawing.Point(67, 151);
            this.txt_fPrecioMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fPrecioMin.Name = "txt_fPrecioMin";
            this.txt_fPrecioMin.Size = new System.Drawing.Size(228, 29);
            this.txt_fPrecioMin.TabIndex = 9;
            this.txt_fPrecioMin.Text = "Precio Mínimo";
            this.txt_fPrecioMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fPrecioMin.TextChanged += new System.EventHandler(this.txt_fPrecioMin_TextChanged);
            this.txt_fPrecioMin.Enter += new System.EventHandler(this.txt_fPrecioMin_Enter);
            this.txt_fPrecioMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fPrecioMin_KeyPress);
            this.txt_fPrecioMin.Leave += new System.EventHandler(this.txt_fPrecioMin_Leave);
            // 
            // txt_fPrecioMax
            // 
            this.txt_fPrecioMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fPrecioMax.Location = new System.Drawing.Point(67, 201);
            this.txt_fPrecioMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fPrecioMax.Name = "txt_fPrecioMax";
            this.txt_fPrecioMax.Size = new System.Drawing.Size(228, 29);
            this.txt_fPrecioMax.TabIndex = 9;
            this.txt_fPrecioMax.Text = "Precio Máximo";
            this.txt_fPrecioMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fPrecioMax.Enter += new System.EventHandler(this.txt_fPrecioMax_Enter);
            this.txt_fPrecioMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fPrecioMax_KeyPress);
            this.txt_fPrecioMax.Leave += new System.EventHandler(this.txt_fPrecioMax_Leave);
            // 
            // ContenedorFiltros
            // 
            this.ContenedorFiltros.Controls.Add(this.txt_fPrecioMax);
            this.ContenedorFiltros.Controls.Add(this.txt_fPrecioMin);
            this.ContenedorFiltros.Controls.Add(this.label1);
            this.ContenedorFiltros.Controls.Add(this.btnBuscarFiltros);
            this.ContenedorFiltros.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContenedorFiltros.Location = new System.Drawing.Point(0, 0);
            this.ContenedorFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContenedorFiltros.Name = "ContenedorFiltros";
            this.ContenedorFiltros.Size = new System.Drawing.Size(349, 688);
            this.ContenedorFiltros.TabIndex = 7;
            this.ContenedorFiltros.Visible = false;
            // 
            // pb_imagen
            // 
            this.pb_imagen.Location = new System.Drawing.Point(1163, 135);
            this.pb_imagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(215, 352);
            this.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagen.TabIndex = 13;
            this.pb_imagen.TabStop = false;
            // 
            // btn_bs
            // 
            this.btn_bs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bs.Location = new System.Drawing.Point(679, 79);
            this.btn_bs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_bs.Name = "btn_bs";
            this.btn_bs.Size = new System.Drawing.Size(135, 31);
            this.btn_bs.TabIndex = 14;
            this.btn_bs.Text = "Buscar";
            this.btn_bs.UseVisualStyleBackColor = true;
            this.btn_bs.Click += new System.EventHandler(this.btn_bs_Click);
            // 
            // btn_recargar
            // 
            this.btn_recargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recargar.FlatAppearance.BorderSize = 0;
            this.btn_recargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recargar.ForeColor = System.Drawing.Color.White;
            this.btn_recargar.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btn_recargar.IconColor = System.Drawing.Color.Purple;
            this.btn_recargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_recargar.IconSize = 32;
            this.btn_recargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recargar.Location = new System.Drawing.Point(503, 498);
            this.btn_recargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btn_recargar.Size = new System.Drawing.Size(204, 49);
            this.btn_recargar.TabIndex = 15;
            this.btn_recargar.Text = "Recargar";
            this.btn_recargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_recargar.UseVisualStyleBackColor = true;
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // buscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1763, 688);
            this.Controls.Add(this.btn_recargar);
            this.Controls.Add(this.btn_bs);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.btn_detalleART);
            this.Controls.Add(this.pb_imagen);
            this.Controls.Add(this.cb_filtros);
            this.Controls.Add(this.ContenedorFiltros);
            this.Controls.Add(this.txt_buscador);
            this.Controls.Add(this.DGV_ListadoArticulos);
            this.Controls.Add(this.cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "buscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buscarArticulo";
            this.Load += new System.EventHandler(this.buscarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListadoArticulos)).EndInit();
            this.ContenedorFiltros.ResumeLayout(false);
            this.ContenedorFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton cerrar;
        private System.Windows.Forms.DataGridView DGV_ListadoArticulos;
        private System.Windows.Forms.TextBox txt_buscador;
        private System.Windows.Forms.CheckBox cb_filtros;
        private FontAwesome.Sharp.IconButton btn_detalleART;
        private FontAwesome.Sharp.IconButton Eliminar;
        private System.Windows.Forms.Button btnBuscarFiltros;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_fPrecioMin;
        public System.Windows.Forms.TextBox txt_fPrecioMax;
        private System.Windows.Forms.Panel ContenedorFiltros;
        private System.Windows.Forms.Button btn_bs;
        private FontAwesome.Sharp.IconButton btn_recargar;
        public System.Windows.Forms.PictureBox pb_imagen;
    }
}