﻿namespace CpParcial2dsgc
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
			this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
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
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.gbxLista = new System.Windows.Forms.GroupBox();
			this.dgvLista = new System.Windows.Forms.DataGridView();
			this.txtParametro = new System.Windows.Forms.TextBox();
			this.lblParametro = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
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
			this.gbxDatos.Location = new System.Drawing.Point(13, 266);
			this.gbxDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbxDatos.Size = new System.Drawing.Size(801, 151);
			this.gbxDatos.TabIndex = 13;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos";
			// 
			// dtpFechaEstreno
			// 
			this.dtpFechaEstreno.Location = new System.Drawing.Point(123, 127);
			this.dtpFechaEstreno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtpFechaEstreno.Name = "dtpFechaEstreno";
			this.dtpFechaEstreno.Size = new System.Drawing.Size(423, 20);
			this.dtpFechaEstreno.TabIndex = 16;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = global::CpParcial2dsgc.Properties.Resources.cancel;
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(695, 105);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(102, 40);
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
			this.btnGuardar.Location = new System.Drawing.Point(576, 105);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(102, 40);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// nudEpisodios
			// 
			this.nudEpisodios.Location = new System.Drawing.Point(123, 105);
			this.nudEpisodios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nudEpisodios.Name = "nudEpisodios";
			this.nudEpisodios.Size = new System.Drawing.Size(421, 20);
			this.nudEpisodios.TabIndex = 12;
			// 
			// txtSinopsis
			// 
			this.txtSinopsis.Location = new System.Drawing.Point(123, 78);
			this.txtSinopsis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtSinopsis.Name = "txtSinopsis";
			this.txtSinopsis.Size = new System.Drawing.Size(423, 20);
			this.txtSinopsis.TabIndex = 9;
			// 
			// txtDirector
			// 
			this.txtDirector.Location = new System.Drawing.Point(123, 50);
			this.txtDirector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtDirector.Name = "txtDirector";
			this.txtDirector.Size = new System.Drawing.Size(423, 20);
			this.txtDirector.TabIndex = 8;
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(123, 23);
			this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(423, 20);
			this.txtTitulo.TabIndex = 7;
			// 
			// lblFechaEstreno
			// 
			this.lblFechaEstreno.AutoSize = true;
			this.lblFechaEstreno.Location = new System.Drawing.Point(4, 130);
			this.lblFechaEstreno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFechaEstreno.Name = "lblFechaEstreno";
			this.lblFechaEstreno.Size = new System.Drawing.Size(93, 13);
			this.lblFechaEstreno.TabIndex = 4;
			this.lblFechaEstreno.Text = "Fecha de estreno:";
			// 
			// lblepisodios
			// 
			this.lblepisodios.AutoSize = true;
			this.lblepisodios.Location = new System.Drawing.Point(4, 105);
			this.lblepisodios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblepisodios.Name = "lblepisodios";
			this.lblepisodios.Size = new System.Drawing.Size(55, 13);
			this.lblepisodios.TabIndex = 3;
			this.lblepisodios.Text = "Episodios:";
			// 
			// lblSinopsis
			// 
			this.lblSinopsis.AutoSize = true;
			this.lblSinopsis.Location = new System.Drawing.Point(4, 80);
			this.lblSinopsis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSinopsis.Name = "lblSinopsis";
			this.lblSinopsis.Size = new System.Drawing.Size(49, 13);
			this.lblSinopsis.TabIndex = 2;
			this.lblSinopsis.Text = "Sinopsis:";
			// 
			// lblDirector
			// 
			this.lblDirector.AutoSize = true;
			this.lblDirector.Location = new System.Drawing.Point(4, 52);
			this.lblDirector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDirector.Name = "lblDirector";
			this.lblDirector.Size = new System.Drawing.Size(47, 13);
			this.lblDirector.TabIndex = 1;
			this.lblDirector.Text = "Director:";
			// 
			// lblTtulo
			// 
			this.lblTtulo.AutoSize = true;
			this.lblTtulo.Location = new System.Drawing.Point(4, 25);
			this.lblTtulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTtulo.Name = "lblTtulo";
			this.lblTtulo.Size = new System.Drawing.Size(36, 13);
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
			this.pnlAcciones.Location = new System.Drawing.Point(13, 205);
			this.pnlAcciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnlAcciones.Name = "pnlAcciones";
			this.pnlAcciones.Size = new System.Drawing.Size(791, 57);
			this.pnlAcciones.TabIndex = 12;
			// 
			// btnSalir
			// 
			this.btnSalir.Image = global::CpParcial2dsgc.Properties.Resources.close;
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.Location = new System.Drawing.Point(496, 2);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(88, 40);
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
			this.btnEliminar.Location = new System.Drawing.Point(395, 2);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(88, 40);
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
			this.btnEditar.Location = new System.Drawing.Point(293, 2);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(88, 40);
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
			this.btnNuevo.Location = new System.Drawing.Point(189, 2);
			this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(88, 40);
			this.btnNuevo.TabIndex = 6;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// gbxLista
			// 
			this.gbxLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbxLista.Controls.Add(this.dgvLista);
			this.gbxLista.Location = new System.Drawing.Point(13, 74);
			this.gbxLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbxLista.Name = "gbxLista";
			this.gbxLista.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbxLista.Size = new System.Drawing.Size(596, 118);
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
			this.dgvLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLista.Location = new System.Drawing.Point(0, 21);
			this.dgvLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvLista.MultiSelect = false;
			this.dgvLista.Name = "dgvLista";
			this.dgvLista.RowHeadersWidth = 62;
			this.dgvLista.RowTemplate.Height = 28;
			this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLista.Size = new System.Drawing.Size(791, 98);
			this.dgvLista.TabIndex = 0;
			// 
			// txtParametro
			// 
			this.txtParametro.Location = new System.Drawing.Point(152, 34);
			this.txtParametro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.Size = new System.Drawing.Size(563, 20);
			this.txtParametro.TabIndex = 9;
			this.txtParametro.TextChanged += new System.EventHandler(this.txtParametro_TextChanged);
			this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
			// 
			// lblParametro
			// 
			this.lblParametro.AutoSize = true;
			this.lblParametro.Location = new System.Drawing.Point(9, 36);
			this.lblParametro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblParametro.Name = "lblParametro";
			this.lblParametro.Size = new System.Drawing.Size(101, 13);
			this.lblParametro.TabIndex = 8;
			this.lblParametro.Text = "Buscar por sinopsis:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(8, 6);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(803, 30);
			this.lblTitulo.TabIndex = 7;
			this.lblTitulo.Text = "Series";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = global::CpParcial2dsgc.Properties.Resources.search;
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(727, 31);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(88, 27);
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(819, 418);
			this.Controls.Add(this.gbxDatos);
			this.Controls.Add(this.pnlAcciones);
			this.Controls.Add(this.gbxLista);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtParametro);
			this.Controls.Add(this.lblParametro);
			this.Controls.Add(this.lblTitulo);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmSerie";
			this.Text = "::: Series :::";
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

