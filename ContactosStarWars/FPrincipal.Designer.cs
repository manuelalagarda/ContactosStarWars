namespace ContactosStarWars
{
    partial class FPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.DataGridView();
            this.contactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skincolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haircolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eyecolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeworldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lstResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(50, 32);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(763, 23);
            this.txtFiltro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encuentra personajes de StarWars";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(19)))));
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(819, 31);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(111, 26);
            this.cmdBuscar.TabIndex = 3;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.AllowUserToAddRows = false;
            this.lstResultado.AllowUserToDeleteRows = false;
            this.lstResultado.AllowUserToResizeColumns = false;
            this.lstResultado.AllowUserToResizeRows = false;
            this.lstResultado.AutoGenerateColumns = false;
            this.lstResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.skincolorDataGridViewTextBoxColumn,
            this.haircolorDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.eyecolorDataGridViewTextBoxColumn,
            this.massDataGridViewTextBoxColumn,
            this.homeworldDataGridViewTextBoxColumn,
            this.birthyearDataGridViewTextBoxColumn});
            this.lstResultado.DataSource = this.contactoBindingSource;
            this.lstResultado.Location = new System.Drawing.Point(50, 97);
            this.lstResultado.MultiSelect = false;
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.ReadOnly = true;
            this.lstResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstResultado.Size = new System.Drawing.Size(763, 335);
            this.lstResultado.TabIndex = 7;
            // 
            // contactoBindingSource
            // 
            this.contactoBindingSource.DataSource = typeof(ContactosStarWars.Aplicacion.Contacto);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // skincolorDataGridViewTextBoxColumn
            // 
            this.skincolorDataGridViewTextBoxColumn.DataPropertyName = "skin_color";
            this.skincolorDataGridViewTextBoxColumn.HeaderText = "skin_color";
            this.skincolorDataGridViewTextBoxColumn.Name = "skincolorDataGridViewTextBoxColumn";
            this.skincolorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // haircolorDataGridViewTextBoxColumn
            // 
            this.haircolorDataGridViewTextBoxColumn.DataPropertyName = "hair_color";
            this.haircolorDataGridViewTextBoxColumn.HeaderText = "hair_color";
            this.haircolorDataGridViewTextBoxColumn.Name = "haircolorDataGridViewTextBoxColumn";
            this.haircolorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eyecolorDataGridViewTextBoxColumn
            // 
            this.eyecolorDataGridViewTextBoxColumn.DataPropertyName = "eye_color";
            this.eyecolorDataGridViewTextBoxColumn.HeaderText = "eye_color";
            this.eyecolorDataGridViewTextBoxColumn.Name = "eyecolorDataGridViewTextBoxColumn";
            this.eyecolorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // massDataGridViewTextBoxColumn
            // 
            this.massDataGridViewTextBoxColumn.DataPropertyName = "mass";
            this.massDataGridViewTextBoxColumn.HeaderText = "mass";
            this.massDataGridViewTextBoxColumn.Name = "massDataGridViewTextBoxColumn";
            this.massDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homeworldDataGridViewTextBoxColumn
            // 
            this.homeworldDataGridViewTextBoxColumn.DataPropertyName = "homeworld";
            this.homeworldDataGridViewTextBoxColumn.HeaderText = "homeworld";
            this.homeworldDataGridViewTextBoxColumn.Name = "homeworldDataGridViewTextBoxColumn";
            this.homeworldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthyearDataGridViewTextBoxColumn
            // 
            this.birthyearDataGridViewTextBoxColumn.DataPropertyName = "birth_year";
            this.birthyearDataGridViewTextBoxColumn.HeaderText = "birth_year";
            this.birthyearDataGridViewTextBoxColumn.Name = "birthyearDataGridViewTextBoxColumn";
            this.birthyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(961, 462);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(977, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(977, 500);
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My IMDB";
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridView lstResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skincolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haircolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eyecolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn massDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeworldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contactoBindingSource;
    }
}

