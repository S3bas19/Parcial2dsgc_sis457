namespace CpParcial2dsgc
{
	partial class FrmSerie
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
			this.gbxDatos = new System.Windows.Forms.GroupBox();
			this.nudEpisodios = new System.Windows.Forms.NumericUpDown();
			this.txtSinopsis = new System.Windows.Forms.TextBox();
			this.txtDirector = new System.Windows.Forms.TextBox();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.lblFechaEstreno = new System.Windows.Forms.Label();
			this.lblepisodios = new System.Windows.Forms.Label();
			this.lblSinopsis = new System.Windows.Forms.Label();
			this.lblDirector = new System.Windows.Forms.Label();
			this.lblTtulo = new System.Windows.Forms.Label();
			this.pnlAcciones = new System.Windows.Forms.Panel();
			this.gbxLista = new System.Windows.Forms.GroupBox();
			this.dgvLista = new System.Windows.Forms.DataGridView();
			this.txtParametro = new System.Windows.Forms.TextBox();
			this.lblParametro = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpDirector = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpSinopsis = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpEpisodio = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpFechaEstreno = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbxDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).BeginInit();
			this.pnlAcciones.SuspendLayout();
			this.gbxLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDirector)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpEpisodio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxDatos
			// 
			this.gbxDatos.Controls.Add(this.dtpFechaEstreno);
			this.gbxDatos.Controls.Add(this.btnCancelar);
			this.gbxDatos.Controls.Add(this.btnGuardar);
			this.gbxDatos.Controls.Add(this.nudEpisodios);
			this.gbxDatos.Controls.Add(this.txtSinopsis);
			this.gbxDatos.Controls.Add(this.txtDirector);
			this.gbxDatos.Controls.Add(this.txtTitulo);
			this.gbxDatos.Controls.Add(this.lblFechaEstreno);
			this.gbxDatos.Controls.Add(this.lblepisodios);
			this.gbxDatos.Controls.Add(this.lblSinopsis);
			this.gbxDatos.Controls.Add(this.lblDirector);
			this.gbxDatos.Controls.Add(this.lblTtulo);
			this.gbxDatos.Location = new System.Drawing.Point(19, 409);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Size = new System.Drawing.Size(1202, 233);
			this.gbxDatos.TabIndex = 13;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos";
			// 
			// nudEpisodios
			// 
			this.nudEpisodios.Location = new System.Drawing.Point(185, 161);
			this.nudEpisodios.Name = "nudEpisodios";
			this.nudEpisodios.Size = new System.Drawing.Size(632, 26);
			this.nudEpisodios.TabIndex = 12;
			// 
			// txtSinopsis
			// 
			this.txtSinopsis.Location = new System.Drawing.Point(185, 120);
			this.txtSinopsis.Name = "txtSinopsis";
			this.txtSinopsis.Size = new System.Drawing.Size(632, 26);
			this.txtSinopsis.TabIndex = 9;
			// 
			// txtDirector
			// 
			this.txtDirector.Location = new System.Drawing.Point(185, 77);
			this.txtDirector.Name = "txtDirector";
			this.txtDirector.Size = new System.Drawing.Size(632, 26);
			this.txtDirector.TabIndex = 8;
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(185, 35);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(632, 26);
			this.txtTitulo.TabIndex = 7;
			// 
			// lblFechaEstreno
			// 
			this.lblFechaEstreno.AutoSize = true;
			this.lblFechaEstreno.Location = new System.Drawing.Point(6, 200);
			this.lblFechaEstreno.Name = "lblFechaEstreno";
			this.lblFechaEstreno.Size = new System.Drawing.Size(138, 20);
			this.lblFechaEstreno.TabIndex = 4;
			this.lblFechaEstreno.Text = "Fecha de estreno:";
			// 
			// lblepisodios
			// 
			this.lblepisodios.AutoSize = true;
			this.lblepisodios.Location = new System.Drawing.Point(6, 162);
			this.lblepisodios.Name = "lblepisodios";
			this.lblepisodios.Size = new System.Drawing.Size(82, 20);
			this.lblepisodios.TabIndex = 3;
			this.lblepisodios.Text = "Episodios:";
			// 
			// lblSinopsis
			// 
			this.lblSinopsis.AutoSize = true;
			this.lblSinopsis.Location = new System.Drawing.Point(6, 123);
			this.lblSinopsis.Name = "lblSinopsis";
			this.lblSinopsis.Size = new System.Drawing.Size(73, 20);
			this.lblSinopsis.TabIndex = 2;
			this.lblSinopsis.Text = "Sinopsis:";
			// 
			// lblDirector
			// 
			this.lblDirector.AutoSize = true;
			this.lblDirector.Location = new System.Drawing.Point(6, 80);
			this.lblDirector.Name = "lblDirector";
			this.lblDirector.Size = new System.Drawing.Size(69, 20);
			this.lblDirector.TabIndex = 1;
			this.lblDirector.Text = "Director:";
			// 
			// lblTtulo
			// 
			this.lblTtulo.AutoSize = true;
			this.lblTtulo.Location = new System.Drawing.Point(6, 38);
			this.lblTtulo.Name = "lblTtulo";
			this.lblTtulo.Size = new System.Drawing.Size(51, 20);
			this.lblTtulo.TabIndex = 0;
			this.lblTtulo.Text = "Titulo:";
			// 
			// pnlAcciones
			// 
			this.pnlAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlAcciones.Controls.Add(this.btnSalir);
			this.pnlAcciones.Controls.Add(this.btnEliminar);
			this.pnlAcciones.Controls.Add(this.btnEditar);
			this.pnlAcciones.Controls.Add(this.btnNuevo);
			this.pnlAcciones.Location = new System.Drawing.Point(19, 315);
			this.pnlAcciones.Name = "pnlAcciones";
			this.pnlAcciones.Size = new System.Drawing.Size(1196, 87);
			this.pnlAcciones.TabIndex = 12;
			// 
			// gbxLista
			// 
			this.gbxLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbxLista.Controls.Add(this.dgvLista);
			this.gbxLista.Location = new System.Drawing.Point(19, 114);
			this.gbxLista.Name = "gbxLista";
			this.gbxLista.Size = new System.Drawing.Size(903, 181);
			this.gbxLista.TabIndex = 11;
			this.gbxLista.TabStop = false;
			this.gbxLista.Text = "Lista de series";
			// 
			// dgvLista
			// 
			this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLista.Location = new System.Drawing.Point(0, 32);
			this.dgvLista.MultiSelect = false;
			this.dgvLista.Name = "dgvLista";
			this.dgvLista.RowHeadersWidth = 62;
			this.dgvLista.RowTemplate.Height = 28;
			this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLista.Size = new System.Drawing.Size(1196, 150);
			this.dgvLista.TabIndex = 0;
			// 
			// txtParametro
			// 
			this.txtParametro.Location = new System.Drawing.Point(228, 53);
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.Size = new System.Drawing.Size(843, 26);
			this.txtParametro.TabIndex = 9;
			this.txtParametro.TextChanged += new System.EventHandler(this.txtParametro_TextChanged);
			this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
			// 
			// lblParametro
			// 
			this.lblParametro.AutoSize = true;
			this.lblParametro.Location = new System.Drawing.Point(14, 56);
			this.lblParametro.Name = "lblParametro";
			this.lblParametro.Size = new System.Drawing.Size(151, 20);
			this.lblParametro.TabIndex = 8;
			this.lblParametro.Text = "Buscar por sinopsis:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(12, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(1214, 46);
			this.lblTitulo.TabIndex = 7;
			this.lblTitulo.Text = "Series";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpFechaEstreno
			// 
			this.dtpFechaEstreno.Location = new System.Drawing.Point(185, 195);
			this.dtpFechaEstreno.Name = "dtpFechaEstreno";
			this.dtpFechaEstreno.Size = new System.Drawing.Size(632, 26);
			this.dtpFechaEstreno.TabIndex = 16;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = global::CpParcial2dsgc.Properties.Resources.cancel;
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(1043, 162);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(153, 61);
			this.btnCancelar.TabIndex = 13;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = global::CpParcial2dsgc.Properties.Resources.save;
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(864, 161);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(153, 61);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Image = global::CpParcial2dsgc.Properties.Resources.close;
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.Location = new System.Drawing.Point(744, 3);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(132, 61);
			this.btnSalir.TabIndex = 9;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Image = global::CpParcial2dsgc.Properties.Resources.delete;
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(592, 3);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(132, 61);
			this.btnEliminar.TabIndex = 8;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Image = global::CpParcial2dsgc.Properties.Resources.edit;
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(439, 3);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(132, 61);
			this.btnEditar.TabIndex = 7;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Image = global::CpParcial2dsgc.Properties.Resources._new;
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(283, 3);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(132, 61);
			this.btnNuevo.TabIndex = 6;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = global::CpParcial2dsgc.Properties.Resources.search;
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(1091, 48);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(132, 42);
			this.btnBuscar.TabIndex = 10;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// erpTitulo
			// 
			this.erpTitulo.ContainerControl = this;
			// 
			// erpDirector
			// 
			this.erpDirector.ContainerControl = this;
			// 
			// erpSinopsis
			// 
			this.erpSinopsis.ContainerControl = this;
			// 
			// erpEpisodio
			// 
			this.erpEpisodio.ContainerControl = this;
			// 
			// erpFechaEstreno
			// 
			this.erpFechaEstreno.ContainerControl = this;
			// 
			// FrmSerie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(1238, 643);
			this.Controls.Add(this.gbxDatos);
			this.Controls.Add(this.pnlAcciones);
			this.Controls.Add(this.gbxLista);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtParametro);
			this.Controls.Add(this.lblParametro);
			this.Controls.Add(this.lblTitulo);
			this.Name = "FrmSerie";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FrmSerie_Load);
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).EndInit();
			this.pnlAcciones.ResumeLayout(false);
			this.gbxLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDirector)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpEpisodio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.NumericUpDown nudEpisodios;
		private System.Windows.Forms.TextBox txtSinopsis;
		private System.Windows.Forms.TextBox txtDirector;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label lblFechaEstreno;
		private System.Windows.Forms.Label lblepisodios;
		private System.Windows.Forms.Label lblSinopsis;
		private System.Windows.Forms.Label lblDirector;
		private System.Windows.Forms.Label lblTtulo;
		private System.Windows.Forms.Panel pnlAcciones;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox gbxLista;
		private System.Windows.Forms.DataGridView dgvLista;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtParametro;
		private System.Windows.Forms.Label lblParametro;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
		private System.Windows.Forms.ErrorProvider erpTitulo;
		private System.Windows.Forms.ErrorProvider erpDirector;
		private System.Windows.Forms.ErrorProvider erpSinopsis;
		private System.Windows.Forms.ErrorProvider erpEpisodio;
		private System.Windows.Forms.ErrorProvider erpFechaEstreno;
	}
}

