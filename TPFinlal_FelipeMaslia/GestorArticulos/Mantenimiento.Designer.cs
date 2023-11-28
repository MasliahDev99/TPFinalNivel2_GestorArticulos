namespace TPFinlal_FelipeMaslia.GestorArticulos
{
    partial class Mantenimiento
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
            this.dgv_Categoria = new System.Windows.Forms.DataGridView();
            this.dgv_Marcas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMant = new System.Windows.Forms.Panel();
            this.modificar = new FontAwesome.Sharp.IconButton();
            this.Eliminar = new FontAwesome.Sharp.IconButton();
            this.Tipos = new System.Windows.Forms.GroupBox();
            this.rb_ambas = new System.Windows.Forms.RadioButton();
            this.rb_soloCategoria = new System.Windows.Forms.RadioButton();
            this.rb_soloMarca = new System.Windows.Forms.RadioButton();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_nuevaCategoria = new System.Windows.Forms.TextBox();
            this.txt_nuevaMarca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).BeginInit();
            this.panelMant.SuspendLayout();
            this.Tipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Categoria
            // 
            this.dgv_Categoria.AllowUserToAddRows = false;
            this.dgv_Categoria.AllowUserToDeleteRows = false;
            this.dgv_Categoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgv_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Categoria.GridColor = System.Drawing.Color.Gray;
            this.dgv_Categoria.Location = new System.Drawing.Point(99, 71);
            this.dgv_Categoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Categoria.Name = "dgv_Categoria";
            this.dgv_Categoria.ReadOnly = true;
            this.dgv_Categoria.RowHeadersWidth = 51;
            this.dgv_Categoria.Size = new System.Drawing.Size(372, 443);
            this.dgv_Categoria.TabIndex = 0;
            // 
            // dgv_Marcas
            // 
            this.dgv_Marcas.AllowUserToAddRows = false;
            this.dgv_Marcas.AllowUserToDeleteRows = false;
            this.dgv_Marcas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgv_Marcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Marcas.GridColor = System.Drawing.Color.Gray;
            this.dgv_Marcas.Location = new System.Drawing.Point(525, 71);
            this.dgv_Marcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Marcas.Name = "dgv_Marcas";
            this.dgv_Marcas.ReadOnly = true;
            this.dgv_Marcas.RowHeadersWidth = 51;
            this.dgv_Marcas.Size = new System.Drawing.Size(361, 443);
            this.dgv_Marcas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(587, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marcas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categorías";
            // 
            // panelMant
            // 
            this.panelMant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMant.Controls.Add(this.modificar);
            this.panelMant.Controls.Add(this.Eliminar);
            this.panelMant.Controls.Add(this.Tipos);
            this.panelMant.Controls.Add(this.btn_add);
            this.panelMant.Controls.Add(this.txt_nuevaCategoria);
            this.panelMant.Controls.Add(this.txt_nuevaMarca);
            this.panelMant.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMant.Location = new System.Drawing.Point(1136, 0);
            this.panelMant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMant.Name = "panelMant";
            this.panelMant.Size = new System.Drawing.Size(441, 737);
            this.panelMant.TabIndex = 4;
            // 
            // modificar
            // 
            this.modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modificar.FlatAppearance.BorderSize = 0;
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.ForeColor = System.Drawing.Color.White;
            this.modificar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.modificar.IconColor = System.Drawing.Color.Goldenrod;
            this.modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modificar.IconSize = 32;
            this.modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificar.Location = new System.Drawing.Point(4, 442);
            this.modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modificar.Name = "modificar";
            this.modificar.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.modificar.Size = new System.Drawing.Size(209, 38);
            this.modificar.TabIndex = 14;
            this.modificar.Text = "Modificar";
            this.modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
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
            this.Eliminar.Location = new System.Drawing.Point(235, 442);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Eliminar.Size = new System.Drawing.Size(191, 38);
            this.Eliminar.TabIndex = 13;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Tipos
            // 
            this.Tipos.Controls.Add(this.rb_ambas);
            this.Tipos.Controls.Add(this.rb_soloCategoria);
            this.Tipos.Controls.Add(this.rb_soloMarca);
            this.Tipos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Tipos.Location = new System.Drawing.Point(72, 81);
            this.Tipos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tipos.Name = "Tipos";
            this.Tipos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tipos.Size = new System.Drawing.Size(288, 96);
            this.Tipos.TabIndex = 3;
            this.Tipos.TabStop = false;
            this.Tipos.Text = "Tipos";
            // 
            // rb_ambas
            // 
            this.rb_ambas.AutoSize = true;
            this.rb_ambas.Location = new System.Drawing.Point(93, 68);
            this.rb_ambas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_ambas.Name = "rb_ambas";
            this.rb_ambas.Size = new System.Drawing.Size(71, 20);
            this.rb_ambas.TabIndex = 2;
            this.rb_ambas.Text = "Ambas";
            this.rb_ambas.UseVisualStyleBackColor = true;
            this.rb_ambas.CheckedChanged += new System.EventHandler(this.rb_ambas_CheckedChanged);
            // 
            // rb_soloCategoria
            // 
            this.rb_soloCategoria.AutoSize = true;
            this.rb_soloCategoria.Location = new System.Drawing.Point(167, 23);
            this.rb_soloCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_soloCategoria.Name = "rb_soloCategoria";
            this.rb_soloCategoria.Size = new System.Drawing.Size(87, 20);
            this.rb_soloCategoria.TabIndex = 1;
            this.rb_soloCategoria.Text = "Categoría";
            this.rb_soloCategoria.UseVisualStyleBackColor = true;
            this.rb_soloCategoria.CheckedChanged += new System.EventHandler(this.rb_soloCategoria_CheckedChanged);
            // 
            // rb_soloMarca
            // 
            this.rb_soloMarca.AutoSize = true;
            this.rb_soloMarca.Checked = true;
            this.rb_soloMarca.Location = new System.Drawing.Point(8, 23);
            this.rb_soloMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_soloMarca.Name = "rb_soloMarca";
            this.rb_soloMarca.Size = new System.Drawing.Size(66, 20);
            this.rb_soloMarca.TabIndex = 0;
            this.rb_soloMarca.TabStop = true;
            this.rb_soloMarca.Text = "Marca";
            this.rb_soloMarca.UseVisualStyleBackColor = true;
            this.rb_soloMarca.CheckedChanged += new System.EventHandler(this.rb_soloMarca_CheckedChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(84, 351);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(276, 43);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_nuevaCategoria
            // 
            this.txt_nuevaCategoria.Enabled = false;
            this.txt_nuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevaCategoria.Location = new System.Drawing.Point(80, 270);
            this.txt_nuevaCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nuevaCategoria.Name = "txt_nuevaCategoria";
            this.txt_nuevaCategoria.Size = new System.Drawing.Size(280, 30);
            this.txt_nuevaCategoria.TabIndex = 1;
            this.txt_nuevaCategoria.Text = "Nueva Categoría";
            this.txt_nuevaCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nuevaCategoria.Enter += new System.EventHandler(this.txt_nuevaCategoria_Enter);
            this.txt_nuevaCategoria.Leave += new System.EventHandler(this.txt_nuevaCategoria_Leave);
            // 
            // txt_nuevaMarca
            // 
            this.txt_nuevaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevaMarca.Location = new System.Drawing.Point(80, 199);
            this.txt_nuevaMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nuevaMarca.Name = "txt_nuevaMarca";
            this.txt_nuevaMarca.Size = new System.Drawing.Size(280, 30);
            this.txt_nuevaMarca.TabIndex = 0;
            this.txt_nuevaMarca.Text = "Nueva Marca";
            this.txt_nuevaMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nuevaMarca.Enter += new System.EventHandler(this.txt_nuevaMarca_Enter);
            this.txt_nuevaMarca.Leave += new System.EventHandler(this.txt_nuevaMarca_Leave);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1577, 737);
            this.Controls.Add(this.panelMant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Marcas);
            this.Controls.Add(this.dgv_Categoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).EndInit();
            this.panelMant.ResumeLayout(false);
            this.panelMant.PerformLayout();
            this.Tipos.ResumeLayout(false);
            this.Tipos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Categoria;
        private System.Windows.Forms.DataGridView dgv_Marcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMant;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_nuevaCategoria;
        private System.Windows.Forms.TextBox txt_nuevaMarca;
        private System.Windows.Forms.GroupBox Tipos;
        private System.Windows.Forms.RadioButton rb_soloCategoria;
        private System.Windows.Forms.RadioButton rb_soloMarca;
        private System.Windows.Forms.RadioButton rb_ambas;
        private FontAwesome.Sharp.IconButton modificar;
        private FontAwesome.Sharp.IconButton Eliminar;
    }
}